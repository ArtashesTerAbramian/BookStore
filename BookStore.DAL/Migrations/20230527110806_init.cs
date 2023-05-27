using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    user_name = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    password_hash = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_admin", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    surname = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_authors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "errors",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_errors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    address = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    square_size = table.Column<int>(type: "integer", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_stores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "book",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    description = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    title = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    author_id = table.Column<int>(type: "integer", nullable: false),
                    category_id = table.Column<int>(type: "integer", nullable: false),
                    store_id = table.Column<int>(type: "integer", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_book", x => x.id);
                    table.ForeignKey(
                        name: "fk_book_authors_author_id",
                        column: x => x.author_id,
                        principalTable: "authors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_book_category_category_id",
                        column: x => x.category_id,
                        principalTable: "category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_book_stores_store_id",
                        column: x => x.store_id,
                        principalTable: "stores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "id", "created_date", "is_deleted", "modify_date", "name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Adventure" },
                    { 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classics" },
                    { 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Fairy_Tales" },
                    { 4, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Fantasy" },
                    { 5, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Historical" }
                });

            migrationBuilder.CreateIndex(
                name: "ix_admin_created_date",
                table: "admin",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_admin_email",
                table: "admin",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_admin_is_deleted",
                table: "admin",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_admin_user_name",
                table: "admin",
                column: "user_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_authors_created_date",
                table: "authors",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_authors_is_deleted",
                table: "authors",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_book_author_id_category_id_store_id",
                table: "book",
                columns: new[] { "author_id", "category_id", "store_id" });

            migrationBuilder.CreateIndex(
                name: "ix_book_category_id",
                table: "book",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "ix_book_created_date",
                table: "book",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_book_is_deleted",
                table: "book",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_book_store_id",
                table: "book",
                column: "store_id");

            migrationBuilder.CreateIndex(
                name: "ix_errors_created_date",
                table: "errors",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_errors_is_deleted",
                table: "errors",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_stores_created_date",
                table: "stores",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_stores_is_deleted",
                table: "stores",
                column: "is_deleted");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "book");

            migrationBuilder.DropTable(
                name: "errors");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "stores");
        }
    }
}
