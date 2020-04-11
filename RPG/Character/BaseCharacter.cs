using RPG.Character.Resources;
using RPG.Character.Stats;

namespace RPG.Character
{
    abstract class BaseCharacter
    {
        protected Health Health { get; set; }
        protected Resource Resource { get; set; }
        protected Attributes Attributes;
        public Statistics Statistics;
        private bool _isAlive { get; set; }
        
        public BaseCharacter()
        {
            _isAlive = true;
        }

        // Na bank stąd wyleci
        public void Attack(BaseCharacter target)
        {
            var damage = Statistics.AttackStrength.Physical;
            target.TakeDamage(damage);
            CheckIsAlive();
        }

        protected void TakeDamage(int amount)
        {
            Health.SubstractHealth(amount);
        }

        protected void CheckIsAlive()
        {
            if(Health.CurrentValue == 0)
            {
                _isAlive = false;
            }
        }

        public int GetCurrentIniciative()
        {
            return Statistics.Iniciative.CurrentValue;
        }

        public bool IsAlive()
        {
            return _isAlive;
        }
    }
}
