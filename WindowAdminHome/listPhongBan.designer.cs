
namespace WindowAdminHome
{
    partial class listPhongBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textTrgPhg = new System.Windows.Forms.ComboBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.labelLead = new System.Windows.Forms.Label();
            this.labelTenPB = new System.Windows.Forms.Label();
            this.textTenPB = new System.Windows.Forms.TextBox();
            this.labelMaPB = new System.Windows.Forms.Label();
            this.textMaPB = new System.Windows.Forms.TextBox();
            this.labelListZoom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Priv_List)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Priv_List
            // 
            this.Priv_List.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Priv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Priv_List.GridColor = System.Drawing.SystemColors.Control;
            this.Priv_List.Location = new System.Drawing.Point(444, 126);
            this.Priv_List.Name = "Priv_List";
            this.Priv_List.RowHeadersWidth = 51;
            this.Priv_List.RowTemplate.Height = 24;
            this.Priv_List.Size = new System.Drawing.Size(693, 397);
            this.Priv_List.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textTrgPhg);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.btUpdate);
            this.panel1.Controls.Add(this.labelLead);
            this.panel1.Controls.Add(this.labelTenPB);
            this.panel1.Controls.Add(this.textTenPB);
            this.panel1.Controls.Add(this.labelMaPB);
            this.panel1.Controls.Add(this.textMaPB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 533);
            this.panel1.TabIndex = 38;
            // 
            // textTrgPhg
            // 
            this.textTrgPhg.FormattingEnabled = true;
            this.textTrgPhg.Location = new System.Drawing.Point(149, 193);
            this.textTrgPhg.Name = "textTrgPhg";
            this.textTrgPhg.Size = new System.Drawing.Size(222, 24);
            this.textTrgPhg.TabIndex = 70;
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Location = new System.Drawing.Point(218, 492);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(77, 29);
            this.btDelete.TabIndex = 69;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Location = new System.Drawing.Point(29, 492);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(77, 29);
            this.btAdd.TabIndex = 68;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdate.Location = new System.Drawing.Point(121, 492);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(77, 29);
            this.btUpdate.TabIndex = 66;
            this.btUpdate.Text = "Sửa";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // labelLead
            // 
            this.labelLead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLead.AutoSize = true;
            this.labelLead.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelLead.ForeColor = System.Drawing.Color.Black;
            this.labelLead.Location = new System.Drawing.Point(36, 192);
            this.labelLead.Name = "labelLead";
            this.labelLead.Size = new System.Drawing.Size(65, 21);
            this.labelLead.TabIndex = 65;
            this.labelLead.Text = "TrgPhg";
            // 
            // labelTenPB
            // 
            this.labelTenPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTenPB.AutoSize = true;
            this.labelTenPB.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelTenPB.ForeColor = System.Drawing.Color.Black;
            this.labelTenPB.Location = new System.Drawing.Point(36, 157);
            this.labelTenPB.Name = "labelTenPB";
            this.labelTenPB.Size = new System.Drawing.Size(64, 21);
            this.labelTenPB.TabIndex = 63;
            this.labelTenPB.Text = "Ten PB";
            // 
            // textTenPB
            // 
            this.textTenPB.Location = new System.Drawing.Point(149, 158);
            this.textTenPB.Name = "textTenPB";
            this.textTenPB.Size = new System.Drawing.Size(222, 22);
            this.textTenPB.TabIndex = 62;
            // 
            // labelMaPB
            // 
            this.labelMaPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaPB.AutoSize = true;
            this.labelMaPB.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelMaPB.ForeColor = System.Drawing.Color.Black;
            this.labelMaPB.Location = new System.Drawing.Point(36, 126);
            this.labelMaPB.Name = "labelMaPB";
            this.labelMaPB.Size = new System.Drawing.Size(64, 21);
            this.labelMaPB.TabIndex = 61;
            this.labelMaPB.Text = "Ma PB";
            // 
            // textMaPB
            // 
            this.textMaPB.Location = new System.Drawing.Point(149, 127);
            this.textMaPB.Name = "textMaPB";
            this.textMaPB.Size = new System.Drawing.Size(222, 22);
            this.textMaPB.TabIndex = 60;
            // 
            // labelListZoom
            // 
            this.labelListZoom.AutoSize = true;
            this.labelListZoom.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.labelListZoom.ForeColor = System.Drawing.Color.Black;
            this.labelListZoom.Location = new System.Drawing.Point(680, 47);
            this.labelListZoom.Name = "labelListZoom";
            this.labelListZoom.Size = new System.Drawing.Size(307, 32);
            this.labelListZoom.TabIndex = 40;
            this.labelListZoom.Text = "Danh sách phòng ban";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 533);
            this.panel2.TabIndex = 41;
            // 
            // listPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1159, 533);
            this.ControlBox = false;
            this.Controls.Add(this.labelListZoom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Priv_List);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "listPhongBan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.Priv_List)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Priv_List;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelListZoom;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label labelLead;
        private System.Windows.Forms.Label labelTenPB;
        private System.Windows.Forms.TextBox textTenPB;
        private System.Windows.Forms.Label labelMaPB;
        private System.Windows.Forms.TextBox textMaPB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox textTrgPhg;
    }
}