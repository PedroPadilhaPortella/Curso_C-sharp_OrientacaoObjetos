using System;
using System.Collections.Generic;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 1200.00));
            list.Add(new Product("Celular", 700.00));
            list.Add(new Product("Notebook", 2400.00));
            list.Add(new Product("Moto", 12000.00));

            //01 - usando a interface IComparable na classe Product
            //list.Sort();

            //02 - usando delegate
            // list.Sort(CompareProducts);
            
            //03 - usando expressão Lambda
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product item in list) {
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
