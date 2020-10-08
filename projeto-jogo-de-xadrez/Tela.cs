using System;
using tabuleiro;
using Xadrez;

namespace projeto_jogo_de_xadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++){
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++){
                    if(tab.Peca(i, j) == null){
                        Console.Write("- ");
                    }
                    Console.Write(tab.Peca(i, j) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a  b  c  d  e  f  g  h");
        }
    }
}