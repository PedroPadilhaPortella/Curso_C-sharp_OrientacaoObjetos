using System;

namespace _04_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o valor máximo: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++) {
                if (i % 2 != 0) {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
