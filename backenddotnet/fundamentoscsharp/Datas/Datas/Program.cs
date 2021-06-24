using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = DateTime.Now;
            //var dateNow = DateTime.Now;
            //Console.WriteLine(data);
            //Console.WriteLine(data.Year);
            //Console.WriteLine(data.Month);
            //Console.WriteLine(data.Day);
            //Console.WriteLine(data.Hour);
            //Console.WriteLine(data.Minute);
            //Console.WriteLine(data.Second);

            var formatada = String.Format("{0:yyyy}", data);
            Console.WriteLine(formatada);
        }
    }
}
