using RPG.Character.Proffesions;
using RPG.Character.Stats;
using RPG.Utilities;

namespace RPG.Character.Player
{
    // Tutaj przekazywanie tej profesji trochę mi nie pasi, w tym sensie że
    // mam PlayerFactory, które ładnie mi tworzy na podstawie enuma, a tutaj
    // umożliwiam przesłanie jakiejś profesji.

    class Player : BaseCharacter
    {
        public readonly string Name;
        public Proffesion Proffesion { get; private set; }
        public Level Level { get; private set; }
        public Player(string name, Proffesion proffesion)
        {
            ParamCheck.IsNullOrWhitespace(name);
            ParamCheck.IsNull(proffesion);

            Name = name;
            Proffesion = proffesion;
            Resource = proffesion.Resource;
            Attributes = proffesion.BaseAttributes;
            Level = new Level();
        }
    }
}
