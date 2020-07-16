using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RPG.API.Database;
using RPG.API.Model;

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
            var player = new Player(command.Name, command.Proffesion, command.Level,
                command.Experience, command.Strength, command.Dexterity, command.Intelligence)
            {
                Id = command.Id,
                PlayerId = command.PlayerId
            };

            _context.Players.Update(player);
            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
