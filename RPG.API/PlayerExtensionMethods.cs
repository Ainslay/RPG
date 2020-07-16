using RPG.API.Model;

namespace RPG.API
{
    static class PlayerExtensionMethods
    {
        public static Player MakeCopyOf(this Player existingPlayer, Player player)
        {
            existingPlayer.Name = player.Name;
            existingPlayer.Strength = player.Strength;
            existingPlayer.Dexterity = player.Dexterity;
            existingPlayer.Intelligence = player.Intelligence;
            existingPlayer.Level = player.Level;
            existingPlayer.Proffesion = player.Proffesion;

            return existingPlayer;
        }
    }
}
