using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parse/Convert/Operadores
            // var texto = "Testando";
            // Console.WriteLine(texto);

            // //Conversão Implicita de Dados
            // float valor = 25.8f;
            // int outro = 25;

            // valor = outro;
            // Console.WriteLine(valor);

            // //Conversão Explicita de Dados
            // int inteiro = 100;
            // uint inteiroSemSinal = (uint)inteiro;
            // Console.WriteLine(inteiroSemSinal);

            // //Parse - Sempre espera uma string
            // int numeroInteiro = int.Parse("100");

            // //Convert - Permite que a gente converta um tipo para outro tipo
            // int numeroInteiro2 = Convert.ToInt32(20.8);

            // //Operadores de atribuição
            // int x = 2;
            // x = 2 + 2;
            // Console.WriteLine(x);
            #endregion

            #region Funções e Metodos
            MeuMetodo("Utilizando Método!");
            Console.WriteLine(RetornaNome("Daniel", "Cruz", 23));
            #endregion            
        }

        private static void MeuMetodo(string parametro)
        {
            Console.WriteLine(parametro);
        }   

        private static string RetornaNome(string nome, string sobrenome, int idade = 0)  
        {
            if(idade == 0)
                return $"{nome} {sobrenome}";
            else 
               return $"{nome} {sobrenome} - Idade: {idade.ToString()}";
        }
    }
}