namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public string BarCode { get; prset; }
        public string Email { get; set; }
        public string BoletoNumber { get; set; }
    }
}
