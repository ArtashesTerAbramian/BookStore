using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class error_seeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "errors",
                columns: new[] { "id", "created_date", "is_deleted", "modify_date", "name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Oops! Something wen't wrong" },
                    { 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Не авторизован." },
                    { 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ошибка при авторизации." },
                    { 4, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Пользователь не найден." },
                    { 5, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ошибки валидации связанные с ограничениями." },
                    { 6, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Пользователь с таким именем уже существует." },
                    { 7, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Внесенные данные не верны." },
                    { 8, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Элемент не найден." },
                    { 9, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Введенный элемент уже существует." },
                    { 10, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ошибка. Невозможно удалить данный компонент." },
                    { 11, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Указанный электронный адрес уже занят." },
                    { 12, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Невозможно изменить статус." },
                    { 13, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Общая ошибка." },
                    { 14, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Существуют активные статьи под данной категорией." },
                    { 15, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Видео размещено в статье." },
                    { 16, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "На данный момент статья редактируется пользователем {UserName}." },
                    { 17, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Несоответствие версии статии" },
                    { 18, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Невозможно удалить. Является категорией по умолчанию" },
                    { 19, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Изображение размещено в статье." },
                    { 20, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "На данный момент статья не редактируется." },
                    { 21, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ошибка. Неверный порядок сортировки." },
                    { 22, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ошибка. Данная очередь используется." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 22);
        }
    }
}
