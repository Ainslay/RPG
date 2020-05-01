using System;

using RPG.Actions;
using RPG.Input.Result;
using RPG.Controls;

namespace RPG.Input
{
    class BattleInput : IInput<BasicAction>
    {
        public InputResult<BasicAction> GetInput()
        {
            Console.WriteLine("Choose your action:");
            Console.WriteLine($"{(char)KeyBindings.Key1}. Attack");
            Console.WriteLine($"{(char)KeyBindings.Key2}. Flee");
            Console.WriteLine();

            var input = (KeyBindings)Console.ReadKey(true).Key;

            switch (input)
            {
                case KeyBindings.Key1:
                    return new InputResult<BasicAction>(BasicAction.BasicAttack, InputResults.Valid);
                case KeyBindings.Key2:
                    return new InputResult<BasicAction>(BasicAction.Flee, InputResults.Valid);
                default:
                    Console.WriteLine("Invalid input.");
                    Console.ReadKey(true);
                    return new InputResult<BasicAction>(BasicAction.None, InputResults.Invalid);
            }
        }
    }
}
