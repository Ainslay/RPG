using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RPG.API.Database;

using RPG.API.Model;
namespace RPG.API.Commands.PlayerCommands
{
    public class AddPlayerCommandHandler : IRequestHandler<AddPlayerCommand>
    {
        private ApplicationDbContext _context;

        public AddPlayerCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(AddPlayerCommand command, CancellationToken cancellationToken)
        {
            var player = new Player(command.Name, command.Proffesion, command.Level, 
                command.Experience, command.Strength, command.Dexterity, command.Intelligence);

            _context.Players.Add(player);
            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
