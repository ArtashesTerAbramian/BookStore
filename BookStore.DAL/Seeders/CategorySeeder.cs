using BookStore.DAL.Enums;
using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DAL.Seeders;

public class CategorySeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = (int)CategoriesEnum.Adventure,
            CreatedDate = DateTime.Now,
            ModiftyDate = DateTime.Now,
            IsDeleted = false,
            Name = "Adventure",
        });

        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = (int)CategoriesEnum.Classics,
            CreatedDate = DateTime.Now,
            ModiftyDate = DateTime.Now,
            IsDeleted = false,
            Name = "Classics",
        });

        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = (int)CategoriesEnum.Fantasy,
            CreatedDate = DateTime.Now,
            ModiftyDate = DateTime.Now,
            IsDeleted = false,
            Name = "Fantasy",
        });
        
        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = (int)CategoriesEnum.Historical,
            CreatedDate = DateTime.Now,
            ModiftyDate = DateTime.Now,
            IsDeleted = false,
            Name = "Historical",
        });
        
        
        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = (int)CategoriesEnum.Fairy_Tales,
            CreatedDate = DateTime.Now,
            ModiftyDate = DateTime.Now,
            IsDeleted = false,
            Name = "Fairy_Tales",
        });
    }
}