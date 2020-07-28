using System.Collections.Generic;
using System.Linq;
using MediatR;
using RPG.API.Database;
using RPG.API.DTOs;

namespace RPG.API.Queries.PlayerItemQueries
{
    public class GetPlayerItemsQueryHandler : RequestHandler<GetPlayerItemsQuery, ICollection<PlayerItemDTO>>
    {
        private ApplicationDbContext _context;

        public GetPlayerItemsQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }
    
        protected override ICollection<PlayerItemDTO> Handle(GetPlayerItemsQuery query)
        {
            var items = _context.PlayerItems.Where(i => i.PlayerGuid == query.PlayerGuid).Select(i => new PlayerItemDTO(i.ItemGuid, i.IsEquipped)).ToList();

            return items;
        }
    }
}
