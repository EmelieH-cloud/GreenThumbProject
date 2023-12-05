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
                new User { UserId = 2, UserName = "User2", Password = "EncryptedPassword2" }
            );

            // Gardens
            modelBuilder.Entity<Garden>().HasData(
                new Garden { GardenId = 1, UserId = 1, Name = "Garden1" },
                new Garden { GardenId = 2, UserId = 2, Name = "Garden2" }
            );

            // Plants
            modelBuilder.Entity<Plant>().HasData(
                new Plant { PlantId = 1, PlantName = "Plant1" },
                new Plant { PlantId = 2, PlantName = "Plant2" }
            );

            // PlantGardens
            modelBuilder.Entity<PlantGarden>().HasData(
                new PlantGarden { PlantId = 1, GardenId = 1 }
            );

            // Instructions
            modelBuilder.Entity<Instruction>().HasData(
                new Instruction { InstructionId = 1, PlantId = 1 }
            );

        }
    }
}