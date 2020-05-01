using RPG.Utilities;

namespace RPG.Character.Stats
{
    class Resistances : IRestorable
    {
        public PhysicalResistance PhysicalResistance { get; private set; }
        public MagicResistance MagicResistance { get; private set; }

        public Resistances(Intelligence intelligence)
        {
            ParamCheck.IsNull(intelligence);

            PhysicalResistance = new PhysicalResistance(intelligence);
            MagicResistance = new MagicResistance(intelligence);
        }

        public int GetPhysicalResistanceCurrentValue()
        {
            return PhysicalResistance.GetCurrentValue();
        }

        public int GetMagicResistanceCurrentValue()
        {
            return MagicResistance.GetCurrentValue();
        }

        public void RestoreBaseValue()
        {
            PhysicalResistance.RestoreBaseValue();
            MagicResistance.RestoreBaseValue();
        }
    }
}
