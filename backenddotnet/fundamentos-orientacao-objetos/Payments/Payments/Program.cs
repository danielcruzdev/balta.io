using System;
using System.Collections.Generic;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var payments = new List<Payment>();
            payments.Add(new Payment(1));
            payments.Add(new Payment(2));
            payments.Add(new Payment(3));

            foreach (var payment in payments)
            {

                Console.WriteLine(payment.Id);
            }

            var paidPayments = new List<Payment>();
            paidPayments.AddRange(payments);

            var payment2 = payments.Find(x => x.Id == 3);

            Console.WriteLine(payment2.Id);

            payments.Remove(payment2);

            foreach (var payment in payments)
            {
                Console.WriteLine(payment.Id);
            }
        }
    }

    public class Payment
    {
        public Payment(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}