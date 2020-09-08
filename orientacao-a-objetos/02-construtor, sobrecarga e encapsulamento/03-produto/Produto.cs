using System;
using System.Globalization;

namespace _01_produto
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() {
            this._quantidade = 10;
        }
        public Produto(string nome, double preco) : this()
        {
            this._nome = nome;
            this._preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            this._quantidade = quantidade;
        }
//Getter e Setters
    public string GetNome() {
        return _nome;
    }
    public void SetNome(string nome) {
        if(nome != null && nome.Length > 1){
            this._nome = nome;
        }
    }
    public double GetPreco() {
        return _preco;
    }
    public void SetPreco(double preco) {
        this._preco = preco;
    }
    public int GetQuantidade() {
        return _quantidade;
    }
    public void SetQuantidade(int quantidade) {
        this._quantidade = quantidade;
    }

//Métodos da classe
        public double TotalEmEstoque()
        {
            return this._preco * this._quantidade;
        }
        public void AdicionarProduto()
        {
            System.Console.Write("Digite a quantidade de Produtos a adicionar no Estoque:");
            int quantidade = int.Parse(Console.ReadLine());
            this._quantidade += quantidade;
        }
        public void RemoverProduto()
        {
            System.Console.Write("Digite a quantidade de Produtos a remover do Estoque:");
            int quantidade = int.Parse(Console.ReadLine());
            this._quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"Dados do Produto: {this._nome}, R$ {this._preco.ToString("F2", CultureInfo.InvariantCulture)}, {this._quantidade} unidades.\nTotal = R$ {TotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}