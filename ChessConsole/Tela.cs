using System;
using ChessConsole.Tabuleiro;

namespace ChessConsole
{
    class Tela
    {
        public static void ImprimirTabuleiro(ChessTabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (tabuleiro.APeca(i, j) == null)
                    {
                        Console.Write("- ");
                    } else
                    {
                        Console.Write(tabuleiro.APeca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
