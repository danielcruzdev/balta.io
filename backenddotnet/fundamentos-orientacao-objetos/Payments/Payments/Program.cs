namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Pagamento
    {
        public Pagamento()
        {
            //Criando construtor da classe

        }

        //Métodos
        public virtual void Pagar(string numero) { }
        public virtual void Pagar(string numero, int numero2) { }
        public virtual void Pagar(string numero, int numero2, int numero3) { }
    }

    public class PagamentoViaCartão : Pagamento
    {
        public override void Pagar(string numero)
        {

        }
    }

    public class Endereco
    {
        string ZipCode;
    }
}