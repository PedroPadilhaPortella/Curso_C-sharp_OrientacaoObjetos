using System;
using System.Globalization;

namespace _01_produto
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade) {
            this._nome = nome;
            this._preco = preco;
            this._quantidade = quantidade;
        }
//Getter e Setters usando Properties
        public string Nome{
            get{
                return _nome;
            }
            set{
                if (value != null && value.Length > 1)
                {
                    this._nome = value;
                }
            }
        }
        public double Preco{
            get{
                return _preco;
            }
            set{
                this._preco = value;
            }
        }
        public int Quantidade{
            get{
                return _quantidade;
            }
            set{
                this._quantidade = value;
            }
        }
    }
}