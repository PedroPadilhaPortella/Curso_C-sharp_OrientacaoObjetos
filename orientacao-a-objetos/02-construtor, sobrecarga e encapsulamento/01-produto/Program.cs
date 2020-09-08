using System;
using System.Globalization;

namespace _01_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com os dados do produto:\nNome:");
            string nome = Console.ReadLine();
            System.Console.Write("Preço:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Quantidade em Estoque:");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p1 = new Produto(nome, preco, quantidade);

            p1.AdicionarProduto();
            System.Console.WriteLine(p1);
            p1.RemoverProduto();
            System.Console.WriteLine(p1);



            Console.Write("Entre com os dados do produto:\nNome:");
            nome = Console.ReadLine();
            System.Console.Write("Preço:");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p2 = new Produto(nome, preco);
            System.Console.WriteLine(p2);

            System.Console.Write("Quantidade em Estoque:");
            quantidade = int.Parse(Console.ReadLine());
            p2.Quantidade = quantidade;
            System.Console.WriteLine(p2);


            Produto p3 = new Produto { Nome = "NotebooK Intel", Preco = 500.00, Quantidade = 15};
            System.Console.WriteLine(p3);
        }
    }
}
