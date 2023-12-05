﻿// <auto-generated />
using GreenThumbProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GreenThumbProject.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20231205105557_newdata")]
    partial class newdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GreenThumbProject.Models.Garden", b =>
                {
                    b.Property<int>("GardenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GardenId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("GardenId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Gardens");

                    b.HasData(
                        new
                        {
                            GardenId = 1,
                            Name = "Rose Lily Garden",
                            UserId = 1
                        },
                        new
                        {
                            GardenId = 2,
                            Name = "Zen Garden",
                            UserId = 2
                        },
                        new
                        {
                            GardenId = 3,
                            Name = "Secret Garden",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("GreenThumbProject.Models.Instruction", b =>
                {
                    b.Property<int>("InstructionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstructionId"), 1L, 1);

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.HasKey("InstructionId");

                    b.HasIndex("PlantId");

                    b.ToTable("Instructions");

                    b.HasData(
                        new
                        {
                            InstructionId = 1,
                            PlantId = 1
                        });
                });

            modelBuilder.Entity("GreenThumbProject.Models.Plant", b =>
                {
                    b.Property<int>("PlantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlantId"), 1L, 1);

                    b.Property<string>("PlantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlantId");

                    b.ToTable("Plants");

                    b.HasData(
                        new
                        {
                            PlantId = 1,
                            PlantName = "Avocado"
                        },
                        new
                        {
                            PlantId = 2,
                            PlantName = "Chili"
                        },
                        new
                        {
                            PlantId = 3,
                            PlantName = "Sunflower"
                        },
                        new
                        {
                            PlantId = 4,
                            PlantName = "Basil"
                        },
                        new
                        {
                            PlantId = 5,
                            PlantName = "Fern"
                        },
                        new
                        {
                            PlantId = 6,
                            PlantName = "Tulip"
                        },
                        new
                        {
                            PlantId = 7,
                            PlantName = "Cactus"
                        },
                        new
                        {
                            PlantId = 8,
                            PlantName = "Orchid"
                        },
                        new
                        {
                            PlantId = 9,
                            PlantName = "Mint"
                        },
                        new
                        {
                            PlantId = 10,
                            PlantName = "Tomato"
                        },
                        new
                        {
                            PlantId = 11,
                            PlantName = "Lily"
                        },
                        new
                        {
                            PlantId = 12,
                            PlantName = "Daisy"
                        },
                        new
                        {
                            PlantId = 13,
                            PlantName = "Aloe Vera"
                        },
                        new
                        {
                            PlantId = 14,
                            PlantName = "Bamboo"
                        },
                        new
                        {
                            PlantId = 15,
                            PlantName = "Succulent"
                        });
                });

            modelBuilder.Entity("GreenThumbProject.Models.PlantGarden", b =>
                {
                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.Property<int>("GardenId")
                        .HasColumnType("int");

                    b.HasKey("PlantId", "GardenId");

                    b.HasIndex("GardenId");

                    b.ToTable("PlantGardens");

                    b.HasData(
                        new
                        {
                            PlantId = 1,
                            GardenId = 1
                        });
                });

            modelBuilder.Entity("GreenThumbProject.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Password = "f7GpZqie1tOnESRrxJeVxGK3spQ4hnD/mK7oOiaaTyo=",
                            UserName = "User1"
                        },
                        new
                        {
                            UserId = 2,
                            Password = "f7GpZqie1tOnESRrxJeVxMFz9kR7JLmicQNL+TGLSMA=",
                            UserName = "User2"
                        },
                        new
                        {
                            UserId = 3,
                            Password = "dWqvyilRa8xuX6cGYGvknQ==",
                            UserName = "AdminUser"
                        });
                });

            modelBuilder.Entity("GreenThumbProject.Models.Garden", b =>
                {
                    b.HasOne("GreenThumbProject.Models.User", "User")
                        .WithOne("Garden")
                        .HasForeignKey("GreenThumbProject.Models.Garden", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("GreenThumbProject.Models.Instruction", b =>
                {
                    b.HasOne("GreenThumbProject.Models.Plant", "Plant")
                        .WithMany("Instructions")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("GreenThumbProject.Models.PlantGarden", b =>
                {
                    b.HasOne("GreenThumbProject.Models.Garden", "Garden")
                        .WithMany("PlantGardens")
                        .HasForeignKey("GardenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GreenThumbProject.Models.Plant", "Plant")
                        .WithMany("PlantGardens")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Garden");

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("GreenThumbProject.Models.Garden", b =>
                {
                    b.Navigation("PlantGardens");
                });

            modelBuilder.Entity("GreenThumbProject.Models.Plant", b =>
                {
                    b.Navigation("Instructions");

                    b.Navigation("PlantGardens");
                });

            modelBuilder.Entity("GreenThumbProject.Models.User", b =>
                {
                    b.Navigation("Garden")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
