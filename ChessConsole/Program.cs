using System;
using ChessConsole.Tabuleiro;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessTabuleiro tab = new ChessTabuleiro(8, 8);
            Tela.ImprimirTabuleiro(tab);
        }
    }
}
