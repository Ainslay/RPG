using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RPG.API.Commands.PlayerCommands;
using RPG.API.Model;
using RPG.API.Queries.PlayerQueries;
using RPG.API.Services;

namespace RPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : ControllerBase
    {
        private IPlayerService _playerService;
        private IMediator _mediator;

        public PlayerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayer(AddPlayerCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetPlayer(GetPlayerQuery query)
        {
            var player = await _mediator.Send(query);
            return Ok(player);
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetPlayers(GetPlayersQuery query)
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
        public IActionResult RemovePlayer([Required][Range(0, int.MaxValue)] int id)
        {
            _playerService.RemoveAtId(id);
            return Ok();
        }
    }
}
