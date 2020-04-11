﻿using System;

using RPG.Character.Stats;
using RPG.Utilities;

namespace RPG.Character.Enemies
{
    static class EnemyFactory
    {
        public static Enemy Create(Level playerLevel, Enemies enemyType, ThreatLevels threatLevel)
        {
            ParamCheck.IsNull(playerLevel);

            var statMultiplier = playerLevel.Value + (int)threatLevel;

            Enemy enemy;

            switch (enemyType)
            {
                case Enemies.Goblin:
                    enemy = new Goblin(statMultiplier, threatLevel);
                    break;
                case Enemies.UndeadMage:
                    enemy = new UndeadMage(statMultiplier, threatLevel);
                    break;
                case Enemies.Slime:
                    enemy = new Slime(statMultiplier, threatLevel);
                    break;
                default:
                    throw new ArgumentException("Could not create enemy object. Invalid enemy type.");
            }

            return enemy;
        }
    }
}
