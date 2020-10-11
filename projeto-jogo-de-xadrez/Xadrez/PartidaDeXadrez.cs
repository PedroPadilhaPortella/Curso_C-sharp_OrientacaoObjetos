using System.Collections.Generic;
using tabuleiro;

namespace Xadrez{
    class PartidaDeXadrez
    {
        public Tabuleiro Table { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }
        private HashSet<Peca> Pecas;
        private HashSet<Peca> PecasCapturadas;

        public PartidaDeXadrez()
        {
            Table = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Verde;//ou outra cor
            Terminada = false;
            Pecas = new HashSet<Peca>();
            PecasCapturadas = new HashSet<Peca>();
            ColocarPecas();
        }
        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Table.RetirarPeca(origem);
            p.IncrementarQuantidadeMovimentos();
            Peca pecaCapturada = Table.RetirarPeca(destino);
            Table.ColocarPeca(p, destino);
            if(pecaCapturada != null){
                PecasCapturadas.Add(pecaCapturada);
            }
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
        public HashSet<Peca> GetPecasCapturadas(Cor cor)
        {
            HashSet<Peca> pecaCapturadaCor = new HashSet<Peca>();
            foreach(Peca x in PecasCapturadas){
                if(x.Cor == cor){
                    pecaCapturadaCor.Add(x);
                }
            }
            return pecaCapturadaCor;
        }
        public HashSet<Peca> PecasEmJogo(Cor cor)
        {
            HashSet<Peca> auxiliar = new HashSet<Peca>();
            foreach(Peca x in PecasCapturadas){
                if(x.Cor == cor){
                    auxiliar.Add(x);
                }
            }
            auxiliar.ExceptWith(GetPecasCapturadas(cor));
            return auxiliar;
        }
        public void ColocarNovaPeca(char coluna, int linha, Peca peca)
        {
            Table.ColocarPeca(peca, new PosicaoXadrez(coluna, linha).ToPosicao());
            Pecas.Add(peca);
        }
        private void ColocarPecas()
        {
            ColocarNovaPeca('c', 1, new Torre(Table, Cor.Verde));
            ColocarNovaPeca('c', 2, new Torre(Table, Cor.Verde));
            ColocarNovaPeca('d', 2, new Torre(Table, Cor.Verde));
            ColocarNovaPeca('e', 2, new Torre(Table, Cor.Verde));
            ColocarNovaPeca('e', 1, new Torre(Table, Cor.Verde));
            ColocarNovaPeca('d', 1, new Rei(Table, Cor.Verde));

            ColocarNovaPeca('c', 8, new Torre(Table, Cor.Amarelo));
            ColocarNovaPeca('c', 7, new Torre(Table, Cor.Amarelo));
            ColocarNovaPeca('d', 7, new Torre(Table, Cor.Amarelo));
            ColocarNovaPeca('e', 7, new Torre(Table, Cor.Amarelo));
            ColocarNovaPeca('e', 8, new Torre(Table, Cor.Amarelo));
            ColocarNovaPeca('d', 8, new Rei(Table, Cor.Amarelo));
        }
    }
}