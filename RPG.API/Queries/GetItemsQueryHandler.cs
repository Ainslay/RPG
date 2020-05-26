using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RPG.API.Database;
using RPG.API.DTOs;

namespace RPG.API.Queries
{
    public class GetItemsQueryHandler : IRequestHandler<GetItemsQuery, ICollection<ItemDTO>>
    {
        private ApplicationDbContext _context;

        public GetItemsQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<ItemDTO>> Handle(GetItemsQuery query, CancellationToken cancellationToken)
        {
            var items = _context.Items.ToList();
            var itemsDTO = new List<ItemDTO>();

            foreach (var item in items)
            {
                itemsDTO.Add(new ItemDTO(item.Name, item.FlavorText, item.Value, item.Weight, item.BonusStrength, item.BonusDexterity, item.BonusIntelligence, item.Type));
            }

            return itemsDTO;
        }
    }
}
