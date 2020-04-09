namespace RPG.Character.Enemies
{
    // Możliwe, że w przyszłości coś tu dołożę (np. listę ruchów), ale chodzi 
    // mi o "obudowanie" potworów jako Enemy, no i wszystkie dzielą ThreatLevel
    abstract class Enemy : BaseCharacter
    {
        public string Name { get; protected set; }
        public ThreatLevels ThreatLevel { get; protected set; }
    }
}
