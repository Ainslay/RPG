using System;
using System.ComponentModel.DataAnnotations;
using MediatR;

namespace RPG.API.Commands.PlayerItemCommands
{
    public class DeletePlayerItemCommand : IRequest
    {
        [Required]
        public Guid PlayerItemGuid { get; set; }
    }
}
