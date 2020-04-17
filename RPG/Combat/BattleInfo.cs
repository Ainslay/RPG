using RPG.Character;
using RPG.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Combat
{
    class BattleInfo
    {
        private readonly Battle _battle;
        private readonly BaseCharacter _player;
        private readonly BaseCharacter _enemy;

        public BattleInfo(Battle battle)
        {
            ParamCheck.IsNull(battle);

            _battle = battle;
            _player = battle.GetPlayer();
            _enemy = battle.GetEnemy();
        }

        public Battle GetBattle()
        {
            return _battle;
        }

        public BaseCharacter GetPlayer()
        {
            return _player;
        }

        public BaseCharacter GetEnemy()
        {
            return _enemy;
        }
    }
}
