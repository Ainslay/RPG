using RPG.Character.Enemies.Tools;
using System;

namespace RPG.Character.Enemies
{
    static class RandomEnemyFactory
    {
        // Na pewno widzę wadę z rozszerzalnością, dodanie nowego potwora wiąże się
        // z dodaniem wpisu w enumie, dodaniem odpowiedniej klasy i dodaniem 
        // case'a w fabryce.
        public static Enemy Create(int playerLevel, IStatMultiplier statMultiplier)
        {
            var enemyCount = Enum.GetNames(typeof(Enemies)).Length;
            var threatLevelCount = Enum.GetNames(typeof(ThreatLevels)).Length;

            var randomGenerator = new Random();

            // Okropnie brzydkie, nie wiem czy tędy droga
            var randomEnemy = (Enemies) Enum.Parse(typeof(Enemies), Enum.GetName(typeof(Enemies), randomGenerator.Next(1, enemyCount)));
            var randomThreatLevel = (ThreatLevels) Enum.Parse(typeof(ThreatLevels), Enum.GetName(typeof(ThreatLevels), randomGenerator.Next(1, threatLevelCount)));

            var multiplier = statMultiplier.Calculate(playerLevel, randomThreatLevel);

            switch (randomEnemy)
            {
                case Enemies.Goblin:
                    return new Goblin(multiplier, randomThreatLevel);
                case Enemies.UndeadMage:
                    return new UndeadMage(multiplier, randomThreatLevel);
                case Enemies.Slime:
                    return new Slime(multiplier, randomThreatLevel);
                default:
                    throw new ArgumentException("Could not create enemy object. Invalid enemy type.");
            }
        }
    }
}
