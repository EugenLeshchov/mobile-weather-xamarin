using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Model
{    
    public struct Coordinates
    {
        [JsonProperty("lon")]
        string Longitude;

        [JsonProperty("lat")]
        string Latitude;
    }

    public class City
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("coord")]
        public Coordinates Coords { get; set; }
    }
}
