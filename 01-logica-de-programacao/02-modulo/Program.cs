using System;

namespace _02_modulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Positivo ou Negativo?");
            int valor = int.Parse(Console.ReadLine());
            if(valor > 0)
                System.Console.WriteLine($"{valor} é positivo");
            else
                System.Console.WriteLine($"{valor} é negativo");
        }
    }
}
