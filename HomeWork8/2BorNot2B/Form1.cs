using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace _2BorNot2B
{
    public partial class Form1 : Form
    {
        private const string MESSAGE_INFO = "Добавте изображение!";
        private const string MESSAGE_ERROR = "Невозможно открыть выбранный файл!";
        private const string MESSAGE_TAG = "Введите тэги через запятую";

        private const string XML_FILTER = "XML-files (XML)|*.XML";
        private const string IMAGE_FILTER = "Image files (*.JPG)|*.JPG|All files (*.*)|*.*";

        private TrueFalse _database;// База данных с вопросами


        public Form1()
        {
            InitializeComponent();
        }


        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemFileNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = XML_FILTER;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFile(saveFileDialog);

                listNumber.Minimum = 1;
                listNumber.Maximum = 1;
                listNumber.Value = 1;
            }
        }

        private void menuFileOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = XML_FILTER;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _database = new TrueFalse(openFileDialog.FileName);
                _database.Load();
                listNumber.Minimum = 1;
                listNumber.Maximum = _database.Count;
                listNumber.Value = 1;
            }
        }

        private void menuFileSaveFile_Click(object sender, EventArgs e)
        {
            {
                if (_database != null)
                    _database.Save();
                else
                    MessageBox.Show("База данных не создана!");
            }
        }

        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            if (_database == null)
            {
                SaveFile(saveFileDialog);

                listNumber.Minimum = 1;
                listNumber.Maximum = 1;
                listNumber.Value = 1;
            }
            else
            {
                _database.FileName = saveFileDialog.FileName;
                _database.Save();
            }
        }

        private void menuHelpAboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Автор: студент GeekBrains Артем Дёмин;
                Версия программы: 0.0000000001 (pre-alpha).", "About the program");
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            FileDialog();
        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            if (_database == null)
            {
                MessageBox.Show("Создайте новую базу данных!");
                return;
            }

            MessageBox.Show(MESSAGE_INFO, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            FileDialog();

            _database.Add(ImageToBase64(picture.Image, picture.Image.RawFormat), MESSAGE_TAG, false);
            listNumber.Maximum = _database.Count;
            listNumber.Value = _database.Count;
        }

        private void buttonDeletFromList_Click(object sender, EventArgs e)
        {
            if (listNumber.Maximum == 1 || _database == null)
                return;

            _database.Remove((int)listNumber.Value - 1);
            listNumber.Maximum--;

            if (listNumber.Value > 1)
                listNumber.Value = listNumber.Value;
        }

        //Метод конвертирования изображения в двоичный файл в качестве Base64
        public string ImageToBase64(Image image, ImageFormat imageFormat)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                //конвертирование изображения в массив byte[]
                Bitmap bitmap = new Bitmap(image);
                bitmap.Save(memoryStream, imageFormat);
                byte[] imageBytes = memoryStream.ToArray();

                //из массива byte[] в Base64
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        //Метод конвертирования из Base64 в изображение
        public Image Base64ToImage(string base64String)
        {
            // конвертировать из Base64 в массив byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);

            // из byte[] в изображение
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        private void buttonSaveToList_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(MESSAGE_INFO, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                FileDialog();

                _database[(int)listNumber.Value - 1].FileNameImg = ImageToBase64(picture.Image, picture.Image.RawFormat);
                _database[(int)listNumber.Value - 1].Tag = textTag.Text;
                _database[(int)listNumber.Value - 1].TrueFalse = checkTrue.Checked;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Внимание: {ex.Message}", "Откройте или создайте базу данных!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void listNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                picture.Image = Base64ToImage(_database[(int)listNumber.Value - 1].FileNameImg);
                textTag.Text = _database[(int)listNumber.Value - 1].Tag;
                checkTrue.Checked = _database[(int)listNumber.Value - 1].TrueFalse;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Внимание! {ex.Message}", "Нет в списке!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SaveFile(SaveFileDialog saveFileDialog)
        {
            _database = new TrueFalse(saveFileDialog.FileName);
            MessageBox.Show(MESSAGE_INFO, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FileDialog();

            _database.Add(ImageToBase64(picture.Image, picture.Image.RawFormat), MESSAGE_TAG, false);
            _database.Save();
        }

        private void FileDialog()
        {
            OpenFileDialog openFileDialogImage = new OpenFileDialog();
            openFileDialogImage.Filter = IMAGE_FILTER;

            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picture.Image = new Bitmap(openFileDialogImage.FileName);
                }
                catch
                {
                    MessageBox.Show(MESSAGE_ERROR, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}