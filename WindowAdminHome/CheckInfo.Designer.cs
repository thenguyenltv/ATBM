
namespace WindowAdminHome
{
    partial class CheckInfo
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
            this.Check_list = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.TextBox();
            this.labelUsr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Check_list)).BeginInit();
            this.SuspendLayout();
            // 
            // Check_list
            // 
            this.Check_list.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Check_list.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Check_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Check_list.GridColor = System.Drawing.SystemColors.Control;
            this.Check_list.Location = new System.Drawing.Point(12, 57);
            this.Check_list.Name = "Check_list";
            this.Check_list.RowHeadersWidth = 51;
            this.Check_list.RowTemplate.Height = 24;
            this.Check_list.Size = new System.Drawing.Size(755, 327);
            this.Check_list.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(125, 15);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(222, 22);
            this.Search.TabIndex = 2;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // labelUsr
            // 
            this.labelUsr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsr.AutoSize = true;
            this.labelUsr.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelUsr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelUsr.Location = new System.Drawing.Point(12, 14);
            this.labelUsr.Name = "labelUsr";
            this.labelUsr.Size = new System.Drawing.Size(66, 21);
            this.labelUsr.TabIndex = 22;
            this.labelUsr.Text = "Name:";
            this.labelUsr.Click += new System.EventHandler(this.labelUsr_Click);
            // 
            // CheckInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 391);
            this.ControlBox = false;
            this.Controls.Add(this.labelUsr);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Check_list);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.Check_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Check_list;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label labelUsr;
    }
}