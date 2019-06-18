using ChessConsole.Tabuleiro;

namespace ChessConsole.Xadrez
{
    class Rei : Peca
    {
        public Rei(ChessTabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
