using System.Collections.Generic;
using System.Threading.Tasks;
using gamelibrary.Models;

namespace gamelibrary.Services
{
    public interface IGamesServices
    {
        Task<List<Game>> GetGamesBasedOnSearch(string gameName);
    }
}