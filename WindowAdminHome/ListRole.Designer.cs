
namespace WindowAdminHome
{
    partial class ListRole
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
            this.Role_list = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.TextBox();
            this.labelUsr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Role_list)).BeginInit();
            this.SuspendLayout();
            // 
            // Role_list
            // 
            this.Role_list.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Role_list.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Role_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Role_list.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Role_list.GridColor = System.Drawing.SystemColors.Control;
            this.Role_list.Location = new System.Drawing.Point(12, 57);
            this.Role_list.Name = "Role_list";
            this.Role_list.RowHeadersWidth = 51;
            this.Role_list.RowTemplate.Height = 24;
            this.Role_list.Size = new System.Drawing.Size(755, 327);
            this.Role_list.TabIndex = 0;
            this.Role_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Role_list_CellContentClick);
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
            this.labelUsr.Size = new System.Drawing.Size(103, 21);
            this.labelUsr.TabIndex = 20;
            this.labelUsr.Text = "Role name:";
            // 
            // ListRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 391);
            this.ControlBox = false;
            this.Controls.Add(this.labelUsr);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Role_list);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListRole";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.Role_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Role_list;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label labelUsr;
    }
}