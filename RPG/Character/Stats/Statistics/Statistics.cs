using System.Collections.Generic;

namespace RPG.Character.Stats
{
    class Statistics : IRestorable
    {
        private PhysicalAttack _physicalAttack;
        private MagicAttack _magicAttack;
        private Resistances _resistances;
        private Iniciative _iniciative;
        private HitChance _hitChance;

        public Statistics(Attributes attributes)
        {
            _physicalAttack = new PhysicalAttack(attributes.GetStrength());
            _magicAttack = new MagicAttack(attributes.GetIntelligence());
            _resistances = new Resistances(attributes.GetIntelligence());
            _iniciative = new Iniciative(attributes.GetDexterity());
            _hitChance = new HitChance(attributes.GetDexterity());
        }

        public int GetCurrentPhysicalResistance()
        {
            return _resistances.GetPhysicalResistanceCurrentValue();
        }

        public int GetCurrentMagicResistance()
        {
            return _resistances.GetMagicResistanceCurrentValue();
        }
        public int GetPhysicalAttack()
        {
            return _physicalAttack.GetCurrentValue();
        }

        public int GetMagicAttack()
        {
            return _magicAttack.GetCurrentValue();
        }

        public int GetCurrentIniciative()
        {
            return _iniciative.GetCurrentValue();
        }

        public int GetCurrentHitChance()
        {
            return _hitChance.GetCurrentValue();
        }

        public void RestoreBaseValue()
        {
            var restorableStats = new List<IRestorable> { _physicalAttack, _magicAttack, _hitChance, _resistances, _iniciative };
            restorableStats.ForEach(stat => stat.RestoreBaseValue());
        }
    }
}
