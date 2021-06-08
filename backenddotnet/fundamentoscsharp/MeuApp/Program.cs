using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Testando";
            Console.WriteLine(texto);

            //Conversão Implicita de Dados
            float valor = 25.8f;
            int outro = 25;

            valor = outro;
            Console.WriteLine(valor);

            //Conversão Explicita de Dados
            int inteiro = 100;
            uint inteiroSemSinal = (uint)inteiro;
            Console.WriteLine(inteiroSemSinal);

            //Parse - Sempre espera uma string
            int numeroInteiro = int.Parse("100");

            //Convert - Permite que a gente converta um tipo para outro tipo
            int numeroInteiro2 = Convert.ToInt32(20.8);
        }
    }
}