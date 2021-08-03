using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;
using System;

namespace Store.Tests.Entitites
{
    [TestClass]
    public class OrderTests
    {
        private readonly Customer _customer = new Customer("Daniel Cruz", "d.afc98@gmail.com");
        private readonly Product _product = new Product("Produto 1", 10, true);
        private readonly Discount _discount = new Discount(10, DateTime.Now.AddDays(5));

        [TestMethod]
        [TestCategory("Domain")]
        public void DadoUmNovoPedidoValidoEleDeveGerarUmNumeroCom8Caracteres()
        {
            var order = new Order(_customer, 0, null);
            Assert.AreEqual(8, order.Number.Length);
        }
    }
}
