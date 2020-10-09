namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;
        
        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            Pecas = new Peca[Linhas, Colunas];
        }
        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
        public Peca Peca(Posicao posicao)
        {
            return Pecas[posicao.Linha, posicao.Coluna];
        }
        public bool ExistenciaDaPeca(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return Peca(posicao) != null;
        }

        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if(ExistenciaDaPeca(posicao)){
                throw new TabuleiroException("Já existe uma Peça nessa Posição!");
            }
            Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }
        public Peca RetirarPeca(Posicao posicao)
        {
            if(Peca(posicao) == null){
                return null;
            }
            Peca auxiliar = Peca(posicao);
            auxiliar.Posicao = null;
            Pecas[posicao.Linha, posicao.Coluna] = null;
            return auxiliar;
        }
        public bool PosicaoValida(Posicao posicao)
        {
            if(posicao.Linha < 0 || posicao.Linha >= Linhas || posicao.Coluna < 0 || posicao.Coluna >= Colunas){
                return false;
            }
            return true;
        }
        public void ValidarPosicao(Posicao posicao)
        {
            if(!PosicaoValida(posicao)){
                throw new TabuleiroException("Posição Inválida!");
            }
        }
    }
}