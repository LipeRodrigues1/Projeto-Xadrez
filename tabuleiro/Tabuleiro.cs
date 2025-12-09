namespace Projeto_Xadrez.Tabuleiro;

public class Tabuleiro(int linhas, int colunas)
{
    public int Linhas { get; set; } = linhas;
    public int Colunas { get; set; } = colunas;
    private Peca[,] pecas = new Peca[linhas,colunas];

    public Peca Peca(int linha, int coluna)
    {
        return pecas[linha,coluna];
    }
}
