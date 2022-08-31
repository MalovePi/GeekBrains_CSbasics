using System;
using System.Windows.Forms;

namespace geekBrains_CSbasics_HomeWork_08_QuizEditor
{
    public partial class Main : Form
    {
        private Core _core;

        public Main()
        {
            InitializeComponent();
        }

        private void MenuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                InitialDirectory = Application.StartupPath,
                Filter = "File XML (*.xml)|*.xml|All files (*.*)|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!dialog.FileName.EndsWith(".xml"))
                    dialog.FileName += ".xml";

                _core = new Core(dialog.FileName);
                _core.Add("Example question:\r\nNew York is nicknamed 'The Big Orange'", false);

                try
                {
                    _core.Save();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Error creating a new file.\n{exception.Message}");
                    return;
                }
                numericQuestion.Maximum = 1;
                numericQuestion.Minimum = 1;
                numericQuestion.Value = 1;

                textBoxQuestion.Text = _core[(int)numericQuestion.Value - 1].Text;
                CheckTrue.Checked = _core[(int)numericQuestion.Value - 1].TrueFalse;
            }
        }

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Filter = "File XML (*.xml)|*.xml|All files (*.*)|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _core = new Core(dialog.FileName);
                try
                {
                    _core.Load();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"File opening error.\n{exception.Message}");
                    return;
                }
                numericQuestion.Maximum = _core.Count;
                numericQuestion.Minimum = 1;
                numericQuestion.Value = 1;
                textBoxQuestion.Text = _core[(int)numericQuestion.Value - 1].Text;
                CheckTrue.Checked = _core[(int)numericQuestion.Value - 1].TrueFalse;
            }
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            if (StartCheck())
            {
                if(textBoxQuestion.Text == "")
                {
                    MessageBox.Show("Before saving.\r\nDelete blank question.", "Warning");
                    return;
                }
                    
                try
                {
                    _core.Save();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Error saving to file.\n{exception.Message}");
                    return;
                }

                MessageBox.Show("Saved to file.", "Saving");
            }
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericQuestion_ValueChanged(object sender, EventArgs e)
        {
            textBoxQuestion.Text = _core[(int)numericQuestion.Value - 1].Text;
            CheckTrue.Checked = _core[(int)numericQuestion.Value - 1].TrueFalse;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (StartCheck())
            {
                if (textBoxQuestion.Text == "")
                {
                    MessageBox.Show("Fill in the box with a question.", "Warning");
                    return;
                }
                _core[(int)numericQuestion.Value - 1].Text = textBoxQuestion.Text;
                _core[(int)numericQuestion.Value - 1].TrueFalse = CheckTrue.Checked;

                _core.Add(string.Empty, false);

                numericQuestion.Maximum = _core.Count;
                numericQuestion.Value = _core.Count;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (StartCheck())
            {
                if (_core.Count <= 1)
                {
                    MessageBox.Show("You can't delete the first question on the list.", "Error");
                    return;
                }
                _core.Remove((int)numericQuestion.Value - 1);
                numericQuestion.Maximum--;
            }
        }

        private bool StartCheck(string text = "Empty question list. Create a new one or open a saved list.")
        {
            if (_core == null)
            {
                MessageBox.Show(text, "Error");
                return false;
            }

            return true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }
    }
}
