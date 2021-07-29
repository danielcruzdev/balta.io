using PaymentContext.Domain.ValueObjects;
using System;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barcode, string email, string boletoNumber, DateTime paidDate, DateTime expireDate,
                             decimal total, decimal totalPaid, string payer, Document document, string address)
                             : base(paidDate, expireDate, total, totalPaid, payer, document, address)
        {
            BarCode = barcode;
            Email = email;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string Email { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}
