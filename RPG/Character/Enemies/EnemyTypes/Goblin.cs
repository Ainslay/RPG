using RPG.Character.Resources;
using RPG.Character.Stats;

namespace RPG.Character.Enemies
{
    class Goblin : Enemy
    {
        public Goblin(int statMultiplier, ThreatLevels threatLevel)
        {
            ThreatLevel = threatLevel;
            Name = Enemies.Goblin.ToString();
            Attributes = new Attributes(3 * statMultiplier, 4 * statMultiplier, 2 * statMultiplier);
            Health = new Health(Attributes.GetStrength());
            Statistics = new Statistics(Attributes);
            Resource = new Rage(CharacterResources.Rage, 100, 20);
        }
    }
}
