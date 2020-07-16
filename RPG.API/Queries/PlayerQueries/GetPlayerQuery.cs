using System;
using System.ComponentModel.DataAnnotations;
using MediatR;
using RPG.API.DTOs;

namespace RPG.API.Queries.PlayerQueries
{
    public class GetPlayerQuery : IRequest<PlayerDTO>
    {
        [Required]
        [Range(0, int.MaxValue)]
        public Guid PlayerId { get; set; }
    }
}
