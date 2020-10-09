using tabuleiro;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) {}
        public override string ToString()
        {
            return "T";
        }
        private bool PodeMover(Posicao posicao)
        {
            Peca rei = Tab.Peca(posicao);
            return rei == null || rei.Cor != this.Cor;
        }
        public override bool[,] MovimentosPossiveis()
        {
            bool [,] matriz = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos= new Posicao(0, 0);

            //top
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while(Tab.PosicaoValida(pos) && PodeMover(pos)){
                matriz[pos.Linha, pos.Coluna] = true;
                if(Tab.Peca(pos) != null && Tab.Peca(pos).Cor != this.Cor){
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }
            //right
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while(Tab.PosicaoValida(pos) && PodeMover(pos)){
                matriz[pos.Linha, pos.Coluna] = true;
                if(Tab.Peca(pos) != null && Tab.Peca(pos).Cor != this.Cor){
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }
            //bottom
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while(Tab.PosicaoValida(pos) && PodeMover(pos)){
                matriz[pos.Linha, pos.Coluna] = true;
                if(Tab.Peca(pos) != null && Tab.Peca(pos).Cor != this.Cor){
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }
            //left
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while(Tab.PosicaoValida(pos) && PodeMover(pos)){
                matriz[pos.Linha, pos.Coluna] = true;
                if(Tab.Peca(pos) != null && Tab.Peca(pos).Cor != this.Cor){
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }
            return matriz;
        }
    }
}