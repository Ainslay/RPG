using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RPG.API.Database;
using RPG.API.Model;

namespace RPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : ControllerBase
    {
        private ApplicationDbContext _context;

        public PlayerController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("add_player")]
        public IActionResult AddPlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();

            return Ok();
        }

        [HttpGet]
        [Route("get_player")]
        public IActionResult GetPlayer(int id)
        {
            if (id < 0)
            {
                return BadRequest("Gicen id was invalid");                          // Lepiej rzucić wyjątek czy zwrócić BadRequest?
            }

            var response = _context.Players.Where(player => player.Id == id);

            if(response.Any())
            {
                return Ok(response.First());
            }

            return BadRequest("There is no player with given id");
        }

        [HttpGet]
        [Route("get_players")]
        public IActionResult GetPlayers()
        {
            var response = _context.Players.Select(player => player);

            if (response.Any())
            {
                return Ok(response.ToList());
            }

            return BadRequest("There are no players in database");
        }

        [HttpPut]
        [Route("update_player")]
        public IActionResult UpdatePlayer(Player player)
        {
            // Chciałem sprawdzić najpierw czy gościu z takim id istnieje, jak to zrobić????
            //var response = _context.Players.Find(player.Id);

            //if(response != null)
            //{
                _context.Players.Update(player);
                _context.SaveChanges();

                return Ok();
            //}

            //return BadRequest("There is no player with matching id to update");
        }

        [HttpDelete]
        [Route("remove_player")]
        public IActionResult RemovePlayer(int id)
        {
            if(id < 0 )
            {
                throw new ArgumentException("Invalid id");
            }
            var response = _context.Players.Where(player => player.Id == id);

            if(response.Any())
            {
                _context.Remove(response.First());
                _context.SaveChanges();

                return Ok();
            }

            return BadRequest(new Exception("There is no player with given id"));       // Taki test, raczej nie powinienem tak robić
        }
    }
}
