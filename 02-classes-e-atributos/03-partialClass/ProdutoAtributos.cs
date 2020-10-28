using System;
using System.Globalization;

namespace _01_produto
{
    partial class Produto
    {
                public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() { } //construtor padrão, sem nenhum argumento
        public Produto(string nome, double preco)
        {
            //Sobrecarga de Construtor
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}