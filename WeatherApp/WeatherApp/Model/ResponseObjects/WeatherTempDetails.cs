using Newtonsoft.Json;

namespace WeatherApp.Models.ResponseObjects
{
    public class WeatherTempDetails
    {
        [JsonProperty("temp")]
        public string Temp { get; set; }
        [JsonProperty("humidity")]
        public string Humidity { get; set; }
    }
}
