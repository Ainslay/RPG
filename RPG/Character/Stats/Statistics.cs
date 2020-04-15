namespace RPG.Character.Stats
{
    class Statistics
    {
        public Resistances Resistances { get; set; }
        public AttackStrength AttackStrength { get; set; }
        public Iniciative Iniciative { get; set; }
        public HitChance HitChance { get; set; }

        public Statistics(Attributes attributes)
        {
            Resistances = new Resistances(attributes.GetIntelligence());
            AttackStrength = new AttackStrength(attributes.GetStrength(), attributes.GetIntelligence());
            Iniciative = new Iniciative(attributes.GetDexterity());
            HitChance = new HitChance(attributes.GetDexterity());
        }
    }
}
