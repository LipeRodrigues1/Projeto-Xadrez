namespace Projeto_Xadrez.Tabuleiro;

public class Posicao(int linha, int coluna)
{
    public int Linha { get; set; } = linha;
    public int Coluna { get; set; } = coluna;

    public override string ToString()
    {
        return $"Linha: {Linha}, Coluna: {Coluna}";
    }
}
