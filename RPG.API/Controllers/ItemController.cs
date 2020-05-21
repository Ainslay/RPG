﻿using System.Linq;
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

        [HttpGet]
        [Route("get_item")]
        public IActionResult GetItem(int id)
        {
            if(id < 0)
            {
                return BadRequest("Given id was invalid");
            }

            var response = _context.Items.Where(item => item.Id == id);

            if(response.Any())
            {
                return Ok(response.First());
            }

            return BadRequest("There is no item with given id");
        }

        [HttpGet]
        [Route("get_items")]
        public IActionResult GetItems()
        {
            var response = _context.Items.Select(item => item);

            if(response.Any())
            {
                return Ok(response.ToList());
            }

            return BadRequest("There are no items in database");
        }
    }
}