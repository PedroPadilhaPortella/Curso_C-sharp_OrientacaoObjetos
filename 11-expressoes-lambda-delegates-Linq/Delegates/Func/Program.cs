using System;
using System.Collections.Generic;
using Func.Entities;
using System.Linq;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

    //01- Usando um delegate de Func
            // List<string> resultado = list.Select(NameToUpper).ToList();

    //02 - Usando Func
            // Func<Product, string> func = p => p.Name.ToUpper();
            // List<string> resultado = list.Select(func).ToList();

    //03- Usando apenas Lamba expression
            List<string> resultado = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string produto in resultado) {
                Console.WriteLine(produto);
            }
        }

        static string NameToUpper(Product product) {
            return product.Name.ToUpper();
        }
    }
}
