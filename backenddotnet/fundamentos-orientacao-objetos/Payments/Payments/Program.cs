using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var pessoa = new Pessoa();

            pessoa = new PessoaFisica();
            pessoa = new PessoaJuridica();
        }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
    }

    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
    }
}