
namespace WindowAdminHome
{
    partial class GrantRole
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usrn = new System.Windows.Forms.TextBox();
            this.Cancel_bt = new System.Windows.Forms.Button();
            this.Grant_bt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rolename:";
            // 
            // usrn
            // 
            this.usrn.Location = new System.Drawing.Point(136, 26);
            this.usrn.Name = "usrn";
            this.usrn.Size = new System.Drawing.Size(220, 22);
            this.usrn.TabIndex = 2;
            // 
            // Cancel_bt
            // 
            this.Cancel_bt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancel_bt.Location = new System.Drawing.Point(552, 485);
            this.Cancel_bt.Name = "Cancel_bt";
            this.Cancel_bt.Size = new System.Drawing.Size(94, 25);
            this.Cancel_bt.TabIndex = 6;
            this.Cancel_bt.Text = "Cancel";
            this.Cancel_bt.UseVisualStyleBackColor = false;
            this.Cancel_bt.Click += new System.EventHandler(this.Cancel_bt_Click);
            // 
            // Grant_bt
            // 
            this.Grant_bt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Grant_bt.Location = new System.Drawing.Point(440, 485);
            this.Grant_bt.Name = "Grant_bt";
            this.Grant_bt.Size = new System.Drawing.Size(94, 25);
            this.Grant_bt.TabIndex = 7;
            this.Grant_bt.Text = "Grant";
            this.Grant_bt.UseVisualStyleBackColor = false;
            this.Grant_bt.Click += new System.EventHandler(this.Grant_bt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.usrn);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 447);
            this.panel1.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // GrantRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(657, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cancel_bt);
            this.Controls.Add(this.Grant_bt);
            this.Name = "GrantRole";
            this.Text = "Grant role to user";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usrn;
        private System.Windows.Forms.Button Cancel_bt;
        private System.Windows.Forms.Button Grant_bt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}