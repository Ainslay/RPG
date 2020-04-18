using System;

using RPG.Character.Enemies.Tools;
using RPG.Utilities;

namespace RPG.Character.Enemies
{
    static class EnemyFactory
    {
        public static Enemy Create(int playerLevel, Enemies enemyType, ThreatLevels threatLevel, IStatMultiplier statMultiplier)
        {
            ParamCheck.IsNull(statMultiplier);

            var multiplier = statMultiplier.Calculate(playerLevel, threatLevel);

            switch (enemyType)
            {
                case Enemies.Goblin:
                    return new Goblin(multiplier, threatLevel);
                case Enemies.UndeadMage:
                    return new UndeadMage(multiplier, threatLevel);
                case Enemies.Slime:
                    return new Slime(multiplier, threatLevel);
                default:
                    throw new ArgumentException("Could not create enemy object. Invalid enemy type.");
            }
        }
    }
}
