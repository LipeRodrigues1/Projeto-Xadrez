using Projeto_Xadrez.Tabuleiro;

public class Rei(Tabuleiro tab, Cor cor) : Peca(tab, cor)
{
    public override string ToString()
    {
        return "R";
    }

    private bool PodeMover(Posicao pos)
    {
        Peca p = Tab.peca(pos);
        return p == null || p.Cor != this.Cor;
    }

    public override bool[,] MovimentosPossiveis()
    {
        bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

        Posicao pos = new(0, 0);
        //Cima
        pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
        if (tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Linha, pos.Coluna] = true;
        }
        //Ne
        pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
        if (tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Linha, pos.Coluna] = true;
        }
        //Direita
        pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
        if (tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Linha, pos.Coluna] = true;
        }
        //Se
        pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
        if (tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Linha, pos.Coluna] = true;
        }
        //Abaixo
        pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
        if (tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Linha, pos.Coluna] = true;
        }
        //So
        pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna -1);
        if (tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Linha, pos.Coluna] = true;
        }
        // Esquerda
        pos.DefinirValores(Posicao.Linha, Posicao.Coluna-1);
        if (tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Linha, pos.Coluna] = true;
        }
        // no
        pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
        if (tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Linha, pos.Coluna] = true;
        }
        return mat;
    }
}

