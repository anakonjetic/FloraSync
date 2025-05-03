using static FloraSync.Models.Enums.Enums;

namespace FloraSync.Models.Entities
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public PlantType Type { get; set; }
        public WateringFrequency Water { get; set; }
        public LightLevel Light { get; set; }
        public TemperatureRange Temperature { get; set; }
        public string? ImageUrl { get; set; }
        public string FunFact { get; set; } = default!;
    }
}
