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
        public ActionResult<List<TodoModel>> Get([FromServices] DatabaseContext context) => Ok(context.Todo.ToList());

        [HttpGet("/{id:int}")]
        public ActionResult<TodoModel> Get([FromRoute] int id,
                                           [FromServices] DatabaseContext context)
        {
            var todo = context.Todo.FirstOrDefault();
            if (todo == null)
                return NotFound();

            return Ok(todo);
        }

        [HttpPost("/")]
        public ActionResult<TodoModel> Post(
                [FromBody] TodoModel todo,
                [FromServices] DatabaseContext context)
        {
            context.Todo.Add(todo);
            context.SaveChanges();
            return Created($"/{todo.Id}", todo);
        }

        [HttpPut("/{id:int}")]
        public ActionResult<TodoModel> Put([FromRoute] int id,
                                           [FromBody] TodoModel todo,
                                           [FromServices] DatabaseContext context)
        {
            var model = context.Todo.FirstOrDefault(x => x.Id == id);

            if (model == null)
                return NotFound();

            model.Title = todo.Title;
            model.Done = todo.Done;

            context.Todo.Update(model);
            context.SaveChanges();

            return Ok(model);
        }

        [HttpDelete("/{id:int}")]
        public ActionResult<TodoModel> Delete([FromRoute] int id,
                                   [FromServices] DatabaseContext context)
        {
            var model = context.Todo.FirstOrDefault(x => x.Id == id);

            if (model == null)
                return NotFound();

            context.Todo.Remove(model);
            context.SaveChanges();

            return Ok(model);
        }
    }
}
