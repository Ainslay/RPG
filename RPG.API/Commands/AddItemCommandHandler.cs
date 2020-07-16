using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RPG.API.Database;
using RPG.API.Model;

namespace RPG.API.Commands
{
    class AddItemCommandHandler : IRequestHandler<AddItemCommand>
    {
        private ApplicationDbContext _context;

        public AddItemCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(AddItemCommand command, CancellationToken cancellationToken)
        {
            var item = new Item(command.Name, command.FlavorText, command.Strength, command.Dexterity, command.Intelligence, command.Type);
            
            _context.Add(item);
            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
