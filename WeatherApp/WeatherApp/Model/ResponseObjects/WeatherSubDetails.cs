using Newtonsoft.Json;

namespace WeatherApp.Models.ResponseObjects
{
    public class WeatherSubDetails
    {
        [JsonProperty("main")]
        public string Main { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}
