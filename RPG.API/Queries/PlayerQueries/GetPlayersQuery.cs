using System.Collections.Generic;
using MediatR;
using RPG.API.DTOs;

namespace RPG.API.Queries.PlayerQueries
{
    public class GetPlayersQuery : IRequest<ICollection<PlayerDTO>>
    { }
}
