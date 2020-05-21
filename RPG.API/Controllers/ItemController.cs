using Microsoft.AspNetCore.Mvc;

using RPG.API.Database;
using RPG.API.Model;

namespace RPG.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("add_item")]
        public IActionResult AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();

            return Ok();
        }
    }
}
