using RPG.Character.Resources;
using RPG.Character.Stats;

namespace RPG.Character.Proffesions
{
    abstract class Proffesion
    {
        public string Name { get; protected set; }
        public Resource Resource { get; protected set; }
        public Attributes BaseAttributes { get; protected set; }
    }
}
