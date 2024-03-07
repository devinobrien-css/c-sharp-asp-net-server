using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_asp_net_server.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ObjectController : ControllerBase
    {   
        // GET: /Object
        [HttpGet]
        public IActionResult Get()
        {
            using var db = new DatabaseContext();
            db.Database.EnsureCreated();

            var objects = db.Objects.ToList();
            return Ok(objects);
        }

        // GET: /Object/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using var db = new DatabaseContext();
            db.Database.EnsureCreated();

            var obj = db.Objects.FirstOrDefault(o => o.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }

        // POST: /Object
        [HttpPost]
        public IActionResult Post([FromBody] Object obj)
        {
            using var db = new DatabaseContext();
            db.Database.EnsureCreated();

            db.Objects.Add(obj);
            db.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = obj.Id }, obj);
        }

        // PUT: /Object/{id}
        [HttpPut("{id}")]
        public IActionResult Patch(int id, [FromBody] Object obj)
        {
            using var db = new DatabaseContext();
            db.Database.EnsureCreated();

            var existingObj = db.Objects.FirstOrDefault(o => o.Id == id);
            if (existingObj == null)
            {
                return NotFound();
            }
            existingObj.Name = obj.Name;
            existingObj.Description = obj.Description;
            db.SaveChanges();
            return NoContent();
        }

        // DELETE: /Object/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using var db = new DatabaseContext();
            db.Database.EnsureCreated();

            var obj = db.Objects.FirstOrDefault(o => o.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            db.Objects.Remove(obj);
            db.SaveChanges();
            return NoContent();
        }
    }
}
