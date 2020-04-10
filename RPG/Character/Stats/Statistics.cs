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
            Resistances = new Resistances(attributes.Intelligence);
            AttackStrength = new AttackStrength(attributes.Strength, attributes.Intelligence);
            Iniciative = new Iniciative(attributes.Dexterity);
            HitChance = new HitChance(attributes.Dexterity);
        }
    }
}
