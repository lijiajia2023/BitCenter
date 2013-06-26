using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BitCenter
{
    public partial class frmPyBitmessage : Form
    {
        public frmPyBitmessage()
        {
            InitializeComponent();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            lblPWchange.Visible = tbPassword.Text.Length == 0;
        }

        private void lblPWchange_Click(object sender, EventArgs e)
        {
            tbPassword.Select();
        }
    }
}
