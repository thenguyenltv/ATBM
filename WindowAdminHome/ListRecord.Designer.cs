
namespace WindowAdminHome
{
    partial class ListRecord
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
            this.Record_list = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.TextBox();
            this.labelObject = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Record_list)).BeginInit();
            this.SuspendLayout();
            // 
            // Record_list
            // 
            this.Record_list.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Record_list.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Record_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Record_list.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Record_list.GridColor = System.Drawing.SystemColors.Control;
            this.Record_list.Location = new System.Drawing.Point(12, 57);
            this.Record_list.Name = "Record_list";
            this.Record_list.RowHeadersWidth = 51;
            this.Record_list.RowTemplate.Height = 24;
            this.Record_list.Size = new System.Drawing.Size(755, 327);
            this.Record_list.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(125, 15);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(222, 22);
            this.Search.TabIndex = 2;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // labelObject
            // 
            this.labelObject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelObject.AutoSize = true;
            this.labelObject.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelObject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelObject.Location = new System.Drawing.Point(12, 14);
            this.labelObject.Name = "labelObject";
            this.labelObject.Size = new System.Drawing.Size(98, 21);
            this.labelObject.TabIndex = 20;
            this.labelObject.Text = "Username:";
            // 
            // ListUsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 391);
            this.ControlBox = false;
            this.Controls.Add(this.labelObject);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Record_list);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListUsr";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.Record_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Record_list;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label labelObject;
    }
}