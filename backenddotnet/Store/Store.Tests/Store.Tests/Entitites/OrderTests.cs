using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;
using Store.Domain.Enums;
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

        [TestMethod]
        [TestCategory("Domain")]
        public void DadoUmNovoPedidoSeuStatusDeveSerAguardandoPagamento()
        {
            var order = new Order(_customer, 0, null);
            Assert.AreEqual(EOrderStatus.WaitingPayment, order.Status);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void DadoUmPagementoDoPedidoSeuStatusDeveSerAguardandoEntrega()
        {
            var order = new Order(_customer, 0, null);
            order.AddItem(_product, 1);
            order.Pay(10);
            Assert.AreEqual(EOrderStatus.WaitingDelivery, order.Status);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void AoCancelarOPedidoSeuStatusDeveSerCancelado()
        {
            var order = new Order(_customer, 0, null);
            order.Cancel();
            Assert.AreEqual(EOrderStatus.Canceled, order.Status);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void DadoUmNovoItemSemProdutoOMesmoNaoDeveSerAdicionado()
        {
            var order = new Order(_customer, 0, null);
            order.AddItem(null, 10);
            Assert.AreEqual(order.Items.Count, 0);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void DadoUmNovoItemComQuantidadeZeroOuMenorNaoDeveAdicionar()
        {
            var order = new Order(_customer, 0, null);
            order.AddItem(_product, 0);
            Assert.AreEqual(order.Items.Count, 0);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void DadoUmNovoPedidoValidoSeuTotalDeveSer50()
        {
            var order = new Order(_customer, 10, _discount);
            order.AddItem(_product, 5);
            Assert.AreEqual(order.Total(), 50);
        }
    }
}
