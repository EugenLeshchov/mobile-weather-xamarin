using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeatherApp.Model.ResponseObjects
{    

    public class WeatherMainModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("main")]
        public WeatherTempDetails Main { get; set; }
        [JsonProperty("weather")]
        public List<WeatherSubDetails> Weather { get; set; }
        [JsonProperty("wind")]
        public WeatherWindDetails Wind { get; set; }
        [JsonProperty("sys")]
        public WeatherSysDetails Sys { get; set; }
    }
}
