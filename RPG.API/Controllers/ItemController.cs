using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MediatR;
using RPG.API.Commands.ItemCommands;
using RPG.API.Queries.ItemQueries;

namespace RPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
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

        [HttpPut]
        public async Task<IActionResult> UpdateItem(UpdateItemCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteItem(DeleteItemCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetItem([FromQuery]GetItemQuery query)
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

    }
}
