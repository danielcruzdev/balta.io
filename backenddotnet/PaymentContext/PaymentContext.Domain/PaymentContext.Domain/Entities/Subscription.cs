using Flunt.Validations;
using PaymentContext.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
    public class Subscription : Entity
    {
        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
        }

        private readonly IList<Payment> _payments;

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public IReadOnlyCollection<Payment> Payments { get => _payments.ToArray(); }

        public void AddPayment(Payment payment)
        {
            AddNotifications(new Contract()
                                .Requires()
                                .IsGreaterThan(DateTime.Now, payment.PaidDate, "Subscription.Paymens", "A data do pagamento deve ser futura!"));

            if (Valid)
                _payments.Add(payment);
        }

        public void SetActive(bool active)
        {
            Active = active;
            LastUpdateDate = DateTime.Now;
        }
    }
}