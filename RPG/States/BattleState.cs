using System;

namespace RPG.States
{
    class BattleState : IState
    {
        private IStateController _stateController;

        public BattleState(IStateController stateController)
        {
            _stateController = stateController;
        }

        public void Handle()
        {
            Console.WriteLine("You are now in battle state!");
            _stateController.SetState(_stateController.GetExploreState());
        }
    }
}
