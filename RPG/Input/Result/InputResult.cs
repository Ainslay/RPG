using System;

using RPG.Actions;

namespace RPG.Input.Result
{
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
            if (IsValid())
            {
                return Action ?? throw new NullReferenceException(nameof(Action));
            }

            throw new Exception("Action is in invalid state.");
        }
    }
}
