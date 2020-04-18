using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Character.Enemies
{
    interface IStatMultiplier
    {
        public int Calculate(int playerLevel, ThreatLevels threatLevel);
    }
}
