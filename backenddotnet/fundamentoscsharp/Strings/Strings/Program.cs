using System;
using System.Text;

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
            //var texto = "Esse texto é um teste";
            //Console.WriteLine(texto.IndexOf("é"));
            //Console.WriteLine(texto.LastIndexOf("s"));
            #endregion

            #region Adicionais
            //var texto = "Este texto é um teste";
            //Console.WriteLine(texto.ToLower());
            //Console.WriteLine(texto.ToUpper());
            //Console.WriteLine(texto.Insert(5, "Aqui "));
            //Console.WriteLine(texto.Remove(5, 5));
            //Console.WriteLine(texto.Length);
            //Console.WriteLine(texto.Replace("Este", "Isto"));

            //var divisao = texto.Split(" ");
            //foreach (var item in divisao)
            //{
            //    Console.WriteLine(item);
            //}

            //var resultado = texto.Substring(5, texto.LastIndexOf("o"));
            //Console.WriteLine(resultado);

            //var texto2 = "       Este texto é um teste           ";
            //Console.WriteLine(texto2.Trim());
            #endregion

            #region StringBuilder
            var texto = new StringBuilder();
            texto.Append("Este texto é um teste1 \n");
            texto.Append("Este texto é um teste2 \n");
            texto.Append("Este texto é um teste3 \n");
            texto.Append("Este texto é um teste4 \n");

            texto.ToString();
            Console.WriteLine(texto);
            #endregion
        }
    }
}
