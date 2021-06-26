using System;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10.25m;

            //var culture = CultureInfo.CreateSpecificCulture("pt-BR");
            //Console.WriteLine(valor.ToString("C", culture));

            Console.WriteLine(Math.Round(valor)); //Aredonda
            Console.WriteLine(Math.Ceiling(valor)); //Aredonda para cima
            Console.WriteLine(Math.Floor(valor)); //Aredonda para baixo
        }
    }
}
