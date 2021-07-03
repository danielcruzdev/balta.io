using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var pessoaA = new Pessoa(1, "Daniel Cruz");
            var pessoaB = new Pessoa(1, "Daniel Cruz");

            Console.WriteLine(pessoaA.Equals(pessoaB));
        }
    }

    public class Pessoa : IEquatable<Pessoa>
    {
        public Pessoa(int id, string nome)
        {
            Nome = nome;
            Id = id;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public bool Equals(Pessoa pessoa)
        {
            return Id == pessoa.Id;
        }
    }
}