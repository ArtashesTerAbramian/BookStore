using System;
using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DAL.Seeders;

public class AdminSeeder
{
    private const string _superAdminPasswordHash = "AQAAAAEAACcQAAAAEJMAC7XvVb24o+j906VcL4UiN9ToLwko3YyKgqrQkvG98qZWUEsPk/pFxJ2saLydhQ==";

    public static void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>().HasData(new Admin
        {
            Id = 1,
            CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            UserName = "admin",
            Name = "admin",
            PasswordHash = _superAdminPasswordHash
        });

        modelBuilder.Entity<Admin>().HasData(new Admin
        {
            Id = 2,
            CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            UserName = "admin2",
            Name = "admin2",
            PasswordHash = _superAdminPasswordHash
        });
        modelBuilder.Entity<Admin>().HasData(new Admin
        {
            Id = 3,
            CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            UserName = "admin3",
            Name = "admin3",
            PasswordHash = _superAdminPasswordHash
        });
    }
}