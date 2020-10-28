using System;
using System.Globalization;

namespace _01_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Notebook", 2000.00, 10);

            p.Nome ="Notebook Lenovo T480";

            System.Console.WriteLine(p.Nome);
            System.Console.WriteLine(p.Preco);
            System.Console.WriteLine(p.Quantidade);

            //Podemos dividir uma classe a partir o prefixo partial na classe, para que melhor possa ser organizada.
        }
    }
}
