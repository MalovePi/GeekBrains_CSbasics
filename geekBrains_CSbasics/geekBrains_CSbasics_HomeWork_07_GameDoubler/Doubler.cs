using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace geekBrains_CSbasics_HomeWork_07_GameDoubler
{
    public class Doubler
    {
        private int _gameRangeIsFrom = 4;
        private int _gameRangeIsTo = 20;

        Random _random = new Random();
        private Stack<int> _stack = new Stack<int>();

        public void RestartGame(ref int gameNumber, ref int playerNumber, ref int score)
        {
            gameNumber = _random.Next(_gameRangeIsFrom, _gameRangeIsTo);
            playerNumber *= 0;
            score *= 0;
        }

        public void Plus(ref int playerNumber, ref int score)
        {
            _stack.Push(playerNumber);
            playerNumber++;
            ++score;
        }

        public void MultiplyTwo(ref int playerNumber, ref int score)
        {
            _stack.Push(playerNumber);
            playerNumber *= 2;
            ++score;
        }

        public void Undo(ref int playerNumber, ref int score)
        {
            if (score == 0)
                return;
            playerNumber = _stack.Pop();
            score--;
        }

        public void CheckWin(ref int gameNumber, ref int playerNumber, ref int score)
        {
            if (playerNumber == gameNumber && playerNumber != 0)
                MessageBox.Show($"WIN\nScore: {score}", "Doubler", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else if (playerNumber > gameNumber && gameNumber != 0 || playerNumber > 100)
                MessageBox.Show($"GAME OVER", "Doubler", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
