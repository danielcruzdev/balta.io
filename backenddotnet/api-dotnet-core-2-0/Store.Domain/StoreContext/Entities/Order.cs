using System;
using System.Collections.Generic;

namespace Store.Domain.StoreContext.Entities
{
    public class Order
    {
        public Order()
        {
            Items = new List<OrderItem>();
        }

        public Customer Customer { get; set; }
        public string Number { get; set; }
        public DateTime CreateDate { get; set; }
        public string Status { get; set; }
        public IList<OrderItem> Items { get; set; }
        public IList<Delivery> Deliveries { get; set; }

        public void Place() { }
    }
}