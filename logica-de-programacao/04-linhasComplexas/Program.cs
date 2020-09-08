using System;

namespace _04_linhasComplexas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numero Complexo: ");
            double numero = double.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++) {
                double primeiro = i;
                double segundo = Math.Pow(i, 2);
                double terceiro = Math.Pow(i, 3);
                System.Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
        }
    }
}
