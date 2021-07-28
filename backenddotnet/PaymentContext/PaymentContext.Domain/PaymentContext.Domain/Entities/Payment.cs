﻿using System;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        public string Number { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
    }

    public class BoletoPayment : Payment
    {

    }

    public class CreditCardPaymento : Payment
    {

    }

    public class PayPalPayment : Payment
    {

    }
}
