using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RPG.API.Database;
using RPG.API.DTOs;

namespace RPG.API.Queries
{
    public class GetItemQueryHandler : IRequestHandler<GetItemQuery, ItemDTO>
    {
        private ApplicationDbContext _context;

        public GetItemQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ItemDTO> Handle(GetItemQuery query, CancellationToken cancellationToken)
        {
            var item = await _context.Items.SingleAsync(item => item.Id == query.Id);

            return new ItemDTO(item.Name, item.FlavorText, item.Value, item.Weight, item.BonusStrength, item.BonusDexterity, item.BonusIntelligence, item.Type);
        }
    }
}
