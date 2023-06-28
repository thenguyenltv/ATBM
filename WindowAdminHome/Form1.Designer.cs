using System.Windows.Forms;

namespace WindowAdminHome
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelDevBy = new System.Windows.Forms.Label();
            this.labelManaSys = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBoxTheme = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.labelAddr = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelPwd = new System.Windows.Forms.Panel();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.pictureBoxLock = new System.Windows.Forms.PictureBox();
            this.panelUsr = new System.Windows.Forms.Panel();
            this.textBoxUsr = new System.Windows.Forms.TextBox();
            this.pictureBoxUsr = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTheme)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panelPwd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLock)).BeginInit();
            this.panelUsr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsr)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelLeft.Controls.Add(this.labelDevBy);
            this.panelLeft.Controls.Add(this.labelManaSys);
            this.panelLeft.Controls.Add(this.labelWelcome);
            this.panelLeft.Controls.Add(this.pictureBoxTheme);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(300, 530);
            this.panelLeft.TabIndex = 0;
            // 
            // labelDevBy
            // 
            this.labelDevBy.AutoSize = true;
            this.labelDevBy.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.labelDevBy.ForeColor = System.Drawing.Color.White;
            this.labelDevBy.Location = new System.Drawing.Point(130, 477);
            this.labelDevBy.Name = "labelDevBy";
            this.labelDevBy.Size = new System.Drawing.Size(151, 19);
            this.labelDevBy.TabIndex = 2;
            this.labelDevBy.Text = "Develop By Group15";
            // 
            // labelManaSys
            // 
            this.labelManaSys.AutoSize = true;
            this.labelManaSys.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.labelManaSys.ForeColor = System.Drawing.Color.White;
            this.labelManaSys.Location = new System.Drawing.Point(16, 271);
            this.labelManaSys.Name = "labelManaSys";
            this.labelManaSys.Size = new System.Drawing.Size(254, 27);
            this.labelManaSys.TabIndex = 1;
            this.labelManaSys.Text = "Management System";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(80, 232);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(201, 27);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome to the ";
            // 
            // pictureBoxTheme
            // 
            this.pictureBoxTheme.Image = global::WindowAdminHome.Properties.Resources.theme;
            this.pictureBoxTheme.Location = new System.Drawing.Point(38, 21);
            this.pictureBoxTheme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxTheme.Name = "pictureBoxTheme";
            this.pictureBoxTheme.Size = new System.Drawing.Size(232, 161);
            this.pictureBoxTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTheme.TabIndex = 0;
            this.pictureBoxTheme.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelRight.Controls.Add(this.labelAddr);
            this.panelRight.Controls.Add(this.labelContact);
            this.panelRight.Controls.Add(this.buttonLogin);
            this.panelRight.Controls.Add(this.panelPwd);
            this.panelRight.Controls.Add(this.panelUsr);
            this.panelRight.Controls.Add(this.labelLogin);
            this.panelRight.Controls.Add(this.btExit);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(300, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(450, 530);
            this.panelRight.TabIndex = 1;
            // 
            // labelAddr
            // 
            this.labelAddr.AutoSize = true;
            this.labelAddr.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.labelAddr.ForeColor = System.Drawing.Color.DarkGray;
            this.labelAddr.Location = new System.Drawing.Point(134, 502);
            this.labelAddr.Name = "labelAddr";
            this.labelAddr.Size = new System.Drawing.Size(162, 19);
            this.labelAddr.TabIndex = 9;
            this.labelAddr.Text = "HCMUS - HCMC - 2023";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.labelContact.ForeColor = System.Drawing.Color.DarkGray;
            this.labelContact.Location = new System.Drawing.Point(187, 477);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(67, 19);
            this.labelContact.TabIndex = 3;
            this.labelContact.Text = "Contact";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(174, 307);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(104, 37);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelPwd
            // 
            this.panelPwd.BackColor = System.Drawing.Color.White;
            this.panelPwd.Controls.Add(this.textBoxPwd);
            this.panelPwd.Controls.Add(this.pictureBoxLock);
            this.panelPwd.Location = new System.Drawing.Point(0, 235);
            this.panelPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPwd.Name = "panelPwd";
            this.panelPwd.Size = new System.Drawing.Size(450, 45);
            this.panelPwd.TabIndex = 5;
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPwd.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBoxPwd.ForeColor = System.Drawing.Color.Silver;
            this.textBoxPwd.Location = new System.Drawing.Point(57, 14);
            this.textBoxPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(374, 21);
            this.textBoxPwd.TabIndex = 2;
            this.textBoxPwd.Text = "Password";
            // 
            // pictureBoxLock
            // 
            this.pictureBoxLock.Image = global::WindowAdminHome.Properties.Resources.lock1;
            this.pictureBoxLock.Location = new System.Drawing.Point(6, 7);
            this.pictureBoxLock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLock.Name = "pictureBoxLock";
            this.pictureBoxLock.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLock.TabIndex = 1;
            this.pictureBoxLock.TabStop = false;
            // 
            // panelUsr
            // 
            this.panelUsr.BackColor = System.Drawing.Color.White;
            this.panelUsr.Controls.Add(this.textBoxUsr);
            this.panelUsr.Controls.Add(this.pictureBoxUsr);
            this.panelUsr.Location = new System.Drawing.Point(0, 188);
            this.panelUsr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUsr.Name = "panelUsr";
            this.panelUsr.Size = new System.Drawing.Size(450, 51);
            this.panelUsr.TabIndex = 4;
            // 
            // textBoxUsr
            // 
            this.textBoxUsr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUsr.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBoxUsr.ForeColor = System.Drawing.Color.Silver;
            this.textBoxUsr.Location = new System.Drawing.Point(57, 18);
            this.textBoxUsr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsr.Name = "textBoxUsr";
            this.textBoxUsr.Size = new System.Drawing.Size(374, 21);
            this.textBoxUsr.TabIndex = 3;
            this.textBoxUsr.Text = "Please Enter Your Name";
            // 
            // pictureBoxUsr
            // 
            this.pictureBoxUsr.Image = global::WindowAdminHome.Properties.Resources.user1;
            this.pictureBoxUsr.Location = new System.Drawing.Point(6, 11);
            this.pictureBoxUsr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUsr.Name = "pictureBoxUsr";
            this.pictureBoxUsr.Size = new System.Drawing.Size(34, 31);
            this.pictureBoxUsr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsr.TabIndex = 0;
            this.pictureBoxUsr.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelLogin.Location = new System.Drawing.Point(99, 125);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(260, 27);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Login to your account";
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold);
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            this.btExit.Location = new System.Drawing.Point(404, 0);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(46, 45);
            this.btExit.TabIndex = 0;
            this.btExit.Text = "X";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTheme)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelPwd.ResumeLayout(false);
            this.panelPwd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLock)).EndInit();
            this.panelUsr.ResumeLayout(false);
            this.panelUsr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLeft;
        private PictureBox pictureBoxTheme;
        private Panel panelRight;
        private Label labelDevBy;
        private Label labelManaSys;
        private Label labelWelcome;
        private Button btExit;
        private Panel panelPwd;
        private TextBox textBoxPwd;
        private PictureBox pictureBoxLock;
        private Panel panelUsr;
        private PictureBox pictureBoxUsr;
        private Label labelLogin;
        private TextBox textBoxUsr;
        private Button buttonLogin;
        private Label labelAddr;
        private Label labelContact;
    }
}

