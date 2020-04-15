using RPG.Character.Resources;
using RPG.Character.Stats;

namespace RPG.Character.Enemies
{
    class Slime : Enemy
    {
        public Slime(int statMultiplier, ThreatLevels threatLevel)
        {
            _threatLevel = threatLevel;

            Name = Enemies.Slime.ToString();
            Attributes = new Attributes(3 * statMultiplier, 3 * statMultiplier, 1 * statMultiplier);
            Health = new Health(Attributes.GetStrength());
            Statistics = new Statistics(Attributes);
            Resource = new Will(CharacterResources.Will, 50);
        }
    }
}
