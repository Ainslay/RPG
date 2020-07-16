using System.Collections.Generic;
using MediatR;
using RPG.API.DTOs;

namespace RPG.API.Queries.ItemQueries
{
    public class GetItemsQuery : IRequest<ICollection<ItemDTO>>
    { }
}
