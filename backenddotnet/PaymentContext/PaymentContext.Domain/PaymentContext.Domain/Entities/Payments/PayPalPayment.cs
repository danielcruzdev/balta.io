using PaymentContext.Domain.ValueObjects;
using System;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string email, string transactionCode, DateTime paidDate, DateTime expireDate,
                             decimal total, decimal totalPaid, string payer, Document document, string address)
                             : base(paidDate, expireDate, total, totalPaid, payer, document, address)
        {
            Email = email;
            TransactionCode = transactionCode;
        }

        public string Email { get; private set; }
        public string TransactionCode { get; private set; }
    }
}
