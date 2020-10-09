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
            PartidaDeXadrez partida = new PartidaDeXadrez();
            while (!partida.Terminada)
            {
                Console.Clear();
                Tela.ImprimirTabuleiro(partida.Table);
                Console.Write("\nOrigem: ");
                Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                bool[,] posicoesPossiveis = partida.Table.Peca(origem).MovimentosPossiveis();

                Console.Clear();
                Tela.ImprimirTabuleiro(partida.Table, posicoesPossiveis);
                Console.Write("\nDestino: ");
                Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                
                partida.ExecutarMovimento(origem, destino);
            }
            }catch(TabuleiroException err)
            {
                System.Console.WriteLine(err.Message);
            }
        }
    }
}
