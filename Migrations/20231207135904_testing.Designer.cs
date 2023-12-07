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
    [Migration("20231207135904_testing")]
    partial class testing
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
                            UserId = 4
                        });
                });

            modelBuilder.Entity("GreenThumbProject.Models.Instruction", b =>
                {
                    b.Property<int>("InstructionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstructionId"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.HasKey("InstructionId");

                    b.HasIndex("PlantId");

                    b.ToTable("Instructions");

                    b.HasData(
                        new
                        {
                            InstructionId = 1,
                            Content = "Water generously",
                            PlantId = 1
                        },
                        new
                        {
                            InstructionId = 2,
                            Content = "Provide high levels of sunlight",
                            PlantId = 1
                        },
                        new
                        {
                            InstructionId = 3,
                            Content = "Must stand close to a window",
                            PlantId = 3
                        },
                        new
                        {
                            InstructionId = 4,
                            Content = "Add extra fertilizer once a week",
                            PlantId = 3
                        },
                        new
                        {
                            InstructionId = 5,
                            Content = "No to little water required",
                            PlantId = 5
                        },
                        new
                        {
                            InstructionId = 6,
                            Content = "Water 2-3 times a week",
                            PlantId = 5
                        },
                        new
                        {
                            InstructionId = 7,
                            Content = "Keep out of reach for cats",
                            PlantId = 7
                        },
                        new
                        {
                            InstructionId = 8,
                            Content = "Keep out of reach for dogs",
                            PlantId = 7
                        },
                        new
                        {
                            InstructionId = 9,
                            Content = "Keep out of reach for children",
                            PlantId = 9
                        },
                        new
                        {
                            InstructionId = 10,
                            Content = "Requires only small amounts of sunlight",
                            PlantId = 9
                        },
                        new
                        {
                            InstructionId = 11,
                            Content = "Water daily",
                            PlantId = 11
                        },
                        new
                        {
                            InstructionId = 12,
                            Content = "Soil must be kept moist at all times",
                            PlantId = 11
                        },
                        new
                        {
                            InstructionId = 13,
                            Content = "Spray the leaves with water",
                            PlantId = 13
                        },
                        new
                        {
                            InstructionId = 14,
                            Content = "Repotting should be done once a year",
                            PlantId = 13
                        },
                        new
                        {
                            InstructionId = 15,
                            Content = "Prefers moist environments",
                            PlantId = 15
                        },
                        new
                        {
                            InstructionId = 16,
                            Content = "Prefers dry air",
                            PlantId = 15
                        },
                        new
                        {
                            InstructionId = 17,
                            Content = "Repotting should be done twice a year",
                            PlantId = 17
                        },
                        new
                        {
                            InstructionId = 18,
                            Content = "Remove dead leaves twice a week",
                            PlantId = 17
                        },
                        new
                        {
                            InstructionId = 19,
                            Content = "No fertilizer",
                            PlantId = 20
                        },
                        new
                        {
                            InstructionId = 20,
                            Content = "Prone to dry out, water generously",
                            PlantId = 20
                        },
                        new
                        {
                            InstructionId = 21,
                            Content = "Prone to dry out, water generously",
                            PlantId = 2
                        },
                        new
                        {
                            InstructionId = 22,
                            Content = "Prone to dry out, water generously",
                            PlantId = 4
                        },
                        new
                        {
                            InstructionId = 23,
                            Content = "Prone to dry out, water generously",
                            PlantId = 6
                        },
                        new
                        {
                            InstructionId = 24,
                            Content = "Prone to dry out, water generously",
                            PlantId = 12
                        });
                });

            modelBuilder.Entity("GreenThumbProject.Models.Plant", b =>
                {
                    b.Property<int>("PlantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlantId"), 1L, 1);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlantId");

                    b.ToTable("Plants");

                    b.HasData(
                        new
                        {
                            PlantId = 1,
                            Details = "Avocado (Persea americana) is a popular fruit with a creamy texture and a rich taste. It is known for its health benefits and is often used in salads, sandwiches, and guacamole.",
                            PlantName = "Avocado"
                        },
                        new
                        {
                            PlantId = 2,
                            Details = "Chili (Capsicum) is a spicy pepper commonly used in various cuisines around the world. It adds heat and flavor to dishes and is available in different varieties, ranging from mild to extremely hot.",
                            PlantName = "Chili"
                        },
                        new
                        {
                            PlantId = 3,
                            Details = "Sunflower (Helianthus annuus) is a vibrant and tall flowering plant. It is well-known for its large, yellow blooms and is cultivated for its seeds, which are a popular snack and ingredient in various dishes.",
                            PlantName = "Sunflower"
                        },
                        new
                        {
                            PlantId = 4,
                            Details = "Basil (Ocimum basilicum) is a fragrant herb commonly used in cooking. It is a key ingredient in many Italian dishes and adds a fresh and aromatic flavor to salads, sauces, and soups.",
                            PlantName = "Basil"
                        },
                        new
                        {
                            PlantId = 5,
                            Details = "Fern is a type of non-flowering plant that reproduces via spores. It is known for its feathery leaves and is often used as an ornamental plant in gardens and homes.",
                            PlantName = "Fern"
                        },
                        new
                        {
                            PlantId = 6,
                            Details = "Tulip is a spring-blooming flower known for its vibrant colors and distinctive shape. It is a popular ornamental plant and is often associated with the arrival of spring.",
                            PlantName = "Tulip"
                        },
                        new
                        {
                            PlantId = 7,
                            Details = "Cactus is a succulent plant adapted to arid environments. It is characterized by its unique and diverse shapes. Some cacti produce colorful flowers, while others are valued for their resilience and low maintenance.",
                            PlantName = "Cactus"
                        },
                        new
                        {
                            PlantId = 8,
                            Details = "Orchid is a diverse and widespread family of flowering plants. Known for their exotic and often fragrant blooms, orchids are popular as ornamental plants and are cultivated for their beauty.",
                            PlantName = "Orchid"
                        },
                        new
                        {
                            PlantId = 9,
                            Details = "Mint (Mentha) is a fragrant herb commonly used in culinary and medicinal applications. It adds a refreshing flavor to dishes, beverages, and desserts. Mint is also known for its therapeutic properties.",
                            PlantName = "Mint"
                        },
                        new
                        {
                            PlantId = 10,
                            Details = "Tomato (Solanum lycopersicum) is a widely cultivated fruit/vegetable. It is a key ingredient in many cuisines and is used in salads, sauces, soups, and various dishes. Tomatoes come in a variety of colors and sizes.",
                            PlantName = "Tomato"
                        },
                        new
                        {
                            PlantId = 11,
                            Details = "Lily is a beautiful and fragrant flowering plant. It is known for its elegant blooms and is often used in floral arrangements. Lilies are available in various colors and varieties.",
                            PlantName = "Lily"
                        },
                        new
                        {
                            PlantId = 12,
                            Details = "Daisy is a cheerful and simple flowering plant. It is characterized by its white petals surrounding a yellow center. Daisies are popular in gardens and are often associated with innocence and purity.",
                            PlantName = "Daisy"
                        },
                        new
                        {
                            PlantId = 13,
                            Details = "Aloe Vera is a succulent plant with medicinal properties. Its gel-like substance is used to soothe and heal skin conditions, burns, and wounds. Aloe Vera is also cultivated as an ornamental plant.",
                            PlantName = "Aloe Vera"
                        },
                        new
                        {
                            PlantId = 14,
                            Details = "Bamboo is a versatile and fast-growing plant. It is used for various purposes, including construction, furniture, and as a decorative element in gardens. Bamboo is known for its strength and sustainability.",
                            PlantName = "Bamboo"
                        },
                        new
                        {
                            PlantId = 15,
                            Details = "Succulent plants are water-retaining plants adapted to arid conditions. They come in various shapes and sizes and are popular for their low maintenance and unique appearance. Succulents are often used in indoor gardens.",
                            PlantName = "Succulent"
                        },
                        new
                        {
                            PlantId = 16,
                            Details = "Rosemary (Rosmarinus officinalis) is an aromatic herb with needle-like leaves. It is used in cooking, especially in Mediterranean cuisine, to add flavor to dishes. Rosemary is also known for its fragrant oil.",
                            PlantName = "Rosemary"
                        },
                        new
                        {
                            PlantId = 17,
                            Details = "Lemon Tree (Citrus limon) produces tart and citrusy fruits. It is cultivated for its lemons, which are used in cooking, beverages, and for their refreshing scent. Lemon trees are popular as ornamental and fruit-bearing plants.",
                            PlantName = "Lemon Tree"
                        },
                        new
                        {
                            PlantId = 18,
                            Details = "Snake Plant (Sansevieria) is a hardy and low-maintenance indoor plant. It is known for its upright, sword-like leaves with distinctive patterns. Snake plants are valued for their air-purifying qualities.",
                            PlantName = "Snake Plant"
                        },
                        new
                        {
                            PlantId = 19,
                            Details = "Lavender (Lavandula) is a fragrant herb with purple flowers. It is known for its soothing aroma and is often used in aromatherapy, skincare products, and culinary applications. Lavender is also popular in gardens.",
                            PlantName = "Lavender"
                        },
                        new
                        {
                            PlantId = 20,
                            Details = "Spider Plant (Chlorophytum comosum) is a popular indoor plant with arching, spider-like leaves. It is easy to care for and is known for its air-purifying qualities. Spider plants are often chosen for their unique appearance.",
                            PlantName = "Spider Plant"
                        },
                        new
                        {
                            PlantId = 21,
                            Details = "Jasmine is a fragrant flowering plant known for its sweet-scented blossoms. It is often used in perfumes, teas, and as an ornamental plant in gardens. Jasmine flowers are associated with beauty and romance.",
                            PlantName = "Jasmine"
                        },
                        new
                        {
                            PlantId = 22,
                            Details = "Pothos (Epipremnum aureum) is a popular and easy-to-care-for indoor plant. It has heart-shaped leaves and is known for its trailing vines. Pothos is valued for its air-purifying qualities.",
                            PlantName = "Pothos"
                        },
                        new
                        {
                            PlantId = 23,
                            Details = "Chrysanthemum is a colorful and flowering plant. It is often cultivated for its vibrant blooms and is used in floral arrangements. Chrysanthemums come in various colors and are associated with autumn.",
                            PlantName = "Chrysanthemum"
                        },
                        new
                        {
                            PlantId = 24,
                            Details = "Fiddle Leaf Fig (Ficus lyrata) is a popular indoor tree with large, violin-shaped leaves. It is valued for its attractive foliage and is often used as a statement plant in interior decor.",
                            PlantName = "Fiddle Leaf Fig"
                        },
                        new
                        {
                            PlantId = 25,
                            Details = "Peace Lily (Spathiphyllum) is a popular indoor plant known for its elegant white flowers and air-purifying qualities. It thrives in low light conditions and is a favorite choice for homes and offices.",
                            PlantName = "Peace Lily"
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
                        },
                        new
                        {
                            PlantId = 2,
                            GardenId = 1
                        },
                        new
                        {
                            PlantId = 3,
                            GardenId = 2
                        },
                        new
                        {
                            PlantId = 4,
                            GardenId = 2
                        },
                        new
                        {
                            PlantId = 5,
                            GardenId = 3
                        },
                        new
                        {
                            PlantId = 6,
                            GardenId = 3
                        },
                        new
                        {
                            PlantId = 7,
                            GardenId = 1
                        },
                        new
                        {
                            PlantId = 8,
                            GardenId = 2
                        },
                        new
                        {
                            PlantId = 9,
                            GardenId = 3
                        },
                        new
                        {
                            PlantId = 10,
                            GardenId = 3
                        },
                        new
                        {
                            PlantId = 11,
                            GardenId = 1
                        },
                        new
                        {
                            PlantId = 12,
                            GardenId = 2
                        },
                        new
                        {
                            PlantId = 13,
                            GardenId = 3
                        },
                        new
                        {
                            PlantId = 14,
                            GardenId = 1
                        },
                        new
                        {
                            PlantId = 15,
                            GardenId = 2
                        },
                        new
                        {
                            PlantId = 16,
                            GardenId = 3
                        },
                        new
                        {
                            PlantId = 17,
                            GardenId = 1
                        },
                        new
                        {
                            PlantId = 18,
                            GardenId = 2
                        },
                        new
                        {
                            PlantId = 19,
                            GardenId = 3
                        },
                        new
                        {
                            PlantId = 20,
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
                        },
                        new
                        {
                            UserId = 4,
                            Password = "f7GpZqie1tOnESRrxJeVxKYlBReYbSiGLAC2K1lMUnQ=",
                            UserName = "User4"
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
