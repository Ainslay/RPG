using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RPG.API.Database;

namespace RPG.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqExamplesController : ControllerBase
    {
        private ApplicationDbContext _context;

        public LinqExamplesController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [Route("grouping")]
        [HttpGet]
        public bool Grouping1()
        {
            var response = _context.Items.ToList();
            var result = response.GroupBy(item => new { item.Type, item.Name })
                .Select(g => new { g.Key.Type, g.Key.Name, result = g});

            return false;
        }

        [Route("example4")]
        [HttpGet]
        public bool Example4()
        {
            var names1 = _context.Items.Select(item => item.Name).Take(7);
            var names2 = _context.Items.Select(item => item.Name).Skip(5);
            var namesIntersect = names1.Intersect(names2).ToArray();
            var namesExcept = names1.Except(names2).ToArray();
            var result = namesIntersect.Concat(namesExcept);

            return false;
        }

        [Route("example5")]
        [HttpGet]
        public bool Example5()
        {
            var players = new List<PlayerExample> {
                new PlayerExample { Name = "Jakub", Id = 1},
                new PlayerExample { Name = "Dawid", Id = 2}
            };

            var items = new List<ItemExample> {
                new ItemExample { Name = "Gloves", PlayerId = 1},
                new ItemExample { Name = "Hat", PlayerId = 1},
                new ItemExample { Name = "Boots", PlayerId = 2},
                new ItemExample { Name = "Armor", PlayerId = 2}
            };

            var result1 = players.
                Join(items, (p) => p.Id, i => i.PlayerId, (player, item) => new { player.Name, ItemName = item.Name })
                .GroupBy(item => item.Name).ToList();

            var result = players.Join(items, p => p.Id, i => (i as ItemExample).PlayerId, (p, i) => new { PlayerName = p.Name, ItemName = i.Name });
            var playerName = result.GroupBy(r => r.PlayerName).Select(g => new { Key = g.Key, Value = g.ToList() });


            return false;
        }
    }

    public class PlayerExample
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ItemExample
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
    }
}
