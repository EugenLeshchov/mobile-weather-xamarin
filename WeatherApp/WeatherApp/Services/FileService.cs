using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WeatherApp.Model;

namespace WeatherApp.Services
{
    class FileService
    {
        public static List<City> GetCities()
        {
            List<City> result;

            using (StreamReader r = new StreamReader("city.list.json"))
            {
                string json = r.ReadToEnd();
                result = JsonConvert.DeserializeObject<List<City>>(json);
            }

            return result;
        }
    }
}
