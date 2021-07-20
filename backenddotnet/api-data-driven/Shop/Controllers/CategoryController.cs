using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> Get()
        {
            return new List<Category>();
        }

        [HttpGet("{categoryId:int}")]
        public async Task<ActionResult<Category>> GetById([FromRoute] int categoryId)
        {
            return new Category();
        }

        [HttpPost]
        public async Task<ActionResult<Category>> Post([FromBody] Category category)
        {
            return Ok(category);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Category>> Put([FromRoute] int id, [FromBody] Category category)
        {
            if (category.Id == id)
                return Ok(category);

            return NotFound();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Category>> Delete([FromRoute] int id)
        {
            return Ok();
        }
    }
}
