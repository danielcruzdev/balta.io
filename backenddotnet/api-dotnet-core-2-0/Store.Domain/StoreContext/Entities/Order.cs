using FluentValidator;
using Store.Domain.StoreContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store.Domain.StoreContext.Entities
{
    public class Order : Notifiable
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

        public void Place() 
        {
            if (_Items.Count == 0)
                AddNotification("Order", "Este pedido não possui itens");
        }

        public void Pay()
        {
            Status = EOrderStatus.Paid;
        }

        public void Ship()
        {
            var deliveries = new List<Delivery>();
            deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
            var count = 1;

            foreach (var item in _Items)
            {
                if (count == 5)
                {
                    count = 1;
                    deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
                }

                count++;
            }

            deliveries.ForEach(x => x.Ship());
            deliveries.ForEach(x => _Deliveries.Add(x));
        }

        public void Cancel()
        {
            Status = EOrderStatus.Canceled;
            _Deliveries.ToList().ForEach(x => x.Cancel());
        }
    }
}