using System;

using RPG.Character;
using RPG.Combat;
using RPG.Utilities;

namespace RPG.Actions
{
    class ActionHandler
    {
        private readonly BaseCharacter _player;
        private readonly BaseCharacter _enemy;
        private readonly Battle _battle;

        public ActionHandler(Battle battle, BaseCharacter player, BaseCharacter enemy)
        {
            ParamCheck.IsNull(battle);
            ParamCheck.IsNull(player);
            ParamCheck.IsNull(enemy);

            _battle = battle;
            _player = player;
            _enemy = enemy;
        }

        public bool ExecuteAction(BasicAction action)
        {
            switch (action)
            {
                case BasicAction.BasicAttack:
                    new BasicAttack(_player, _enemy).Execute();
                    break;
                case BasicAction.Flee:
                    new Flee(_battle).Execute();
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    return false;
            }
            return true;
        }
    }
}
