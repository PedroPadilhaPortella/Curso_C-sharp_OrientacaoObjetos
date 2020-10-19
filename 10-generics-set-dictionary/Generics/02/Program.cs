using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            PrintService<string> printService = new PrintService<string>();
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++){
                Console.Write($"{i + 1}) ");
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine($"First: {printService.First()}");

            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
