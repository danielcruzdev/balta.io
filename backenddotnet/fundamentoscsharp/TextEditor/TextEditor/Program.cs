using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar arquivo");
            Console.WriteLine("0 - Sair");

            short option;
            var hasOption = short.TryParse(Console.ReadLine(), out option);

            if (hasOption)
            {
                switch (option)
                {
                    case 0:
                        Environment.Exit(0); ;
                        break;
                    case 1:
                        Abrir();
                        break;
                    case 2:
                        Editar();
                        break;
                    default:
                        Menu();
                        break;
                }
            }
        }

        static void Abrir()
        {

        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-----------------------");
            string text = "";

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {

            }
        }
    }
}
