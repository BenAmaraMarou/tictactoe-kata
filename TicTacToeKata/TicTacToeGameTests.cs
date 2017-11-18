using NFluent;
using NUnit.Framework;

namespace TicTacToeKata
{
    public class TicTacToeGameTests
    {
        private const char X = 'X';
        private const char O = 'O';
        private char initalBoard;
        private char inputToken;

        [Test]
        public void Place_X_on_empty()
        {
            initalBoard = new char();
            var ticTacToeGame = new TicTacToeGame(initalBoard);
            inputToken = X;
            char newBoard = ticTacToeGame.Mark(inputToken);
            Check.That(newBoard).IsEqualTo(X);
        }

        [Test]
        public void Place_X_on_X()
        {
            initalBoard = X;
            var ticTacToeGame = new TicTacToeGame(initalBoard);
            inputToken = X;
            char newBoard = ticTacToeGame.Mark(inputToken);
            Check.That(newBoard).IsEqualTo(X);
        }

        [Test]
        public void Place_O_on_X()
        {
            initalBoard = X;
            var ticTacToeGame = new TicTacToeGame(initalBoard);
            inputToken = O;
            char newBoard = ticTacToeGame.Mark(inputToken);
            Check.That(newBoard).IsEqualTo(X);
        }

        [Test]
        public void Place_O_on_empty()
        {
            initalBoard = new char();
            var ticTacToeGame = new TicTacToeGame(initalBoard);
            inputToken = O;
            char newBoard = ticTacToeGame.Mark(inputToken);
            Check.That(newBoard).IsEqualTo(O);
        }

        [Test]
        public void Place_O_on_O()
        {
            initalBoard = O;
            var ticTacToeGame = new TicTacToeGame(initalBoard);
            inputToken = O;
            char newBoard = ticTacToeGame.Mark(inputToken);
            Check.That(newBoard).IsEqualTo(O);
        }
    }
}
