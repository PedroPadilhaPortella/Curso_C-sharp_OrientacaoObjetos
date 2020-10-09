using tabuleiro;

namespace Xadrez{
    class PartidaDeXadrez
    {
        public Tabuleiro Table { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }
        public PartidaDeXadrez()
        {
            Table = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branco;//ou outra cor
            Terminada = false;
            ColocarPecas();
        }
        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Table.RetirarPeca(origem);
            p.IncrementarQuantidadeMovimentos();
            Peca pecaCapturada = Table.RetirarPeca(destino);
            Table.ColocarPeca(p, destino);
        }
        private void ColocarPecas()
        {
            Table.ColocarPeca(new Torre(Table, Cor.Verde) , new PosicaoXadrez('c', 1).ToPosicao());
            Table.ColocarPeca(new Rei(Table, Cor.Verde) , new PosicaoXadrez('d', 1).ToPosicao());
            Table.ColocarPeca(new Rei(Table, Cor.Amarelo) , new PosicaoXadrez('d', 8).ToPosicao());
            Table.ColocarPeca(new Torre(Table, Cor.Amarelo) , new PosicaoXadrez('c', 8).ToPosicao());
        }
    }
}