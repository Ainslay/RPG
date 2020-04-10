using RPG.Character.Resources;
using RPG.Character.Stats;

namespace RPG.Character
{
    abstract class BaseCharacter
    {
        public Health Health { get; protected set; }
        public Resource Resource { get; protected set; }
        protected Attributes Attributes;
        public Statistics Statistics;
        public bool IsAlive { get; set; }
        
        public BaseCharacter()
        {
            IsAlive = true;
        }

        public void RecalculateStats()
        {
            if(Health.CurrentValue == 0)
            {
                IsAlive = false;
            }
        }
    }
}
