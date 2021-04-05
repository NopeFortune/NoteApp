using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class SearchForm : Form
    {
        private bool direction;
        private bool register;

        private Form1 Form;
        public SearchForm(Form1 form)
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
            
            Form.TestMethod(tbSearch.Text, direction, register);


        }
    }
}
