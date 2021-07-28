using System;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        public Subscription()
        {
            Payments = new List<Payment>();
        }

        public DateTime CreateDate { get; set; }
        public DateTime lastUpdateDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool Active { get; set; }
        public List<Payment> Payments { get; set; }
    }
}