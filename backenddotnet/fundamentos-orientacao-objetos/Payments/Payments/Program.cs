namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var context = new DataContext<Person, Payments, Subscription>();
            context.Save(person);
        }
    }

    public class DataContext<P, PA, S> where P : Person
                                       where PA : Payments
                                       where S: Subscription
    {
        public void Save(P person)
        {
       
        }

        public void Save(PA payment)
        {

        }

        public void Save(S subscription)
        {

        }
    }

    public class Person { }

    public class Payments { }

    public class Subscription { }
}