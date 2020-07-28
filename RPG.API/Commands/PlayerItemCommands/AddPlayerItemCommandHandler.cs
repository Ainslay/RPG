using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using MediatR;
using RPG.API.Database;
using RPG.API.Model;

namespace RPG.API.Commands.PlayerItemCommands
{
    public class AddPlayerItemCommandHandler : IRequestHandler<AddPlayerItemCommand, Guid>
    {
        private ApplicationDbContext _context;

        public AddPlayerItemCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(AddPlayerItemCommand command, CancellationToken cancellationToken)
        {
            var playerId = _context.Players.Single(p => p.PlayerId == command.PlayerGuid).Id;
            var itemId = _context.Items.Single(p => p.ItemId == command.ItemGuid).Id;
            var playerItem = new PlayerItem(playerId, itemId, command.IsEquipped, command.PlayerGuid, command.ItemGuid);
          
            _context.PlayerItems.Add(playerItem);
            await _context.SaveChangesAsync();

            return playerItem.PlayerItemId;
        }
    }
}
