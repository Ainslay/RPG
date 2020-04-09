using RPG.Character.Stats;
using RPG.Utilities;
using System;

namespace RPG.Character.Enemies
{
    static class EnemyFactory
    {
        // Na pewno widzę wadę z rozszerzalnością, dodanie nowego potwora wiąże się
        // z dodaniem wpisu w enumie, dodaniem odpowiedniej klasy i dodaniem 
        // case'a w fabryce.
        public static Enemy Create(Level playerLevel)
        {
            ParamCheck.IsNull(playerLevel);

            var enemyCount = Enum.GetNames(typeof(Enemies)).Length;
            var threatLevelCount = Enum.GetNames(typeof(ThreatLevels)).Length;

            var randomGenerator = new Random();

            // Okropnie brzydkie, nie wiem czy tędy droga
            var randomEnemy = (Enemies) Enum.Parse(typeof(Enemies), Enum.GetName(typeof(Enemies), randomGenerator.Next(1, enemyCount)));
            var randomThreatLevel = (ThreatLevels) Enum.Parse(typeof(ThreatLevels), Enum.GetName(typeof(ThreatLevels), randomGenerator.Next(1, threatLevelCount)));

            var statMultiplier = playerLevel.Value + (int)randomThreatLevel;

            Enemy enemy;

            switch (randomEnemy)
            {
                case Enemies.Goblin:
                    enemy = new Goblin(statMultiplier, randomThreatLevel);
                    break;
                case Enemies.UndeadMage:
                    enemy = new UndeadMage(statMultiplier, randomThreatLevel);
                    break;
                case Enemies.Slime:
                    enemy = new Slime(statMultiplier, randomThreatLevel);
                    break;
                default:
                    throw new ArgumentException("Could not create enemy object. Invalid enemy type.");
            }

            return enemy;
        }
    }
}
