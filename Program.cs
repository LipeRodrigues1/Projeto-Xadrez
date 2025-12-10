using Projeto_Xadrez;
using Projeto_Xadrez.Tabuleiro;
try
{
    PartidaXadrez patida = new();
    while (!patida.Terminada)
    {
        Console.Clear();
        Tela.Imprimir(patida.tab);
        System.Console.Write("Origem: ");
        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
        System.Console.Write("Destino: ");
        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

        // PartidaXadrez.ExecutaMovimento(origem,destino);

    }





}
catch (TabuleiroException e)
{

    System.Console.WriteLine(e.Message); ;
}