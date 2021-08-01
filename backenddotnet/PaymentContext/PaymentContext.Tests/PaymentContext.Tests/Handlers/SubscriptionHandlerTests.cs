using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;
using System;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        // Red, Green, Refactor

        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Danyel França";
            command.LastName = "Cruz";
            command.Document = "12332112310";
            command.Email = "d.afc98@gmail.com";
            command.BarCode = "123456789";
            command.BoletoNumber = "73109273";
            command.PaymentNumber = "749123";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "Maria França";
            command.PayerDocument = "12345678911";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "maria@gmail.com";
            command.Street = "Rua 13 de Maio";
            command.Number = "123";
            command.Neighborhood = "Jd. Flora";
            command.City = "Americana";
            command.State = "São Paulo";
            command.Country = "Brazil";
            command.ZipCode = "13245123";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}
