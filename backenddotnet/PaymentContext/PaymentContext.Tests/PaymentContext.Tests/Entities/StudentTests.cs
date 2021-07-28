using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var subscription = new Subscription();
            var student = new Student("Daniel", "Cruz", "123456789", "d.afc98@gmail.com");
            student.AddSubscription(subscription);
        }
    }
}
