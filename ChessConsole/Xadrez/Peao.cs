﻿using ChessConsole.Tabuleiro;

namespace ChessConsole.Xadrez
{
    class Peao : Peca
    {
        public Peao(ChessTabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tabuleiro.APeca(pos);
            return p == null || p.Cor != this.Cor;
        }

        private bool ExisteInimigo(Posicao pos)
        {
            Peca p = Tabuleiro.APeca(pos);
            return p != null && p.Cor != Cor;
        }

        private bool Livre(Posicao pos)
        {
            return Tabuleiro.APeca(pos) == null;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            Posicao pos = new Posicao(0, 0);

            if (Cor == Cor.Branca)
            {
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(pos) && Livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(pos) && Livre(pos) && QteMovimentos == 0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }
            else
            {
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(pos) && Livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(pos) && Livre(pos) && QteMovimentos == 0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }
            return mat;
        }

        public override string ToString()
        {
            return "P";
        }
    }
}