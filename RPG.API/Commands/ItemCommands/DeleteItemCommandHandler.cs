﻿using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RPG.API.Database;

namespace RPG.API.Commands.ItemCommands
{
    public class DeleteItemCommandHandler : IRequestHandler<DeleteItemCommand>
    {
        private ApplicationDbContext _context;

        public DeleteItemCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteItemCommand command, CancellationToken cancellationToken)
        {
            var itemToBeRemoved = _context.Items.SingleOrDefault(item => item.ItemId == command.ItemId);

            if (itemToBeRemoved != null)
            {
                _context.Remove(itemToBeRemoved);
                await _context.SaveChangesAsync();
            }

            return Unit.Value;
        }
    }
}
