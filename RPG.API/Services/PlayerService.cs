using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.API.Database;
using RPG.API.Model;

namespace RPG.API.Services
{
    class PlayerService : IPlayerService
    {
        private ApplicationDbContext _context;

        public PlayerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddPlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
        }

        public Player GetPlayerById(int id)
        {
            // Wymyślone wymagania biznesowe
            // ...
            return _context.Players.Single(player => player.PlayerId == id);
        }

        public ICollection<Player> GetPlayers()
        {
            return _context.Players.ToList();
        }

        public void RemoveAtId(int id)
        {
            var playerToRemove = GetPlayerById(id);

            if (playerToRemove != null)
            {
                _context.Remove(playerToRemove);
                _context.SaveChanges();
            }
        }

        public void UpdatePlayer(Player player)
        {
            _context.Players.Update(player);
            _context.SaveChanges();
        }
    }
}
