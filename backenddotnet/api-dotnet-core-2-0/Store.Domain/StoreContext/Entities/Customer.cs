using Store.Domain.StoreContext.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace Store.Domain.StoreContext.Entities
{
    public class Customer
    {
        public Customer(Name name, Document document, Email email, string phone)
        {
            Name = name;
            Document = document;
            Email = email;
            Phone = phone;
            _Addresses = new List<Address>();
        }

        private readonly IList<Address> _Addresses;
        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses => _Addresses.ToArray();
        
        public void AddAddress(Address address)
        {
            _Addresses.Add(address);
        }

        public override string ToString() => Name.ToString();
    }
}
