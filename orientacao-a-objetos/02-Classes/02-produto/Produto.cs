using System;
using System.Globalization;

namespace _01_produto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() {
            this.Quantidade = 10;
        } //construtor padrão, sem nenhum argumento
        public Produto(string nome, double preco) : this()
        {//referencia o construtor padrão nesse construtor
            //Sobrecarga de Construtor
            this.Nome = nome;
            this.Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            this.Quantidade = quantidade;
        }
        public double TotalEmEstoque()
        {
            return this.Preco * this.Quantidade;
        }
        public void AdicionarProduto()
        {
            System.Console.Write("Digite a quantidade de Produtos a adicionar no Estoque:");
            int quantidade = int.Parse(Console.ReadLine());
            this.Quantidade += quantidade;
        }
        public void RemoverProduto()
        {
            System.Console.Write("Digite a quantidade de Produtos a remover do Estoque:");
            int quantidade = int.Parse(Console.ReadLine());
            this.Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"Dados do Produto: {this.Nome}, R$ {this.Preco.ToString("F2", CultureInfo.InvariantCulture)}, {this.Quantidade} unidades.\nTotal = R$ {TotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}