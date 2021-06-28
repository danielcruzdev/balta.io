using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[3];

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Inner Exception: {ex.InnerException}");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Oops! Algo errado aconteceu...");
            }
        }
    }
}
