using System.ComponentModel.DataAnnotations;

namespace RPG.API.Model
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        public string Proffesion { get; set; }
        [Required]
        [Range(0.0, 100.0)]
        public int Health { get; set; }
        public int Resource { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Level { get; set; }
    }
}
