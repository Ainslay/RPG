using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RPG.API.Database;

namespace RPG.API.Commands.PlayerCommands
{
    public class DeletePlayerCommandHandler : IRequestHandler<DeletePlayerCommand>
    {
        private ApplicationDbContext _context;

        public DeletePlayerCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeletePlayerCommand command, CancellationToken cancellationToken)
        {
            var playerToRemove = _context.Players.SingleOrDefault(player => player.PlayerId == command.PlayerId);

            if(playerToRemove != null)
            {
                _context.Players.Remove(playerToRemove);
                await _context.SaveChangesAsync();
            }

            return Unit.Value;
        }
    }
}
