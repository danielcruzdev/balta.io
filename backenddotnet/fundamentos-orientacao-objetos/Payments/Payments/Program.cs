using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
            pagamento.DataPagamento2 = DateTime.Now;
        }
    }

    public class Pagamento
    {
        //Propriedades 
        public DateTime Vencimento { get; set; }

        private DateTime DataPagamento;

        public DateTime DataPagamento2
        {
            get
            {
                Console.WriteLine("Lendo Valor");
                return DataPagamento;
            }
            set
            {
                Console.WriteLine("Atribuindo Valor");
                DataPagamento = value;
            }
        }


        //Métodos
        public void Pagar() { }
    }

    public class Endereco
    {
        string ZipCode;
    }
}