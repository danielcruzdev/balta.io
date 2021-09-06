using Store.Domain.StoreContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store.Domain.StoreContext.Entities
{
    public class Order
    {
        public Order(Customer customer)
        {
            Customer = customer;
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
            CreateDate = DateTime.Now;
            Status = EOrderStatus.Created;
            _Items = new List<OrderItem>();
            _Deliveries = new List<Delivery>();
        }

        private readonly IList<OrderItem> _Items;
        private readonly IList<Delivery> _Deliveries;
        public Customer Customer { get; private set; }
        public string Number { get; private set; }
        public DateTime CreateDate { get; private set; }
        public EOrderStatus Status { get; private set; }
        public IReadOnlyCollection<OrderItem> Items => _Items.ToArray();
        public IReadOnlyCollection<Delivery> Deliveries => _Deliveries.ToArray();

        public void AddItem(OrderItem item)
        {
            _Items.Add(item);
        }


        public void AddDelivery(Delivery delivery)
        {
            _Deliveries.Add(delivery);
        }

        public void Place() { }
    }
}