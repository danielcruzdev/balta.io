using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Entities;

namespace Todo.Tests.CommandTests
{
    [TestClass]
    public class TodoItemTest
    {
        private readonly TodoItem _todo = new TodoItem("Titulo de Teste", DateTime.Now, "Daniel Cruz");

        [TestMethod]
        public void DadoUmNovoTodoOMesmoNaoPodeSerConcluido() => Assert.AreEqual(_todo.Done, false);
    }
}
