using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.StoreContext.Entities;

namespace Store.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer("Daniel", "Cruz", "12345678910", "d.afc98@gmail.com", "19993878933", "Rua Panamá");
        }
    }
}
