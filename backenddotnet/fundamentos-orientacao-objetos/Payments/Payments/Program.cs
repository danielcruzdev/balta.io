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

    public sealed class Pagamento
    {
        public static DateTime Vencimento { get; set; }
    }
}