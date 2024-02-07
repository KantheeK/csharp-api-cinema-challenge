﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    [Migration("20240207120546_UpdatingDatabase1")]
    partial class UpdatingDatabase1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Custommer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("custommer_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("Date")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("Date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("custommer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2018, 3, 16, 23, 15, 17, 413, DateTimeKind.Local),
                            Email = "QWER@hotmail.com",
                            Name = "Kanthee K",
                            Phone = "111111",
                            UpdatedAt = new DateTime(2022, 5, 15, 11, 10, 7, 542, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2019, 1, 2, 16, 31, 7, 758, DateTimeKind.Local),
                            Email = "1234A@hotmail.com",
                            Name = "Mohans M",
                            Phone = "22222",
                            UpdatedAt = new DateTime(2022, 11, 3, 23, 5, 2, 346, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2019, 4, 8, 22, 5, 1, 973, DateTimeKind.Local),
                            Email = "QDollkee@hotmail.com",
                            Name = "Sqlq Q",
                            Phone = "33333",
                            UpdatedAt = new DateTime(2022, 9, 9, 2, 54, 55, 815, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2019, 4, 2, 10, 57, 43, 45, DateTimeKind.Local),
                            Email = "XCXXx@hotmail.com",
                            Name = "Xcewwww",
                            Phone = "44444",
                            UpdatedAt = new DateTime(2022, 9, 10, 1, 36, 23, 821, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("movie_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("Date")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rating");

                    b.Property<int>("Runtime")
                        .HasColumnType("integer")
                        .HasColumnName("runtime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("Date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2007, 3, 23, 8, 16, 21, 953, DateTimeKind.Local),
                            Description = "NOOOO",
                            Rating = "10",
                            Runtime = 160,
                            Title = "IRONMNAA",
                            UpdatedAt = new DateTime(2022, 10, 8, 15, 17, 54, 547, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2017, 8, 26, 23, 5, 24, 181, DateTimeKind.Local),
                            Description = "OOOOHH NOOOOO",
                            Rating = "2",
                            Runtime = 90,
                            Title = "BARbie",
                            UpdatedAt = new DateTime(2022, 12, 16, 9, 43, 39, 660, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2012, 8, 10, 16, 53, 30, 123, DateTimeKind.Local),
                            Description = "OOHH OOHH NOOO",
                            Rating = "5",
                            Runtime = 66,
                            Title = "Avatar",
                            UpdatedAt = new DateTime(2022, 12, 21, 2, 58, 6, 245, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2002, 6, 1, 19, 42, 58, 815, DateTimeKind.Local),
                            Description = "OOOOHH YES",
                            Rating = "9",
                            Runtime = 15,
                            Title = "Fight Club",
                            UpdatedAt = new DateTime(2022, 7, 1, 11, 10, 44, 585, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2000, 1, 15, 1, 28, 24, 389, DateTimeKind.Local),
                            Description = "YEEEES",
                            Rating = "16",
                            Runtime = 200,
                            Title = "God Father",
                            UpdatedAt = new DateTime(2022, 11, 25, 15, 24, 35, 272, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("screening_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("Date")
                        .HasColumnName("created_at");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screen_number");

                    b.Property<DateTime>("StartAt")
                        .HasColumnType("Date")
                        .HasColumnName("start_at");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("Date")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("screening");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 10, 27, 23, 48, 41, 813, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenNumber = 2,
                            StartAt = new DateTime(2024, 2, 21, 14, 0, 18, 444, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 26, 19, 48, 55, 654, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 10, 6, 7, 43, 29, 978, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenNumber = 1,
                            StartAt = new DateTime(2024, 2, 22, 6, 16, 32, 146, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 19, 19, 49, 35, 401, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 12, 3, 13, 32, 8, 87, DateTimeKind.Local),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartAt = new DateTime(2024, 2, 22, 22, 48, 48, 147, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 15, 23, 22, 34, 179, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 11, 11, 2, 18, 54, 207, DateTimeKind.Local),
                            MovieId = 5,
                            ScreenNumber = 9,
                            StartAt = new DateTime(2024, 2, 26, 8, 18, 25, 989, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 26, 9, 42, 22, 231, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 7, 3, 10, 15, 51, 629, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenNumber = 3,
                            StartAt = new DateTime(2024, 2, 27, 17, 45, 55, 22, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 29, 15, 58, 7, 75, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 6,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 3, 19, 6, 34, 25, 61, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenNumber = 9,
                            StartAt = new DateTime(2024, 2, 27, 23, 8, 29, 907, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 29, 6, 30, 23, 45, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 7,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 9, 15, 9, 31, 38, 493, DateTimeKind.Local),
                            MovieId = 5,
                            ScreenNumber = 5,
                            StartAt = new DateTime(2024, 2, 28, 2, 49, 30, 665, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 15, 3, 44, 20, 87, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 8,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 10, 4, 0, 56, 49, 687, DateTimeKind.Local),
                            MovieId = 1,
                            ScreenNumber = 5,
                            StartAt = new DateTime(2024, 2, 28, 3, 48, 32, 21, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 19, 3, 26, 45, 571, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 9,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 5, 7, 11, 37, 1, 774, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenNumber = 5,
                            StartAt = new DateTime(2024, 2, 28, 3, 32, 44, 414, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 26, 22, 52, 15, 464, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 10,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 9, 7, 22, 12, 36, 301, DateTimeKind.Local),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartAt = new DateTime(2024, 2, 28, 3, 26, 27, 337, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 28, 16, 12, 51, 818, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 11,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 8, 12, 0, 58, 59, 572, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenNumber = 5,
                            StartAt = new DateTime(2024, 2, 28, 2, 31, 7, 761, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 18, 14, 54, 18, 420, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 12,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 3, 1, 7, 45, 30, 305, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenNumber = 1,
                            StartAt = new DateTime(2024, 2, 28, 3, 1, 7, 677, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 23, 12, 46, 25, 735, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 13,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 1, 21, 22, 58, 6, 529, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenNumber = 4,
                            StartAt = new DateTime(2024, 2, 28, 1, 32, 43, 713, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 23, 3, 18, 29, 255, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 14,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 3, 28, 2, 8, 50, 408, DateTimeKind.Local),
                            MovieId = 2,
                            ScreenNumber = 7,
                            StartAt = new DateTime(2024, 2, 28, 1, 36, 21, 376, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 19, 9, 45, 52, 43, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 15,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 9, 11, 9, 5, 36, 738, DateTimeKind.Local),
                            MovieId = 1,
                            ScreenNumber = 5,
                            StartAt = new DateTime(2024, 2, 28, 3, 14, 18, 496, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 17, 1, 31, 53, 358, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 16,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 2, 4, 0, 6, 19, 685, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenNumber = 8,
                            StartAt = new DateTime(2024, 2, 28, 1, 49, 11, 339, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 24, 21, 44, 32, 881, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 17,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 12, 2, 19, 5, 49, 167, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenNumber = 3,
                            StartAt = new DateTime(2024, 2, 28, 0, 59, 9, 960, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 21, 8, 9, 0, 82, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 18,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 8, 15, 19, 25, 11, 792, DateTimeKind.Local),
                            MovieId = 2,
                            ScreenNumber = 7,
                            StartAt = new DateTime(2024, 2, 28, 2, 17, 23, 32, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 22, 9, 50, 51, 734, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 19,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 1, 19, 11, 40, 34, 848, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenNumber = 7,
                            StartAt = new DateTime(2024, 2, 28, 1, 14, 4, 67, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 29, 21, 21, 44, 635, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 20,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 12, 26, 16, 23, 28, 899, DateTimeKind.Local),
                            MovieId = 5,
                            ScreenNumber = 1,
                            StartAt = new DateTime(2024, 2, 28, 4, 22, 46, 271, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 20, 8, 5, 18, 568, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer");

                    b.Property<int>("CustommerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("Date")
                        .HasColumnName("created_at");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("ticket_id");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("integer")
                        .HasColumnName("seat_number");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("Date")
                        .HasColumnName("updated_at");

                    b.HasKey("ScreeningId", "CustommerId", "CreatedAt");

                    b.HasIndex("CustommerId");

                    b.ToTable("ticket");

                    b.HasData(
                        new
                        {
                            ScreeningId = 5,
                            CustommerId = 2,
                            CreatedAt = new DateTime(2022, 11, 20, 22, 53, 36, 771, DateTimeKind.Local),
                            Id = 1,
                            SeatNumber = 33,
                            UpdatedAt = new DateTime(2024, 1, 29, 23, 14, 40, 203, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 1,
                            CustommerId = 3,
                            CreatedAt = new DateTime(2022, 4, 21, 16, 35, 40, 325, DateTimeKind.Local),
                            Id = 1,
                            SeatNumber = 35,
                            UpdatedAt = new DateTime(2024, 1, 25, 2, 26, 44, 838, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 13,
                            CustommerId = 1,
                            CreatedAt = new DateTime(2022, 3, 1, 15, 6, 54, 644, DateTimeKind.Local),
                            Id = 2,
                            SeatNumber = 28,
                            UpdatedAt = new DateTime(2024, 1, 18, 19, 42, 9, 581, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 1,
                            CustommerId = 3,
                            CreatedAt = new DateTime(2022, 8, 25, 17, 57, 26, 931, DateTimeKind.Local),
                            Id = 3,
                            SeatNumber = 10,
                            UpdatedAt = new DateTime(2024, 1, 29, 2, 13, 5, 369, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 19,
                            CustommerId = 3,
                            CreatedAt = new DateTime(2022, 1, 16, 8, 18, 28, 213, DateTimeKind.Local),
                            Id = 4,
                            SeatNumber = 8,
                            UpdatedAt = new DateTime(2024, 1, 17, 5, 21, 47, 794, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 3,
                            CustommerId = 3,
                            CreatedAt = new DateTime(2022, 10, 29, 3, 20, 39, 201, DateTimeKind.Local),
                            Id = 5,
                            SeatNumber = 17,
                            UpdatedAt = new DateTime(2024, 1, 17, 22, 47, 14, 598, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 12,
                            CustommerId = 1,
                            CreatedAt = new DateTime(2022, 8, 7, 1, 39, 47, 20, DateTimeKind.Local),
                            Id = 6,
                            SeatNumber = 2,
                            UpdatedAt = new DateTime(2024, 1, 22, 11, 39, 0, 666, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 2,
                            CustommerId = 2,
                            CreatedAt = new DateTime(2022, 1, 12, 23, 41, 35, 5, DateTimeKind.Local),
                            Id = 7,
                            SeatNumber = 23,
                            UpdatedAt = new DateTime(2024, 1, 21, 13, 31, 49, 580, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 2,
                            CustommerId = 1,
                            CreatedAt = new DateTime(2022, 1, 23, 18, 42, 39, 711, DateTimeKind.Local),
                            Id = 8,
                            SeatNumber = 34,
                            UpdatedAt = new DateTime(2024, 1, 26, 0, 56, 19, 466, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 15,
                            CustommerId = 1,
                            CreatedAt = new DateTime(2022, 9, 5, 11, 32, 13, 628, DateTimeKind.Local),
                            Id = 9,
                            SeatNumber = 10,
                            UpdatedAt = new DateTime(2024, 1, 22, 6, 39, 32, 413, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 4,
                            CustommerId = 3,
                            CreatedAt = new DateTime(2022, 11, 24, 3, 44, 22, 592, DateTimeKind.Local),
                            Id = 10,
                            SeatNumber = 36,
                            UpdatedAt = new DateTime(2024, 1, 21, 8, 11, 0, 38, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 9,
                            CustommerId = 2,
                            CreatedAt = new DateTime(2022, 12, 6, 14, 46, 1, 359, DateTimeKind.Local),
                            Id = 11,
                            SeatNumber = 9,
                            UpdatedAt = new DateTime(2024, 1, 23, 9, 27, 44, 241, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 2,
                            CustommerId = 3,
                            CreatedAt = new DateTime(2022, 9, 28, 22, 2, 43, 511, DateTimeKind.Local),
                            Id = 12,
                            SeatNumber = 31,
                            UpdatedAt = new DateTime(2024, 1, 20, 7, 28, 41, 325, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 1,
                            CustommerId = 3,
                            CreatedAt = new DateTime(2022, 11, 11, 12, 7, 34, 260, DateTimeKind.Local),
                            Id = 13,
                            SeatNumber = 5,
                            UpdatedAt = new DateTime(2024, 1, 26, 23, 34, 38, 600, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 9,
                            CustommerId = 2,
                            CreatedAt = new DateTime(2022, 9, 24, 10, 26, 35, 114, DateTimeKind.Local),
                            Id = 14,
                            SeatNumber = 8,
                            UpdatedAt = new DateTime(2024, 1, 26, 12, 29, 5, 741, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 14,
                            CustommerId = 2,
                            CreatedAt = new DateTime(2022, 11, 7, 15, 19, 17, 314, DateTimeKind.Local),
                            Id = 15,
                            SeatNumber = 31,
                            UpdatedAt = new DateTime(2024, 1, 27, 21, 50, 28, 636, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 19,
                            CustommerId = 2,
                            CreatedAt = new DateTime(2022, 9, 7, 21, 11, 6, 61, DateTimeKind.Local),
                            Id = 16,
                            SeatNumber = 5,
                            UpdatedAt = new DateTime(2024, 1, 20, 21, 59, 10, 867, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 19,
                            CustommerId = 1,
                            CreatedAt = new DateTime(2022, 4, 26, 22, 48, 58, 785, DateTimeKind.Local),
                            Id = 17,
                            SeatNumber = 42,
                            UpdatedAt = new DateTime(2024, 1, 20, 22, 4, 53, 465, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 3,
                            CustommerId = 3,
                            CreatedAt = new DateTime(2022, 5, 3, 4, 58, 30, 425, DateTimeKind.Local),
                            Id = 18,
                            SeatNumber = 41,
                            UpdatedAt = new DateTime(2024, 1, 23, 20, 20, 40, 160, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 14,
                            CustommerId = 4,
                            CreatedAt = new DateTime(2022, 9, 16, 18, 40, 53, 197, DateTimeKind.Local),
                            Id = 19,
                            SeatNumber = 5,
                            UpdatedAt = new DateTime(2024, 1, 17, 0, 24, 0, 250, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Custommer", "Custommer")
                        .WithMany("Tickets")
                        .HasForeignKey("CustommerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_cinema_challenge.Models.Screening", "Screening")
                        .WithMany()
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Custommer");

                    b.Navigation("Screening");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Custommer", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
