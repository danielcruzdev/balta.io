using PaymentContext.Domain.ValueObjects;
using System;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPaymento : Payment
    {
        public CreditCardPaymento(string cardHolderName, string cardNumber, string lastTransactionNumber, DateTime paidDate, DateTime expireDate,
                                 decimal total, decimal totalPaid, string payer, Document document, Address address)
                                 : base(paidDate, expireDate, total, totalPaid, payer, document, address)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }
}
