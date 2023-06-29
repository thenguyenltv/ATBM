
namespace WindowAdminHome
{
    partial class listPhanCong
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
            this.labelMaNV = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textTime = new System.Windows.Forms.DateTimePicker();
            this.textMaNV = new System.Windows.Forms.ComboBox();
            this.textMaDA = new System.Windows.Forms.ComboBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelMaDA = new System.Windows.Forms.Label();
            this.labelListAssignment = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Priv_List)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Priv_List
            // 
            this.Priv_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Priv_List.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Priv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Priv_List.GridColor = System.Drawing.SystemColors.Control;
            this.Priv_List.Location = new System.Drawing.Point(444, 126);
            this.Priv_List.Name = "Priv_List";
            this.Priv_List.RowHeadersWidth = 51;
            this.Priv_List.RowTemplate.Height = 24;
            this.Priv_List.Size = new System.Drawing.Size(703, 402);
            this.Priv_List.TabIndex = 0;
            // 
            // labelMaNV
            // 
            this.labelMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelMaNV.ForeColor = System.Drawing.Color.Black;
            this.labelMaNV.Location = new System.Drawing.Point(38, 126);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(70, 21);
            this.labelMaNV.TabIndex = 37;
            this.labelMaNV.Text = "Ma NV";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textTime);
            this.panel1.Controls.Add(this.textMaNV);
            this.panel1.Controls.Add(this.textMaDA);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.btUpdate);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.labelMaDA);
            this.panel1.Controls.Add(this.labelMaNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 533);
            this.panel1.TabIndex = 38;
            // 
            // textTime
            // 
            this.textTime.Location = new System.Drawing.Point(151, 192);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(222, 22);
            this.textTime.TabIndex = 62;
            // 
            // textMaNV
            // 
            this.textMaNV.FormattingEnabled = true;
            this.textMaNV.Location = new System.Drawing.Point(151, 124);
            this.textMaNV.Name = "textMaNV";
            this.textMaNV.Size = new System.Drawing.Size(221, 24);
            this.textMaNV.TabIndex = 61;
            // 
            // textMaDA
            // 
            this.textMaDA.FormattingEnabled = true;
            this.textMaDA.Location = new System.Drawing.Point(151, 157);
            this.textMaDA.Name = "textMaDA";
            this.textMaDA.Size = new System.Drawing.Size(222, 24);
            this.textMaDA.TabIndex = 60;
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Location = new System.Drawing.Point(296, 490);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(77, 29);
            this.btDelete.TabIndex = 59;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Location = new System.Drawing.Point(42, 490);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(77, 29);
            this.btAdd.TabIndex = 58;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdate.Location = new System.Drawing.Point(169, 490);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(77, 29);
            this.btUpdate.TabIndex = 56;
            this.btUpdate.Text = "Sửa";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelTime.ForeColor = System.Drawing.Color.Black;
            this.labelTime.Location = new System.Drawing.Point(38, 192);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(83, 21);
            this.labelTime.TabIndex = 41;
            this.labelTime.Text = "Thoi gian";
            // 
            // labelMaDA
            // 
            this.labelMaDA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaDA.AutoSize = true;
            this.labelMaDA.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelMaDA.ForeColor = System.Drawing.Color.Black;
            this.labelMaDA.Location = new System.Drawing.Point(38, 157);
            this.labelMaDA.Name = "labelMaDA";
            this.labelMaDA.Size = new System.Drawing.Size(70, 21);
            this.labelMaDA.TabIndex = 39;
            this.labelMaDA.Text = "Ma DA";
            // 
            // labelListAssignment
            // 
            this.labelListAssignment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelListAssignment.AutoSize = true;
            this.labelListAssignment.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.labelListAssignment.ForeColor = System.Drawing.Color.Black;
            this.labelListAssignment.Location = new System.Drawing.Point(645, 45);
            this.labelListAssignment.Name = "labelListAssignment";
            this.labelListAssignment.Size = new System.Drawing.Size(306, 32);
            this.labelListAssignment.TabIndex = 40;
            this.labelListAssignment.Text = "Danh sách phân công";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelListAssignment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 533);
            this.panel2.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 42;
            this.label1.Text = "Thao tác Chính sách";
            // 
            // listPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1159, 533);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Priv_List);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(783, 542);
            this.Name = "listPhanCong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.Priv_List)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Priv_List;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelMaDA;
        private System.Windows.Forms.Label labelListAssignment;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox textMaDA;
        private System.Windows.Forms.ComboBox textMaNV;
        private System.Windows.Forms.DateTimePicker textTime;
        private System.Windows.Forms.Label label1;
    }
}