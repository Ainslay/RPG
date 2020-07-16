using System.Collections.Generic;
using System.Linq;
using MediatR;
using RPG.API.Database;
using RPG.API.DTOs;

namespace RPG.API.Queries.PlayerQueries
{
    public class GetPlayersQueryHandler : RequestHandler<GetPlayersQuery, ICollection<PlayerDTO>>
    {
        private ApplicationDbContext _context;

        public GetPlayersQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override ICollection<PlayerDTO> Handle(GetPlayersQuery request)
        {
            var players = _context.Players.ToList();
            var playersDTO = new List<PlayerDTO>();

            foreach (var player in players)
            {
                playersDTO.Add(new PlayerDTO(player.Name, player.Proffesion, player.Level, player.Experience,
                player.Strength, player.Dexterity, player.Intelligence));
            }

            return playersDTO;
        }
    }
}
