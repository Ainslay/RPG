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

            _physical = strength.GetValue();
            _magic = intelligence.GetValue();
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
