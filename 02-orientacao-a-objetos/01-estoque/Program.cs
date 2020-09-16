using System;
using System.Globalization;

namespace _01_estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.Write("Entre com os dados do produto:\nNome:");
            p.Nome = Console.ReadLine();
            System.Console.Write("Preço:");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Quantidade em Estoque:");
            p.Quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProduto();
            System.Console.WriteLine(p);
            p.RemoverProduto();
            System.Console.WriteLine(p);
            
        }
    }
}
