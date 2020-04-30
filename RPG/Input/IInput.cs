using System;
using RPG.Input.Result;

namespace RPG.Input
{
    interface IInput<T> where T : struct, IConvertible
    {
        InputResult<T> GetInput();
    }
}
