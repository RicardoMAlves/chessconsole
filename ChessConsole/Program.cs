using System;
using ChessConsole.Tabuleiro;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(5, 6);
            Console.WriteLine("Posicao: " + p);
        }
    }
}
