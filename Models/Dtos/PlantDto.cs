namespace FloraSync.Models.Dtos
{
    public class PlantDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Type { get; set; } = default!;
        public string TypeValue { get; set; } = default!;
        public string TypeIcon { get; set; } = default!;
        public string Water { get; set; } = default!;
        public string WaterValue { get; set; } = default!;
        public string WaterIcon { get; set; } = default!;
        public string Light { get; set; } = default!;
        public string LightValue { get; set; } = default!;
        public string LightIcon { get; set; } = default!;
        public string Temperature { get; set; } = default!;
        public string TemperatureValue { get; set; } = default!;
        public string TemperatureIcon { get; set; } = default!;
        public string? ImageUrl { get; set; }
        public string FunFact { get; set; } = default!;
    }
}
