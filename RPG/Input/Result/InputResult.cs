using System;

namespace RPG.Input.Result
{
    class InputResult<T> where T : struct , IConvertible
    {
        private T? _input;
        private InputResults _result;

        public InputResult(T? input, InputResults result)
        {
            if(!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enumerable type");
            }

            _input = input;
            _result = result;
        }

        public bool IsValid()
        {
            return _result == InputResults.Valid;
        }

        public T GetValidInput()
        {
            if (IsValid())
            {
                return _input ?? throw new NullReferenceException(nameof(_input));
            }

            throw new Exception("Input is in invalid state.");
        }
    }
}
