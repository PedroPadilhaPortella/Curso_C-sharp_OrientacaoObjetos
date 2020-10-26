using System;
using System.Collections.Generic;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> lista = new List<Product>();

            lista.Add(new Product("TV", 1200.00));
            lista.Add(new Product("Celular", 700.00));
            lista.Add(new Product("Notebook", 2400.00));
            lista.Add(new Product("Moto", 12000.00));

            //01 - usando a interface IComparable na classe Product
            //lista.Sort();

            //02 - usando delegate
            // lista.Sort(CompareProducts);
            
            //03 - usando expressão Lambda
            lista.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product item in lista) {
                Console.WriteLine(item);
            }
        }

        //delegate
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
