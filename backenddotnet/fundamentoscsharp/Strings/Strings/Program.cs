using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            #region GUID
            //var id = Guid.NewGuid();
            //id.ToString();

            //Console.WriteLine(id);
            #endregion

            var price = 10.2;
            var texto = $"O preço do produto é: {price}";

            Console.WriteLine(texto);
        }
    }
}
