using System;

using RPG.Actions;

namespace RPG.Input
{
    class PlayerInput
    {
        public BasicAction GetInput()
        {
            Console.WriteLine("Choose your action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Flee");
            Console.WriteLine();
            return (BasicAction) Console.ReadKey(true).Key;
        }
    }
}
