using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DAL.Configuration;

public class AdminConfiguration : BaseConfiguration<Admin>
{
    public override void Configure(EntityTypeBuilder<Admin> builder)
    {
        base.Configure(builder);

        builder.ToTable("admin");

        builder.Property(x => x.Name)
            .HasMaxLength(256);

        builder.Property(x => x.UserName)
            .IsRequired()
            .HasMaxLength(512);

        builder.Property(x => x.PasswordHash)
            .IsRequired()
            .HasMaxLength(512);

        builder.Property(x => x.Email)
            .HasMaxLength(256);

        builder.HasIndex(x => x.UserName)
            .IsUnique();

        builder.HasIndex(x => x.Email)
            .IsUnique();
    }
}