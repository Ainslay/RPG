using RPG.Character.Resources;
using RPG.Character.Stats;

namespace RPG.Character.Enemies
{
    class UndeadMage : Enemy
    {
        public UndeadMage(int statMultiplier, ThreatLevels threatLevel)
        {
            // Tutaj chciałem unikać hardcodowania nazw, ale problem ze spacją w nazwie hmm
            _threatLevel = threatLevel;
            Name = Enemies.UndeadMage.ToString();
            Attributes = new Attributes(2 * statMultiplier, 2 * statMultiplier, 4 * statMultiplier);
            Health = new Health(Attributes.GetStrength());
            Statistics = new Statistics(Attributes);
            Resource = new Mana(CharacterResources.Mana, 100);
        }
    }
}
