using RPG.Character.Player;
using RPG.Utilities;

namespace RPG.States
{
    class StateController : IStateController
    {
        private IState _currentState;

        public StateController(PlayerCharacter player)
        {
            ParamCheck.IsNull(player);

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
            ParamCheck.IsNull(state);

            _currentState = state;
        }
    }
}
