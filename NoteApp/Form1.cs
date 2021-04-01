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

        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            tbMain.Undo();
        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            tbMain.Cut();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            tbMain.Copy();
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            tbMain.Paste();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)   
        {
            // TODO: фикс курсор
            if (!string.IsNullOrWhiteSpace(tbMain.Text))
            {
                tbMain.Text = tbMain.Text.Remove(tbMain.Text.Length - 1);
            }
        }

        private void tsmiFind_Click(object sender, EventArgs e)
        {
            // TODO: доделать поиск
        }

        private void tsmiFindNext_Click(object sender, EventArgs e)
        {
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

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            tbMain.SelectAll();
        }

        private void tsmiDateAndTime_Click(object sender, EventArgs e)
        {
            // TODO: Фикс курсор
            tbMain.Text += DateTime.Now.ToString() + " ";
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
            // TODO: доделать (удалять всё)
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
        #endregion
    }
}
