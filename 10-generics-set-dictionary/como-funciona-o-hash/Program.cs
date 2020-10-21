using System;
using System.Collections.Generic;
using como_funciona_o_hash.Entities;

namespace como_funciona_o_hash
{
    class Program
    {
        static void Main(string[] args)
        {
            //para tipos que tem a interface, GetHashCode e Equal, ele faz a comparação por elas
            HashSet<string> set = new HashSet<string>();
            set.Add("Maria");
            set.Add("José");
            System.Console.WriteLine("Contém Maria: " + set.Contains("Maria"));

            //Classes comparam por referencia de memória, a não ser que sejam implementadas as interfaces GetHashCode() e Equals()
            HashSet<Product> produtos = new HashSet<Product>();
            produtos.Add(new Product("TV", 900.0));
            produtos.Add(new Product("Notebook", 1200));
            Product prod = new Product("Notebook", 1200);
            Console.WriteLine("Contém Produtos: " + produtos.Contains(prod));



            //Structs comparam por conteúdo
            HashSet<Point> pontos = new HashSet<Point>();
            pontos.Add(new Point(4, 6));
            pontos.Add(new Point(5, 2));
            Point ponto = new Point(5, 2);
            Console.WriteLine("Contém Pontos: " + pontos.Contains(ponto));


        }
    }
}
