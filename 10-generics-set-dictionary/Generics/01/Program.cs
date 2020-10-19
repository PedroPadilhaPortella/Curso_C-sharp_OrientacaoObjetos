using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++){
                Console.Write($"{i + 1}) ");
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine($"First: {printService.First()}");
        }
    }
}
