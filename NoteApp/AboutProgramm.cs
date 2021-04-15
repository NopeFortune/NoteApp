using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace NoteApp
{
    public partial class AboutProgramm : Form
    {
        public AboutProgramm()
        {
            InitializeComponent();  
        }

        private void lbGitLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/NopeFortune?tab=repositories");
        }
    }
}
