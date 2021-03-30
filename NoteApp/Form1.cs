using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmiCreate_Click(object sender, EventArgs e)
        {
            // TODO: вынести в метод
            path = string.Empty;
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
                        MessageBox.Show("saved");
                        break;
                    case DialogResult.No:
                    case DialogResult.Cancel:
                        tbMain.Clear();
                        break;
                }
            }

        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            LoadFile(path);
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
            //TODO: Проверка на сейв
            this.Close();
        }

        
        // TODO: Пофиксить path = null;
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

        private async void SaveFileAs(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
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

        private async void LoadFile(string path)
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
    }
}
