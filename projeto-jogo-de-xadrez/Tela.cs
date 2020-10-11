using System;
using System.Collections.Generic;
using tabuleiro;
using Xadrez;

namespace projeto_jogo_de_xadrez
{
    class Tela
    {
        public static void ImprimirPartida(PartidaDeXadrez partida)
        {
            ImprimirTabuleiro(partida.Table);
            Console.WriteLine();
            ImprimirPecasCapturadas(partida);
            Console.Write($"\nTurno: " + partida.Turno);
            Console.Write($"\nAguardando jogada: " + partida.JogadorAtual);
        }
        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            ConsoleColor aux = Console.ForegroundColor;
            Console.WriteLine("Peças Capturadas: ");

            Console.Write("Amarelas: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            ImprimirConjunto(partida.GetPecasCapturadas(Cor.Amarelo));
            Console.ForegroundColor = aux;

            Console.Write("\nVerdes: ");
            Console.ForegroundColor = ConsoleColor.Green;
            ImprimirConjunto(partida.GetPecasCapturadas(Cor.Verde));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }
        public static void ImprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach(Peca x in conjunto){
                Console.Write(x + " ");
            }
            Console.Write("]");
        }
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    ImprimirPeca(tab.Peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.Linhas; i++){
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++){
                    if(posicoesPossiveis[i, j] == true){
                        Console.BackgroundColor = fundoAlterado;
                    }else{
                        Console.BackgroundColor = fundoOriginal;
                    }
                    ImprimirPeca(tab.Peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }
        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
        public static void ImprimirPeca(Peca peca)
        {
            if(peca == null){
                Console.Write("- ");
            }else{
                if(peca.Cor == Cor.Verde){
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }else{
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
