using NFluent;
using NUnit.Framework;
using System;

namespace TicTacToeKata
{
    public class TicTacToeGameTests
    {
        private const char X = 'X';
        private const char O = 'O';
        private char[,] _initalBoard;
        private char _inputToken;
        private const char _ = new char();
        private Tuple<int, int> _inputPosition;

        [Test]
        public void Place_X_on_empty()
        {
            _initalBoard = new char[,] { { _ } };
            _inputToken = X;
            _inputPosition = new Tuple<int, int>(0, 0);
            var ticTacToeGame = new TicTacToeGame(_initalBoard);
            char[,] newBoard = ticTacToeGame.Mark(_inputToken, _inputPosition);
            char[,] expectedBoard = new char[,] { { X } };
            CheckThatBoardsAreEqual(newBoard, expectedBoard);
        }

        [Test]
        public void Place_X_on_X()
        {
            _initalBoard = new char[,] { { X } };
            var ticTacToeGame = new TicTacToeGame(_initalBoard);
            _inputToken = X;
            char[,] newBoard = ticTacToeGame.Mark(_inputToken, _inputPosition);
            char[,] expectedBoard = new char[,] { { X } };
            CheckThatBoardsAreEqual(newBoard, expectedBoard);
        }

        [Test]
        public void Place_O_on_X()
        {
            _initalBoard = new char[,] { { X } };
            _inputToken = O;
            _inputPosition = new Tuple<int, int>(0, 0);
            var ticTacToeGame = new TicTacToeGame(_initalBoard);
            char[,] newBoard = ticTacToeGame.Mark(_inputToken, _inputPosition);
            char[,] expectedBoard = new char[,] { { X } };
            CheckThatBoardsAreEqual(newBoard, expectedBoard);
        }

        [Test]
        public void Place_O_on_empty()
        {
            _initalBoard = new char[,] { { _ } };
            _inputToken = O;
            _inputPosition = new Tuple<int, int>(0, 0);
            var ticTacToeGame = new TicTacToeGame(_initalBoard);
            char[,] newBoard = ticTacToeGame.Mark(_inputToken, _inputPosition);
            char[,] expectedBoard = new char[,] { { O } };
            CheckThatBoardsAreEqual(newBoard, expectedBoard);
        }

        [Test]
        public void Place_O_on_O()
        {
            _initalBoard = new char[,] { { O } };
            _inputToken = O;
            _inputPosition = new Tuple<int, int>(0, 0);
            var ticTacToeGame = new TicTacToeGame(_initalBoard);
            char[,] newBoard = ticTacToeGame.Mark(_inputToken, _inputPosition);
            char[,] expectedBoard = new char[,] { { O } };
            CheckThatBoardsAreEqual(newBoard, expectedBoard);
        }

        [Test]
        public void Place_X_on_2x2_row()
        {
            _initalBoard = new char[,]
            {
                { X, _ },
                { O, _ }
            };
            _inputToken = X;
            _inputPosition = new Tuple<int, int>(0, 1);
            var ticTacToeGame = new TicTacToeGame(_initalBoard);
            char[,] newBoard = ticTacToeGame.Mark(_inputToken, _inputPosition);
            char[,] expectedBoard = new char[,]
            {
                { X, X },
                { O, _ }
            };
            CheckThatBoardsAreEqual(newBoard, expectedBoard);
        }

        [Test]
        public void Place_O_on_2x2_row()
        {
            _initalBoard = new char[,]
            {
                { O, _ },
                { X, _ }
            };
            _inputToken = O;
            _inputPosition = new Tuple<int, int>(0, 1);
            var ticTacToeGame = new TicTacToeGame(_initalBoard);
            char[,] newBoard = ticTacToeGame.Mark(_inputToken, _inputPosition);
            char[,] expectedBoard = new char[,]
            {
                { O, O },
                { X, _ }
            };
            CheckThatBoardsAreEqual(newBoard, expectedBoard);
        }

        [Test]
        public void Place_X_on_2x2_column()
        {
            _initalBoard = new char[,]
            {
                { X, O },
                { _, _ }
            };
            _inputToken = X;
            _inputPosition = new Tuple<int, int>(1, 0);
            var ticTacToeGame = new TicTacToeGame(_initalBoard);
            char[,] newBoard = ticTacToeGame.Mark(_inputToken, _inputPosition);
            char[,] expectedBoard = new char[,]
            {
                { X, O },
                { X, _ }
            };
            CheckThatBoardsAreEqual(newBoard, expectedBoard);
        }

        [Test]
        public void Place_X_on_2x2_diagonal()
        {
            _initalBoard = new char[,]
            {
                { X, O },
                { _, _ }
            };
            _inputToken = X;
            _inputPosition = new Tuple<int, int>(1, 1);
            var ticTacToeGame = new TicTacToeGame(_initalBoard);
            char[,] newBoard = ticTacToeGame.Mark(_inputToken, _inputPosition);
            char[,] expectedBoard = new char[,]
            {
                { X, O },
                { _, X }
            };
            CheckThatBoardsAreEqual(newBoard, expectedBoard);
        }

        [Test]
        public void Place_X_when_not_X_turn()
        {
            _initalBoard = new char[,]
            {
                { X, _ },
                { _, _ }
            };
            _inputToken = X;
            _inputPosition = new Tuple<int, int>(1, 0);
            var ticTacToeGame = new TicTacToeGame(_initalBoard);
            char[,] newBoard = ticTacToeGame.Mark(_inputToken, _inputPosition);
            char[,] expectedBoard = new char[,]
            {
                { X, _ },
                { _, _ }
            };
            CheckThatBoardsAreEqual(newBoard, expectedBoard);
        }

        private static void CheckThatBoardsAreEqual(char[,] newBoard, char[,] expectedBoard)
        {
            for (int i = 0; i < newBoard.GetLength(0); i++)
            {
                for (int j = 0; j < newBoard.GetLength(1); j++)
                {
                    Check.That(newBoard[i, j]).IsEqualTo(expectedBoard[i, j]);
                }
            }
        }
    }
}