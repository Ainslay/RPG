using RPG.Character.Resources;
using RPG.Character.Stats;

namespace RPG.Character
{
    abstract class BaseCharacter
    {
        public Health Health { get; protected set; }
        public Resource Resource { get; protected set; }
        protected Attributes Attributes;
        protected Statistics Statistics;
        public bool IsAlive { get; set; }
        
        public BaseCharacter()
        {
            Statistics = new Statistics();
            IsAlive = true;
        }
    }
}
