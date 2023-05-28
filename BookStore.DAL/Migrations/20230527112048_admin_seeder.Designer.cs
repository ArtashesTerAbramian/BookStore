﻿// <auto-generated />
using System;
using BookStore.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BookStore.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230527112048_admin_seeder")]
    partial class admin_seeder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BookStore.DAL.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("email");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modify_date");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("name");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)")
                        .HasColumnName("password_hash");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)")
                        .HasColumnName("user_name");

                    b.HasKey("Id")
                        .HasName("pk_admin");

                    b.HasIndex("CreatedDate")
                        .HasDatabaseName("ix_admin_created_date");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("ix_admin_email");

                    b.HasIndex("IsDeleted")
                        .HasDatabaseName("ix_admin_is_deleted");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasDatabaseName("ix_admin_user_name");

                    b.ToTable("admin", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            ModifyDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEJMAC7XvVb24o+j906VcL4UiN9ToLwko3YyKgqrQkvG98qZWUEsPk/pFxJ2saLydhQ==",
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            ModifyDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "admin2",
                            PasswordHash = "AQAAAAEAACcQAAAAEJMAC7XvVb24o+j906VcL4UiN9ToLwko3YyKgqrQkvG98qZWUEsPk/pFxJ2saLydhQ==",
                            UserName = "admin2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            ModifyDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "admin3",
                            PasswordHash = "AQAAAAEAACcQAAAAEJMAC7XvVb24o+j906VcL4UiN9ToLwko3YyKgqrQkvG98qZWUEsPk/pFxJ2saLydhQ==",
                            UserName = "admin3"
                        });
                });

            modelBuilder.Entity("BookStore.DAL.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modify_date");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("name");

                    b.Property<string>("Surname")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("surname");

                    b.HasKey("Id")
                        .HasName("pk_authors");

                    b.HasIndex("CreatedDate")
                        .HasDatabaseName("ix_authors_created_date");

                    b.HasIndex("IsDeleted")
                        .HasDatabaseName("ix_authors_is_deleted");

                    b.ToTable("authors", (string)null);
                });

            modelBuilder.Entity("BookStore.DAL.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer")
                        .HasColumnName("author_id");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("category_id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modify_date");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("name");

                    b.Property<int>("StoreId")
                        .HasColumnType("integer")
                        .HasColumnName("store_id");

                    b.Property<string>("Title")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_book");

                    b.HasIndex("CategoryId")
                        .HasDatabaseName("ix_book_category_id");

                    b.HasIndex("CreatedDate")
                        .HasDatabaseName("ix_book_created_date");

                    b.HasIndex("IsDeleted")
                        .HasDatabaseName("ix_book_is_deleted");

                    b.HasIndex("StoreId")
                        .HasDatabaseName("ix_book_store_id");

                    b.HasIndex("AuthorId", "CategoryId", "StoreId")
                        .HasDatabaseName("ix_book_author_id_category_id_store_id");

                    b.ToTable("book", (string)null);
                });

            modelBuilder.Entity("BookStore.DAL.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modify_date");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_category");

                    b.ToTable("category", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            ModifyDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            ModifyDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Classics"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            ModifyDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            ModifyDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Historical"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            ModifyDate = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Name = "Fairy_Tales"
                        });
                });

            modelBuilder.Entity("BookStore.DAL.Models.Error", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modify_date");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_errors");

                    b.HasIndex("CreatedDate")
                        .HasDatabaseName("ix_errors_created_date");

                    b.HasIndex("IsDeleted")
                        .HasDatabaseName("ix_errors_is_deleted");

                    b.ToTable("errors", (string)null);
                });

            modelBuilder.Entity("BookStore.DAL.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("address");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modify_date");

                    b.Property<int>("SquareSize")
                        .HasColumnType("integer")
                        .HasColumnName("square_size");

                    b.HasKey("Id")
                        .HasName("pk_stores");

                    b.HasIndex("CreatedDate")
                        .HasDatabaseName("ix_stores_created_date");

                    b.HasIndex("IsDeleted")
                        .HasDatabaseName("ix_stores_is_deleted");

                    b.ToTable("stores", (string)null);
                });

            modelBuilder.Entity("BookStore.DAL.Models.Book", b =>
                {
                    b.HasOne("BookStore.DAL.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_book_authors_author_id");

                    b.HasOne("BookStore.DAL.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_book_category_category_id");

                    b.HasOne("BookStore.DAL.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_book_stores_store_id");

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("Store");
                });
#pragma warning restore 612, 618
        }
    }
}
