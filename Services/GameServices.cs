using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using gamelibrary.Models;
using Newtonsoft.Json;

namespace gamelibrary.Services
{
    public class GamesServices : IGamesServices
    {
        public async Task<List<Game>> GetGamesBasedOnSearch(string gameName)
        {
            using (var client = new WebClient())
            {
                var userKey = Environment.GetEnvironmentVariable("USER-KEY");
                var url = new Uri("https://api-v3.igdb.com/games");
                string data = $"search \"{gameName}\"; fields id, name, url, rating, cover.url, platforms, platforms.name, first_release_date; limit 24;";
                var headers = new WebHeaderCollection();
                headers.Add("user-key", userKey); // You will need a key
                client.Headers = headers;
                var result = client.UploadString(url, data);
                Console.Write(result);
                return JsonConvert.DeserializeObject<List<Game>>(result);
            }
        }
    }
}