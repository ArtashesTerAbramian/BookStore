using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class add_error_seeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "errors",
                columns: new[] { "id", "created_date", "is_deleted", "modify_date", "name" },
                values: new object[,]
                {
                    { 24, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ошибка. автор не наидена." },
                    { 25, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ошибка. магазин не наидена." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "errors",
                keyColumn: "id",
                keyValue: 25);
        }
    }
}
