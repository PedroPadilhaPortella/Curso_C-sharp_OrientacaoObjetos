using System;
using System.Globalization;

namespace _01_estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double TotalEmEstoque(){
            return Preco * Quantidade;
        }
        public void AdicionarProduto(){
            System.Console.Write("Digite a quantidade de Produtos a adicionar no Estoque:");
            int quantidade = int.Parse(Console.ReadLine());
            Quantidade += quantidade;

        }
        public void RemoverProduto(){
            System.Console.Write("Digite a quantidade de Produtos a remover do Estoque:");
            int quantidade = int.Parse(Console.ReadLine());
            Quantidade -= quantidade;
        }

        public override string ToString(){
            return $"Dados do Produto: {Nome}, R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades.\nTotal = R$ {TotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}