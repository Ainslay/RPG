using System;
using System.ComponentModel.DataAnnotations;
using MediatR;
using RPG.API.DTOs;

namespace RPG.API.Queries.ItemQueries
{
    public class GetItemQuery : IRequest<ItemDTO>
    {
        [Required]
        public Guid ItemId { get; set; }
    }
}
