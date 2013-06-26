using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BitCenter
{
    public partial class frmMain : Form
    {
        frmPyBitmessage fPy;
        frmBackup fBa;

        public frmMain()
        {
            InitializeComponent();

            fPy = new frmPyBitmessage();
            fPy.MdiParent = this;
            fPy.FormClosed += new FormClosedEventHandler(fPy_FormClosed);

            fBa = new frmBackup();
            fBa.MdiParent = this;
            fBa.FormClosed += new FormClosedEventHandler(fBa_FormClosed);
        }

        void fPy_FormClosed(object sender, FormClosedEventArgs e)
        {
            fPy = new frmPyBitmessage();
            fPy.MdiParent = this;
            fPy.FormClosed += new FormClosedEventHandler(fPy_FormClosed);
        }

        void fBa_FormClosed(object sender, FormClosedEventArgs e)
        {
            fBa = new frmBackup();
            fBa.MdiParent = this;
            fBa.FormClosed += new FormClosedEventHandler(fBa_FormClosed);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Shutdown logic
            Close();
        }

        private void backupAndRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Backup and restore Configuration
            fBa.Show();
        }

        private void PyBitmessageStripMenuItem_Click(object sender, EventArgs e)
        {
            fPy.Show();
            //PyBitmessage Settings
        }

        private void manageRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Message Processing Rules
        }

        private void adressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Address Manager
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Task Controller
        }

        private void outputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Input/Output Settings
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BitCenter V "+Application.ProductVersion+"\r\n\r\nThis is free software.\r\n\r\nAyrA.ch","BitCenter",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
