using System.ComponentModel.DataAnnotations;
using MediatR;

namespace RPG.API.Commands
{
    public class DeleteItemCommand : IRequest
    {
        [Required][Range(0, int.MaxValue)]
        public int Id { get; set; }
    }
}
