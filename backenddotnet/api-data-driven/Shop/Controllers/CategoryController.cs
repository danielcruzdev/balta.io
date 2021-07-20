using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "GET";
        }

        [HttpGet("{categoryId:int}")]
        public string GetById([FromRoute] int categoryId)
        {
            return $"GET: {categoryId}";
        }

        [HttpPost]
        public string Post([FromBody] Category category)
        {
            return $"POST - {category.Title}";
        }

        [HttpPut]
        public string Put()
        {
            return "PUT";
        }

        [HttpDelete]
        public string Delete()
        {
            return "DELETE";
        }
    }
}
