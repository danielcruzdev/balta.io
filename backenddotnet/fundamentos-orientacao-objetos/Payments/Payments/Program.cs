using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var pagamento = new Pagamento())
            {
                Console.WriteLine("Processando Pagamento...");
            }

            Console.WriteLine("Hello World!");
        }
    }

    public class Pagamento : IDisposable
    {

        public Pagamento()
        {
            Console.WriteLine("Iniciando Pagamento...");
        }

        public void Dispose()
        {
            Console.WriteLine("Finalizando pagamento");
        }
    }
}