using System.ComponentModel.DataAnnotations;
using MediatR;
using RPG.API.DTOs;

namespace RPG.API.Queries
{
    public class GetItemQuery : IRequest<ItemDTO>
    {
        [Required][Range(0, int.MaxValue)]
        public int Id { get; set; }
    }
}
