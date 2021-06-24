using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = new DateTime(2020, 10, 12, 8, 23, 14);
            //var dateNow = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
        }
    }
}
