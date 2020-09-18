using System;

namespace datetimekind
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2020, 09, 17, 23, 15, 20, DateTimeKind.Local);
            DateTime d2 = new DateTime(2020, 09, 17, 23, 15, 20, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2020, 09, 17, 23, 15, 20, DateTimeKind.Unspecified);
            Console.WriteLine(d1);
            Console.WriteLine(d1.Kind);//data local, que pode ser convertida em utc
            Console.WriteLine($"LocalTime: {d1.ToLocalTime()}");
            Console.WriteLine($"UniversalTime {d1.ToUniversalTime()}");

            Console.WriteLine(d2);
            Console.WriteLine(d2.Kind);//data utc, que pode ser convertida em local
            Console.WriteLine($"LocalTime: {d2.ToLocalTime()}");
            Console.WriteLine($"UniversalTime {d2.ToUniversalTime()}");

            Console.WriteLine(d3);
            Console.WriteLine(d3.Kind); //data não especificada, então pode ser convertida para local e utc
            Console.WriteLine($"LocalTime: {d3.ToLocalTime()}");
            Console.WriteLine($"UniversalTime {d3.ToUniversalTime()}");
        }
    }
}
