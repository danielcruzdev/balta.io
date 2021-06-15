using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
            Subtracao();
            Divisao();
            Multiplicacao();
        }

        private static void Soma()
        {
            Console.Clear();
            Console.WriteLine("-----SOMA-----");

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Soma: {resultado}");
            Console.ReadKey();
        }

        private static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("-----SUBTRAÇÃO-----");

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Subtração: {resultado}");
            Console.ReadKey();
        }

        private static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("-----DIVISÃO-----");

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Divisão: {resultado}");
            Console.ReadKey();
        }

        private static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("-----MULTIPLICAÇÃO-----");

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Multiplicacao: {resultado}");
            Console.ReadKey();
        }

    }
}
