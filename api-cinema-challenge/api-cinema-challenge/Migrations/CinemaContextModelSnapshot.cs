﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            CreatedAt = new DateTime(2018, 5, 29, 2, 26, 51, 867, DateTimeKind.Local),
                            Email = "QWER@hotmail.com",
                            Name = "Kanthee K",
                            Phone = "111111",
                            UpdatedAt = new DateTime(2022, 8, 5, 7, 41, 6, 783, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2018, 5, 20, 17, 2, 54, 601, DateTimeKind.Local),
                            Email = "1234A@hotmail.com",
                            Name = "Mohans M",
                            Phone = "22222",
                            UpdatedAt = new DateTime(2022, 7, 10, 8, 21, 1, 46, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2018, 8, 20, 5, 11, 28, 736, DateTimeKind.Local),
                            Email = "QDollkee@hotmail.com",
                            Name = "Sqlq Q",
                            Phone = "33333",
                            UpdatedAt = new DateTime(2022, 3, 31, 6, 33, 6, 491, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2019, 9, 29, 23, 44, 39, 557, DateTimeKind.Local),
                            Email = "XCXXx@hotmail.com",
                            Name = "Xcewwww",
                            Phone = "44444",
                            UpdatedAt = new DateTime(2022, 12, 26, 6, 48, 20, 576, DateTimeKind.Local)
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
                            CreatedAt = new DateTime(2014, 2, 2, 11, 23, 13, 222, DateTimeKind.Local),
                            Description = "NOOOO",
                            Rating = "10",
                            Runtime = 160,
                            Title = "IRONMNAA",
                            UpdatedAt = new DateTime(2022, 2, 21, 13, 5, 41, 672, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2003, 2, 18, 19, 36, 28, 900, DateTimeKind.Local),
                            Description = "OOOOHH NOOOOO",
                            Rating = "2",
                            Runtime = 90,
                            Title = "BARbie",
                            UpdatedAt = new DateTime(2022, 2, 16, 0, 13, 30, 102, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2011, 6, 1, 16, 5, 20, 774, DateTimeKind.Local),
                            Description = "OOHH OOHH NOOO",
                            Rating = "5",
                            Runtime = 66,
                            Title = "Avatar",
                            UpdatedAt = new DateTime(2022, 11, 4, 3, 7, 49, 265, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2011, 9, 24, 17, 32, 12, 424, DateTimeKind.Local),
                            Description = "OOOOHH YES",
                            Rating = "9",
                            Runtime = 15,
                            Title = "Fight Club",
                            UpdatedAt = new DateTime(2022, 2, 16, 1, 39, 15, 823, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2005, 9, 17, 5, 5, 28, 676, DateTimeKind.Local),
                            Description = "YEEEES",
                            Rating = "16",
                            Runtime = 200,
                            Title = "God Father",
                            UpdatedAt = new DateTime(2022, 8, 23, 21, 46, 32, 920, DateTimeKind.Local)
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
                            CreatedAt = new DateTime(2022, 6, 24, 17, 35, 10, 567, DateTimeKind.Local),
                            MovieId = 5,
                            ScreenNumber = 7,
                            StartAt = new DateTime(2024, 2, 19, 10, 37, 58, 223, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 24, 15, 5, 46, 131, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 1, 24, 3, 48, 9, 628, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenNumber = 5,
                            StartAt = new DateTime(2024, 2, 20, 12, 2, 51, 642, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 19, 17, 41, 23, 334, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 2, 3, 21, 9, 38, 975, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenNumber = 4,
                            StartAt = new DateTime(2024, 2, 22, 13, 13, 59, 706, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 26, 0, 54, 2, 167, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 4, 6, 15, 9, 24, 542, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenNumber = 9,
                            StartAt = new DateTime(2024, 2, 26, 13, 14, 22, 901, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 21, 7, 14, 9, 997, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 9, 4, 19, 45, 43, 309, DateTimeKind.Local),
                            MovieId = 5,
                            ScreenNumber = 8,
                            StartAt = new DateTime(2024, 2, 27, 13, 2, 9, 581, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 20, 4, 33, 36, 48, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 6,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 5, 4, 23, 54, 40, 189, DateTimeKind.Local),
                            MovieId = 2,
                            ScreenNumber = 1,
                            StartAt = new DateTime(2024, 2, 27, 19, 41, 17, 832, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 23, 9, 53, 50, 591, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 7,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 5, 20, 13, 4, 24, 833, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenNumber = 5,
                            StartAt = new DateTime(2024, 2, 27, 23, 38, 22, 688, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 21, 1, 38, 22, 389, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 8,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 1, 8, 8, 35, 53, 536, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenNumber = 7,
                            StartAt = new DateTime(2024, 2, 28, 0, 52, 32, 563, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 29, 8, 49, 36, 187, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 9,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 4, 8, 18, 13, 46, 349, DateTimeKind.Local),
                            MovieId = 1,
                            ScreenNumber = 5,
                            StartAt = new DateTime(2024, 2, 28, 3, 25, 36, 6, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 24, 22, 44, 11, 984, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 10,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 11, 1, 21, 23, 10, 222, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenNumber = 1,
                            StartAt = new DateTime(2024, 2, 28, 1, 27, 22, 96, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 29, 0, 9, 20, 17, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 11,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 11, 4, 6, 26, 43, 536, DateTimeKind.Local),
                            MovieId = 1,
                            ScreenNumber = 8,
                            StartAt = new DateTime(2024, 2, 28, 3, 32, 38, 88, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 29, 2, 16, 43, 563, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 12,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 4, 4, 5, 9, 48, 807, DateTimeKind.Local),
                            MovieId = 1,
                            ScreenNumber = 5,
                            StartAt = new DateTime(2024, 2, 28, 5, 32, 30, 790, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 20, 4, 6, 59, 875, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 13,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 7, 29, 0, 24, 17, 6, DateTimeKind.Local),
                            MovieId = 1,
                            ScreenNumber = 5,
                            StartAt = new DateTime(2024, 2, 28, 4, 54, 52, 717, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 17, 12, 20, 17, 501, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 14,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 1, 1, 0, 26, 47, 102, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenNumber = 5,
                            StartAt = new DateTime(2024, 2, 28, 5, 18, 40, 175, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 26, 15, 25, 1, 255, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 15,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 8, 1, 12, 28, 34, 659, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenNumber = 1,
                            StartAt = new DateTime(2024, 2, 28, 1, 1, 13, 888, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 16, 4, 33, 58, 465, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 16,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 5, 17, 18, 1, 27, 115, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenNumber = 8,
                            StartAt = new DateTime(2024, 2, 28, 1, 14, 19, 36, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 24, 16, 58, 44, 227, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 17,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 2, 26, 23, 57, 55, 478, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenNumber = 4,
                            StartAt = new DateTime(2024, 2, 28, 1, 20, 1, 120, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 19, 10, 41, 31, 351, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 18,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 7, 10, 20, 1, 26, 316, DateTimeKind.Local),
                            MovieId = 5,
                            ScreenNumber = 6,
                            StartAt = new DateTime(2024, 2, 28, 3, 35, 23, 529, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 24, 20, 46, 57, 429, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 19,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 5, 21, 12, 58, 16, 355, DateTimeKind.Local),
                            MovieId = 1,
                            ScreenNumber = 9,
                            StartAt = new DateTime(2024, 2, 28, 4, 36, 36, 298, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 28, 0, 55, 2, 755, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 20,
                            Capacity = 50,
                            CreatedAt = new DateTime(2022, 6, 1, 21, 37, 5, 928, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenNumber = 6,
                            StartAt = new DateTime(2024, 2, 28, 1, 50, 37, 995, DateTimeKind.Local),
                            UpdatedAt = new DateTime(2024, 1, 18, 9, 45, 7, 575, DateTimeKind.Local)
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ticket_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

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
                            ScreeningId = 10,
                            CustommerId = 2,
                            CreatedAt = new DateTime(2022, 10, 6, 17, 27, 29, 334, DateTimeKind.Local),
                            Id = 1,
                            SeatNumber = 48,
                            UpdatedAt = new DateTime(2024, 1, 16, 23, 1, 44, 445, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 18,
                            CustommerId = 3,
                            CreatedAt = new DateTime(2022, 6, 16, 12, 19, 19, 673, DateTimeKind.Local),
                            Id = 1,
                            SeatNumber = 23,
                            UpdatedAt = new DateTime(2024, 1, 26, 19, 46, 39, 467, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 1,
                            CustommerId = 2,
                            CreatedAt = new DateTime(2022, 3, 11, 0, 24, 37, 713, DateTimeKind.Local),
                            Id = 2,
                            SeatNumber = 6,
                            UpdatedAt = new DateTime(2024, 1, 26, 14, 1, 16, 139, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 4,
                            CustommerId = 1,
                            CreatedAt = new DateTime(2022, 12, 18, 0, 35, 47, 315, DateTimeKind.Local),
                            Id = 3,
                            SeatNumber = 1,
                            UpdatedAt = new DateTime(2024, 1, 22, 22, 49, 5, 785, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 16,
                            CustommerId = 1,
                            CreatedAt = new DateTime(2022, 4, 5, 0, 13, 27, 957, DateTimeKind.Local),
                            Id = 4,
                            SeatNumber = 43,
                            UpdatedAt = new DateTime(2024, 1, 29, 13, 2, 52, 379, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 5,
                            CustommerId = 3,
                            CreatedAt = new DateTime(2022, 10, 22, 14, 21, 48, 447, DateTimeKind.Local),
                            Id = 5,
                            SeatNumber = 4,
                            UpdatedAt = new DateTime(2024, 1, 18, 17, 25, 47, 828, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 4,
                            CustommerId = 2,
                            CreatedAt = new DateTime(2022, 1, 4, 5, 57, 43, 658, DateTimeKind.Local),
                            Id = 6,
                            SeatNumber = 10,
                            UpdatedAt = new DateTime(2024, 1, 18, 12, 41, 19, 949, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 5,
                            CustommerId = 4,
                            CreatedAt = new DateTime(2022, 1, 21, 20, 17, 55, 156, DateTimeKind.Local),
                            Id = 7,
                            SeatNumber = 23,
                            UpdatedAt = new DateTime(2024, 1, 22, 12, 23, 27, 115, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 5,
                            CustommerId = 4,
                            CreatedAt = new DateTime(2022, 1, 20, 5, 27, 24, 269, DateTimeKind.Local),
                            Id = 8,
                            SeatNumber = 49,
                            UpdatedAt = new DateTime(2024, 1, 18, 0, 28, 18, 670, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 9,
                            CustommerId = 4,
                            CreatedAt = new DateTime(2022, 1, 22, 15, 40, 38, 923, DateTimeKind.Local),
                            Id = 9,
                            SeatNumber = 47,
                            UpdatedAt = new DateTime(2024, 1, 25, 10, 44, 46, 317, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 3,
                            CustommerId = 3,
                            CreatedAt = new DateTime(2022, 4, 8, 7, 0, 9, 679, DateTimeKind.Local),
                            Id = 10,
                            SeatNumber = 0,
                            UpdatedAt = new DateTime(2024, 1, 27, 6, 49, 53, 487, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 1,
                            CustommerId = 4,
                            CreatedAt = new DateTime(2022, 2, 17, 10, 1, 1, 911, DateTimeKind.Local),
                            Id = 11,
                            SeatNumber = 23,
                            UpdatedAt = new DateTime(2024, 1, 20, 16, 28, 46, 608, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 2,
                            CustommerId = 4,
                            CreatedAt = new DateTime(2022, 7, 25, 10, 7, 4, 660, DateTimeKind.Local),
                            Id = 12,
                            SeatNumber = 4,
                            UpdatedAt = new DateTime(2024, 1, 20, 16, 18, 26, 389, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 7,
                            CustommerId = 3,
                            CreatedAt = new DateTime(2022, 4, 19, 0, 40, 7, 402, DateTimeKind.Local),
                            Id = 13,
                            SeatNumber = 47,
                            UpdatedAt = new DateTime(2024, 1, 20, 17, 27, 39, 152, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 4,
                            CustommerId = 3,
                            CreatedAt = new DateTime(2022, 12, 16, 16, 22, 21, 938, DateTimeKind.Local),
                            Id = 14,
                            SeatNumber = 49,
                            UpdatedAt = new DateTime(2024, 1, 23, 8, 24, 54, 574, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 3,
                            CustommerId = 2,
                            CreatedAt = new DateTime(2022, 5, 12, 8, 47, 0, 952, DateTimeKind.Local),
                            Id = 15,
                            SeatNumber = 3,
                            UpdatedAt = new DateTime(2024, 1, 23, 13, 0, 7, 160, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 9,
                            CustommerId = 1,
                            CreatedAt = new DateTime(2022, 7, 24, 20, 57, 8, 846, DateTimeKind.Local),
                            Id = 16,
                            SeatNumber = 3,
                            UpdatedAt = new DateTime(2024, 1, 17, 18, 47, 37, 67, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 10,
                            CustommerId = 1,
                            CreatedAt = new DateTime(2022, 12, 6, 12, 32, 37, 128, DateTimeKind.Local),
                            Id = 17,
                            SeatNumber = 27,
                            UpdatedAt = new DateTime(2024, 1, 15, 23, 8, 31, 404, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 3,
                            CustommerId = 1,
                            CreatedAt = new DateTime(2022, 3, 15, 6, 26, 4, 640, DateTimeKind.Local),
                            Id = 18,
                            SeatNumber = 14,
                            UpdatedAt = new DateTime(2024, 1, 28, 0, 24, 0, 441, DateTimeKind.Local)
                        },
                        new
                        {
                            ScreeningId = 18,
                            CustommerId = 4,
                            CreatedAt = new DateTime(2022, 11, 26, 15, 29, 43, 211, DateTimeKind.Local),
                            Id = 19,
                            SeatNumber = 1,
                            UpdatedAt = new DateTime(2024, 1, 16, 0, 11, 52, 607, DateTimeKind.Local)
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
