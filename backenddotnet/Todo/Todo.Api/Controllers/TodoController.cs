using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Todo.Domain.Commands;
using Todo.Domain.Entities;
using Todo.Domain.Handlers;
using Todo.Domain.Repositories;

namespace Todo.Api.Controllers
{
    [ApiController]
    [Route("v1/todos")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<TodoItem> GetAll([FromServices] ITodoRepository repository)
        {
            return repository.GetAll("Daniel Cruz");
        }

        [HttpGet("done")]
        public IEnumerable<TodoItem> GetAllDone([FromServices] ITodoRepository repository)
        {
            return repository.GetAllDone("Daniel Cruz");
        }


        [HttpGet("undone")]
        public IEnumerable<TodoItem> GetAllUndone([FromServices] ITodoRepository repository)
        {
            return repository.GetAllUndone("Daniel Cruz");
        }

        [HttpGet("done/today")]
        public IEnumerable<TodoItem> GetDoneForToday([FromServices] ITodoRepository repository)
        {
            return repository.GetByPeriod("Daniel Cruz", DateTime.Now.Date, true);
        }


        [HttpGet("undone/today")]
        public IEnumerable<TodoItem> GetUndoneForToday([FromServices] ITodoRepository repository)
        {
            return repository.GetByPeriod("Daniel Cruz", DateTime.Now.Date, false);
        }


        [HttpPost]
        public GenericCommandResult Create([FromBody] CreateTodoCommand command,
                                           [FromServices] TodoHandler handler)
        {
            command.User = "danielcruz";
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}
