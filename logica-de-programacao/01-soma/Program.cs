using System;

namespace _01_soma
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("SOMA -> digite dois valores inteiros:");
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int soma = valor1 + valor2;
            System.Console.WriteLine($"SOMA: {soma}");
        }
    }
}
