using System;
using System.ComponentModel.DataAnnotations;
using MediatR;

namespace RPG.API.Commands.ItemCommands
{
    public class DeleteItemCommand : IRequest
    {
        [Required]
        public Guid ItemId { get; set; }
    }
}
