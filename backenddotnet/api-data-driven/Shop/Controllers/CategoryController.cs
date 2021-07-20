using Microsoft.AspNetCore.Mvc;

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
        public string Post()
        {
            return "POST";
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
