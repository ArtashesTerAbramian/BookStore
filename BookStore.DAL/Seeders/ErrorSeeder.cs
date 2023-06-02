using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookStore.DAL.Seeders
{
    internal static class ErrorSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 1,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Oops! Something wen't wrong"
            });

            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 2,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Не авторизован."
            });

            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 3,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Ошибка при авторизации."
            });

            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 4,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Пользователь не найден."
            });

            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 5,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Ошибки валидации связанные с ограничениями."
            });

            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 6,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Пользователь с таким именем уже существует."
            });

            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 7,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Внесенные данные не верны."
            });

            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 8,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Элемент не найден."
            });

            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 9,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Введенный элемент уже существует."
            });

            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 10,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Ошибка. Невозможно удалить данный компонент."
            });

            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 11,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Указанный электронный адрес уже занят."
            });

            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 12,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Невозможно изменить статус."
            });

            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 13,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Общая ошибка."
            });

            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 14,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Существуют активные статьи под данной категорией."
            });

            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 15,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Видео размещено в статье."
            });
            
            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 16,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "На данный момент статья редактируется пользователем {UserName}."
            });
            
            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 17,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Несоответствие версии статии"
            });
            
            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 18,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Невозможно удалить. Является категорией по умолчанию"
            });

            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 19,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Изображение размещено в статье."
            });

            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 20,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "На данный момент статья не редактируется."
            });
            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 21,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Ошибка. Неверный порядок сортировки."
            });
            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 22,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Ошибка. Данная очередь используется."
            });
            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 23,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Ошибка. Категориа не наидена."
            });
            
            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 24,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Ошибка. автор не наидена."
            });
            modelBuilder.Entity<Error>().HasData(new Error
            {
                Id = 25,
                CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
                Name = "Ошибка. магазин не наидена."
            });
        }
    }
}
