namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var context = new DataContext<Person>();
            context.Save(person);
        }
    }

    public class DataContext<T>
    {
        public void Save(T entity)
        {

        }
    }

    public class Person { }

    public class Payments { }

    public class Subscription { }
}