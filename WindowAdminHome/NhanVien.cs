using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowAdminHome
{
    public partial class NhanVien : Form
    {
        OracleConnection conn;
        public static string role;
        public static string username;

        public NhanVien(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            labelRole.Text = "Role: " + role;
            if(username.Length  <= 6)
                labelUser.Text = username;
            else
            {
                string usr = username.Substring(0, 6) + "...";
                labelUser.Text = usr;
            }
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelSubList.Visible = false;
            notiPanel.Visible = false;
            pictureBoxNoti2.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void hideSubMenu(Panel subMenu)
        {
            if(subMenu.Visible)
                subMenu.Visible = false;
        }

        private void hideAllSubMenu()
        {
            if (panelSubList.Visible)
                panelSubList.Visible = false;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubList);
        }

        public void loadForm(object Form)
        {

            if (this.PanelTable.Controls.Count > 0)
                this.PanelTable.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PanelTable.Controls.Add(f);
            this.PanelTable.Tag = f;
            f.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //loadForm(new NhanVien(conn));
            // reload form
            //this.Refresh();
            loadForm(new ChildHome());
            hideAllSubMenu();
        }

        private void L_privs_bt_Click(object sender, EventArgs e)
        {
            loadForm(new listNhanVien(conn));
        }

        private void List_role_Click(object sender, EventArgs e)
        {
            loadForm(new listPhanCong(conn));
        }

        private void List_user_Click(object sender, EventArgs e)
        {
            loadForm(new listPhongBan(conn));
        }

        private void List_table_bt_Click(object sender, EventArgs e)
        {
            loadForm(new listDeAn(conn));
        }

        private void PanelTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            // Disconnect Oracle (optional)
            // code here

            // close current form
            this.Close();

            // load login form
            Form1 loginForm = new Form1();
            loginForm.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            notiPanel.Visible = true;
            pictureNoti1.Visible = false;
            pictureBoxNoti2.Visible = true;
        }

        private void pictureBoxNoti2_Click(object sender, EventArgs e)
        {
            if(notiPanel.Visible)
                notiPanel.Visible = false;
            pictureBoxNoti2.Visible = false;
            pictureNoti1.Visible = true;
        }

        /*//Cap nhat listNV vao notice
        private void updateGrid()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "nhanvien";
            try
            {
                getEmps.CommandType = CommandType.Text;
                OracleDataReader reader = getEmps.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(reader);
                dataGridView1.DataSource = empDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nguoi dung khong co quyen truy cap! " + ex.Message);
            }
            conn.Close();
        }
        //updateGrid();*/
    }
}
