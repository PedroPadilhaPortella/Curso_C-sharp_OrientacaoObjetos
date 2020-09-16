using System;

namespace _04_fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fatorial: ");
            int numero = int.Parse(Console.ReadLine());
            int fat = 1;
            for (int i = 1; i <= numero ; i++) {
                fat *= i;
            }

            System.Console.WriteLine($"Fatorial de {numero} é {fat}");
        }
    }
}
