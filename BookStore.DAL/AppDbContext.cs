using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using BookStore.DAL.Seeders;

namespace BookStore.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) 
    : base(options)
    {
        
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Error> Errors { get; set; }

    public override int SaveChanges()
    {
        AddModificationDate();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        AddModificationDate();
        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        foreach (var property in modelBuilder.Model.GetEntityTypes()
                     .SelectMany(p => p.GetProperties())
                     .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
        {
            property.SetColumnType("decimal(18,2)");
        }

        foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                     .SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }

        modelBuilder.SeedData();
    }
    
    private void AddModificationDate()
    {
        var entries = ChangeTracker
            .Entries()
            .Where(e => e.Entity is BaseEntity && (
                e.State == EntityState.Added
                || e.State == EntityState.Modified));

        foreach (var entityEntry in entries)
        {
            ((BaseEntity)entityEntry.Entity).ModifyDate = DateTime.UtcNow;

            if (entityEntry.State == EntityState.Added)
            {
                ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.UtcNow;
            }
        }
    }
}