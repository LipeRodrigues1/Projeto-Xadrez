using System.ComponentModel.DataAnnotations.Schema;

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
                    Tela.ImprimirPeca(tab.peca(i,j));
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine("  A B C D E F G H");
    }



    public static void ImprimirPeca(Peca peca)
    {
        if (peca.Cor == Cor.Branca)
        {
            System.Console.Write(peca);
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
