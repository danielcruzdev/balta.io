using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Segundo => 10s = 10 segundos");
            Console.WriteLine("M - Minuto => 1m = 1 minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();

            char type;
            int time;

            var startIndex = data.Length - 1;

            var hasType = char.TryParse(data.Substring(startIndex, 1), out type);
            var hasTime = int.TryParse(data.Substring(0, startIndex), out time);
            int multiplier = 1;

            if (hasTime && hasType)
            {
                if (type == 'm')
                    multiplier = 60;

                if (time == 0)
                    Environment.Exit(0);

                PreStart(time * multiplier);
            }
        }

        private static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(900);

            Start(time);
        }

        private static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch Finalizado...");
            Thread.Sleep(1500);
            Menu();
        }
    }
}