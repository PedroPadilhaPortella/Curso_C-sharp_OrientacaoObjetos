using System;

namespace _05_Fibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("Quantos valores da Sequencia de Fibonnaci serão impressos: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Sequencia:");

            for (int i = 0; i < n; i++) {
                Console.Write($"  {a}");
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
