﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _003_WriteOwn.Models;

#nullable disable

namespace _003_WriteOwn.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("_003_WriteOwn.Models.Movie.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rate")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDateTime = new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(836),
                            CreatedBy = "Mt.khademi",
                            Description = "",
                            InsertDateTime = new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(847),
                            IsDeleted = false,
                            Name = "Movie 001",
                            Rate = 10,
                            UpdateDateTime = new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(847)
                        },
                        new
                        {
                            Id = 2,
                            CreateDateTime = new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(849),
                            CreatedBy = "Brother warner",
                            Description = "",
                            InsertDateTime = new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(850),
                            IsDeleted = false,
                            Name = "Movie 002",
                            Rate = 10,
                            UpdateDateTime = new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(850)
                        },
                        new
                        {
                            Id = 3,
                            CreateDateTime = new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(851),
                            CreatedBy = "Pixar",
                            Description = "",
                            InsertDateTime = new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(853),
                            IsDeleted = false,
                            Name = "Movie 003",
                            Rate = 10,
                            UpdateDateTime = new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(852)
                        },
                        new
                        {
                            Id = 4,
                            CreateDateTime = new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(853),
                            CreatedBy = "Alibaba",
                            Description = "",
                            InsertDateTime = new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(855),
                            IsDeleted = false,
                            Name = "Movie 004",
                            Rate = 10,
                            UpdateDateTime = new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(854)
                        },
                        new
                        {
                            Id = 5,
                            CreateDateTime = new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(856),
                            CreatedBy = "Vedio Full intertanment",
                            Description = "",
                            InsertDateTime = new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(857),
                            IsDeleted = false,
                            Name = "Movie 005",
                            Rate = 10,
                            UpdateDateTime = new DateTime(2024, 5, 30, 11, 40, 18, 322, DateTimeKind.Local).AddTicks(857)
                        });
                });

            modelBuilder.Entity("_003_WriteOwn.Models.User.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
