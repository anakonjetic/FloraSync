using static FloraSync.Models.Enums.Enums;

namespace FloraSync.Models.Enums
{
    public static class EnumExtensions
    {
        public static string ToDescription(this WateringFrequency e) => e switch
        {
            WateringFrequency.Rare => "Every 2–3 weeks",
            WateringFrequency.Occasional => "Every 10–14 days",
            WateringFrequency.Regular => "Weekly",
            WateringFrequency.Frequent => "2–3 times a week",
            WateringFrequency.Constant => "Keep soil moist at all times",
            _ => "Unknown"
        };
        public static string ToConstant(this WateringFrequency e) => e.ToString();
        public static string ToIcon(this WateringFrequency e) => e switch
        {
            WateringFrequency.Rare => "🥀",
            WateringFrequency.Occasional => "📆",
            WateringFrequency.Regular => "💧",
            WateringFrequency.Frequent => "🚿",
            WateringFrequency.Constant => "🌊",
            _ => "❔"
        };

        public static string ToDescription(this LightLevel e) => e switch
        {
            LightLevel.Low => "Low light",
            LightLevel.Medium => "Medium indirect light",
            LightLevel.Bright => "Bright indirect light",
            LightLevel.Direct => "Direct sunlight",
            LightLevel.ShadeLoving => "Shade-tolerant",
            _ => "Unknown"
        };
        public static string ToConstant(this LightLevel e) => e.ToString();
        public static string ToIcon(this LightLevel e) => e switch
        {
            LightLevel.Low => "🌑",
            LightLevel.Medium => "🌥️",
            LightLevel.Bright => "☀️",
            LightLevel.Direct => "🔆",
            LightLevel.ShadeLoving => "🌲",
            _ => "❔"
        };

        public static string ToDescription(this TemperatureRange e) => e switch
        {
            TemperatureRange.Cold => "10–15°C",
            TemperatureRange.Cool => "15–20°C",
            TemperatureRange.Moderate => "18–27°C",
            TemperatureRange.Warm => "20–30°C",
            TemperatureRange.Tropical => "24–35°C",
            _ => "Unknown"
        };
        public static string ToConstant(this TemperatureRange e) => e.ToString();
        public static string ToIcon(this TemperatureRange e) => e switch
        {
            TemperatureRange.Cold => "❄️",
            TemperatureRange.Cool => "🌬️",
            TemperatureRange.Moderate => "🌡️",
            TemperatureRange.Warm => "🔥",
            TemperatureRange.Tropical => "🌴",
            _ => "❔"
        };

        public static string ToDescription(this PlantType e) => e switch
        {
            PlantType.Tropical => "Tropical Plant",
            PlantType.Succulent => "Succulent",
            PlantType.Fern => "Fern",
            PlantType.Cactus => "Cactus",
            PlantType.Flowering => "Flowering Plant",
            PlantType.Trailing => "Trailing Vine",
            PlantType.Herb => "Herb",
            PlantType.AirPlant => "Air Plant",
            _ => "Unknown"
        };
        public static string ToConstant(this PlantType e) => e.ToString();
        public static string ToIcon(this PlantType e) => e switch
        {
            PlantType.Tropical => "🌴",
            PlantType.Succulent => "🪴",
            PlantType.Fern => "🌿",
            PlantType.Cactus => "🌵",
            PlantType.Flowering => "🌸",
            PlantType.Trailing => "🌾",
            PlantType.Herb => "🍃",
            PlantType.AirPlant => "💨",
            _ => "❔"
        };
    }
}
