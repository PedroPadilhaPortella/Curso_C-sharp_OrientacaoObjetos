using tabuleiro;

namespace Xadrez{
    class PartidaDeXadrez
    {
        public Tabuleiro Table { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            Table = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Verde;//ou outra cor
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
        public void ValidarPosicaoDeOrigem(Posicao posicao)
        {
            if(Table.Peca(posicao) == null){
                throw new TabuleiroException("Não existe nenhuma peça nesta posição!");
            }
            if(JogadorAtual != Table.Peca(posicao).Cor){
                throw new TabuleiroException("A peça de origem escolhida não é sua!");
            }
            if(!Table.Peca(posicao).ExistemMovimentosPossiveis()){
                throw new TabuleiroException("Não há movimentos disponíveis para a peça de origem escolhida!");
            }
        }
        public void ValidarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if(!Table.Peca(origem).PodeMoverPara(destino)){
                throw new TabuleiroException("Posição de Destino Inválida!");
            }
        }
        public void RealizarJogada(Posicao origem, Posicao destino)
        {
            ExecutarMovimento(origem, destino);
            Turno++;
            MudarJogador();
        }
        private void MudarJogador()
        {
            if (JogadorAtual == Cor.Verde){
                JogadorAtual = Cor.Amarelo;
            }else{
                JogadorAtual = Cor.Verde;
            }
        }
        private void ColocarPecas()
        {
            Table.ColocarPeca(new Rei(Table, Cor.Amarelo) , new PosicaoXadrez('d', 8).ToPosicao());
            Table.ColocarPeca(new Torre(Table, Cor.Amarelo) , new PosicaoXadrez('c', 8).ToPosicao());
            Table.ColocarPeca(new Rei(Table, Cor.Verde) , new PosicaoXadrez('d', 1).ToPosicao());
            Table.ColocarPeca(new Torre(Table, Cor.Verde) , new PosicaoXadrez('c', 1).ToPosicao());
            Table.ColocarPeca(new Torre(Table, Cor.Verde) , new PosicaoXadrez('c', 2).ToPosicao());
            Table.ColocarPeca(new Torre(Table, Cor.Verde) , new PosicaoXadrez('d', 2).ToPosicao());
            Table.ColocarPeca(new Torre(Table, Cor.Verde) , new PosicaoXadrez('e', 2).ToPosicao());
            Table.ColocarPeca(new Torre(Table, Cor.Verde) , new PosicaoXadrez('e', 1).ToPosicao());
        }
    }
}