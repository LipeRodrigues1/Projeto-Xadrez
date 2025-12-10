namespace Projeto_Xadrez.Tabuleiro;

public class Tabuleiro(int linhas, int colunas)
{
    public int Linhas { get; set; } = linhas;
    public int Colunas { get; set; } = colunas;
    private Peca[,] pecas = new Peca[linhas, colunas];

    public Peca peca(int linha, int coluna)
    {
        return pecas[linha, coluna];
    }
    public Peca peca(Posicao pos)
    {
        return pecas[pos.Linha, pos.Coluna];
    }
    public bool ExistePeca(Posicao pos)
    {
        ValidarPosicao(pos);
        return peca(pos) != null;
    }

    public void ColocarPeca(Peca p, Posicao pos)
    {
        if (ExistePeca(pos))
        {
            throw new TabuleiroException("Já existe uma peça aqui!");
        }
        pecas[pos.Linha, pos.Coluna] = p;
        p.Posi = pos;
    }

    public Peca RetirarPeca(Posicao pos)
    {
        if (peca(pos) == null)
        {
            return null;
        }
        else
        {
            Peca aux = peca(pos);
            aux.Posi = null;
            pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }
    }
    public bool PosicaoValida(Posicao pos)
    {
        if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void ValidarPosicao(Posicao pos)
    {
        if (!PosicaoValida(pos))
        {
            throw new TabuleiroException("Posição Inválida!");
        }
    }

}
