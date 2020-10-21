using System;
using System.Collections.Generic;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> produtos = new HashSet<string>();
            produtos.Add("IPhone");
            produtos.Add("Intel Core");
            produtos.Add("Notebook Lenovo");

            Console.Write(produtos.Contains("Intel Core") + ", ");
            Console.Write(produtos.Contains("Intel Core i5") + "\n");

            foreach (string produto in produtos){
                Console.WriteLine(produto);
            }
        }
    }
}
