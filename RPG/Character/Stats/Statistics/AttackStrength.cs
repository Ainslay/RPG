using RPG.Utilities;

namespace RPG.Character.Stats
{
    class AttackStrength
    {
        private int _physical;
        private int _magic; 

        public AttackStrength(Strength strength, Intelligence intelligence)
        {
            ParamCheck.IsNull(strength);
            ParamCheck.IsNull(intelligence);

            _physical = strength.GetBaseValue();
            _magic = intelligence.GetBaseValue();
        }

        public int GetPhysicalAttack()
        {
            return _physical;
        }

        public int GetMagicAttack()
        {
            return _magic;
        }
    }
}
