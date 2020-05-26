using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.API.Model;

namespace RPG.API.Services
{
    interface IPlayerService
    {
        void AddPlayer(Player player);
        Player GetPlayerById(int id);
        ICollection<Player> GetPlayers();
        void UpdatePlayer(Player player);
        void RemoveAtId(int id);
    }
}
