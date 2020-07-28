using System;
using System.ComponentModel.DataAnnotations;
using MediatR;

namespace RPG.API.Commands.PlayerItemCommands
{
    public class AddPlayerItemCommand : IRequest<Guid>
    {
        [Required]
        public Guid PlayerGuid { get; set; }
        [Required]
        public Guid ItemGuid { get; set; }
        [Required]
        public bool IsEquipped { get; set; }
    }
}
