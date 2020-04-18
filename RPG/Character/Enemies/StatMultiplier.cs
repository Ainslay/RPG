using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Character.Enemies
{
    class StatMultiplier : IStatMultiplier
    {
        public int Calculate(int playerLevel, ThreatLevels threatLevel)
        {
            return playerLevel + (int)threatLevel;
        }
    }
}
