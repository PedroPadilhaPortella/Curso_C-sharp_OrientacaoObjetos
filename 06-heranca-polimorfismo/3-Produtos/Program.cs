using System;
using Produtos.Entities;
using System.Collections.Generic;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> produtos = new List<Product>();

            Console.Write("Enter the numbeer of Products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Product #{i} data:");
                Console.Write($"Commom, used or imported (c/u/i)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(tipo == 'u'){
                    Console.Write("Manufactured Date (DD/MM/YYYY): ");
                    DateTime manufacturedDate = DateTime.Parse(Console.ReadLine());
                    produtos.Add(new UsedProduct(name, price, manufacturedDate));
                }else if(tipo == 'i'){
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    produtos.Add(new ImportedProduct(name, price, customsFee));
                }else{
                    produtos.Add(new Product(name, price));
                }

                foreach (Product produto in produtos)
                {
                    Console.WriteLine(produto.PriceTag());
                }
            }
        }
    }
}
