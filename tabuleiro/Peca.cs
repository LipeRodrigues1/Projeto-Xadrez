namespace Projeto_Xadrez.Tabuleiro;

public abstract class Peca(Tabuleiro tab, Cor cor)
{
    public Posicao? Posicao { get; set; } = null;
    public Cor Cor { get; protected set; } = cor;
    public int QteMovimentos { get; protected set; } = 0;
    public Tabuleiro Tab { get; protected set; } = tab;

    public void IncrementarMovi()
    {
        QteMovimentos++;
    }
    public void DecrementarQteMovimentos()
    {
        QteMovimentos--;
    }

    public abstract bool[,] MovimentosPossiveis();

}
