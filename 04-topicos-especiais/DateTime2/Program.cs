using System;

namespace datetime2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            // Conversores de Data
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            System.Console.WriteLine();

            DateTime x = new DateTime(2000, 1, 1, 00, 00, 00, 500);

            DateTime y1 = x.AddHours(3);
            DateTime y2 = x.AddMinutes(20);
            DateTime y3 = x.AddDays(7);
            DateTime y4 = x.AddMonths(9);
            DateTime y5 = x.AddYears(20);
            DateTime y6 = x.AddSeconds(30);
            System.Console.WriteLine(y1);
            System.Console.WriteLine(y2);
            System.Console.WriteLine(y3);
            System.Console.WriteLine(y4);
            System.Console.WriteLine(y5);
            System.Console.WriteLine(y6);
            System.Console.WriteLine();

            DateTime data1 = new DateTime(2000, 11, 30);
            DateTime data2 = new DateTime(2000, 8, 20);

            TimeSpan diff = data1.Subtract(data2);
            System.Console.WriteLine(diff);
        }
    }
}
