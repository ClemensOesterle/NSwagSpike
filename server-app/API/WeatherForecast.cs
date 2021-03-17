using System;
using System.Text.Json.Serialization;

namespace API
{
    public class WeatherForecast : InfoEntryBase
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [JsonPropertyName("Summary")]
        public string Summary { get; set; }
    }
}
