namespace ChessConsole.Tabuleiro
{
    class ChessTabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public ChessTabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca APeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
    }
}
