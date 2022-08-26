using System;
using System.Windows.Forms;

namespace geekBrains_CSbasics_HomeWork_07_GameDoubler
{
    public partial class Main : Form
    {
        private int _startGameNumber;
        private int _startPlayerNumber;
        private int _score;

        private Doubler _doubler;

        public Main()
        {
            InitializeComponent();
            _doubler = new Doubler();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 0.1.1 \nby Malove", "Doubler");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _doubler.RestartGame(ref _startGameNumber, ref _startPlayerNumber, ref _score);
            UpdateGame();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            _doubler.RestartGame(ref _startGameNumber, ref _startPlayerNumber, ref _score);
            UpdateGame();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            _doubler.Plus(ref _startPlayerNumber, ref _score);
            UpdateGame();
            Check();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            _doubler.MultiplyTwo(ref _startPlayerNumber, ref _score);
            UpdateGame();
            Check();
        }

        private void buttonOndo_Click(object sender, EventArgs e)
        {
            _doubler.Undo(ref _startPlayerNumber, ref _score);
            UpdateGame();
        }

        private void Check()
        {
            _doubler.CheckWin(ref _startGameNumber, ref _startPlayerNumber, ref _score);
        }

        private void UpdateGame()
        {
            labelGameNumber.Text = _startGameNumber.ToString();
            labelPlayerNumber.Text = _startPlayerNumber.ToString();
            labelScope.Text = _score.ToString();
        }
    }
}
