using System;
using System.Globalization;

namespace _01_produto
{
    class Produto
    {
//Usando Auto Properties, no caso do nome, não da pra usar porque ele tem uma logica aplicada nele mesmo
        private string _nome;
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade){
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }
        //Getter e Setters usando Properties
        public string Nome{
            get{
                return _nome;
            }
            set{
                if (value != null && value.Length > 1){
                    this._nome = value;
                }
            }
        }
    }
}