using System;

using RPG.Actions;
using RPG.Input.Result;

namespace RPG.Input
{
    class PlayerInput
    {
        public InputResult GetInput()
        {
            BasicAction input;
            
            Console.WriteLine("Choose your action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Flee");
            Console.WriteLine();

            input = (BasicAction)Console.ReadKey(true).Key;

            switch (input)
            {
                case BasicAction.BasicAttack:
                case BasicAction.Flee:
                    return new InputResult(input, InputResults.Valid);
                default:
                    Console.WriteLine("Invalid input.");
                    Console.ReadKey();
                    return new InputResult(input, InputResults.Invalid);
            }
        }
    }
}
