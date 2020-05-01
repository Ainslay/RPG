using System;
using RPG.Character.Player;

namespace RPG.States
{
    class StateController : IStateController
    {
        private IState _currentState;

        public StateController(PlayerCharacter player)
        {
            _currentState = new ExploreState(this, player);
        }

        public void HandleState()
        {
            _currentState.Handle();
        }
        
        public IState GetCurrentState()
        {
            return _currentState;
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }
    }
}
