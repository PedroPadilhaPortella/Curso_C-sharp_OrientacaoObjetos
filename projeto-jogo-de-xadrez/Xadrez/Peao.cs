using tabuleiro;

namespace xadrez {

    class Peao : Peca {

        private PartidaDeXadrez partida;

        public Peao(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor) {
            this.partida = partida;
        }

        public override string ToString() {
            return "P";
        }

        private bool ExisteInimigo(Posicao pos) {
            Peca p = Table.Peca(pos);
            return p != null && p.Cor != Cor;
        }

        private bool Livre(Posicao pos) {
            return Table.Peca(pos) == null;
        }

        public override bool[,] MovimentosPossiveis() {
            bool[,] mat = new bool[Table.Linhas, Table.Colunas];

            Posicao pos = new Posicao(0, 0);

            if (Cor == Cor.Branca) {
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
                if (Table.PosicaoValida(pos) && Livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna);
                Posicao p2 = new Posicao(Posicao.Linha - 1, Posicao.Coluna);
                if (Table.PosicaoValida(p2) && Livre(p2) && Table.PosicaoValida(pos) && Livre(pos) && QuantidadeDeMovimentos == 0) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Table.PosicaoValida(pos) && ExisteInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Table.PosicaoValida(pos) && ExisteInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                // #jogadaespecial en passant
                if (Posicao.Linha == 3) {
                    Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    if (Table.PosicaoValida(esquerda) && ExisteInimigo(esquerda) && Table.Peca(esquerda) == partida.VulneravelEnPassant) {
                        mat[esquerda.Linha - 1, esquerda.Coluna] = true;
                    }
                    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    if (Table.PosicaoValida(direita) && ExisteInimigo(direita) && Table.Peca(direita) == partida.VulneravelEnPassant) {
                        mat[direita.Linha - 1, direita.Coluna] = true;
                    }
                }
            }
            else {
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
                if (Table.PosicaoValida(pos) && Livre(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna);
                Posicao p2 = new Posicao(Posicao.Linha + 1, Posicao.Coluna);
                if (Table.PosicaoValida(p2) && Livre(p2) && Table.PosicaoValida(pos) && Livre(pos) && QuantidadeDeMovimentos == 0) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Table.PosicaoValida(pos) && ExisteInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Table.PosicaoValida(pos) && ExisteInimigo(pos)) {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                // #jogadaespecial en passant
                if (Posicao.Linha == 4) {
                    Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    if (Table.PosicaoValida(esquerda) && ExisteInimigo(esquerda) && Table.Peca(esquerda) == partida.VulneravelEnPassant) {
                        mat[esquerda.Linha + 1, esquerda.Coluna] = true;
                    }
                    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    if (Table.PosicaoValida(direita) && ExisteInimigo(direita) && Table.Peca(direita) == partida.VulneravelEnPassant) {
                        mat[direita.Linha + 1, direita.Coluna] = true;
                    }
                }
            }
            return mat;
        }
    }
}
