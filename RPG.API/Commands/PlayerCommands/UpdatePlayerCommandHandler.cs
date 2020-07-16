using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RPG.API.Database;

namespace RPG.API.Commands.PlayerCommands
{
    public class UpdatePlayerCommandHandler : IRequestHandler<UpdatePlayerCommand>
    {
        private ApplicationDbContext _context;

        public UpdatePlayerCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdatePlayerCommand command, CancellationToken cancellationToken)
        {
            var player = _context.Players.SingleOrDefault(player => player.PlayerId == command.PlayerId);

            if(player != null)
            {
                player.Name = command.Name;
                player.Proffesion = command.Proffesion;
                player.Level = command.Level;
                player.Experience = command.Experience;
                player.Strength = command.Strength;
                player.Dexterity = command.Dexterity;
                player.Intelligence = command.Intelligence;
    
                _context.Players.Update(player);
                await _context.SaveChangesAsync();
            }

            return Unit.Value;
        }
    }
}
