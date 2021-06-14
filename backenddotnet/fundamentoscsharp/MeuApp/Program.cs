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
            //MeuMetodo("Utilizando Método!");
            //Console.WriteLine(RetornaNome("Daniel", "Cruz", 23));
            #endregion

            #region  Value Types
            //int x = 25;
            //// Variável y é uma cópia da x
            //int y = x;

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //x = 32;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            #endregion

            #region Reference Types

            //var arr = new string[2];
            //arr[0] = "Item 1";

            //var arr2 = arr;

            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr2[0]);

            //arr[0] = "Item 2";

            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr2[0]);
            #endregion

            #region using Struct and Enum
            var mouseGamer = new Product(1, "Mouse Gamer", 299.99, EProductType.Product);


            Console.WriteLine(mouseGamer.Id);
            Console.WriteLine(mouseGamer.Name);
            Console.WriteLine(mouseGamer.Price);
            Console.WriteLine(mouseGamer.PriceInDolar(5.43));
            Console.WriteLine(mouseGamer.Type);
            Console.WriteLine((int)mouseGamer.Type);
            #endregion


        }

        #region Funções 
        private static void MeuMetodo(string parametro)
        {
            Console.WriteLine(parametro);
        }

        private static string RetornaNome(string nome, string sobrenome, int idade = 0)
        {
            if (idade == 0)
                return $"{nome} {sobrenome}";
            else
                return $"{nome} {sobrenome} - Idade: {idade}";
        }

        #endregion
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        //Propriedades
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        //Métodos
        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}