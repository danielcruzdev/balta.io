using System;

namespace Calculator
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Soma()
        {
            Console.Clear();
            Console.WriteLine("-----SOMA-----");

            var valores = GetValuesUser();

            float resultado = valores.Valor1 + valores.Valor2;
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Soma: {resultado}");
            Console.ReadKey();
        }

        private static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("-----SUBTRAÇÃO-----");

            var valores = GetValuesUser();

            float resultado = valores.Valor1 - valores.Valor2;
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Subtração: {resultado}");
            Console.ReadKey();
        }

        private static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("-----DIVISÃO-----");
            var valores = GetValuesUser();

            float resultado = valores.Valor1 / valores.Valor2;
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Divisão: {resultado}");
            Console.ReadKey();
        }

        private static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("-----MULTIPLICAÇÃO-----");
            var valores = GetValuesUser();

            float resultado = valores.Valor1 * valores.Valor2;

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

            short operacao;
            bool canParse = short.TryParse(Console.ReadLine(), out operacao);

            if (canParse)
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
                Console.Clear();
                Console.WriteLine("Digite um número válido!");
                Console.WriteLine("Para continuar pressione Enter.");
                Console.ReadKey();
                Menu();
            }
        }

        private static Valores GetValuesUser()
        {
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            var valores = new Valores();
            valores.Valor1 = v1;
            valores.Valor2 = v2;

            return valores;
        }
    }
}