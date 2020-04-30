using System;

namespace RPG.States
{
    class ExploreState : IState
    {
        private IStateController _stateController;

        public ExploreState(IStateController stateController)
        {
            _stateController = stateController;
        }

        public void Handle()
        {
            Console.WriteLine("You are now in exploration state!");
            _stateController.SetState(_stateController.GetBattleState());
        }
    }
}
