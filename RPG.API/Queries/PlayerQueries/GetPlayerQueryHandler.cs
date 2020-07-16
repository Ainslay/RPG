using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RPG.API.Database;
using RPG.API.DTOs;

namespace RPG.API.Queries.PlayerQueries
{
    public class GetPlayerQueryHandler : IRequestHandler<GetPlayerQuery, PlayerDTO>
    {
        private ApplicationDbContext _context;

        public GetPlayerQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PlayerDTO> Handle(GetPlayerQuery query, CancellationToken cancellationToken)
        {
            var player = await _context.Players.SingleAsync(player => player.PlayerId == query.PlayerId);

            return new PlayerDTO(player.Name, player.Proffesion, player.Level, player.Experience, 
                player.Strength, player.Dexterity, player.Intelligence);
        }
    }
}
