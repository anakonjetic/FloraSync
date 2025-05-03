using FloraSync.Models.Entities;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using static FloraSync.Models.Enums.Enums;

namespace FloraSync.Repository
{
    public class FloraSyncContext : DbContext
    {
        public FloraSyncContext(DbContextOptions<FloraSyncContext> options) : base(options) { }

        public DbSet<Plant> Plants => Set<Plant>();
        public DbSet<DiaryImage> DiaryImages => Set<DiaryImage>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plant>().HasData(new Plant
            {
                Id = 1,
                Name = "Monstera Deliciosa",
                Type = PlantType.Tropical,
                Water = WateringFrequency.Regular,
                Light = LightLevel.Medium,
                Temperature = TemperatureRange.Moderate,
                ImageUrl = "/images/monstera.png",
                FunFact = "Monstera leaves develop holes to withstand tropical storms."
            });
        }
    }
 }
