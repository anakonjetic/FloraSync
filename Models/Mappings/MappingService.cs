using FloraSync.Models.Dtos;
using FloraSync.Models.Entities;
using FloraSync.Models.Enums;

namespace FloraSync.Models.Mappings
{
    public static class MappingService
    {
        public static PlantDto ToDto(Plant p) => new()
        {
            Id = p.Id,
            Name = p.Name,
            Type = p.Type.ToDescription(),
            TypeValue = p.Type.ToConstant(),
            TypeIcon = p.Type.ToIcon(),
            Water = p.Water.ToDescription(),
            WaterValue = p.Water.ToConstant(),
            WaterIcon = p.Water.ToIcon(),
            Light = p.Light.ToDescription(),
            LightValue = p.Light.ToConstant(),
            LightIcon = p.Light.ToIcon(),
            Temperature = p.Temperature.ToDescription(),
            TemperatureValue = p.Temperature.ToConstant(),
            TemperatureIcon = p.Temperature.ToIcon(),
            ImageUrl = p.ImageUrl,
            FunFact = p.FunFact
        };
    }
}
