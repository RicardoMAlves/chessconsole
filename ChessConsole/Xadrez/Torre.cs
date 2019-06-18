using ChessConsole.Tabuleiro;

namespace ChessConsole.Xadrez
{
    class Torre : Peca
    {
        public Torre(ChessTabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
