using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Maria";
            string b = "José";
            System.Console.WriteLine($"{a} == {b}? {a.Equals(b)}");

            a = "Maria";
            b = "Maria";
            System.Console.WriteLine($"{a} == {b}? {a.Equals(b)}");

            a = "Maria";
            b = "José";
            System.Console.WriteLine(a.GetHashCode());
            System.Console.WriteLine(b.GetHashCode());

            a = "Maria";
            b = "Maria";
            System.Console.WriteLine(a.GetHashCode());
            System.Console.WriteLine(b.GetHashCode());
        }
    }
}
