using System;
using System.Globalization;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(2020, 09, 16, 0, 45, 11);
            DateTime d3 = new DateTime(2020, 09, 16, 0, 45, 11, 500);
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;


            System.Console.WriteLine(d1);
            System.Console.WriteLine(d2);
            System.Console.WriteLine(d3);
            System.Console.WriteLine(d4);
            System.Console.WriteLine(d5);
            System.Console.WriteLine(d6);
            System.Console.WriteLine();

            DateTime d7 = DateTime.Parse("2001-06-10 10:21:09");
            DateTime d8 = DateTime.Parse("15/09/2009 12:00:12");
            DateTime d9 = DateTime.ParseExact("2020-09-16", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d10 = DateTime.ParseExact("15/08/2019 13:10:11", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            System.Console.WriteLine(d7);
            System.Console.WriteLine(d8);
            System.Console.WriteLine(d9);
            System.Console.WriteLine(d10);
        }
    }
}
