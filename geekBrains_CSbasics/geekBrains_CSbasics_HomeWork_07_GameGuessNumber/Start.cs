using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geekBrains_CSbasics_HomeWork_07_GameGuessNumber
{
    public partial class Start : Form
    {
        private Thread _thread;

        public Start()
        {
            InitializeComponent();
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            this.Close();
            _thread = new Thread(Open);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }

        private void Open(object obj)
        {
            Application.Run(new Game());
        }

        private void buttonQuitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }
    }
}
