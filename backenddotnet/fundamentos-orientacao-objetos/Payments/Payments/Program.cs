using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagamento.Vencimento = DateTime.Now;
            Console.WriteLine("Hello World!");
        }
    }

    public static class Pagamento
    {
        public static DateTime Vencimento { get; set; }
    }
}