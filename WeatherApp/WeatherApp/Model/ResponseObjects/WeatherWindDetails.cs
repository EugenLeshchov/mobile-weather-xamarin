using Newtonsoft.Json;

namespace WeatherApp.Models.ResponseObjects
{
    public class WeatherWindDetails
    {
        [JsonProperty("speed")]
        public string Speed { get; set; }
        [JsonProperty("deg")]
        public float Angle { get; set; }
    }
}
