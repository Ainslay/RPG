using System;
using System.ComponentModel.DataAnnotations;
using MediatR;
using RPG.API.Model;

namespace RPG.API.Commands
{
    public class UpdateItemCommand : IRequest
    {
        [Required][Range(0, int.MaxValue)]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)][StringLength(30)]
        public string Name { get; set; }
        public string FlavorText { get; set; }
        public int Strength { get; set; }
        [Range(0, 999)]
        public int Dexterity { get; set; }
        [Range(0, 999)]
        public int Intelligence { get; set; }
        public ItemTypes Type { get; set; }
    }
}
