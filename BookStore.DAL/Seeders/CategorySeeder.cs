using System;
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
            CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            Name = "Adventure",
        });

        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = (int)CategoriesEnum.Classics,
            CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            Name = "Classics",
        });

        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = (int)CategoriesEnum.Fantasy,
            CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            Name = "Fantasy",
        });
        
        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = (int)CategoriesEnum.Historical,
            CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            Name = "Historical",
        });
        
        
        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = (int)CategoriesEnum.Fairy_Tales,
            CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            Name = "Fairy_Tales",
        });
    }
}