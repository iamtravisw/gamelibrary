using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gamelibrary.Models
{
    public class Game
    {
        public int id { get; set; } = 0;
        public string name { get; set; } = "";
        public string url { get; set; } = "";
        public Cover cover { get; set; } = new Cover();
        public List<Platform> platforms { get; set; } = new List<Platform>();
        public long first_release_date { get; set; } = 0;
        public double rating { get; set; } = 0.00;
    }
}
