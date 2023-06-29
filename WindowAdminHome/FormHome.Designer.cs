
namespace WindowAdminHome
{
    partial class FormHome
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
            this.PanelTable = new System.Windows.Forms.Panel();
            this.List_user = new System.Windows.Forms.Button();
            this.List_table_bt = new System.Windows.Forms.Button();
            this.L_privs_bt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.List_role = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSubPrivs = new System.Windows.Forms.Panel();
            this.btnRevokePrivs = new System.Windows.Forms.Button();
            this.btnGrantPrivs = new System.Windows.Forms.Button();
            this.btnPrivs = new System.Windows.Forms.Button();
            this.panelSubCreate = new System.Windows.Forms.Panel();
            this.btnCreRole = new System.Windows.Forms.Button();
            this.btnCreUsr = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panelSubList = new System.Windows.Forms.Panel();
            this.List_record = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLogout = new System.Windows.Forms.Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.panel1.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelSubPrivs.SuspendLayout();
            this.panelSubCreate.SuspendLayout();
            this.panelSubList.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTable
            // 
            this.PanelTable.AutoSize = true;
            this.PanelTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelTable.Location = new System.Drawing.Point(197, 156);
            this.PanelTable.Name = "PanelTable";
            this.PanelTable.Size = new System.Drawing.Size(797, 409);
            this.PanelTable.TabIndex = 2;
            // 
            // List_user
            // 
            this.List_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(141)))));
            this.List_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.List_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.List_user.FlatAppearance.BorderSize = 0;
            this.List_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.List_user.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_user.ForeColor = System.Drawing.Color.White;
            this.List_user.Location = new System.Drawing.Point(0, 111);
            this.List_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.List_user.Name = "List_user";
            this.List_user.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.List_user.Size = new System.Drawing.Size(170, 37);
            this.List_user.TabIndex = 11;
            this.List_user.Text = "List User";
            this.List_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.List_user.UseVisualStyleBackColor = false;
            this.List_user.Click += new System.EventHandler(this.List_user_Click);
            // 
            // List_table_bt
            // 
            this.List_table_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(141)))));
            this.List_table_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.List_table_bt.Dock = System.Windows.Forms.DockStyle.Top;
            this.List_table_bt.FlatAppearance.BorderSize = 0;
            this.List_table_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.List_table_bt.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_table_bt.ForeColor = System.Drawing.Color.White;
            this.List_table_bt.Location = new System.Drawing.Point(0, 148);
            this.List_table_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.List_table_bt.Name = "List_table_bt";
            this.List_table_bt.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.List_table_bt.Size = new System.Drawing.Size(170, 37);
            this.List_table_bt.TabIndex = 12;
            this.List_table_bt.Text = "List Table";
            this.List_table_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.List_table_bt.UseVisualStyleBackColor = false;
            this.List_table_bt.Click += new System.EventHandler(this.List_table_bt_Click);
            // 
            // L_privs_bt
            // 
            this.L_privs_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(141)))));
            this.L_privs_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.L_privs_bt.Dock = System.Windows.Forms.DockStyle.Top;
            this.L_privs_bt.FlatAppearance.BorderSize = 0;
            this.L_privs_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.L_privs_bt.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_privs_bt.ForeColor = System.Drawing.Color.White;
            this.L_privs_bt.Location = new System.Drawing.Point(0, 37);
            this.L_privs_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.L_privs_bt.Name = "L_privs_bt";
            this.L_privs_bt.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.L_privs_bt.Size = new System.Drawing.Size(170, 37);
            this.L_privs_bt.TabIndex = 13;
            this.L_privs_bt.Text = "List Privs";
            this.L_privs_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_privs_bt.UseVisualStyleBackColor = false;
            this.L_privs_bt.Click += new System.EventHandler(this.L_privs_bt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.labelWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 52);
            this.panel1.TabIndex = 18;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(251, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(520, 35);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Account Managment Application";
            // 
            // List_role
            // 
            this.List_role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(141)))));
            this.List_role.Cursor = System.Windows.Forms.Cursors.Hand;
            this.List_role.Dock = System.Windows.Forms.DockStyle.Top;
            this.List_role.FlatAppearance.BorderSize = 0;
            this.List_role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.List_role.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_role.ForeColor = System.Drawing.Color.White;
            this.List_role.Location = new System.Drawing.Point(0, 74);
            this.List_role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.List_role.Name = "List_role";
            this.List_role.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.List_role.Size = new System.Drawing.Size(170, 37);
            this.List_role.TabIndex = 21;
            this.List_role.Text = "List Role";
            this.List_role.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.List_role.UseVisualStyleBackColor = false;
            this.List_role.Click += new System.EventHandler(this.List_role_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(178)))));
            this.panelSideMenu.Controls.Add(this.panelSubPrivs);
            this.panelSideMenu.Controls.Add(this.btnPrivs);
            this.panelSideMenu.Controls.Add(this.panelSubCreate);
            this.panelSideMenu.Controls.Add(this.btnCreate);
            this.panelSideMenu.Controls.Add(this.panelSubList);
            this.panelSideMenu.Controls.Add(this.btnList);
            this.panelSideMenu.Controls.Add(this.btnSearch);
            this.panelSideMenu.Controls.Add(this.btnHome);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 52);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(191, 519);
            this.panelSideMenu.TabIndex = 22;
            // 
            // panelSubPrivs
            // 
            this.panelSubPrivs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(141)))));
            this.panelSubPrivs.Controls.Add(this.btnRevokePrivs);
            this.panelSubPrivs.Controls.Add(this.btnGrantPrivs);
            this.panelSubPrivs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubPrivs.Location = new System.Drawing.Point(0, 545);
            this.panelSubPrivs.Name = "panelSubPrivs";
            this.panelSubPrivs.Size = new System.Drawing.Size(170, 75);
            this.panelSubPrivs.TabIndex = 25;
            // 
            // btnRevokePrivs
            // 
            this.btnRevokePrivs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(141)))));
            this.btnRevokePrivs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevokePrivs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevokePrivs.FlatAppearance.BorderSize = 0;
            this.btnRevokePrivs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevokePrivs.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevokePrivs.ForeColor = System.Drawing.Color.White;
            this.btnRevokePrivs.Location = new System.Drawing.Point(0, 37);
            this.btnRevokePrivs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRevokePrivs.Name = "btnRevokePrivs";
            this.btnRevokePrivs.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRevokePrivs.Size = new System.Drawing.Size(170, 37);
            this.btnRevokePrivs.TabIndex = 21;
            this.btnRevokePrivs.Text = "Revoke";
            this.btnRevokePrivs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevokePrivs.UseVisualStyleBackColor = false;
            this.btnRevokePrivs.Click += new System.EventHandler(this.btnRevokePrivs_Click);
            // 
            // btnGrantPrivs
            // 
            this.btnGrantPrivs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(141)))));
            this.btnGrantPrivs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrantPrivs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrantPrivs.FlatAppearance.BorderSize = 0;
            this.btnGrantPrivs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrantPrivs.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrantPrivs.ForeColor = System.Drawing.Color.White;
            this.btnGrantPrivs.Location = new System.Drawing.Point(0, 0);
            this.btnGrantPrivs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrantPrivs.Name = "btnGrantPrivs";
            this.btnGrantPrivs.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGrantPrivs.Size = new System.Drawing.Size(170, 37);
            this.btnGrantPrivs.TabIndex = 13;
            this.btnGrantPrivs.Text = "Grant";
            this.btnGrantPrivs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrantPrivs.UseVisualStyleBackColor = false;
            this.btnGrantPrivs.Click += new System.EventHandler(this.btnGrantPrivs_Click);
            // 
            // btnPrivs
            // 
            this.btnPrivs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrivs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrivs.FlatAppearance.BorderSize = 0;
            this.btnPrivs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivs.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivs.ForeColor = System.Drawing.Color.White;
            this.btnPrivs.Location = new System.Drawing.Point(0, 508);
            this.btnPrivs.Name = "btnPrivs";
            this.btnPrivs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrivs.Size = new System.Drawing.Size(170, 37);
            this.btnPrivs.TabIndex = 24;
            this.btnPrivs.Text = "Privileges";
            this.btnPrivs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrivs.UseVisualStyleBackColor = true;
            this.btnPrivs.Click += new System.EventHandler(this.btnPrivs_Click);
            // 
            // panelSubCreate
            // 
            this.panelSubCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(141)))));
            this.panelSubCreate.Controls.Add(this.btnCreRole);
            this.panelSubCreate.Controls.Add(this.btnCreUsr);
            this.panelSubCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubCreate.Location = new System.Drawing.Point(0, 433);
            this.panelSubCreate.Name = "panelSubCreate";
            this.panelSubCreate.Size = new System.Drawing.Size(170, 75);
            this.panelSubCreate.TabIndex = 23;
            // 
            // btnCreRole
            // 
            this.btnCreRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(141)))));
            this.btnCreRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreRole.FlatAppearance.BorderSize = 0;
            this.btnCreRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreRole.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreRole.ForeColor = System.Drawing.Color.White;
            this.btnCreRole.Location = new System.Drawing.Point(0, 37);
            this.btnCreRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreRole.Name = "btnCreRole";
            this.btnCreRole.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCreRole.Size = new System.Drawing.Size(170, 37);
            this.btnCreRole.TabIndex = 21;
            this.btnCreRole.Text = "Role";
            this.btnCreRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreRole.UseVisualStyleBackColor = false;
            this.btnCreRole.Click += new System.EventHandler(this.btnCreRole_Click);
            // 
            // btnCreUsr
            // 
            this.btnCreUsr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(141)))));
            this.btnCreUsr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreUsr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreUsr.FlatAppearance.BorderSize = 0;
            this.btnCreUsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreUsr.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreUsr.ForeColor = System.Drawing.Color.White;
            this.btnCreUsr.Location = new System.Drawing.Point(0, 0);
            this.btnCreUsr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreUsr.Name = "btnCreUsr";
            this.btnCreUsr.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCreUsr.Size = new System.Drawing.Size(170, 37);
            this.btnCreUsr.TabIndex = 13;
            this.btnCreUsr.Text = "User";
            this.btnCreUsr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreUsr.UseVisualStyleBackColor = false;
            this.btnCreUsr.Click += new System.EventHandler(this.btnCreUsr_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(0, 396);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCreate.Size = new System.Drawing.Size(170, 37);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "Implement";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panelSubList
            // 
            this.panelSubList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(141)))));
            this.panelSubList.Controls.Add(this.List_table_bt);
            this.panelSubList.Controls.Add(this.List_user);
            this.panelSubList.Controls.Add(this.List_role);
            this.panelSubList.Controls.Add(this.L_privs_bt);
            this.panelSubList.Controls.Add(this.List_record);
            this.panelSubList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubList.Location = new System.Drawing.Point(0, 211);
            this.panelSubList.Name = "panelSubList";
            this.panelSubList.Size = new System.Drawing.Size(170, 185);
            this.panelSubList.TabIndex = 21;
            // 
            // List_record
            // 
            this.List_record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.List_record.Dock = System.Windows.Forms.DockStyle.Top;
            this.List_record.FlatAppearance.BorderSize = 0;
            this.List_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.List_record.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.List_record.ForeColor = System.Drawing.Color.White;
            this.List_record.Location = new System.Drawing.Point(0, 0);
            this.List_record.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.List_record.Name = "List_record";
            this.List_record.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.List_record.Size = new System.Drawing.Size(170, 37);
            this.List_record.TabIndex = 29;
            this.List_record.Text = "List record";
            this.List_record.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.List_record.UseVisualStyleBackColor = true;
            this.List_record.Click += new System.EventHandler(this.List_record_Click);
            // 
            // btnList
            // 
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(0, 174);
            this.btnList.Name = "btnList";
            this.btnList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnList.Size = new System.Drawing.Size(170, 37);
            this.btnList.TabIndex = 21;
            this.btnList.Text = "List";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(178)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(0, 137);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(170, 37);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(178)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(170, 37);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(170, 100);
            this.panelLogo.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowAdminHome.Properties.Resources.logo_khoa_hoc_tu_nhien_inkythuatso_01;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLogout.Location = new System.Drawing.Point(909, 93);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(85, 31);
            this.btLogout.TabIndex = 23;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.labelRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelRole.Location = new System.Drawing.Point(418, 87);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(95, 37);
            this.labelRole.TabIndex = 26;
            this.labelRole.Text = "Role: ";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(905, 65);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(93, 21);
            this.labelUser.TabIndex = 27;
            this.labelUser.Text = "Username";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowAdminHome.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(839, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 571);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTable);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormHome";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubPrivs.ResumeLayout(false);
            this.panelSubCreate.ResumeLayout(false);
            this.panelSubList.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelTable;
        private System.Windows.Forms.Button List_table_bt;
        private System.Windows.Forms.Button L_privs_bt;
        private System.Windows.Forms.Button List_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button List_role;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelSubList;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Panel panelSubCreate;
        private System.Windows.Forms.Button btnCreRole;
        private System.Windows.Forms.Button btnCreUsr;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panelSubPrivs;
        private System.Windows.Forms.Button btnRevokePrivs;
        private System.Windows.Forms.Button btnGrantPrivs;
        private System.Windows.Forms.Button btnPrivs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button List_record;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
    }
}

