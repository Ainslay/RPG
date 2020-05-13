using System;
using System.Collections.Generic;
using System.Text;
using RPG.Character.Stats;
using RPG.Controls;
using RPG.Input.Result;

namespace RPG.Input
{
    class LevelUpInput : IInput<AttributesEnum>
    {
        public InputResult<AttributesEnum> GetInput()
        {
            Console.WriteLine("Which attribute do you want to increase:");
            Console.WriteLine($"{(char)KeyBindings.Key1}. Strength");
            Console.WriteLine($"{(char)KeyBindings.Key2}. Dexterity");
            Console.WriteLine($"{(char)KeyBindings.Key3}. Intelligence");
            Console.WriteLine();

            var input = (KeyBindings)Console.ReadKey(true).Key;

            switch (input)
            {
                case KeyBindings.Key1:
                    return new InputResult<AttributesEnum>(AttributesEnum.Strength, InputResults.Valid);
                case KeyBindings.Key2:
                    return new InputResult<AttributesEnum>(AttributesEnum.Dexterity, InputResults.Valid);
                case KeyBindings.Key3:
                    return new InputResult<AttributesEnum>(AttributesEnum.Intelligence, InputResults.Valid);
                default:
                    Console.WriteLine("Invalid input.");
                    Console.ReadKey(true);
                    return new InputResult<AttributesEnum>(AttributesEnum.None, InputResults.Invalid);
            }
        }
    }
}
