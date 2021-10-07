﻿using Flunt.Notifications;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Entities;
using Todo.Domain.Handlers.Contracts;
using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers
{
    public class TodoHandler :
        Notifiable,
        IHandler<CreateTodoCommand>,
        IHandler<UpdateTodoCommand>,
        IHandler<MarkTodoAsDoneCommand>,
        IHandler<MarkTodoAsUndoneCommand>
    {
        private readonly ITodoRepository _todoRepository;

        public TodoHandler(ITodoRepository todoRepository) => _todoRepository = todoRepository;

        public ICommandResult Handle(CreateTodoCommand command)
        {
            //Fail Fast Validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ops, parece que sua tarefa está errada!", command.Notifications);

            var todo = new TodoItem(command.Title, command.Date, command.User);

            _todoRepository.Create(todo);

            return new GenericCommandResult(true, "Tarefa Salva com Sucesso!", todo);
        }

        public ICommandResult Handle(UpdateTodoCommand command)
        {
            //Fail Fast Validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ops, parece que sua tarefa está errada!", command.Notifications);

            var todo = _todoRepository.GetById(command.Id, command.User);

            todo.UpdateTitle(command.Title);

            _todoRepository.Update(todo);

            return new GenericCommandResult(true, "Tarefa Atualizada com Sucesso!", todo);
        }

        public ICommandResult Handle(MarkTodoAsDoneCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ops, parece que sua tarefa está errada!", command.Notifications);

            var todo = _todoRepository.GetById(command.Id, command.User);

            todo.MarkAsDone();

            _todoRepository.Update(todo);

            return new GenericCommandResult(true, "Tarefa Salva!", todo);
        }

        public ICommandResult Handle(MarkTodoAsUndoneCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ops, parece que sua tarefa está errada!", command.Notifications);

            var todo = _todoRepository.GetById(command.Id, command.User);

            todo.MarkAsUndone();

            _todoRepository.Update(todo);

            return new GenericCommandResult(true, "Tarefa Salva!", todo);
        }
    }
}
