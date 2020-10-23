using System;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 10, 22, 19, 10, 45);
            System.Console.WriteLine(dt.ElapsedTime());

            string str = "Gutter morgen Manner";
            Console.WriteLine(str.Cut(10));
            Console.WriteLine(str.Cut(4));
            Console.WriteLine(str.Cut(100));
        }
    }
}
