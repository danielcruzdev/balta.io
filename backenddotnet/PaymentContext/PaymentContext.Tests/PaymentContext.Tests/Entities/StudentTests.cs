using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.ValueObjects;
using System;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        //[TestMethod]
        public void AdicionarAssinatura()
        {
            var name = new Name("Daniel", "Cruz");
            foreach (var notification in name.Notifications)
            {
                Console.WriteLine(notification.Message);
                Console.WriteLine(notification.Property);
            }
        }
    }
}
