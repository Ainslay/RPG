using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RPG.API.Commands;
using RPG.API.Database;
using RPG.API.Model;
using RPG.API.Queries;

namespace RPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private ApplicationDbContext _context;
        private IMediator _mediator;
        public ItemController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddItem(AddItemCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetItem([FromQuery][Required]GetItemQuery query)
        {
            var item = await _mediator.Send(query);
            return Ok(item);
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetItems()
        {
            var items = await _mediator.Send(new GetItemsQuery());
            return Ok(items);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateItem(UpdateItemCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteItem(int id)
        {
            if (id < 0)
            {
                return BadRequest("Given id was invalid");
            }

            var response = _context.Items.Where(item => item.Id == id);

            if (response.Any())
            {
                _context.Remove(response.First());
                _context.SaveChanges();

                return Ok();
            }

            return BadRequest("There is no item with given id");
        }
    }
}
