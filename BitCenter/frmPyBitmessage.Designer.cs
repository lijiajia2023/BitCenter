namespace BitCenter
{
    partial class frmPyBitmessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPyBitmessage));
            this.lbClients = new System.Windows.Forms.ListBox();
            this.gbClients = new System.Windows.Forms.GroupBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPWchange = new System.Windows.Forms.Label();
            this.tbDest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.gbClients.SuspendLayout();
            this.CMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbClients
            // 
            this.lbClients.ContextMenuStrip = this.CMS;
            this.lbClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbClients.FormattingEnabled = true;
            this.lbClients.Location = new System.Drawing.Point(3, 16);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(131, 134);
            this.lbClients.TabIndex = 0;
            this.ttMain.SetToolTip(this.lbClients, "Select the Client you wish to modify.\r\nUse the context menu to delete a client.");
            // 
            // gbClients
            // 
            this.gbClients.Controls.Add(this.lbClients);
            this.gbClients.Location = new System.Drawing.Point(12, 12);
            this.gbClients.Name = "gbClients";
            this.gbClients.Size = new System.Drawing.Size(137, 158);
            this.gbClients.TabIndex = 1;
            this.gbClients.TabStop = false;
            this.gbClients.Text = "Clients";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(223, 79);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(181, 20);
            this.tbUsername.TabIndex = 2;
            this.ttMain.SetToolTip(this.tbUsername, "Username to use with the API");
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(223, 105);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(181, 20);
            this.tbPassword.TabIndex = 2;
            this.ttMain.SetToolTip(this.tbPassword, "Password for the API");
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // lblPWchange
            // 
            this.lblPWchange.AutoSize = true;
            this.lblPWchange.BackColor = System.Drawing.SystemColors.Window;
            this.lblPWchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWchange.Location = new System.Drawing.Point(278, 108);
            this.lblPWchange.Name = "lblPWchange";
            this.lblPWchange.Size = new System.Drawing.Size(67, 13);
            this.lblPWchange.TabIndex = 3;
            this.lblPWchange.Text = "[unchanged]";
            this.ttMain.SetToolTip(this.lblPWchange, "Password for the API");
            this.lblPWchange.Click += new System.EventHandler(this.lblPWchange_Click);
            // 
            // tbDest
            // 
            this.tbDest.Location = new System.Drawing.Point(223, 54);
            this.tbDest.Name = "tbDest";
            this.tbDest.Size = new System.Drawing.Size(181, 20);
            this.tbDest.TabIndex = 2;
            this.tbDest.Text = "127.0.0.1:8442";
            this.ttMain.SetToolTip(this.tbDest, "The address the client listens on.\r\nThis is in the format of <host>:<port>\r\nHost " +
                    "can be an IP or a DNS name.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 2;
            this.ttMain.SetToolTip(this.textBox1, resources.GetString("textBox1.ToolTip"));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // ttMain
            // 
            this.ttMain.AutoPopDelay = 5000;
            this.ttMain.InitialDelay = 1000;
            this.ttMain.IsBalloon = true;
            this.ttMain.ReshowDelay = 1;
            this.ttMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttMain.ToolTipTitle = "Quick Help";
            this.ttMain.UseAnimation = false;
            this.ttMain.UseFading = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(344, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.CMS.Name = "CMS";
            this.CMS.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Right click on the Client list to delete clients.";
            // 
            // frmPyBitmessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 196);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPWchange);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbDest);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.gbClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPyBitmessage";
            this.Text = "PyBitmessage API settings";
            this.gbClients.ResumeLayout(false);
            this.CMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.GroupBox gbClients;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPWchange;
        private System.Windows.Forms.TextBox tbDest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label5;
    }
}