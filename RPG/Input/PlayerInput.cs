using System;

using RPG.Actions;
using RPG.Combat;

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

    // TODO: Extract class and enum to seperate files
    class InputResult
    {
        public BasicAction? Action;
        public InputResults Result;

        public InputResult(BasicAction? action, InputResults result)
        {
            Action = action;
            Result = result;
        }

        public bool IsValid()
        {
            return Result == InputResults.Valid;
        }

        public BasicAction GetValidAction()
        {
            if(IsValid())
            {
                return Action ?? throw new NullReferenceException(nameof(Action));
            }

            throw new Exception("Action is in invalid state.");
        }
    }

    enum InputResults
    {
        Invalid,
        Valid
    }

}
