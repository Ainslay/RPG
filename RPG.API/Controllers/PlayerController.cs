using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RPG.API.Commands.PlayerCommands;
using RPG.API.Database;
using RPG.API.Model;
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
        public IActionResult GetPlayer([Required][Range(0, int.MaxValue)] int id)
        {
            var player = _playerService.GetPlayerById(id);
            return Ok(player);
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetPlayers()
        {
            var players = _playerService.GetPlayers();

            if (players.Any())
            {
                return Ok(players);
            }

            return BadRequest("There are no players in database");
        }

        [HttpPut]
        public IActionResult UpdatePlayer([Required]Player player)
        {
            _playerService.UpdatePlayer(player);
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
