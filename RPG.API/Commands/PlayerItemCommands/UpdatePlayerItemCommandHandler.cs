using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RPG.API.Database;

namespace RPG.API.Commands.PlayerItemCommands
{
    public class UpdatePlayerItemCommandHandler : IRequestHandler<UpdatePlayerItemCommand>
    {
        private ApplicationDbContext _context;

        public UpdatePlayerItemCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdatePlayerItemCommand command, CancellationToken cancellationToken)
        {
            var item = _context.PlayerItems.SingleOrDefault(i => i.PlayerItemId == command.PlayerItemGuid);

            if (item != null)
            {
                item.IsEquipped = command.IsEquipped;
                _context.Attach(item);
                _context.Entry(item).Property("IsEquipped").IsModified = true;
                await _context.SaveChangesAsync();
            }

            return Unit.Value;
        }
    }
}
