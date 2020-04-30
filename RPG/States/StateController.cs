using System;

namespace RPG.States
{
    class StateController : IStateController
    {
        private IState _battleState;
        private IState _exploreState;
        private IState _state;

        public StateController()
        {
            _battleState = new BattleState(this);
            _exploreState = new ExploreState(this);
            _state = _exploreState;
        }

        public void HandleState()
        {
            _state.Handle();
        }
        
        public IState GetCurrentState()
        {
            return _state;
        }

        public IState GetBattleState()
        {
            return _battleState;
        }

        public IState GetExploreState()
        {
            return _exploreState;
        }

        public void SetState(IState state)
        {
            _state = state;
        }
    }
}
