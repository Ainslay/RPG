using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RPG.API.Commands.PlayerItemCommands;
using RPG.API.Queries.PlayerItemQueries;

namespace RPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerItemController : ControllerBase
    {
        private IMediator _mediator;

        public PlayerItemController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetPlayerItems([FromQuery]GetPlayerItemsQuery query)
        {
            var items = await _mediator.Send(query);  
            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayerItem(AddPlayerItemCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePlayerItem(DeletePlayerItemCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePlayerItem(UpdatePlayerItemCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}
