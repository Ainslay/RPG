using RPG.Character.Resources;
using RPG.Character.Stats;

namespace RPG.Character.Proffesions
{
    class Mage : Proffesion
    {
        public Mage()
        {
            Name = PlayerProffesions.Mage.ToString();
            Resource = new Mana(CharacterResources.Mana, 100);
            BaseAttributes = new Attributes(3, 5, 11);
        }
    }
}
