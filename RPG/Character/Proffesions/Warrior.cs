using RPG.Character.Resources;
using RPG.Character.Stats;

namespace RPG.Character.Proffesions
{
    class Warrior : Proffesion
    {
        public Warrior()
        {
            Name = PlayerProffesions.Warrior.ToString();
            Resource = new Rage(CharacterResources.Rage, 100, 25);
            BaseAttributes = new Attributes(10, 6, 4);
        }
    }
}
