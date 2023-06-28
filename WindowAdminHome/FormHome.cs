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
    public partial class FormHome : Form
    {
        OracleConnection conn;
        public static string role;
        public static string username;

        public FormHome(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            labelRole.Text = "Role: " + role;
            if (username.Length <= 6)
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
            panelSubCreate.Visible = false;
            panelSubPrivs.Visible = false;
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
            if (panelSubCreate.Visible)
                panelSubCreate.Visible = false;
            if (panelSubPrivs.Visible)
                panelSubPrivs.Visible = false;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubList);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubCreate);
        }

        private void btnPrivs_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubPrivs);
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
            // load form information of usr
            //loadForm(new listNhanVien(conn));
            hideAllSubMenu();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadForm(new CheckInfo(conn));

        }
        private void List_user_Click(object sender, EventArgs e)
        {
            loadForm(new ListUsr(conn));
        }

        private void List_table_bt_Click(object sender, EventArgs e)
        {
            loadForm(new ListTab(conn));
        }

        private void L_privs_bt_Click(object sender, EventArgs e)
        {
            loadForm(new ListPriv(conn));
        }

        private void List_role_Click(object sender, EventArgs e)
        {
            loadForm(new ListRole(conn));
        }

        private void btnCreUsr_Click(object sender, EventArgs e)
        {
            ImplementUsr form = new ImplementUsr(conn);
            form.Show();
        }

        private void btnCreRole_Click(object sender, EventArgs e)
        {
            ImplementRole form = new ImplementRole(conn);
            form.Show();
        }

        private void btnGrantPrivs_Click(object sender, EventArgs e)
        {
            ///MessageBox.Show("dung roi! ");
            GrantUser form = new GrantUser(conn);
            form.Show();
        }

        private void btnRevokePrivs_Click(object sender, EventArgs e)
        {
            RevokeUser form = new RevokeUser(conn);
            form.Show();
        }

        private void FormHome_Load(object sender, EventArgs e)
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

        private void List_record_Click(object sender, EventArgs e)
        {
            loadForm(new ListRecord(conn));
        }
    }
}
