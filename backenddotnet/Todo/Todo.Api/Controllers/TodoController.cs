using Microsoft.AspNetCore.Mvc;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;

namespace Todo.Api.Controllers
{
    [ApiController]
    [Route("v1/todos")]
    public class TodoController : ControllerBase
    {

        [HttpPost]
        public GenericCommandResult Create([FromBody] CreateTodoCommand command,
                                           [FromServices] TodoHandler handler)
        {
            command.User = "danielcruz";
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}
