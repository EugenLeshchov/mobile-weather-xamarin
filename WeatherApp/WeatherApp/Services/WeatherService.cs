using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        public static async Task<List<dynamic>> GetWeatherData(IEnumerable<string> cityIds)
        {
            string key = "675b45961b3ab46cd4aa975ba7b4965e";

            HttpClient client = new HttpClient();

            List<dynamic> result = new List<dynamic>();

            foreach (string cityId in cityIds)
            {
                string query = "http://api.openweathermap.org/data/2.5/forecast?id="+ cityId + "&appid=" + key;
                var response = await client.GetAsync(query);
                if (response != null)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    result.Add(JsonConvert.DeserializeObject(json));
                }
            }

            return result;
        }
    }
}
