using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var numeros = new int[5] { 1, 2, 3, 4, 5 };
            numeros[0] = 12;


            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
