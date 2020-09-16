using System;

namespace _02_par_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Par ou Impar?");
            int valor = int.Parse(Console.ReadLine());
            if (valor % 2 == 0)
                System.Console.WriteLine($"{valor} é par");
            else
                System.Console.WriteLine($"{valor} é impar");
        }
    }
}
