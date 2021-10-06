using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;

namespace Todo.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        private readonly CreateTodoCommand _invalidCommand = new("", "", DateTime.Now);
        private readonly CreateTodoCommand _validCommand = new("Titulo da Tarefa", "Daniel Cruz", DateTime.Now);

        public CreateTodoCommandTests()
        {
            _invalidCommand.Validate();
            _validCommand.Validate();
        }

        [TestMethod]
        public void DadoUmComandoInvalido() => Assert.AreEqual(_invalidCommand.Valid, false);

        [TestMethod]
        public void DadoUmComandoValido() => Assert.AreEqual(_validCommand.Valid, true);
    }
}
