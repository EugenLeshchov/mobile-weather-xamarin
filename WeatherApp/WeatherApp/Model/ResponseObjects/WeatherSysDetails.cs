using Newtonsoft.Json;

namespace WeatherApp.Models.ResponseObjects
{
    public class WeatherSysDetails
    {
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
