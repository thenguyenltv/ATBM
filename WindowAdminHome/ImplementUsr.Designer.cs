
namespace WindowAdminHome
{
    partial class ImplementUsr
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
            this.name = new System.Windows.Forms.TextBox();
            this.Cancel_bt = new System.Windows.Forms.Button();
            this.Create_bt = new System.Windows.Forms.Button();
            this.Drop_bt = new System.Windows.Forms.Button();
            this.passwordBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password: ";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(169, 75);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(313, 22);
            this.name.TabIndex = 2;
            // 
            // Cancel_bt
            // 
            this.Cancel_bt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancel_bt.Location = new System.Drawing.Point(494, 323);
            this.Cancel_bt.Name = "Cancel_bt";
            this.Cancel_bt.Size = new System.Drawing.Size(99, 28);
            this.Cancel_bt.TabIndex = 6;
            this.Cancel_bt.Text = "Cancel";
            this.Cancel_bt.UseVisualStyleBackColor = false;
            this.Cancel_bt.Click += new System.EventHandler(this.Cancel_bt_Click);
            // 
            // Create_bt
            // 
            this.Create_bt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Create_bt.Location = new System.Drawing.Point(271, 323);
            this.Create_bt.Name = "Create_bt";
            this.Create_bt.Size = new System.Drawing.Size(99, 28);
            this.Create_bt.TabIndex = 9;
            this.Create_bt.Text = "Create";
            this.Create_bt.UseVisualStyleBackColor = false;
            this.Create_bt.Click += new System.EventHandler(this.Create_bt_Click);
            // 
            // Drop_bt
            // 
            this.Drop_bt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Drop_bt.Location = new System.Drawing.Point(382, 323);
            this.Drop_bt.Name = "Drop_bt";
            this.Drop_bt.Size = new System.Drawing.Size(100, 28);
            this.Drop_bt.TabIndex = 10;
            this.Drop_bt.Text = "Drop";
            this.Drop_bt.UseVisualStyleBackColor = false;
            this.Drop_bt.Click += new System.EventHandler(this.Drop_bt_Click);
            // 
            // passwordBox1
            // 
            this.passwordBox1.Location = new System.Drawing.Point(169, 118);
            this.passwordBox1.MaxLength = 14;
            this.passwordBox1.Name = "passwordBox1";
            this.passwordBox1.PasswordChar = '*';
            this.passwordBox1.Size = new System.Drawing.Size(313, 22);
            this.passwordBox1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.passwordBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 281);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(157, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Alter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImplementUsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Drop_bt);
            this.Controls.Add(this.Create_bt);
            this.Controls.Add(this.Cancel_bt);
            this.Name = "ImplementUsr";
            this.Text = "Implement user";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button Cancel_bt;
        private System.Windows.Forms.Button Create_bt;
        private System.Windows.Forms.Button Drop_bt;
        private System.Windows.Forms.TextBox passwordBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}