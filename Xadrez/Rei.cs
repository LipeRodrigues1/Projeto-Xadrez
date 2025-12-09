using Projeto_Xadrez.Tabuleiro;

public class Rei(Tabuleiro tab, Cor cor) : Peca(tab, cor)
{
    public override string ToString()
    {
        return "R";
    }
}

