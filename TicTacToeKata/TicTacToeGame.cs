using System;

namespace TicTacToeKata
{
    public class TicTacToeGame
    {
        private char _board;

        public TicTacToeGame(char board)
        {
            _board = board;
        }

        public char Mark(char token)
        {
            if(_board == new char())
            {
                _board = token;
            }
            return _board;
        }
    }
}