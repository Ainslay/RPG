using RPG.Utilities;

namespace RPG.Character.Stats
{
    class Resistances
    {
        public PhysicalResistance PhysicalResistance { get; private set; }
        public MagicResistance MagicResistance { get; private set; }

        public Resistances(Intelligence intelligence)
        {
            ParamCheck.IsNull(intelligence);

            PhysicalResistance = new PhysicalResistance(intelligence);
            MagicResistance = new MagicResistance(intelligence);
        }
    }
}
