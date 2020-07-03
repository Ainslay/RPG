using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RPG.API.Database;
using RPG.API.Model;
using RPG.API.Services;

namespace RPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class PlayerController : ControllerBase
    {
        private ApplicationDbContext _context;
        private IPlayerService _playerService;

        public PlayerController(IPlayerService playerService, ApplicationDbContext context)
        {
            _playerService = playerService;
            _context = context;
        }

        [HttpPost]
        public IActionResult AddPlayer([Required]Player player)
        {
            _playerService.AddPlayer(player);
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
