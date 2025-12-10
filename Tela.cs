using System.ComponentModel.DataAnnotations.Schema;
using Projeto_Xadrez.Xadrez;

namespace Projeto_Xadrez.Tabuleiro;

public class Tela
{
    public static void Imprimir(Tabuleiro tab)
    {
        for (int i = 0; i < tab.Linhas; i++)
        {
            System.Console.Write(8 - i + " ");
            for (int j = 0; j < tab.Colunas; j++)
            {
                if (tab.peca(i, j) == null)
                {
                    System.Console.Write("- ");
                }
                else
                {
                    Tela.ImprimirPeca(tab.peca(i, j));
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine("  A B C D E F G H");
    }

    public static PosicaoXadrez LerPosicaoXadrez()
    {
        string s = Console.ReadLine();
        char coluna = s[0];
        int linha = int.Parse(s[1] + "");
        return new PosicaoXadrez(coluna, linha);
    }



    public static void ImprimirPeca(Peca peca)
    {
        if (peca.Cor == Cor.Branca)
        {
            ConsoleColor blue = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.Write(peca);
            Console.ForegroundColor = blue;
        }
        else
        {
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write(peca);
            Console.ForegroundColor = aux;
        }
    }
}
