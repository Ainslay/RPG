using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RPG.API.Database;
using RPG.API.Model;

namespace RPG.API.Commands.ItemCommands
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
            var item = _context.Items.SingleOrDefault(item => item.ItemId == command.ItemId);

            if(item != null)
            {
                item.Name = command.Name;
                item.FlavorText = command.FlavorText;
                item.Type = command.Type;
                item.Strength = command.Strength;
                item.Dexterity = command.Dexterity;
                item.Intelligence = command.Intelligence;

                _context.Update(item);
                await _context.SaveChangesAsync();
            }
            
            return Unit.Value;
        }
    }
}
