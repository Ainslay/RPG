using System;

using RPG.Character;
using RPG.Combat.Battles;
using RPG.Utilities;

namespace RPG.Actions
{
    class PlayerActionHandler
    {
        private readonly BattleInfo _battleInfo;

        public PlayerActionHandler(BattleInfo battleInfo)
        {
            ParamCheck.IsNull(battleInfo);
            _battleInfo = battleInfo;
        }

        public void ExecuteAction(BasicAction action)
        {
            switch (action)
            {
                case BasicAction.BasicAttack:
                    new BasicAttack(_battleInfo.GetPlayer(), _battleInfo.GetEnemy()).Execute();
                    break;
                case BasicAction.Flee:
                    new Flee(_battleInfo.GetBattle()).Execute();
                    break;
                default:
                    throw new ArgumentException("Invalid action.");
            }
        }
    }
}
