using System;
using System.Collections.Generic;
using System.Linq;

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

            payments.AsEnumerable();
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