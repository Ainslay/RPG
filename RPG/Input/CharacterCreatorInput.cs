using System;
using RPG.Character.Proffesions;
using RPG.Input.Result;

namespace RPG.Input
{
    class CharacterCreatorInput : IInput<PlayerProffesions>
    {
        public InputResult<PlayerProffesions> GetInput()
        {
            PlayerProffesions input;

            Console.WriteLine("Choose your proffesion:");
            Console.WriteLine("1. Mage");
            Console.WriteLine("2. Monk");
            Console.WriteLine("3. Warrior");
            Console.WriteLine();

            input = (PlayerProffesions)Console.ReadKey(true).Key;

            switch (input)
            {
                case PlayerProffesions.Mage:
                case PlayerProffesions.Monk:
                case PlayerProffesions.Warrior:
                    return new InputResult<PlayerProffesions>(input, InputResults.Valid);
                default:
                    Console.WriteLine("Invalid input.");
                    Console.ReadKey(true);
                    return new InputResult<PlayerProffesions>(input, InputResults.Invalid);
            }
        }
    }
}
