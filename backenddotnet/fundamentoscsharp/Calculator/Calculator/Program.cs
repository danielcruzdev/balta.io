using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
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

        private static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação você deseja?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("-------------------");
            Console.Write("Selecione uma opção:");
            short? operacao = short.Parse(Console.ReadLine());

            if (operacao != null)
            {
                switch (operacao)
                {
                    case 1:
                        Soma();
                        Menu();
                        break;
                    case 2:
                        Subtracao();
                        Menu();
                        break;
                    case 3:
                        Divisao();
                        Menu();
                        break;
                    case 4:
                        Multiplicacao();
                        Menu();
                        break;
                    case 0:
                        Environment.Exit(0);
                        Console.Clear();
                        break;
                    default:
                        Menu();
                        break;
                }
            }
            else
            {
                Menu();
            }
        }
    }
}
