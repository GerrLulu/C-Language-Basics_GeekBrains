using System;
using System.Windows.Forms;

namespace TrueFalseEditor
{
    public partial class Form1 : Form
    {
        private TrueFalse _database; // База данных с вопросами


        public Form1()
        {
            InitializeComponent();
        }


        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuFileNewFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _database = new TrueFalse(saveFileDialog.FileName);
                _database.Add("Замля круглая?", true);
                _database.Save();
                numericUpDownCountQuestion.Minimum = 1;
                numericUpDownCountQuestion.Maximum = 1;
                numericUpDownCountQuestion.Value = 1;
            }
        }

        private void menuFileOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _database = new TrueFalse(openFileDialog.FileName);
                _database.Load();
                numericUpDownCountQuestion.Minimum = 1;
                numericUpDownCountQuestion.Maximum = _database.Count;
                numericUpDownCountQuestion.Value = 1;
            }
        }

        private void numericUpDownCountQuestion_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxQuestion.Text = _database[(int)numericUpDownCountQuestion.Value - 1].Text;
                if (_database[(int)numericUpDownCountQuestion.Value - 1].TrueFalse)
                {
                    radioButtonYes.Checked = true;
                }
                else
                {
                    radioButtonNo.Checked = true;
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show($"Внимание! {ex.Message}", "Такого вопроса нет!");
            }
        }

        private void menuFileSaveFile_Click(object sender, EventArgs e)
        {
            if (_database != null)
                _database.Save();
            else
                MessageBox.Show("База данных не создана!");
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            if(_database == null)
            {
                MessageBox.Show("Создайте новую базу данных!");
                return;
            }

            _database.Add("#" + (_database.Count + 1).ToString(), true);
            numericUpDownCountQuestion.Maximum = _database.Count;
            numericUpDownCountQuestion.Value = _database.Count;
        }

        private void buttonDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (numericUpDownCountQuestion.Maximum == 1 || _database == null)
                return;

            _database.Remove((int)numericUpDownCountQuestion.Value - 1);
            numericUpDownCountQuestion.Maximum--;

            if (numericUpDownCountQuestion.Value > 1)
                numericUpDownCountQuestion.Value = numericUpDownCountQuestion.Value;
        }

        private void buttonSaveQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                _database[(int)numericUpDownCountQuestion.Value - 1].Text = textBoxQuestion.Text;
                if (radioButtonYes.Checked)
                {
                    _database[(int)numericUpDownCountQuestion.Value - 1].TrueFalse = true;
                }
                else
                {
                    _database[(int)numericUpDownCountQuestion.Value - 1].TrueFalse = false;
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show($"Внимание: {ex.Message}", "Откройте или создайте базу данных с " +
                    "вопросами!");
            }
        }

        private void menuHelpAboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Автор: Преподаватель GeekBrains Станислав Байраковский;
                Редактор: студент GeekBrains Артем Дёмин;
                Версия программы: 0.0000000001 (pre-alpha).", "About the program");
        }

        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            if(_database == null)
            {
                _database = new TrueFalse(saveFileDialog.FileName);
                _database.Add("Замля круглая?", true);
                _database.Save();
                numericUpDownCountQuestion.Minimum = 1;
                numericUpDownCountQuestion.Maximum = 1;
                numericUpDownCountQuestion.Value = 1;
            }
            else
            {
                _database.FileName = saveFileDialog.FileName;
                _database.Save();
            }
        }
    }
}