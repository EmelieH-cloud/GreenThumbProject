using EntityFrameworkCore.EncryptColumn.Extension;
using EntityFrameworkCore.EncryptColumn.Interfaces;
using EntityFrameworkCore.EncryptColumn.Util;
using GreenThumbProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenThumbProject.Data
{
    public class MyDBContext : DbContext
    {
        private readonly IEncryptionProvider _provider;

        public MyDBContext()
        {
            _provider = new GenerateEncryptionProvider("oooooooooooooooooooooooo");
        }

#nullable disable
        public DbSet<User> Users { get; set; }
        public DbSet<Garden> Gardens { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<PlantGarden> PlantGardens { get; set; }
#nullable restore



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=USER-PC\\SQLEXPRESS;Database=GreenThumbProjectDB;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=True;MultipleActiveResultSets=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.UseEncryption(_provider); // Kryptering 

            // 1:1 relation mellan user och garden
            modelBuilder.Entity<User>()
                .HasOne(u => u.Garden)
                .WithOne(g => g.User)
                .HasForeignKey<Garden>(g => g.UserId);

            // 1:M relation mellan plant och instruction 
            modelBuilder.Entity<Plant>()
                .HasMany(p => p.Instructions)
                .WithOne(i => i.Plant)
                .HasForeignKey(i => i.PlantId);

            // M:N relation mellan plant och garden 
            modelBuilder.Entity<PlantGarden>()
                .HasKey(pg => new { pg.PlantId, pg.GardenId });

            modelBuilder.Entity<PlantGarden>()
                .HasOne(pg => pg.Plant)
                .WithMany(p => p.PlantGardens)
                .HasForeignKey(pg => pg.PlantId);

            modelBuilder.Entity<PlantGarden>()
                .HasOne(pg => pg.Garden)
                .WithMany(g => g.PlantGardens)
                .HasForeignKey(pg => pg.GardenId);

            // Users
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, UserName = "User1", Password = "EncryptedPassword1" },
                new User { UserId = 2, UserName = "User2", Password = "EncryptedPassword2" },
                new User { UserId = 3, UserName = "AdminUser", Password = "AdminPassword" }
            );

            // Gardens
            modelBuilder.Entity<Garden>().HasData(
                new Garden { GardenId = 1, UserId = 1, Name = "Rose Lily Garden" },
                new Garden { GardenId = 2, UserId = 2, Name = "Zen Garden" },
                new Garden { GardenId = 3, UserId = 3, Name = "Secret Garden" }
            );

            // Plants
            modelBuilder.Entity<Plant>().HasData(
    new Plant { PlantId = 1, PlantName = "Avocado", Details = "Avocado (Persea americana) is a popular fruit with a creamy texture and a rich taste. It is known for its health benefits and is often used in salads, sandwiches, and guacamole." },
    new Plant { PlantId = 2, PlantName = "Chili", Details = "Chili (Capsicum) is a spicy pepper commonly used in various cuisines around the world. It adds heat and flavor to dishes and is available in different varieties, ranging from mild to extremely hot." },
    new Plant { PlantId = 3, PlantName = "Sunflower", Details = "Sunflower (Helianthus annuus) is a vibrant and tall flowering plant. It is well-known for its large, yellow blooms and is cultivated for its seeds, which are a popular snack and ingredient in various dishes." },
    new Plant { PlantId = 4, PlantName = "Basil", Details = "Basil (Ocimum basilicum) is a fragrant herb commonly used in cooking. It is a key ingredient in many Italian dishes and adds a fresh and aromatic flavor to salads, sauces, and soups." },
    new Plant { PlantId = 5, PlantName = "Fern", Details = "Fern is a type of non-flowering plant that reproduces via spores. It is known for its feathery leaves and is often used as an ornamental plant in gardens and homes." },
    new Plant { PlantId = 6, PlantName = "Tulip", Details = "Tulip is a spring-blooming flower known for its vibrant colors and distinctive shape. It is a popular ornamental plant and is often associated with the arrival of spring." },
    new Plant { PlantId = 7, PlantName = "Cactus", Details = "Cactus is a succulent plant adapted to arid environments. It is characterized by its unique and diverse shapes. Some cacti produce colorful flowers, while others are valued for their resilience and low maintenance." },
    new Plant { PlantId = 8, PlantName = "Orchid", Details = "Orchid is a diverse and widespread family of flowering plants. Known for their exotic and often fragrant blooms, orchids are popular as ornamental plants and are cultivated for their beauty." },
    new Plant { PlantId = 9, PlantName = "Mint", Details = "Mint (Mentha) is a fragrant herb commonly used in culinary and medicinal applications. It adds a refreshing flavor to dishes, beverages, and desserts. Mint is also known for its therapeutic properties." },
    new Plant { PlantId = 10, PlantName = "Tomato", Details = "Tomato (Solanum lycopersicum) is a widely cultivated fruit/vegetable. It is a key ingredient in many cuisines and is used in salads, sauces, soups, and various dishes. Tomatoes come in a variety of colors and sizes." },
    new Plant { PlantId = 11, PlantName = "Lily", Details = "Lily is a beautiful and fragrant flowering plant. It is known for its elegant blooms and is often used in floral arrangements. Lilies are available in various colors and varieties." },
    new Plant { PlantId = 12, PlantName = "Daisy", Details = "Daisy is a cheerful and simple flowering plant. It is characterized by its white petals surrounding a yellow center. Daisies are popular in gardens and are often associated with innocence and purity." },
    new Plant { PlantId = 13, PlantName = "Aloe Vera", Details = "Aloe Vera is a succulent plant with medicinal properties. Its gel-like substance is used to soothe and heal skin conditions, burns, and wounds. Aloe Vera is also cultivated as an ornamental plant." },
    new Plant { PlantId = 14, PlantName = "Bamboo", Details = "Bamboo is a versatile and fast-growing plant. It is used for various purposes, including construction, furniture, and as a decorative element in gardens. Bamboo is known for its strength and sustainability." },
    new Plant { PlantId = 15, PlantName = "Succulent", Details = "Succulent plants are water-retaining plants adapted to arid conditions. They come in various shapes and sizes and are popular for their low maintenance and unique appearance. Succulents are often used in indoor gardens." },
    new Plant { PlantId = 16, PlantName = "Rosemary", Details = "Rosemary (Rosmarinus officinalis) is an aromatic herb with needle-like leaves. It is used in cooking, especially in Mediterranean cuisine, to add flavor to dishes. Rosemary is also known for its fragrant oil." },
    new Plant { PlantId = 17, PlantName = "Lemon Tree", Details = "Lemon Tree (Citrus limon) produces tart and citrusy fruits. It is cultivated for its lemons, which are used in cooking, beverages, and for their refreshing scent. Lemon trees are popular as ornamental and fruit-bearing plants." },
    new Plant { PlantId = 18, PlantName = "Snake Plant", Details = "Snake Plant (Sansevieria) is a hardy and low-maintenance indoor plant. It is known for its upright, sword-like leaves with distinctive patterns. Snake plants are valued for their air-purifying qualities." },
    new Plant { PlantId = 19, PlantName = "Lavender", Details = "Lavender (Lavandula) is a fragrant herb with purple flowers. It is known for its soothing aroma and is often used in aromatherapy, skincare products, and culinary applications. Lavender is also popular in gardens." },
    new Plant { PlantId = 20, PlantName = "Spider Plant", Details = "Spider Plant (Chlorophytum comosum) is a popular indoor plant with arching, spider-like leaves. It is easy to care for and is known for its air-purifying qualities. Spider plants are often chosen for their unique appearance." },
    new Plant { PlantId = 21, PlantName = "Jasmine", Details = "Jasmine is a fragrant flowering plant known for its sweet-scented blossoms. It is often used in perfumes, teas, and as an ornamental plant in gardens. Jasmine flowers are associated with beauty and romance." },
    new Plant { PlantId = 22, PlantName = "Pothos", Details = "Pothos (Epipremnum aureum) is a popular and easy-to-care-for indoor plant. It has heart-shaped leaves and is known for its trailing vines. Pothos is valued for its air-purifying qualities." },
    new Plant { PlantId = 23, PlantName = "Chrysanthemum", Details = "Chrysanthemum is a colorful and flowering plant. It is often cultivated for its vibrant blooms and is used in floral arrangements. Chrysanthemums come in various colors and are associated with autumn." },
    new Plant { PlantId = 24, PlantName = "Fiddle Leaf Fig", Details = "Fiddle Leaf Fig (Ficus lyrata) is a popular indoor tree with large, violin-shaped leaves. It is valued for its attractive foliage and is often used as a statement plant in interior decor." },
    new Plant { PlantId = 25, PlantName = "Peace Lily", Details = "Peace Lily (Spathiphyllum) is a popular indoor plant known for its elegant white flowers and air-purifying qualities. It thrives in low light conditions and is a favorite choice for homes and offices." }
);


            // PlantGardens
            modelBuilder.Entity<PlantGarden>().HasData(
          new PlantGarden { PlantId = 1, GardenId = 1 },
          new PlantGarden { PlantId = 2, GardenId = 1 },
          new PlantGarden { PlantId = 3, GardenId = 2 },
          new PlantGarden { PlantId = 4, GardenId = 2 },
          new PlantGarden { PlantId = 5, GardenId = 3 },
          new PlantGarden { PlantId = 6, GardenId = 3 },
          new PlantGarden { PlantId = 7, GardenId = 1 },
          new PlantGarden { PlantId = 8, GardenId = 2 },
          new PlantGarden { PlantId = 9, GardenId = 3 },
          new PlantGarden { PlantId = 10, GardenId = 3 },
          new PlantGarden { PlantId = 11, GardenId = 1 },
          new PlantGarden { PlantId = 12, GardenId = 2 },
          new PlantGarden { PlantId = 13, GardenId = 3 },
          new PlantGarden { PlantId = 14, GardenId = 1 },
          new PlantGarden { PlantId = 15, GardenId = 2 },
          new PlantGarden { PlantId = 16, GardenId = 3 },
          new PlantGarden { PlantId = 17, GardenId = 1 },
          new PlantGarden { PlantId = 18, GardenId = 2 },
          new PlantGarden { PlantId = 19, GardenId = 3 },
          new PlantGarden { PlantId = 20, GardenId = 1 }
            );

            // Instructions
            modelBuilder.Entity<Instruction>().HasData(
        new Instruction { InstructionId = 1, PlantId = 1, Content = "Water generously" },
        new Instruction { InstructionId = 2, PlantId = 1, Content = "Provide high levels of sunlight" },
        new Instruction { InstructionId = 3, PlantId = 3, Content = "Must stand close to a window" },
        new Instruction { InstructionId = 4, PlantId = 3, Content = "Add extra fertilizer once a week" },
        new Instruction { InstructionId = 5, PlantId = 5, Content = "No to little water required" },
        new Instruction { InstructionId = 6, PlantId = 5, Content = "Water 2-3 times a week" },
        new Instruction { InstructionId = 7, PlantId = 7, Content = "Keep out of reach for cats" },
        new Instruction { InstructionId = 8, PlantId = 7, Content = "Keep out of reach for dogs" },
        new Instruction { InstructionId = 9, PlantId = 9, Content = "Keep out of reach for children" },
        new Instruction { InstructionId = 10, PlantId = 9, Content = "Requires only small amounts of sunlight" },
        new Instruction { InstructionId = 11, PlantId = 11, Content = "Water daily" },
        new Instruction { InstructionId = 12, PlantId = 11, Content = "Soil must be kept moist at all times" },
        new Instruction { InstructionId = 13, PlantId = 13, Content = "Spray the leaves with water" },
        new Instruction { InstructionId = 14, PlantId = 13, Content = "Repotting should be done once a year" },
        new Instruction { InstructionId = 15, PlantId = 15, Content = "Prefers moist environments" },
        new Instruction { InstructionId = 16, PlantId = 15, Content = "Prefers dry air" },
        new Instruction { InstructionId = 17, PlantId = 17, Content = "Repotting should be done twice a year" },
        new Instruction { InstructionId = 18, PlantId = 17, Content = "Remove dead leaves twice a week" },
        new Instruction { InstructionId = 19, PlantId = 20, Content = "No fertilizer" },
        new Instruction { InstructionId = 20, PlantId = 20, Content = "Prone to dry out, water generously" }
            );

        }
    }
}