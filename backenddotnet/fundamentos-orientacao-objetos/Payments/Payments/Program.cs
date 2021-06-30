using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.numeroBoleto = "NumeroBoleto";
        }
    }

    public class Pagamento
    {
        //Propriedades 
        DateTime Vencimento;

        //Métodos
        public virtual void Pagar()
        {
        }
    }

    public class PagamentoBoleto : Pagamento
    {
        public string numeroBoleto;

        public override void Pagar()
        {
            //Regra do boleto
        }
    }

    public class PagamentoCartaoCredito : Pagamento
    {
        public string numeroCartao;

        public override void Pagar()
        {
            //Regra do cartão de crédito
        }
    }
}