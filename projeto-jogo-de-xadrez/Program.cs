using System;
using tabuleiro;
using Xadrez;

namespace projeto_jogo_de_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Verde) , new Posicao(0, 0));
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Verde) , new Posicao(1, 3));
            tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Amarelo) , new Posicao(3, 5));
            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Amarelo) , new Posicao(6, 6));
            Tela.ImprimirTabuleiro(tabuleiro);
            }catch(TabuleiroException err)
            {
                System.Console.WriteLine(err.Message);
            }
        }
    }
}
