﻿// <auto-generated />
using System;
using DbOperationsEFCoreApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DbOperationsEFCoreApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241108112537_updatecurrencyrecord")]
    partial class updatecurrencyrecord
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DbOperationsEFCoreApp.Data.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("NoOfPages")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("DbOperationsEFCoreApp.Data.BookPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CurrencyId");

                    b.ToTable("BookPrices");
                });

            modelBuilder.Entity("DbOperationsEFCoreApp.Data.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CurrencyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Currencies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CurrencyName = "INR",
                            Description = "Indian INR"
                        },
                        new
                        {
                            Id = 2,
                            CurrencyName = "Pound",
                            Description = "GBP"
                        },
                        new
                        {
                            Id = 3,
                            CurrencyName = "Dollar",
                            Description = "USA Dollar"
                        },
                        new
                        {
                            Id = 4,
                            CurrencyName = "Euro",
                            Description = "Euro"
                        });
                });

            modelBuilder.Entity("DbOperationsEFCoreApp.Data.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Hindi",
                            Title = "Hindi"
                        },
                        new
                        {
                            Id = 2,
                            Description = "English",
                            Title = "English"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Telugu",
                            Title = "Telugu"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Gujarati",
                            Title = "Gujarati"
                        });
                });

            modelBuilder.Entity("DbOperationsEFCoreApp.Data.Book", b =>
                {
                    b.HasOne("DbOperationsEFCoreApp.Data.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("DbOperationsEFCoreApp.Data.BookPrice", b =>
                {
                    b.HasOne("DbOperationsEFCoreApp.Data.Book", "Book")
                        .WithMany("BookPrices")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbOperationsEFCoreApp.Data.Currency", "Currency")
                        .WithMany("bookPrices")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("DbOperationsEFCoreApp.Data.Book", b =>
                {
                    b.Navigation("BookPrices");
                });

            modelBuilder.Entity("DbOperationsEFCoreApp.Data.Currency", b =>
                {
                    b.Navigation("bookPrices");
                });

            modelBuilder.Entity("DbOperationsEFCoreApp.Data.Language", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
