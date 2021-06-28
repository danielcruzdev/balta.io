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

            var arr = new int[4];
            var arr2 = arr;

            arr[0] = 12;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            var primeiroArray = new int[4];
            var segundoArray = new int[4];

            segundoArray[0] = primeiroArray[0];

            primeiroArray[0] = 23;

            Console.WriteLine(segundoArray[0]);
        }
    }
}
