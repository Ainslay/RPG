using RPG.Character;
using RPG.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Combat
{
    class BattleInterface
    {
        private readonly BaseCharacter _player;
        private readonly BaseCharacter _enemy;

        public BattleInterface(BaseCharacter player, BaseCharacter enemy)
        {
            ParamCheck.IsNull(player);
            ParamCheck.IsNull(enemy);

            _player = player;
            _enemy = enemy;
        }

        public void PrintStatuses()
        {
            _player.PrintStatus();
            _enemy.PrintStatus();
        }
    }
}
