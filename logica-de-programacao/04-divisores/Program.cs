using System;

namespace _04_divisores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            System.Console.WriteLine("----Divisores----");
            for (int i = 1; i < numero; i++) {
                if(numero % i == 0){
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
