namespace Projeto_Xadrez.Tabuleiro;

public class Peca(Posicao posi, Cor cor, Tabuleiro tab)
{
    public Posicao Posi { get; set; } = posi;
    public Cor Cor { get; protected set; } = cor;
    public int QteMovimentos { get; protected set; } = 0;
    public Tabuleiro Tab { get; protected set; } = tab;

    
}
