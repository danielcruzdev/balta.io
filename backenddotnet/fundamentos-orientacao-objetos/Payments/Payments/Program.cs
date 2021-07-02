using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Pagamento : IPagamento
    {
        public DateTime Vencimento { get; set; }
        public double Valor { get; set; }

        public void Pagar(double valor)
        {

        }
    }

    public interface IPagamento
    {
        DateTime Vencimento { get; set; }
        double Valor { get; set; }
        void Pagar(double valor);
    }
}