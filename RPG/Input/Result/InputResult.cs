using System;

namespace RPG.Input.Result
{
    class InputResult<T> where T : struct , IConvertible
    {
        public T? Input;
        public InputResults Result;

        public InputResult(T? input, InputResults result)
        {
            if(typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enumerable type");
            }

            Input = input;
            Result = result;
        }

        public bool IsValid()
        {
            return Result == InputResults.Valid;
        }

        public T GetValidInput()
        {
            if (IsValid())
            {
                return Input ?? throw new NullReferenceException(nameof(Input));
            }

            throw new Exception("Input is in invalid state.");
        }
    }
}
