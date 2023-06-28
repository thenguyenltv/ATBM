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
    public partial class Form1 : Form
    {
        OracleConnection conn;
        //OracleCommand cmd;
        public Form1()
        {
            InitializeComponent();
            this.textBoxUsr.Leave += new System.EventHandler(this.textBoxUsr_Leave);
            this.textBoxUsr.Enter += new System.EventHandler(this.textBoxUsr_Enter);
            this.textBoxPwd.Leave += new System.EventHandler(this.textBoxPwd_Leave);
            this.textBoxPwd.Enter += new System.EventHandler(this.textBoxPwd_Enter);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsr.Text == "" || textBoxPwd.Text == "")
            {
                MessageBox.Show("Vui long dien ten dang nhap hoac mat khau! ");
                textBoxUsr.Focus();
            }
            else
            {
                string usr = textBoxUsr.Text;
                string pswd = textBoxPwd.Text;
                Console.WriteLine(usr + " " + pswd);
                string loginQuery = @"DATA SOURCE=localhost:1521/XEPDB1;USER ID=" + usr + ";PASSWORD=" + pswd + "";
                string role = "";
                try
                {
                    conn = new OracleConnection(loginQuery);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    OracleCommand getRole = conn.CreateCommand();
                    //getEmps.CommandText = "SELECT role, owner, table_name,privilege,grantable FROM role_tab_privs";
                    getRole.CommandText = "SELECT OLS_TEST1.F_VAITRO(USER) FROM DUAL";
                    OracleDataReader reader = getRole.ExecuteReader();
                    // get role from Oracle
                    reader.Read();
                    role = reader.GetString(0);

                    // hard code sample
                    //string role = "NhanVien";
                    ///MessageBox.Show("dung roi! ");
                    if (role == "RESOURCE")
                    {
                        FormHome.role = "Admin";
                        FormHome.username = usr;
                        FormHome form1 = new FormHome(conn);
                        form1.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        NhanVien.role = role;
                        NhanVien.username = usr;

                        listNhanVien.role = role;
                        listNhanVien.username = usr;

                        listPhanCong.role = role;
                        listPhanCong.username = usr;

                        listPhongBan.role = role;
                        listPhongBan.username = usr;

                        listDeAn.role = role;
                        listDeAn.username = usr;

                        NhanVien form1 = new NhanVien(conn);
                        form1.Show();
                        this.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Sai tai khoan hoac mat khau." + ex.Message);

                }

            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxUsr_Leave(object sender, EventArgs e)
        {
            if (textBoxUsr.Text.Length == 0)
            {
                textBoxUsr.Text = "Please Enter Your Name";
                textBoxUsr.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void textBoxUsr_Enter(object sender, EventArgs e)
        {
            if (textBoxUsr.Text == "Please Enter Your Name")
            {
                textBoxUsr.Text = "";
                textBoxUsr.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBoxPwd_Leave(object sender, EventArgs e)
        {
            if (textBoxPwd.Text.Length == 0)
            {
                textBoxPwd.Text = "Password";
                textBoxPwd.ForeColor = System.Drawing.Color.Silver;
                textBoxPwd.UseSystemPasswordChar = false;
            }
        }

        private void textBoxPwd_Enter(object sender, EventArgs e)
        {
            if (textBoxPwd.Text == "Password")
            {
                textBoxPwd.Text = "";
                textBoxPwd.ForeColor = SystemColors.WindowText;
                textBoxPwd.UseSystemPasswordChar = true;
            }
        }
    }
}
