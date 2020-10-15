namespace tabuleiro {
    abstract class Peca {

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeDeMovimentos { get; protected set; }
        public Tabuleiro Table { get; protected set; }
         
        public Peca(Tabuleiro table, Cor cor) {
            this.Posicao = null;
            this.Table = table;
            this.Cor = cor;
            this.QuantidadeDeMovimentos = 0;
        }

        public void IncrementarQuantidadeDeMovimentos() {
            QuantidadeDeMovimentos++;
        }

        public void DecrementarQuantidadeDeMovimentos() {
            QuantidadeDeMovimentos--;
        }

        public bool ExisteMovimentosPossiveis() {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Table.Linhas; i++) {
                for (int j = 0; j < Table.Colunas; j++) {
                    if (mat[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool MovimentoPossivel(Posicao posicao) {
            return MovimentosPossiveis()[posicao.Linha, posicao.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
