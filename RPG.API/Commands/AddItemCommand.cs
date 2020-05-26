using System;
using System.ComponentModel.DataAnnotations;
using MediatR;
using RPG.API.Model;

namespace RPG.API.Commands
{
    public class AddItemCommand : IRequest
    {
        [Required(AllowEmptyStrings = false)]
        [StringLength(30)]
        public string Name { get; set; }
        public string FlavorText { get; set; }
        [Range(0, 9999)]
        public int Value { get; set; }
        [Range(0, 999)]
        public int Weight { get; set; }
        [Range(0, 999)]
        public int BonusStrength { get; set; }
        [Range(0, 999)]
        public int BonusDexterity { get; set; }
        [Range(0, 999)]
        public int BonusIntelligence { get; set; }
        public ItemTypes Type { get; set; }
    }
}
