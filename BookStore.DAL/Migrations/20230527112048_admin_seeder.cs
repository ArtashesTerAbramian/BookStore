using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class admin_seeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "admin",
                columns: new[] { "id", "created_date", "email", "is_deleted", "modify_date", "name", "password_hash", "user_name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "admin", "AQAAAAEAACcQAAAAEJMAC7XvVb24o+j906VcL4UiN9ToLwko3YyKgqrQkvG98qZWUEsPk/pFxJ2saLydhQ==", "admin" },
                    { 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "admin2", "AQAAAAEAACcQAAAAEJMAC7XvVb24o+j906VcL4UiN9ToLwko3YyKgqrQkvG98qZWUEsPk/pFxJ2saLydhQ==", "admin2" },
                    { 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "admin3", "AQAAAAEAACcQAAAAEJMAC7XvVb24o+j906VcL4UiN9ToLwko3YyKgqrQkvG98qZWUEsPk/pFxJ2saLydhQ==", "admin3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "admin",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "admin",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "admin",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
