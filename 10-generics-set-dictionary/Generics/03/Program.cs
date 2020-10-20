using _03.Services;
using _03.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(',');
                string name = vet[0];
                double price = double.Parse(vet[1], CultureInfo.InvariantCulture);
                products.Add(new Product(name, price));
            }
            CalculationService calcular = new CalculationService();
            Product max = calcular.Max(products);

            Console.WriteLine($"Max: {max}");
        }
    }
}
