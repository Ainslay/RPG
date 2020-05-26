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

        public async Task<Unit> Handle(AddItemCommand request, CancellationToken cancellationToken)
        {
            var item = new Item(request.Name, request.FlavorText, request.Value, request.Weight, request.BonusStrength, request.BonusDexterity, request.BonusIntelligence, request.Type);
            
            _context.Add(item);
            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
