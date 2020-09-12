using System;
using System.Globalization;

namespace _01_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Notebook", 2000.00, 10);

            p.SetNome("Notebook Lenovo T480");

            System.Console.WriteLine(p);
            System.Console.WriteLine(p.GetPreco());
        }
    }
}
