using Microsoft.EntityFrameworkCore;

namespace BookStore.DAL.Seeders;

internal static class MainSeeder
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        CategorySeeder.SeedData(modelBuilder);
        AdminSeeder.SeedData(modelBuilder);
        ErrorSeeder.SeedData(modelBuilder);
    }
}