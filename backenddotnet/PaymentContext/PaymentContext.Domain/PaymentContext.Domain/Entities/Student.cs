using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public List<Subscription> Subscriptions { get; set; }
    }
}
