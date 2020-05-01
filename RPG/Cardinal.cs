using System;
using RPG.Character.CharacterCreator;
using RPG.Character.Player;
using RPG.States;

namespace RPG
{
    class Cardinal
    {
        private IStateController _stateController;
        private PlayerCharacter _player;
        
        public Cardinal()
        {
            _player = new CharacterCreator().Create();
            _stateController = new StateController(_player);
        }

        public void Supervise()
        {
            while(true)
            {
                _stateController.HandleState();
            }
        }
    }
}
