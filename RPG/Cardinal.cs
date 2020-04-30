using System;
using RPG.States;

namespace RPG
{
    class Cardinal
    {
        private IStateController _stateController;

        public Cardinal()
        {
            _stateController = new StateController();
        }

        public void Supervise()
        {
            while(true)
            {
                _stateController.HandleState();
                Console.ReadKey();
            }
        }
    }
}
