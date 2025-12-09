using Projeto_Xadrez.Tabuleiro;

public class Torre(Tabuleiro tab, Cor cor) : Peca(tab,cor)
{
    public override string ToString()
    {
        return "T";
    }
}
