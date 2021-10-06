using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Tests.Repositories;

namespace Todo.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoHandlerTests
    {
        private readonly CreateTodoCommand _invalidCommand = new("", "", DateTime.Now);
        private readonly CreateTodoCommand _validCommand = new("Titulo da Tarefa", "Daniel Cruz", DateTime.Now);
        private readonly TodoHandler _handler = new(new FakeTodoRepository());

        [TestMethod]
        public void DadoUmComandoInvalidoDeveInteromperAExecucao()
        {
            var result = (GenericCommandResult)_handler.Handle(_invalidCommand);
            Assert.AreEqual(result.Success, false);
        }

        [TestMethod]
        public void DadoUmComandoValidoDeveCriarATarefa()
        {
            var result = (GenericCommandResult)_handler.Handle(_validCommand);
            Assert.AreEqual(result.Success, true);
        }
    }
}
