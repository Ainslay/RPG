using RPG.Combat;
using RPG.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Actions
{
    class EnemyActionHandler
    {
        private readonly BattleInfo _battleInfo;

        public EnemyActionHandler(BattleInfo battleInfo)
        {
            ParamCheck.IsNull(battleInfo);
            _battleInfo = battleInfo;
        }

        public bool ExecuteAction(BasicAction action)
        {
            switch (action)
            {
                case BasicAction.BasicAttack:
                    new BasicAttack(_battleInfo.GetEnemy(), _battleInfo.GetPlayer()).Perform();
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    return false;
            }
            return true;
        }
    }
}
