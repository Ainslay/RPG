namespace RPG.Character.Enemies.Tools
{
    class StatMultiplier : IStatMultiplier
    {
        public int Calculate(int playerLevel, ThreatLevels threatLevel)
        {
            return playerLevel + (int)threatLevel;
        }
    }
}
