using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_asp_net_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectController : ControllerBase
    {   
        // GET: api/Object
        [HttpGet]
        public IEnumerable<Object> Get()
        {
            using(var db = new DatabaseContext())
            {
                db.Database.EnsureCreated();

                var objects = db.Objects.ToList();
                return objects;
            }
        }

        // // GET: api/Object/5
        // [HttpGet("{id}")]
        // public IActionResult Get(int id)
        // {
        //     var obj = _objects.FirstOrDefault(o => o.Id == id);
        //     if (obj == null)
        //     {
        //         return NotFound();
        //     }
        //     return Ok(obj);
        // }

        // // POST: api/Object
        // [HttpPost]
        // public IActionResult Post([FromBody] ObjectModel obj)
        // {
        //     obj.Id = _objects.Max(o => o.Id) + 1;
        //     _objects.Add(obj);
        //     return CreatedAtAction(nameof(Get), new { id = obj.Id }, obj);
        // }

        // // PUT: api/Object/5
        // [HttpPut("{id}")]
        // public IActionResult Put(int id, [FromBody] ObjectModel obj)
        // {
        //     var existingObj = _objects.FirstOrDefault(o => o.Id == id);
        //     if (existingObj == null)
        //     {
        //         return NotFound();
        //     }
        //     existingObj.Name = obj.Name;
        //     existingObj.Description = obj.Description;
        //     return NoContent();
        // }

        // // DELETE: api/Object/5
        // [HttpDelete("{id}")]
        // public IActionResult Delete(int id)
        // {
        //     var objToRemove = _objects.FirstOrDefault(o => o.Id == id);
        //     if (objToRemove == null)
        //     {
        //         return NotFound();
        //     }
        //     _objects.Remove(objToRemove);
        //     return NoContent();
        // }
    }
}
