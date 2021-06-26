using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //var data = DateTime.Now;
            //var dateNow = DateTime.Now;
            //Console.WriteLine(data);
            //Console.WriteLine(data.Year);
            //Console.WriteLine(data.Month);
            //Console.WriteLine(data.Day);
            //Console.WriteLine(data.Hour);
            //Console.WriteLine(data.Minute);
            //Console.WriteLine(data.Second);

            //var formatada = String.Format("{0:yyyy}", data);        

            //Console.WriteLine(data.AddDays(1));
            //Console.WriteLine(data.AddMonths(1));
            //Console.WriteLine(data.AddYears(1));


            //if (data.Date == DateTime.Now.Date)
            //{
            //    Console.WriteLine("É igual!");
            //}

            //Console.WriteLine(data);

            //var pt = new CultureInfo("pt-PT");
            //var br = new CultureInfo("pt-BR");
            //var en = new CultureInfo("en-US");
            //var de = new CultureInfo("de-DE");
            //var atual = CultureInfo.CurrentCulture;

            var dateTime = DateTime.UtcNow;


            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.ToLocalTime());

            var timeZones = TimeZoneInfo.GetSystemTimeZones();

            foreach (var timeZone in timeZones)
            {
                Console.WriteLine(timeZone.Id);
                Console.WriteLine(timeZone.DisplayName);
                Console.WriteLine(timeZone.BaseUtcOffset);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZone));
                Console.WriteLine("|---------------------------------------|");
            }

            var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("New Zealand Standard Time");

            Console.WriteLine(timeZoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZoneAustralia);
            Console.WriteLine(horaAustralia);
        }
    }
}
