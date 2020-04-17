using System;

using RPG.Actions;
using RPG.Combat;

namespace RPG.Input
{
    class PlayerInput
    {
        private BattleInterface _battleInterface;

        public PlayerInput(BattleInterface battleInterface)
        {
            _battleInterface = battleInterface;
        }

        public BasicAction GetInput()
        {
            BasicAction input;
            bool isInputValid = false;
            
            do
            {
                Console.Clear();
                _battleInterface.Print();

                Console.WriteLine("Choose your action:");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Flee");
                Console.WriteLine();

                input = (BasicAction)Console.ReadKey(true).Key;

                switch (input)
                {
                    case BasicAction.BasicAttack:
                    case BasicAction.Flee:
                        isInputValid = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        Console.ReadKey();
                        break;
                }
            }
            while (isInputValid == false);

            return input;
        }
    }
}
