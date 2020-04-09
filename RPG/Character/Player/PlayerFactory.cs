using System;

using RPG.Utilities;
using RPG.Character.Proffesions;

namespace RPG.Character.Player
{
    static class PlayerFactory
    {
        public static Player Create(string name, PlayerProffesions proffesion)
        {
            ParamCheck.IsNullOrWhitespace(name);

            Proffesion playerProffesion = null;

            switch (proffesion)
            {
                case PlayerProffesions.Warrior:
                    playerProffesion = new Warrior();
                    break;

                case PlayerProffesions.Mage:
                    playerProffesion = new Mage();
                    break;

                case PlayerProffesions.Monk:
                    playerProffesion = new Monk();
                    break;

                default:
                    throw new ArgumentException("Could not create player object. Invalid proffesion.");
            }

            return new Player(name, playerProffesion);
        }
    }
}
