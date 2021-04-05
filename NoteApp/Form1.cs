using System;
using System.Windows.Forms;
using System.IO;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // TODO: Добавить выведение названия файла в тайтл
            InitializeComponent();
        }

        string path;

        private void tsmiCreate_Click(object sender, EventArgs e)
        {
            path = string.Empty;
            SaveCheck();
        }
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            LoadFile();
        }
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            SaveFile(path);
        }
        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileAs(path);
        }
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            SaveCheck();
            this.Close();
        }
        private void tsmiFind_Click(object sender, EventArgs e)
        {
            // TODO: доделать поиск
            SearchForm sf = new SearchForm(this);
            sf.Show();
        }
        private void tsmiFindNext_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm(this);
            sf.btnFindNext_Click(sender, e);
        }
        private void tsmiFindPrevious_Click(object sender, EventArgs e)
        {
        }
        private void tsmiReplace_Click(object sender, EventArgs e)
        {

        }
        private void tsmiGoOn_Click(object sender, EventArgs e)
        {

        }
        private void tsmiDateAndTime_Click(object sender, EventArgs e)
        {
            // TODO: Пофиксить курсор
            tbMain.Text += DateTime.Now.ToString() + " ";
            tbMain.SelectionStart = tbMain.Text.Length;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCheck();
        }
        private void tsmiWordWrap_Click(object sender, EventArgs e)
        {
            if (tsmiWordWrap.Checked == false)
            {
                tbMain.WordWrap = false;
            }
            else
            {
                tbMain.WordWrap = true;
            }
        }
        private void tsmiFont_Click(object sender, EventArgs e)
        {
            FontDialog fontdialog = new FontDialog();
            if (fontdialog.ShowDialog() == DialogResult.OK)
            {
                tbMain.Font = fontdialog.Font;
            }
        }

        #region Methods

        // TODO : создавать новый файл

        private async void SaveFileAs(string path)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Текстовые файлы|*.txt", ValidateNames = true })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                    {
                        await sw.WriteAsync(tbMain.Text);
                    }
                }
            }
        }
        private async void LoadFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Text Document|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(openFileDialog.FileName, System.Text.Encoding.UTF8))
                    {
                        path = openFileDialog.FileName;
                        tbMain.Text = await sr.ReadToEndAsync();
                    }
                }
            }
        }
        private async void SaveFile(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Текстовые файлы|*.txt", ValidateNames = true })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                        {
                            await sw.WriteAsync(tbMain.Text);
                        }
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    await sw.WriteAsync(tbMain.Text);
                }
            }
        }
        private void SaveCheck()
        {
            if (string.IsNullOrWhiteSpace(tbMain.Text))
            {
                tbMain.Clear();
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Вы хотите сохранить изменения?",
                    "NoteApp",
                    MessageBoxButtons.YesNoCancel
                    );

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveFile(path);
                        break;
                    case DialogResult.No:
                        tbMain.Clear();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        public void TestMethod(string findText, bool direction, bool register)
        {

        }
        #endregion

    }
}
