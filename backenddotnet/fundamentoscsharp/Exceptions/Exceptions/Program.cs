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
            catch (MinhaException ex)
            {
                Console.WriteLine($"Inner Exception: {ex.InnerException}");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Message: {ex.DataHoraErro}");
                Console.WriteLine($"Minha exception....");
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
            finally
            {
                Console.WriteLine("Chegou ao fim!");
            }
        }

        static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new MinhaException(DateTime.Now);
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime dataHora)
            {
                DataHoraErro = dataHora;
            }

            public DateTime DataHoraErro { get; set; }
        }
    }
}
