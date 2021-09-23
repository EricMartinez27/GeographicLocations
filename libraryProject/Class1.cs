using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace libraryProject
{
    public record Location(string name,  float[] position);

    public class Fetching
    {
        public static async Task<List<Location>> GetDataFromHttp()
        {
            var client = new HttpClient();
            var Locations = await client.GetFromJsonAsync<List<Location>>("https://raw.githubusercontent.com/chyld/datasets/main/markers.json");
           

            // if (jsonTask.Status != TaskStatus.RanToCompletion) throw new Exception("JSON Error");

            return Locations;      

        }
    }
}
