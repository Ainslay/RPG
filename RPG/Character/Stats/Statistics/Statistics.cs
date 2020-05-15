using System.Collections.Generic;
using RPG.Items;

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

        public void RecalculateBaseStatistics(Attributes attributes, Equipment equipment)
        {
            _physicalAttack.RecalculateBaseValue(attributes.GetStrength(), equipment);
            _magicAttack.RecalculateBaseValue(attributes.GetIntelligence(), equipment);
            _iniciative.RecalculateBaseValue(attributes.GetDexterity(), equipment);
            _hitChance.RecalculateBaseValue(attributes.GetDexterity(), equipment);
            _resistances.RecalculateBaseResistances(attributes.GetIntelligence(), equipment);
        }

        public void RecalculateCurrentStatistics(Attributes attributes, Equipment equipment)
        {
            _physicalAttack.RecalculateCurrentValue(attributes.GetStrength(), equipment);
            _magicAttack.RecalculateCurrentValue(attributes.GetIntelligence(), equipment);
            _iniciative.RecalculateCurrentValue(attributes.GetDexterity(), equipment);
            _hitChance.RecalculateCurrentValue(attributes.GetDexterity(), equipment);
            _resistances.RecalculateCurrentResistances(attributes.GetIntelligence(), equipment);
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
