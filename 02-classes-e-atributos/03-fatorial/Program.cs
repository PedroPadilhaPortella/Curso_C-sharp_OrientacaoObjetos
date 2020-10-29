using System;

namespace _03_fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Calcule um fatorial: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write($"O fatorial de {i} é {Fatorial(i)}");
            
        }

        static int Fatorial(int num)
        {
            if(num <= 0){
                return 1;
            }
            return num * Fatorial(num - 1);
        }
    }
}
