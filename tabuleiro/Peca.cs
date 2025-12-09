namespace Projeto_Xadrez.Tabuleiro;

public class Peca(Tabuleiro tab, Cor cor)
{
    public Posicao? Posi { get; set; } = null;
    public Cor Cor { get; protected set; } = cor;
    public int QteMovimentos { get; protected set; } = 0;
    public Tabuleiro Tab { get; protected set; } = tab;

    
}
