using System.Collections.Generic;
using System.Linq;
using MediatR;
using RPG.API.Database;
using RPG.API.DTOs;

namespace RPG.API.Queries.ItemQueries
{
    public class GetItemsQueryHandler : RequestHandler<GetItemsQuery, ICollection<ItemDTO>>
    {
        private ApplicationDbContext _context;

        public GetItemsQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override ICollection<ItemDTO> Handle(GetItemsQuery request)
        {
            var items = _context.Items.ToList();
            var itemsDTO = new List<ItemDTO>();

            foreach (var item in items)
            {
                itemsDTO.Add(new ItemDTO(item.Name, item.FlavorText, item.Strength, item.Dexterity, item.Intelligence, item.Type));
            }

            return itemsDTO;
        }
    }
}
