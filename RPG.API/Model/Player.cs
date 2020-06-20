using System.Collections.Generic;

namespace RPG.API.Model
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Proffesion { get; set; }
        public int Health { get; set; }
        public int Resource { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Level { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
