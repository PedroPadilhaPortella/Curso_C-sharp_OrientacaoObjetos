using System;

namespace timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Construtores do TimeSpan()
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(1, 11, 45);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 300);

            System.Console.WriteLine(t1);
            System.Console.WriteLine(t2);
            System.Console.WriteLine(t3);
            System.Console.WriteLine(t4);
            System.Console.WriteLine(t5);
            System.Console.WriteLine();

            TimeSpan tm1 = TimeSpan.FromDays(1.5);
            TimeSpan tm2 = TimeSpan.FromHours(1.5);
            TimeSpan tm3 = TimeSpan.FromMinutes(1.45);
            TimeSpan tm4 = TimeSpan.FromSeconds(15.5);
            TimeSpan tm5 = TimeSpan.FromMilliseconds(1);
            TimeSpan tm6 = TimeSpan.FromTicks(900000000L);

            System.Console.WriteLine(tm1);
            System.Console.WriteLine(tm2);
            System.Console.WriteLine(tm3);
            System.Console.WriteLine(tm4);
            System.Console.WriteLine(tm5);
            System.Console.WriteLine(tm6);
        }
    }
}
