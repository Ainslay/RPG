namespace RPG.Character.Enemies.Tools
{
    interface IStatMultiplier
    {
        public int Calculate(int playerLevel, ThreatLevels threatLevel);
    }
}
