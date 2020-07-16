using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RPG.API.Database;
using RPG.API.Model;

namespace RPG.API.Commands.ItemCommands
{
    class AddItemCommandHandler : IRequestHandler<AddItemCommand, Guid>
    {
        private ApplicationDbContext _context;

        public AddItemCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(AddItemCommand command, CancellationToken cancellationToken)
        {
            var item = new Item(command.Name, command.FlavorText, command.Strength, command.Dexterity, command.Intelligence, command.Type);

            _context.Add(item);
            await _context.SaveChangesAsync();

            return item.ItemId;
        }
    }
}
