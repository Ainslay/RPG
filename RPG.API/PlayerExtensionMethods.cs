using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.API.Model;

namespace RPG.API
{
    static class PlayerExtensionMethods
    {
        public static Player MakeCopyOf(this Player existingPlayer, Player player)
        {
            existingPlayer.Name = player.Name;
            existingPlayer.Health = player.Health;
            existingPlayer.Strength = player.Strength;
            existingPlayer.Dexterity = player.Dexterity;
            existingPlayer.Intelligence = player.Intelligence;
            existingPlayer.Level = player.Level;
            existingPlayer.Proffesion = player.Proffesion;
            existingPlayer.Resource = player.Resource;

            return existingPlayer;
        }
    }
}
