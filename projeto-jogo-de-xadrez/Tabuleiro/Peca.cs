namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.Posicao = null;
            this.Tab = tab;
            this.Cor = cor;
            this.QuantidadeMovimentos = 0;
        }
        public void IncrementarQuantidadeMovimentos()
        {
            QuantidadeMovimentos++;
        }
        public bool ExistemMovimentosPossiveis()
        {
            bool[,] matriz = MovimentosPossiveis();
            for (int i = 0; i < Tab.Linhas; i++){
                for (int j = 0; j < Tab.Colunas; j++){
                    if(matriz[i,j] == true){
                        return true;
                    }
                }
            }
            return false;
        }
        public abstract bool[,] MovimentosPossiveis();
    }
}