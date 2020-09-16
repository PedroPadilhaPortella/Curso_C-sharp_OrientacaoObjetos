using System;

namespace _01_diferenca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira 4 valores:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int diferenca = a * b - c * d;
            System.Console.WriteLine($"DIFERENCA: {diferenca}");
        }
    }
}
