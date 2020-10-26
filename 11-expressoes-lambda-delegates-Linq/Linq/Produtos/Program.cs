using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Produtos.Entities;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full path file: ");
            string path = Console.ReadLine();

            List<Product> lista = new List<Product>();

            try {
                using(StreamReader sr = File.OpenText(path)){
                    while(!sr.EndOfStream){
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        lista.Add(new Product(name, price));
                    }
                }

                var avg = lista.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                System.Console.WriteLine("Average Price: " + avg.ToString("F2", CultureInfo.InvariantCulture));

                var names = lista.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
                foreach (var product in names) {
                    Console.WriteLine(product);
                }

            } catch (IOException e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
