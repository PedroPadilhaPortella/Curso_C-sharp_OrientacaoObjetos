using tabuleiro;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) {}
        public override string ToString()
        {
            return "R";
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

            //norte
            pos.DefinirValores(Posicao.Linha -1, Posicao.Coluna);
            if(Tab.PosicaoValida(pos) && PodeMover(pos)){
                matriz[pos.Linha, pos.Coluna] = true;
            }
            //nordeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if(Tab.PosicaoValida(pos) && PodeMover(pos)){
                matriz[pos.Linha, pos.Coluna] = true;
            }
            //leste
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if(Tab.PosicaoValida(pos) && PodeMover(pos)){
                matriz[pos.Linha, pos.Coluna] = true;
            }
            //sudeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if(Tab.PosicaoValida(pos) && PodeMover(pos)){
                matriz[pos.Linha, pos.Coluna] = true;
            }
            //sul
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if(Tab.PosicaoValida(pos) && PodeMover(pos)){
                matriz[pos.Linha, pos.Coluna] = true;
            }
            //sudoeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if(Tab.PosicaoValida(pos) && PodeMover(pos)){
                matriz[pos.Linha, pos.Coluna] = true;
            }
            //oeste
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if(Tab.PosicaoValida(pos) && PodeMover(pos)){
                matriz[pos.Linha, pos.Coluna] = true;
            }
            //noroeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if(Tab.PosicaoValida(pos) && PodeMover(pos)){
                matriz[pos.Linha, pos.Coluna] = true;
            }
            return matriz;
        }
    }
}