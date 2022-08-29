using System;
using System.Windows.Forms;

namespace geekBrains_CSbasics_HomeWork_07_GameGuessNumber
{
    public partial class Game : Form
    {
        private Random _random = new Random();

        private int _startGameNumber;
        private int _playerNumber;
        private int _numberAttempts;

        public Game()
        {
            InitializeComponent();
            textBoxPlayerInput.Enabled = false;
            textBoxPlayerInput.KeyPress += new KeyPressEventHandler(CheckEnterKeyPress);
        }

        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (int.TryParse(textBoxPlayerInput.Text, out _playerNumber))
            {                
                if (e.KeyChar == (char)Keys.Enter)
                {
                    labelNumberAttempts.Text = $"Number attempts: {++_numberAttempts}";
                    if (_playerNumber == _startGameNumber)
                    {
                        labelStatus.Text = $"Well done! You guessed my number in {_numberAttempts} attempts.";
                        buttonRestart.Enabled = true;
                        this.textBoxPlayerInput.Enabled = false;
                    }
                    else if (_startGameNumber < _playerNumber)
                    {
                        labelStatus.Text = $"Oops {_playerNumber} is too high! Try a lower number.";
                    }
                    else if (_startGameNumber > _playerNumber)
                    {
                        labelStatus.Text = $"Oops {_playerNumber} is too low! Try a higher number.";
                    }
                    textBoxPlayerInput.Text = string.Empty;
                }
            }
                
        }

        private void textBoxPlayerInput_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPlayerInput.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите пожалуста только числа!");
                textBoxPlayerInput.Text = string.Empty;
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            buttonRestart.Enabled = false;
            textBoxPlayerInput.Enabled = true;
            _startGameNumber = _random.Next(1, 100);
            textBoxPlayerInput.Focus();
            labelStatus.Text = $"Number attempts previous guesses: {_numberAttempts}";
            labelNumberAttempts.Text = $"Number attempts: {_numberAttempts = 0}";
        }
    }
}
