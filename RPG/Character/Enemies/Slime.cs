using RPG.Character.Resources;
using RPG.Character.Stats;

namespace RPG.Character.Enemies
{
    class Slime : Enemy
    {
        public Slime(int statMultiplier, ThreatLevels threatLevel)
        {
            ThreatLevel = threatLevel;

            Name = Enemies.Slime.ToString();
            Attributes = new Attributes(3 * statMultiplier, 3 * statMultiplier, 1 * statMultiplier);
            Resource = new Will(CharacterResources.Will, 50);
        }
    }
}
