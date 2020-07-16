using System;
using System.ComponentModel.DataAnnotations;
using MediatR;

namespace RPG.API.Commands.PlayerCommands
{
    public class DeletePlayerCommand : IRequest
    {
        [Required]
        public Guid PlayerId { get; set; }
    }
}
