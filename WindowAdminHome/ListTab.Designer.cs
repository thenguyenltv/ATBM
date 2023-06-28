
namespace WindowAdminHome
{
    partial class ListTab
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
            this.TabList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TabList)).BeginInit();
            this.SuspendLayout();
            // 
            // TabList
            // 
            this.TabList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TabList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TabList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabList.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TabList.GridColor = System.Drawing.SystemColors.Control;
            this.TabList.Location = new System.Drawing.Point(12, 57);
            this.TabList.Name = "TabList";
            this.TabList.RowHeadersWidth = 51;
            this.TabList.RowTemplate.Height = 24;
            this.TabList.Size = new System.Drawing.Size(755, 327);
            this.TabList.TabIndex = 0;
            // 
            // ListTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 391);
            this.ControlBox = false;
            this.Controls.Add(this.TabList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListTab";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.TabList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TabList;
    }
}