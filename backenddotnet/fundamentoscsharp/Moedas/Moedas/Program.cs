using System;
using System.Globalization;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10.25m;
            var culture = CultureInfo.CreateSpecificCulture("pt-BR");

            Console.WriteLine(valor.ToString("C", culture));

        }
    }
}
