using System;
using System.Linq;
using System.Collections.Generic;

namespace QueryLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Specify the data source
            int[] number = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            foreach(int i in number){
                Console.Write($"{i}  ");
            }

            //define the query expression, different ways

            // var result = number.Where(x => x % 2 == 0).Select(x => x * 10);
            IEnumerable<int> result = number.Where(x => x % 2 == 0).Select(x => x * 10);
            // List<int> result = number.Where(x => x % 2 == 0).Select(x => x * 10).ToList();

            Console.Write("\nValores pares multiplicados por 10:");
            //execute que query
            foreach (int x in result){
                Console.Write($"  {x}");
            }
        }
    }
}
