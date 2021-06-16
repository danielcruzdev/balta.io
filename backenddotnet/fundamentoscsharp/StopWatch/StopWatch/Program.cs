using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void Start()
        {
            int time = 10;
            int currentTime = 0;

            while (currentTime != time)
            {
                currentTime++;
            }
        }
    }
}
