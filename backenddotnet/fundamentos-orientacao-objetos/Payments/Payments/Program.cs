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

    public class Pagamento
    {
        //Propriedades 
        DateTime Vencimento;

        //Métodos
        void Pagar()
        {
        }
    }

    public class PagamentoBoleto : Pagamento
    {

    }
}