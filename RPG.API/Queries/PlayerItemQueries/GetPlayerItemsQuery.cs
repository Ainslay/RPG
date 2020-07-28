using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MediatR;
using RPG.API.DTOs;

namespace RPG.API.Queries.PlayerItemQueries
{
    public class GetPlayerItemsQuery : IRequest<ICollection<PlayerItemDTO>>
    {
        [Required]
        public Guid PlayerGuid { get; set; }
    }
}
