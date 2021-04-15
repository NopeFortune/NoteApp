using System;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class SearchForm : Form
    {
        private bool direction;
        private bool register;

        private MainForm Form;
        public SearchForm(MainForm form)
        {
            this.Form = form;
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void btnFindNext_Click(object sender, EventArgs e)
        {
            
            #region direction
            if (rbDown.Checked == true)
            {
                direction = true;
            }
            else
            {
                direction = false;
            }
            #endregion

            #region register
            if (cbRegister.Checked == true)
            {
                register = true;
            }
            else
            {
                register = false;
            }
            #endregion
            
            Form.SearchMethod(tbSearch.Text, direction, register);


        }
    }
}
