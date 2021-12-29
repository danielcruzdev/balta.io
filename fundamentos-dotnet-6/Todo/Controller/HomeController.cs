using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Models;

namespace Todo.Controller
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        public ActionResult<List<TodoModel>> Get([FromServices] DatabaseContext context)
        {
            return Ok(context.Todo.ToList());
        }

        [HttpPost("/")]
        public ActionResult<TodoModel> Post(
                [FromBody] TodoModel todo,
                [FromServices] DatabaseContext context)
        {
            context.Todo.Add(todo);
            context.SaveChanges();
            return Ok(todo);
        }

        [HttpPut("/")]
        public ActionResult<List<TodoModel>> Put(
        [FromBody] TodoModel todo,
        [FromServices] DatabaseContext context)
        {
            context.Todo.Update(todo);
            context.SaveChanges();
            return Ok(todo);
        }
    }
}
