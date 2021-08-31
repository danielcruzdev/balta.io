using System;

namespace Store.Domain.StoreContext
{
    public class Customer
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        public void Register() { }

        public void OnRegister() { }
    }
}
