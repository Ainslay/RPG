using RPG.Character.Resources;
using RPG.Character.Stats;

namespace RPG.Character.Proffesions
{
    class Monk : Proffesion
    {
        public Monk()
        {
            Name = PlayerProffesions.Monk.ToString();
            Resource = new Will(CharacterResources.Will, 100);
            BaseAttributes = new Attributes(8, 8, 5);
        }
    }
}
