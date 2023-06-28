namespace WindowAdminHome
{
    partial class ChildHome
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
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.oracleCommand2 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // oracleCommand2
            // 
            this.oracleCommand2.Transaction = null;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Chiller", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.Black;
            this.labelWelcome.Location = new System.Drawing.Point(290, 195);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(535, 97);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "Group 15 - HCMUS";
            // 
            // ChildHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 504);
            this.Controls.Add(this.labelWelcome);
            this.Name = "ChildHome";
            this.Text = "ChildHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand2;
        private System.Windows.Forms.Label labelWelcome;
    }
}