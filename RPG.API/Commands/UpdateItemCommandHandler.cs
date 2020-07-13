﻿using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RPG.API.Database;
using RPG.API.Model;

namespace RPG.API.Commands
{
    public class UpdateItemCommandHandler : IRequestHandler<UpdateItemCommand>
    {
        private ApplicationDbContext _context;

        public UpdateItemCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateItemCommand command, CancellationToken cancellationToken)
        {
            var item = new Item(command.Name, command.FlavorText, command.Value, command.Weight, command.BonusStrength, command.BonusDexterity, command.BonusIntelligence, command.Type);
            item.Id = command.Id;

            _context.Update(item);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}