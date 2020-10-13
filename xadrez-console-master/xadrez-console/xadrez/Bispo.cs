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
            Posicao pos = new Posicao(0, 0);

            // NO
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Table.PosicaoValida(pos) && PodeMover(pos)) {
                mat[Posicao.Linha, Posicao.Coluna] = true;
                if (Table.Peca(pos) != null && Table.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            // NE
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Table.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Table.Peca(pos) != null && Table.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);
            }

            // SE
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Table.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Table.Peca(pos) != null && Table.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna + 1);
            }

            // SO
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Table.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Table.Peca(pos) != null && Table.Peca(pos).Cor != Cor) {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
            }
            return mat;
        }
    }
}
