using RPG.Utilities;

namespace RPG.Character.Stats
{
    class AttackStrength
    {
        public int Physical { get; private set; }
        public int Magic { get; private set; }

        public AttackStrength(Strength strength, Intelligence intelligence)
        {
            ParamCheck.IsNull(strength);
            ParamCheck.IsNull(intelligence);

            Physical = strength.Value;
            Magic = intelligence.Value;
        }
    }
}
