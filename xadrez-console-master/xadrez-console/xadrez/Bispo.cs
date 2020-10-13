using tabuleiro;

namespace xadrez {

    class Bispo : Peca {

        public Bispo(Tabuleiro table, Cor cor) : base(table, cor) {
        }

        public override string ToString() {
            return "B";
        }

        private bool PodeMover(Posicao posicao) {
            Peca peca = Table.Peca(posicao);
            return peca == null || peca.Cor != Cor;
        }
        
        public override bool[,] MovimentosPossiveis() {
            bool[,] mat = new bool[Table.Linhas, Table.Colunas];

            Posicao posicao = new Posicao(0, 0);

            // NO
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Table.PosicaoValida(posicao) && PodeMover(posicao)) {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Table.Peca(posicao) != null && Table.Peca(posicao).Cor != Cor) {
                    break;
                }
                posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
            }

            // NE
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha - 1, pos.coluna + 1);
            }

            // SE
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha + 1, pos.coluna + 1);
            }

            // SO
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.definirValores(pos.linha + 1, pos.coluna - 1);
            }

            return mat;
        }
    }
}
