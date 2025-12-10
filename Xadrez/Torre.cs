using Projeto_Xadrez.Tabuleiro;

public class Torre(Tabuleiro tab, Cor cor) : Peca(tab, cor)
{
    public override string ToString()
    {
        return "T";
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
        // acima
        pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
        while (tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Linha, pos.Coluna] = true;
            if (tab.peca(pos) != null && tab.peca(pos).Cor != cor)
            {
                break;
            }
            pos.Linha = pos.Linha - 1;
        }

        // abaixo
        pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
        while (tab.PosicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Linha, pos.Coluna] = true;
            if (tab.peca(pos) != null && tab.peca(pos).Cor != cor)
            {
                break;
            }
            pos.Linha = pos.Linha + 1;
        }
        // direita
        pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
        while (tab.posicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Linha, pos.Coluna] = true;
            if (tab.peca(pos) != null && tab.peca(pos).Cor != cor)
            {
                break;
            }
            pos.Coluna = pos.Coluna + 1;
        }
        // esquerda
        pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
        while (tab.posicaoValida(pos) && PodeMover(pos))
        {
            mat[pos.Linha, pos.Coluna] = true;
            if (tab.peca(pos) != null && tab.peca(pos).Cor != cor)
            {
                break;
            }
            pos.Coluna = pos.Coluna - 1;
        }

        return mat;
    }

    
}
