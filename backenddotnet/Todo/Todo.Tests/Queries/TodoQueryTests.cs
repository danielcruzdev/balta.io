using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Tests.Queries
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", DateTime.Now, "Usuario A"));
            _items.Add(new TodoItem("Tarefa 2", DateTime.Now, "Daniel Cruz"));
            _items.Add(new TodoItem("Tarefa 3", DateTime.Now, "Usuario B"));
            _items.Add(new TodoItem("Tarefa 4", DateTime.Now, "Daniel Cruz"));
            _items.Add(new TodoItem("Tarefa 5", DateTime.Now, "Usuario C"));
            _items.Add(new TodoItem("Tarefa 6", DateTime.Now, "Daniel Cruz"));
        }


        [TestMethod]
        public void DeveRetornarTarefasApenasDoUsuarioDanielCruz()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("Daniel Cruz"));
            Assert.AreEqual(3, result.Count());
        }
    }
}
