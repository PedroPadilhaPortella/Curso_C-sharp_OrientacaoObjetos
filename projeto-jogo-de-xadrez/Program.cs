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
                try{
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Table);
                    Console.Write($"\nTurno: " + partida.Turno);
                    Console.Write($"\nAguardando jogada: " + partida.JogadorAtual);
                    Console.Write("\n\nOrigem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    partida.ValidarPosicaoDeOrigem(origem);

                    bool[,] posicoesPossiveis = partida.Table.Peca(origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Table, posicoesPossiveis);
                    Console.Write("\nDestino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                    partida.ValidarPosicaoDeDestino(origem, destino);
                
                    partida.RealizarJogada(origem, destino);
                }catch(TabuleiroException err){
                Console.WriteLine(err.Message);
                Console.ReadLine();
                }
            }
            }catch(TabuleiroException err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
