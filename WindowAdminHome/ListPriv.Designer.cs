
namespace WindowAdminHome
{
    partial class ListPriv
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
            this.Priv_List = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.TextBox();
            this.labelUsr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Priv_List)).BeginInit();
            this.SuspendLayout();
            // 
            // Priv_List
            // 
            this.Priv_List.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Priv_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Priv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Priv_List.GridColor = System.Drawing.SystemColors.Control;
            this.Priv_List.Location = new System.Drawing.Point(12, 57);
            this.Priv_List.Name = "Priv_List";
            this.Priv_List.RowHeadersWidth = 51;
            this.Priv_List.RowTemplate.Height = 24;
            this.Priv_List.Size = new System.Drawing.Size(755, 327);
            this.Priv_List.TabIndex = 0;
            this.Priv_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Priv_List_CellContentClick);
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
            this.labelUsr.Size = new System.Drawing.Size(92, 21);
            this.labelUsr.TabIndex = 21;
            this.labelUsr.Text = "Privname:";
            // 
            // ListPriv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 391);
            this.ControlBox = false;
            this.Controls.Add(this.labelUsr);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Priv_List);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListPriv";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.Priv_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Priv_List;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label labelUsr;
    }
}