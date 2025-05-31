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
            modelBuilder.Entity<Plant>().HasData(
                new Plant
                {
                    Id = 1,
                    Name = "Monstera Deliciosa",
                    Type = PlantType.Tropical,
                    Water = WateringFrequency.Regular,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/monstera_deliciosa.png",
                    FunFact = "Monstera leaves develop holes to withstand heavy rainfall."
                },

                new Plant
                {
                    Id = 2,
                    Name = "Aloe Vera",
                    Type = PlantType.Succulent,
                    Water = WateringFrequency.Rare,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/aloe_vera.png",
                    FunFact = "Aloe vera gel can be used to treat sunburns."
                },

                new Plant
                {
                    Id = 3,
                    Name = "Boston Fern",
                    Type = PlantType.Fern,
                    Water = WateringFrequency.Frequent,
                    Light = LightLevel.ShadeLoving,
                    Temperature = TemperatureRange.Cool,
                    ImageUrl = "/images/boston_fern.png",
                    FunFact = "Ferns were around before dinosaurs roamed the earth."
                },

                new Plant
                {
                    Id = 4,
                    Name = "Prickly Pear",
                    Type = PlantType.Cactus,
                    Water = WateringFrequency.Rare,
                    Light = LightLevel.Direct,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/prickly_pear.png",
                    FunFact = "Its fruit is edible and often used in jams and drinks."
                },

                new Plant
                {
                    Id = 5,
                    Name = "Peace Lily",
                    Type = PlantType.Flowering,
                    Water = WateringFrequency.Regular,
                    Light = LightLevel.Low,
                    Temperature = TemperatureRange.Moderate,
                    ImageUrl = "/images/peace_lily.png",
                    FunFact = "It can bloom even in low light."
                },

                new Plant
                {
                    Id = 6,
                    Name = "Pothos",
                    Type = PlantType.Trailing,
                    Water = WateringFrequency.Occasional,
                    Light = LightLevel.Low,
                    Temperature = TemperatureRange.Moderate,
                    ImageUrl = "/images/pothos.png",
                    FunFact = "Pothos can grow in water without soil."
                },

                new Plant
                {
                    Id = 7,
                    Name = "Basil",
                    Type = PlantType.Herb,
                    Water = WateringFrequency.Frequent,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/basil.png",
                    FunFact = "Basil is considered a sacred herb in some cultures."
                },

                new Plant
                {
                    Id = 8,
                    Name = "Tillandsia",
                    Type = PlantType.AirPlant,
                    Water = WateringFrequency.Occasional,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Tropical,
                    ImageUrl = "/images/tillandsia.png",
                    FunFact = "Air plants don't need soil to grow."
                },

                new Plant
                {
                    Id = 9,
                    Name = "Fiddle Leaf Fig",
                    Type = PlantType.Tropical,
                    Water = WateringFrequency.Regular,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/fiddle_leaf_fig.png",
                    FunFact = "Fiddle Leaf Figs can grow over 10 feet indoors."
                },

                new Plant
                {
                    Id = 10,
                    Name = "Jade Plant",
                    Type = PlantType.Succulent,
                    Water = WateringFrequency.Occasional,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/jade_plant.png",
                    FunFact = "Jade is considered a symbol of good luck."
                },

                new Plant
                {
                    Id = 11,
                    Name = "Staghorn Fern",
                    Type = PlantType.Fern,
                    Water = WateringFrequency.Frequent,
                    Light = LightLevel.Low,
                    Temperature = TemperatureRange.Cool,
                    ImageUrl = "/images/staghorn_fern.png",
                    FunFact = "Its fronds resemble a stag’s antlers."
                },

                new Plant
                {
                    Id = 12,
                    Name = "Barrel Cactus",
                    Type = PlantType.Cactus,
                    Water = WateringFrequency.Rare,
                    Light = LightLevel.Direct,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/barrel_cactus.png",
                    FunFact = "It stores water to survive long droughts."
                },

                new Plant
                {
                    Id = 13,
                    Name = "Anthurium",
                    Type = PlantType.Flowering,
                    Water = WateringFrequency.Regular,
                    Light = LightLevel.Medium,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/anthurium.png",
                    FunFact = "Known for its heart-shaped waxy flowers."
                },

                new Plant
                {
                    Id = 14,
                    Name = "String of Pearls",
                    Type = PlantType.Trailing,
                    Water = WateringFrequency.Occasional,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/string_of_pearls.png",
                    FunFact = "Each pearl stores water."
                },

                new Plant
                {
                    Id = 15,
                    Name = "Mint",
                    Type = PlantType.Herb,
                    Water = WateringFrequency.Frequent,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Cool,
                    ImageUrl = "/images/mint.png",
                    FunFact = "Mint can spread quickly and become invasive."
                },

                new Plant
                {
                    Id = 16,
                    Name = "Spanish Moss",
                    Type = PlantType.AirPlant,
                    Water = WateringFrequency.Frequent,
                    Light = LightLevel.ShadeLoving,
                    Temperature = TemperatureRange.Tropical,
                    ImageUrl = "/images/spanish_moss.png",
                    FunFact = "It gets nutrients from the air."
                },

                new Plant
                {
                    Id = 17,
                    Name = "Rubber Plant",
                    Type = PlantType.Tropical,
                    Water = WateringFrequency.Regular,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/rubber_plant.png",
                    FunFact = "It can grow up to 100 feet in the wild."
                },

                new Plant
                {
                    Id = 18,
                    Name = "Zebra Haworthia",
                    Type = PlantType.Succulent,
                    Water = WateringFrequency.Rare,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Cool,
                    ImageUrl = "/images/zebra_haworthia.png",
                    FunFact = "It looks like a tiny zebra-striped aloe."
                },

                new Plant
                {
                    Id = 19,
                    Name = "Maidenhair Fern",
                    Type = PlantType.Fern,
                    Water = WateringFrequency.Frequent,
                    Light = LightLevel.ShadeLoving,
                    Temperature = TemperatureRange.Cool,
                    ImageUrl = "/images/maidenhair_fern.png",
                    FunFact = "Its leaves resemble soft hair."
                },

                new Plant
                {
                    Id = 20,
                    Name = "Golden Barrel",
                    Type = PlantType.Cactus,
                    Water = WateringFrequency.Rare,
                    Light = LightLevel.Direct,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/golden_barrel.png",
                    FunFact = "It can live for over 30 years."
                },

                new Plant
                {
                    Id = 21,
                    Name = "Orchid",
                    Type = PlantType.Flowering,
                    Water = WateringFrequency.Regular,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Tropical,
                    ImageUrl = "/images/orchid.png",
                    FunFact = "Orchids have the smallest seeds in the world."
                },

                new Plant
                {
                    Id = 22,
                    Name = "English Ivy",
                    Type = PlantType.Trailing,
                    Water = WateringFrequency.Regular,
                    Light = LightLevel.Low,
                    Temperature = TemperatureRange.Cool,
                    ImageUrl = "/images/english_ivy.png",
                    FunFact = "It can climb and cover entire walls."
                },

                new Plant
                {
                    Id = 23,
                    Name = "Cilantro",
                    Type = PlantType.Herb,
                    Water = WateringFrequency.Frequent,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Cool,
                    ImageUrl = "/images/cilantro.png",
                    FunFact = "Cilantro leaves and coriander seeds come from the same plant."
                },

                new Plant
                {
                    Id = 24,
                    Name = "Bulbosa",
                    Type = PlantType.AirPlant,
                    Water = WateringFrequency.Occasional,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Tropical,
                    ImageUrl = "/images/bulbosa.png",
                    FunFact = "It curls its leaves to retain water."
                },

                new Plant
                {
                    Id = 25,
                    Name = "Calathea",
                    Type = PlantType.Tropical,
                    Water = WateringFrequency.Frequent,
                    Light = LightLevel.ShadeLoving,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/calathea.png",
                    FunFact = "Leaves close up at night."
                },

                new Plant
                {
                    Id = 26,
                    Name = "Echeveria",
                    Type = PlantType.Succulent,
                    Water = WateringFrequency.Rare,
                    Light = LightLevel.Direct,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/echeveria.png",
                    FunFact = "Named after a Mexican botanical illustrator."
                },

                new Plant
                {
                    Id = 27,
                    Name = "Bird’s Nest Fern",
                    Type = PlantType.Fern,
                    Water = WateringFrequency.Frequent,
                    Light = LightLevel.Low,
                    Temperature = TemperatureRange.Cool,
                    ImageUrl = "/images/bird’s_nest_fern.png",
                    FunFact = "New fronds grow from the center like a bird’s nest."
                },

                new Plant
                {
                    Id = 28,
                    Name = "Bunny Ear Cactus",
                    Type = PlantType.Cactus,
                    Water = WateringFrequency.Rare,
                    Light = LightLevel.Direct,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/bunny_ear_cactus.png",
                    FunFact = "Named for its pad-like shape."
                },

                new Plant
                {
                    Id = 29,
                    Name = "Begonia",
                    Type = PlantType.Flowering,
                    Water = WateringFrequency.Regular,
                    Light = LightLevel.Low,
                    Temperature = TemperatureRange.Moderate,
                    ImageUrl = "/images/begonia.png",
                    FunFact = "There are over 1,000 species."
                },

                new Plant
                {
                    Id = 30,
                    Name = "Creeping Jenny",
                    Type = PlantType.Trailing,
                    Water = WateringFrequency.Frequent,
                    Light = LightLevel.Medium,
                    Temperature = TemperatureRange.Moderate,
                    ImageUrl = "/images/creeping_jenny.png",
                    FunFact = "It spreads easily and fast."
                },

                new Plant
                {
                    Id = 31,
                    Name = "Rosemary",
                    Type = PlantType.Herb,
                    Water = WateringFrequency.Occasional,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/rosemary.png",
                    FunFact = "Used historically as a memory aid."
                },

                new Plant
                {
                    Id = 32,
                    Name = "Caput Medusae",
                    Type = PlantType.AirPlant,
                    Water = WateringFrequency.Occasional,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Tropical,
                    ImageUrl = "/images/caput_medusae.png",
                    FunFact = "Its twisted leaves resemble Medusa’s hair."
                },

                new Plant
                {
                    Id = 33,
                    Name = "Philodendron",
                    Type = PlantType.Tropical,
                    Water = WateringFrequency.Regular,
                    Light = LightLevel.Low,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/philodendron.png",
                    FunFact = "Can grow without direct sunlight."
                },

                new Plant
                {
                    Id = 34,
                    Name = "Panda Plant",
                    Type = PlantType.Succulent,
                    Water = WateringFrequency.Rare,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/panda_plant.png",
                    FunFact = "Fuzzy leaves resemble panda fur."
                },

                new Plant
                {
                    Id = 35,
                    Name = "Asparagus Fern",
                    Type = PlantType.Fern,
                    Water = WateringFrequency.Frequent,
                    Light = LightLevel.ShadeLoving,
                    Temperature = TemperatureRange.Cool,
                    ImageUrl = "/images/asparagus_fern.png",
                    FunFact = "Not a true fern!"
                },

                new Plant
                {
                    Id = 36,
                    Name = "Christmas Cactus",
                    Type = PlantType.Cactus,
                    Water = WateringFrequency.Regular,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Cool,
                    ImageUrl = "/images/christmas_cactus.png",
                    FunFact = "Blooms in winter."
                },

                new Plant
                {
                    Id = 37,
                    Name = "African Violet",
                    Type = PlantType.Flowering,
                    Water = WateringFrequency.Regular,
                    Light = LightLevel.Low,
                    Temperature = TemperatureRange.Cool,
                    ImageUrl = "/images/african_violet.png",
                    FunFact = "Leaves are sensitive to cold water."
                },

                new Plant
                {
                    Id = 38,
                    Name = "String of Hearts",
                    Type = PlantType.Trailing,
                    Water = WateringFrequency.Occasional,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Moderate,
                    ImageUrl = "/images/string_of_hearts.png",
                    FunFact = "Heart-shaped leaves on vines."
                },

                new Plant
                {
                    Id = 39,
                    Name = "Chives",
                    Type = PlantType.Herb,
                    Water = WateringFrequency.Frequent,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Cool,
                    ImageUrl = "/images/chives.png",
                    FunFact = "Flowers are edible and tasty."
                },

                new Plant
                {
                    Id = 40,
                    Name = "Ionantha",
                    Type = PlantType.AirPlant,
                    Water = WateringFrequency.Occasional,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Tropical,
                    ImageUrl = "/images/ionantha.png",
                    FunFact = "Turns red when about to bloom."
                },

                new Plant
                {
                    Id = 41,
                    Name = "Dieffenbachia",
                    Type = PlantType.Tropical,
                    Water = WateringFrequency.Regular,
                    Light = LightLevel.Low,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/dieffenbachia.png",
                    FunFact = "Also called dumb cane."
                },

                new Plant
                {
                    Id = 42,
                    Name = "Hens and Chicks",
                    Type = PlantType.Succulent,
                    Water = WateringFrequency.Rare,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Cold,
                    ImageUrl = "/images/hens_and_chicks.png",
                    FunFact = "Offsets look like chicks."
                },

                new Plant
                {
                    Id = 43,
                    Name = "Kangaroo Fern",
                    Type = PlantType.Fern,
                    Water = WateringFrequency.Frequent,
                    Light = LightLevel.ShadeLoving,
                    Temperature = TemperatureRange.Cool,
                    ImageUrl = "/images/kangaroo_fern.png",
                    FunFact = "Native to Australia."
                },

                new Plant
                {
                    Id = 44,
                    Name = "Old Man Cactus",
                    Type = PlantType.Cactus,
                    Water = WateringFrequency.Rare,
                    Light = LightLevel.Direct,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/old_man_cactus.png",
                    FunFact = "Covered in white hairs."
                },

                new Plant
                {
                    Id = 45,
                    Name = "Petunia",
                    Type = PlantType.Flowering,
                    Water = WateringFrequency.Regular,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Moderate,
                    ImageUrl = "/images/petunia.png",
                    FunFact = "Blooms in many vibrant colors."
                },

                new Plant
                {
                    Id = 46,
                    Name = "Spider Plant",
                    Type = PlantType.Trailing,
                    Water = WateringFrequency.Regular,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Moderate,
                    ImageUrl = "/images/spider_plant.png",
                    FunFact = "Produces baby spiderettes."
                },

                new Plant
                {
                    Id = 47,
                    Name = "Thyme",
                    Type = PlantType.Herb,
                    Water = WateringFrequency.Occasional,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Warm,
                    ImageUrl = "/images/thyme.png",
                    FunFact = "Used for culinary and medicinal purposes."
                },

                new Plant
                {
                    Id = 48,
                    Name = "Stricta",
                    Type = PlantType.AirPlant,
                    Water = WateringFrequency.Occasional,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Tropical,
                    ImageUrl = "/images/stricta.png",
                    FunFact = "One of the easiest air plants."
                },

                new Plant
                {
                    Id = 49,
                    Name = "Banana Plant",
                    Type = PlantType.Tropical,
                    Water = WateringFrequency.Frequent,
                    Light = LightLevel.Bright,
                    Temperature = TemperatureRange.Tropical,
                    ImageUrl = "/images/banana_plant.png",
                    FunFact = "Technically a giant herb, not a tree."
                }
            );
        }
    }
 }
