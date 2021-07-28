namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public string Email { get; set; }
        public string TransactionCode { get; set; }
    }
}
