
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

    public void ColocarPeca(Peca p, Posicao pos)
    {
        pecas[pos.Linha,pos.Coluna] = p;
        p.Posi =pos;
    }

    internal void colocarPeca(Torre torre)
    {
        throw new NotImplementedException();
    }
}
