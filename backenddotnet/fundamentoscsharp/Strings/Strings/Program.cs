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

            #region INTERPOLACAO

            //var price = 10.2;
            //var texto = $"O preço do produto é: {price}";

            //Console.WriteLine(texto);

            #endregion

            #region COMPARACAO ENTRE STRINGS 
            //var texto = "Testando";
            //Console.WriteLine(texto.CompareTo("Testando"));

            //var texto2 = "Esse texto contem a palavra teste?";
            //Console.WriteLine(texto2.Contains("teste"));
            //Console.WriteLine(texto2.Contains("TESTE", StringComparison.OrdinalIgnoreCase));
            #endregion

            #region StartWith/EndsWith
            //var texto = "Este texto é um teste";
            //Console.WriteLine(texto.StartsWith("Este"));
            //Console.WriteLine(texto.EndsWith("teste"));
            #endregion

            #region Equals
            //var texto = "Este texto é um teste";
            //Console.WriteLine(texto.Equals(texto + " "));
            //Console.WriteLine(texto.Equals(texto));
            #endregion[

            #region Indices
            var texto = "Esse texto é um teste";
            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.LastIndexOf("s"));
            #endregion
        }
    }
}
