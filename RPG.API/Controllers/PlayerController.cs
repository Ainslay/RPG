using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using RPG.API.Commands.PlayerCommands;
using RPG.API.Queries.PlayerQueries;

namespace RPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : ControllerBase
    {
        private IMediator _mediator;

        public PlayerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayer(AddPlayerCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetPlayer([FromQuery]GetPlayerQuery query)
        {
            var player = await _mediator.Send(query);
            return Ok(player);
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetPlayers([FromQuery]GetPlayersQuery query)
        {
            var players = await _mediator.Send(query);
            return Ok(players);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePlayer(UpdatePlayerCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePlayer(DeletePlayerCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}
