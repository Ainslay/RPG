using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RPG.API.Database;

namespace RPG.API.Commands.PlayerItemCommands
{
    public class DeletePlayerItemCommandHandler : IRequestHandler<DeletePlayerItemCommand>
    {
        private ApplicationDbContext _context;

        public DeletePlayerItemCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeletePlayerItemCommand command, CancellationToken cancellationToken)
        {
            var itemToBeRemoved = _context.PlayerItems.SingleOrDefault(i => i.PlayerItemId == command.PlayerItemGuid);
            
            if(itemToBeRemoved != null)
            {
                _context.PlayerItems.Remove(itemToBeRemoved);
                await _context.SaveChangesAsync();
            }

            return Unit.Value;
        }
    }
}
