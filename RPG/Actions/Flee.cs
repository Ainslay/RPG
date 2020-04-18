using RPG.Character.Enemies;
using RPG.Character.Player;
using RPG.Combat;
using RPG.Utilities;
using System;

namespace RPG.Actions
{
    class Flee : Action, IAction
    {
        private PlayerCharacter _player;
        private Enemy _enemy;
        private Battle _battle;

        public Flee(Battle battle)
        {
            ParamCheck.IsNull(battle);

            _battle = battle;
            _player = battle.GetPlayer();
            _enemy = battle.GetEnemy();
        }

        public void Perform()
        {
            IsAlreadyExecuted();

            if (_player.GetCurrentIniciative() > _enemy.GetCurrentIniciative())
            {
                _battle.SetFled();
                Console.WriteLine("You've managed to flee the scene, your enemies are no match for your swiftness.");
            }
            else
            {
                Console.WriteLine("You overestimated your speed, monsters easly caught up to you.");
            }
            _executed = true;
        }
    }
}
