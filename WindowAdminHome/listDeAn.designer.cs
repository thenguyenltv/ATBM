
namespace WindowAdminHome
{
    partial class listDeAn
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
            this.labelTenDa = new System.Windows.Forms.Label();
            this.textTenDA = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textNgayBD = new System.Windows.Forms.DateTimePicker();
            this.textPhong = new System.Windows.Forms.ComboBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.labelPhong = new System.Windows.Forms.Label();
            this.labelNgayBD = new System.Windows.Forms.Label();
            this.labelMaDA = new System.Windows.Forms.Label();
            this.textMaDa = new System.Windows.Forms.TextBox();
            this.labelListProject = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Priv_List)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Priv_List
            // 
            this.Priv_List.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Priv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Priv_List.GridColor = System.Drawing.SystemColors.Control;
            this.Priv_List.Location = new System.Drawing.Point(20, 124);
            this.Priv_List.Name = "Priv_List";
            this.Priv_List.RowHeadersWidth = 51;
            this.Priv_List.RowTemplate.Height = 24;
            this.Priv_List.Size = new System.Drawing.Size(693, 397);
            this.Priv_List.TabIndex = 0;
            // 
            // labelTenDa
            // 
            this.labelTenDa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTenDa.AutoSize = true;
            this.labelTenDa.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelTenDa.ForeColor = System.Drawing.Color.Black;
            this.labelTenDa.Location = new System.Drawing.Point(40, 161);
            this.labelTenDa.Name = "labelTenDa";
            this.labelTenDa.Size = new System.Drawing.Size(70, 21);
            this.labelTenDa.TabIndex = 37;
            this.labelTenDa.Text = "Ten DA";
            // 
            // textTenDA
            // 
            this.textTenDA.Location = new System.Drawing.Point(153, 162);
            this.textTenDA.Name = "textTenDA";
            this.textTenDA.Size = new System.Drawing.Size(222, 22);
            this.textTenDA.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textNgayBD);
            this.panel1.Controls.Add(this.textPhong);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.btUpdate);
            this.panel1.Controls.Add(this.labelPhong);
            this.panel1.Controls.Add(this.labelNgayBD);
            this.panel1.Controls.Add(this.labelTenDa);
            this.panel1.Controls.Add(this.textTenDA);
            this.panel1.Controls.Add(this.labelMaDA);
            this.panel1.Controls.Add(this.textMaDa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 533);
            this.panel1.TabIndex = 38;
            // 
            // textNgayBD
            // 
            this.textNgayBD.Location = new System.Drawing.Point(153, 192);
            this.textNgayBD.Name = "textNgayBD";
            this.textNgayBD.Size = new System.Drawing.Size(222, 22);
            this.textNgayBD.TabIndex = 61;
            // 
            // textPhong
            // 
            this.textPhong.FormattingEnabled = true;
            this.textPhong.Location = new System.Drawing.Point(153, 228);
            this.textPhong.Name = "textPhong";
            this.textPhong.Size = new System.Drawing.Size(221, 24);
            this.textPhong.TabIndex = 60;
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Location = new System.Drawing.Point(297, 494);
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
            this.btAdd.Location = new System.Drawing.Point(45, 494);
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
            this.btUpdate.Location = new System.Drawing.Point(171, 494);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(77, 29);
            this.btUpdate.TabIndex = 56;
            this.btUpdate.Text = "Sửa";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // labelPhong
            // 
            this.labelPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhong.AutoSize = true;
            this.labelPhong.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelPhong.ForeColor = System.Drawing.Color.Black;
            this.labelPhong.Location = new System.Drawing.Point(40, 227);
            this.labelPhong.Name = "labelPhong";
            this.labelPhong.Size = new System.Drawing.Size(62, 21);
            this.labelPhong.TabIndex = 41;
            this.labelPhong.Text = "Phong";
            // 
            // labelNgayBD
            // 
            this.labelNgayBD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNgayBD.AutoSize = true;
            this.labelNgayBD.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelNgayBD.ForeColor = System.Drawing.Color.Black;
            this.labelNgayBD.Location = new System.Drawing.Point(40, 192);
            this.labelNgayBD.Name = "labelNgayBD";
            this.labelNgayBD.Size = new System.Drawing.Size(82, 21);
            this.labelNgayBD.TabIndex = 39;
            this.labelNgayBD.Text = "Ngay BD";
            // 
            // labelMaDA
            // 
            this.labelMaDA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaDA.AutoSize = true;
            this.labelMaDA.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelMaDA.ForeColor = System.Drawing.Color.Black;
            this.labelMaDA.Location = new System.Drawing.Point(40, 126);
            this.labelMaDA.Name = "labelMaDA";
            this.labelMaDA.Size = new System.Drawing.Size(70, 21);
            this.labelMaDA.TabIndex = 35;
            this.labelMaDA.Text = "Ma DA";
            // 
            // textMaDa
            // 
            this.textMaDa.Location = new System.Drawing.Point(153, 127);
            this.textMaDa.Name = "textMaDa";
            this.textMaDa.Size = new System.Drawing.Size(222, 22);
            this.textMaDa.TabIndex = 34;
            this.textMaDa.TextChanged += new System.EventHandler(this.textMaDa_TextChanged);
            // 
            // labelListProject
            // 
            this.labelListProject.AutoSize = true;
            this.labelListProject.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.labelListProject.ForeColor = System.Drawing.Color.Black;
            this.labelListProject.Location = new System.Drawing.Point(243, 52);
            this.labelListProject.Name = "labelListProject";
            this.labelListProject.Size = new System.Drawing.Size(238, 32);
            this.labelListProject.TabIndex = 40;
            this.labelListProject.Text = "Danh sách đề án";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelListProject);
            this.panel2.Controls.Add(this.Priv_List);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(421, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 533);
            this.panel2.TabIndex = 41;
            // 
            // listDeAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1159, 533);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "listDeAn";
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
        private System.Windows.Forms.Label labelTenDa;
        private System.Windows.Forms.TextBox textTenDA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPhong;
        private System.Windows.Forms.Label labelNgayBD;
        private System.Windows.Forms.Label labelListProject;
        private System.Windows.Forms.Label labelMaDA;
        private System.Windows.Forms.TextBox textMaDa;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox textPhong;
        private System.Windows.Forms.DateTimePicker textNgayBD;
    }
}