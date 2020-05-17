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
        public IActionResult SavePlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();

            return Ok();
        }
    }
}
