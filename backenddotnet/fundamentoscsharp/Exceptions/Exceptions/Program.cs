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
                //for (int i = 0; i < 10; i++)
                //{
                //    Console.WriteLine(array[i]);
                //}

                Cadastrar(null);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Inner Exception: {ex.InnerException}");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Oops! Não encontrei o index no array...");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Inner Exception: {ex.InnerException}");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Oops! Falha ao cadastrar texto");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Inner Exception: {ex.InnerException}");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Oops! Algo errado aconteceu...");
            }
        }

        static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new ArgumentNullException("O texto não pode ser nulo");
            }
        }
    }
}
