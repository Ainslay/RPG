using System;
using RPG.Character.Proffesions;
using RPG.Controls;
using RPG.Input.Result;

namespace RPG.Input
{
    class CharacterCreatorInput : IInput<PlayerProffesions>
    {
        public InputResult<PlayerProffesions> GetInput()
        {
            Console.WriteLine("Choose your proffesion:");
            Console.WriteLine($"{(char)KeyBindings.Key1}. Mage");
            Console.WriteLine($"{(char)KeyBindings.Key2}. Monk");
            Console.WriteLine($"{(char)KeyBindings.Key3}. Warrior");
            Console.WriteLine();

            var input = (KeyBindings)Console.ReadKey(true).Key;

            switch (input)
            {
                case KeyBindings.Key1:
                    return new InputResult<PlayerProffesions>(PlayerProffesions.Mage, InputResults.Valid);
                case KeyBindings.Key2:
                    return new InputResult<PlayerProffesions>(PlayerProffesions.Monk, InputResults.Valid);
                case KeyBindings.Key3:
                    return new InputResult<PlayerProffesions>(PlayerProffesions.Warrior, InputResults.Valid);
                default:
                    Console.WriteLine("Invalid input.");
                    Console.ReadKey(true);
                    return new InputResult<PlayerProffesions>(PlayerProffesions.None, InputResults.Invalid);
            }
        }
    }
}
