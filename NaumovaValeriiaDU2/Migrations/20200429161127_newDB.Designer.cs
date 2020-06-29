﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NaumovaValeriiaDU2.Models;

namespace NaumovaValeriiaDU2.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200429161127_newDB")]
    partial class newDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NaumovaValeriiaDU2.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOfCategory")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            NameOfCategory = "Electronics"
                        });
                });

            modelBuilder.Entity("NaumovaValeriiaDU2.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("File")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("responseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("responseId");

                    b.ToTable("Requests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Electronics",
                            Date = new DateTime(2020, 4, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "ssss@gmail.com",
                            Product = "Computer",
                            Text = "jjjjj"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Electronics",
                            Date = new DateTime(2020, 4, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "hhh@gmail.com",
                            Product = "Vacuum cleaner",
                            Text = "ooooo"
                        });
                });

            modelBuilder.Entity("NaumovaValeriiaDU2.Models.Product", b =>
                {
                    b.Property<string>("NameOfProduct")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("NameOfProduct");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            NameOfProduct = "Computer",
                            CategoryId = 1
                        },
                        new
                        {
                            NameOfProduct = "Vacuum Cleaner",
                            CategoryId = 1
                        });
                });

            modelBuilder.Entity("NaumovaValeriiaDU2.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("File")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("NaumovaValeriiaDU2.Models.Message", b =>
                {
                    b.HasOne("NaumovaValeriiaDU2.Models.Report", "response")
                        .WithMany()
                        .HasForeignKey("responseId");
                });
#pragma warning restore 612, 618
        }
    }
}
