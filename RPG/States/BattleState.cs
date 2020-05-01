using System;
using RPG.Character.Enemies;
using RPG.Character.Enemies.Tools;
using RPG.Character.Player;
using RPG.Combat.Battles;

namespace RPG.States
{
    class BattleState : IState
    {
        private IStateController _stateController;
        private PlayerCharacter _player;
        private Enemy _enemy;

        public BattleState(IStateController stateController, PlayerCharacter player, Enemy enemy)
        {
            _stateController = stateController;
            _player = player;
            _enemy = enemy;
        }

        public void Handle()
        {
            Console.Clear();
            Console.WriteLine("You are now in battle state!");
            Console.WriteLine();

            var battle = new Battle(_player, _enemy);

            battle.Fight();

            _stateController.SetState(new ExploreState(_stateController, _player));
        }
    }
}
