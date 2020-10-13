using System.Collections.Generic;
using tabuleiro;

namespace xadrez {
    class PartidaDeXadrez {

        public Tabuleiro Table { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }
        private HashSet<Peca> Pecas;
        private HashSet<Peca> Capturadas;
        public bool Xeque { get; private set; }
        public Peca VulneravelEnPassant { get; private set; }

        public PartidaDeXadrez() {
            Table = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            Xeque = false;
            VulneravelEnPassant = null;
            Pecas = new HashSet<Peca>();
            Capturadas = new HashSet<Peca>();
            colocarPecas();
        }

        public Peca ExecutarMovimento(Posicao origem, Posicao destino) {
            Peca peca = Table.RetirarPeca(origem);
            peca.IncrementarQuantidadeDeMovimentos();
            Peca pecaCapturada = Table.RetirarPeca(destino);
            Table.ColocarPeca(peca, destino);
            if (pecaCapturada != null) {
                Capturadas.Add(pecaCapturada);
            }

            // #jogadaespecial roque pequeno
            if (peca is Rei && destino.Coluna == origem.Coluna + 2) {
                Posicao origemT = new Posicao(origem.Linha, origem.Coluna + 3);
                Posicao destinoT = new Posicao(origem.Linha, origem.Coluna + 1);
                Peca T = Table.RetirarPeca(origemT);
                T.IncrementarQuantidadeDeMovimentos();
                Table.ColocarPeca(T, destinoT);
            }

            // #jogadaespecial roque grande
            if (peca is Rei && destino.Coluna == origem.Coluna - 2) {
                Posicao origemT = new Posicao(origem.Linha, origem.Coluna - 4);
                Posicao destinoT = new Posicao(origem.Linha, origem.Coluna - 1);
                Peca T = Table.RetirarPeca(origemT);
                T.IncrementarQuantidadeDeMovimentos();
                Table.ColocarPeca(T, destinoT);
            }

            // #jogadaespecial en passant
            if (peca is Peao) {
                if (origem.Coluna != destino.Coluna && pecaCapturada == null) {
                    Posicao posP;
                    if (peca.Cor == Cor.Branca) {
                        posP = new Posicao(destino.Linha + 1, destino.Coluna);
                    }
                    else {
                        posP = new Posicao(destino.Linha - 1, destino.Coluna);
                    }
                    pecaCapturada = Table.RetirarPeca(posP);
                    Capturadas.Add(pecaCapturada);
                }
            }
            return pecaCapturada;
        }

        public void DesfazerMovimento(Posicao origem, Posicao destino, Peca pecaCapturada) {
            Peca peca = Table.RetirarPeca(destino);
            peca.DecrementarQuantidadeDeMovimentos();
            if (pecaCapturada != null) {
                Table.ColocarPeca(pecaCapturada, destino);
                Capturadas.Remove(pecaCapturada);
            }
            Table.ColocarPeca(peca, origem);

            // #jogadaespecial roque pequeno
            if (peca is Rei && destino.Coluna == origem.Coluna + 2) {
                Posicao origemT = new Posicao(origem.Linha, origem.Coluna + 3);
                Posicao destinoT = new Posicao(origem.Linha, origem.Coluna + 1);
                Peca T = Table.RetirarPeca(destinoT);
                T.DecrementarQuantidadeDeMovimentos();
                Table.ColocarPeca(T, origemT);
            }

            // #jogadaespecial roque grande
            if (peca is Rei && destino.Coluna == origem.Coluna - 2) {
                Posicao origemT = new Posicao(origem.Linha, origem.Coluna - 4);
                Posicao destinoT = new Posicao(origem.Linha, origem.Coluna - 1);
                Peca T = Table.RetirarPeca(destinoT);
                T.DecrementarQuantidadeDeMovimentos();
                Table.ColocarPeca(T, origemT);
            }

            // #jogadaespecial en passant
            if (peca is Peao) {
                if (origem.Coluna != destino.Coluna && pecaCapturada == VulneravelEnPassant) {
                    Peca peao = Table.RetirarPeca(destino);
                    Posicao posP;
                    if (peca.Cor == Cor.Branca) {
                        posP = new Posicao(3, destino.Coluna);
                    }
                    else {
                        posP = new Posicao(4, destino.Coluna);
                    }
                    Table.ColocarPeca(peao, posP);
                }
            }
        }

        public void RealizarJogada(Posicao origem, Posicao destino) {
            Peca pecaCapturada = ExecutarMovimento(origem, destino);
            if (EstaEmXeque(JogadorAtual)) {
                DesfazerMovimento(origem, destino, pecaCapturada);
                throw new TabuleiroException("Você não pode se colocar em xeque!");
            }
            Peca peca = Table.Peca(destino);
            // #jogadaespecial promocao
            if (peca is Peao) {
                if ((peca.Cor == Cor.Branca && destino.Linha == 0) || (peca.Cor == Cor.Preta && destino.Linha == 7)) {
                    peca = Table.RetirarPeca(destino);
                    Pecas.Remove(peca);
                    Peca dama = new Dama(Table, peca.Cor);
                    Table.ColocarPeca(dama, destino);
                    Pecas.Add(dama);
                }
            }
            if (EstaEmXeque(Adversaria(JogadorAtual))) {
                Xeque = true;
            }
            else {
                Xeque = false;
            }
            if (TesteXequemate(Adversaria(JogadorAtual))) {
                Terminada = true;
            }
            else {
                Turno++;
                MudarJogador();
            }
            // #jogadaespecial en passant
            if (peca is Peao && (destino.Linha == origem.Linha - 2 || destino.Linha == origem.Linha + 2)) {
                VulneravelEnPassant = peca;
            }
            else {
                VulneravelEnPassant = null;
            }
        }

        public void ValidarPosicaoDeOrigem(Posicao posicao) {
            if (Table.Peca(posicao) == null) {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida!");
            }
            if (JogadorAtual != Table.Peca(posicao).Cor) {
                throw new TabuleiroException("A peça de origem escolhida não é sua!");
            }
            if (!Table.Peca(posicao).ExisteMovimentosPossiveis()) {
                throw new TabuleiroException("Não há movimentos possíveis para a peça de origem escolhida!");
            }
        }

        public void ValidarPosicaoDeDestino(Posicao origem, Posicao destino) {
            if (!Table.Peca(origem).MovimentoPossivel(destino)) {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }

        private void MudarJogador() {
            if (JogadorAtual == Cor.Branca) {
                JogadorAtual = Cor.Preta;
            }
            else {
                JogadorAtual = Cor.Branca;
            }
        }

        public HashSet<Peca> PecasCapturadas(Cor cor) {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in Capturadas) {
                if (x.Cor == cor) {
                    aux.Add(x);
                }
            }
            return aux;
        }

        public HashSet<Peca> PecasEmJogo(Cor cor) {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in Pecas) {
                if (x.Cor == cor) {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(PecasCapturadas(cor));
            return aux;
        }

        private Cor Adversaria(Cor cor) {
            if (cor == Cor.Branca) {
                return Cor.Preta;
            }
            else {
                return Cor.Branca;
            }
        }

        private Peca Rei(Cor cor) {
            foreach (Peca x in PecasEmJogo(cor)) {
                if (x is Rei) {
                    return x;
                }
            }
            return null;
        }

        public bool EstaEmXeque(Cor cor) {
            Peca R = Rei(cor);
            if (R == null) {
                throw new TabuleiroException("Não tem rei da cor " + cor + " no tabuleiro!");
            }
            foreach (Peca x in PecasEmJogo(Adversaria(cor))) {
                bool[,] mat = x.MovimentosPossiveis();
                if (mat[R.Posicao.Linha, R.Posicao.Coluna]) {
                    return true;
                }
            }
            return false;
        }

        public bool TesteXequemate(Cor cor) {
            if (!EstaEmXeque(cor)) {
                return false;
            }
            foreach (Peca x in PecasEmJogo(cor)) {
                bool[,] mat = x.MovimentosPossiveis();
                for (int i = 0; i < Table.Linhas; i++) {
                    for (int j = 0; j < Table.Colunas; j++) {
                        if (mat[i, j]) {
                            Posicao origem = x.Posicao;
                            Posicao destino = new Posicao(i, j);
                            Peca pecaCapturada = ExecutarMovimento(origem, destino);
                            bool testeXeque = EstaEmXeque(cor);
                            DesfazerMovimento(origem, destino, pecaCapturada);
                            if (!testeXeque) {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        public void ColocarNovaPeca(char coluna, int linha, Peca peca) {
            Table.ColocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
            Pecas.Add(peca);
        }

        private void colocarPecas() {
            ColocarNovaPeca('a', 1, new Torre(Table, Cor.Branca));
            ColocarNovaPeca('b', 1, new Cavalo(Table, Cor.Branca));
            ColocarNovaPeca('c', 1, new Bispo(Table, Cor.Branca));
            ColocarNovaPeca('d', 1, new Dama(Table, Cor.Branca));
            ColocarNovaPeca('e', 1, new Rei(Table, Cor.Branca, this));
            ColocarNovaPeca('f', 1, new Bispo(Table, Cor.Branca));
            ColocarNovaPeca('g', 1, new Cavalo(Table, Cor.Branca));
            ColocarNovaPeca('h', 1, new Torre(Table, Cor.Branca));
            ColocarNovaPeca('a', 2, new Peao(Table, Cor.Branca, this));
            ColocarNovaPeca('b', 2, new Peao(Table, Cor.Branca, this));
            ColocarNovaPeca('c', 2, new Peao(Table, Cor.Branca, this));
            ColocarNovaPeca('d', 2, new Peao(Table, Cor.Branca, this));
            ColocarNovaPeca('e', 2, new Peao(Table, Cor.Branca, this));
            ColocarNovaPeca('f', 2, new Peao(Table, Cor.Branca, this));
            ColocarNovaPeca('g', 2, new Peao(Table, Cor.Branca, this));
            ColocarNovaPeca('h', 2, new Peao(Table, Cor.Branca, this));

            ColocarNovaPeca('a', 8, new Torre(Table, Cor.Preta));
            ColocarNovaPeca('b', 8, new Cavalo(Table, Cor.Preta));
            ColocarNovaPeca('c', 8, new Bispo(Table, Cor.Preta));
            ColocarNovaPeca('d', 8, new Dama(Table, Cor.Preta));
            ColocarNovaPeca('e', 8, new Rei(Table, Cor.Preta, this));
            ColocarNovaPeca('f', 8, new Bispo(Table, Cor.Preta));
            ColocarNovaPeca('g', 8, new Cavalo(Table, Cor.Preta));
            ColocarNovaPeca('h', 8, new Torre(Table, Cor.Preta));
            ColocarNovaPeca('a', 7, new Peao(Table, Cor.Preta, this));
            ColocarNovaPeca('b', 7, new Peao(Table, Cor.Preta, this));
            ColocarNovaPeca('c', 7, new Peao(Table, Cor.Preta, this));
            ColocarNovaPeca('d', 7, new Peao(Table, Cor.Preta, this));
            ColocarNovaPeca('e', 7, new Peao(Table, Cor.Preta, this));
            ColocarNovaPeca('f', 7, new Peao(Table, Cor.Preta, this));
            ColocarNovaPeca('g', 7, new Peao(Table, Cor.Preta, this));
            ColocarNovaPeca('h', 7, new Peao(Table, Cor.Preta, this));
        }
    }
}
