using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.States
{
    interface IStateController
    {
        void SetState(IState state);
        void HandleState();
        IState GetCurrentState();
    }
}
