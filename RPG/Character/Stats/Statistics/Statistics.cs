namespace RPG.Character.Stats
{
    class Statistics : IRestorable
    {
        private Resistances _resistances;
        private AttackStrength _attackStrength;
        private Iniciative _iniciative;
        private HitChance _hitChance;

        public Statistics(Attributes attributes)
        {
            _resistances = new Resistances(attributes.GetIntelligence());
            _attackStrength = new AttackStrength(attributes.GetStrength(), attributes.GetIntelligence());
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
            return _attackStrength.GetPhysicalAttack();
        }

        public int GetMagicAttack()
        {
            return _attackStrength.GetMagicAttack();
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
            _resistances.RestoreBaseValue();
            _iniciative.RestoreBaseValue();
            _hitChance.RestoreBaseValue();

            // TODO: restore base attack strength
        }
    }
}
