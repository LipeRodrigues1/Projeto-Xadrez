namespace Projeto_Xadrez.Tabuleiro;

using Projeto_Xadrez.Xadrez;


public class PartidaXadrez
{
    public Tabuleiro tab { get; private set; }
    private int Turno;
    private Cor JogadorAtual;
    public bool Terminada { get; private set; }


    public PartidaXadrez()
    {
        tab = new(8, 8);
        Turno = 1;
        JogadorAtual = Cor.Branca;
        ColocarPecas();
    }
    public void ColocarPecas()
    {
        tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 1).ToPosicao());
        tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 2).ToPosicao());
        tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('d', 2).ToPosicao());
        tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 2).ToPosicao());
        tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 1).ToPosicao());
        tab.ColocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());

        tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 7).ToPosicao());
        tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 8).ToPosicao());
        tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('d', 7).ToPosicao());
        tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 7).ToPosicao());
        tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 8).ToPosicao());
        tab.ColocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('d', 8).ToPosicao());
       
    }

    public void ExecutaMovimento(Posicao ori, Posicao dest)
    {
        Peca p = tab.RetirarPeca(ori);
        p.IncrementarMovi();
        Peca pecaCapturada = tab.RetirarPeca(dest);
        tab.ColocarPeca(p, dest);
    }






}
