
using System;

namespace TicTacToeKata
{
    public class TicTacToeGame
    {
        private char[,] _board;
        private const char _ = new char();

        public TicTacToeGame(char[,] board)
        {
            _board = board;
        }
        
        public char[,] Mark(char token, Tuple<int, int> position)
        {
            var cell = MarkCell(_board[position.Item1, position.Item2], token);
            _board[position.Item1, position.Item2] = cell;
            return _board;
        }

        private static char MarkCell(char cell, char token)
        {
            if (cell == _)
            {
                cell = token;
            }
            return cell;
        }
    }
}