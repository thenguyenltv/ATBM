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
using WindowAdminHome;

namespace Login
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
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
                string loginQuery = @"DATA SOURCE=localhost:1521/XE;USER ID=" + usr + ";PASSWORD=" + pswd + "";
                conn = new OracleConnection(loginQuery);
                // get role from oracle
                string role;
                role = "Admin"; // hard code sample
                try
                {
                    conn.Open();
                     ///MessageBox.Show("dung roi! ");
                    if(role!="Admin")
                    {
                        NhanVien form1 = new NhanVien(conn);
                        form1.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        FormHome form1 = new FormHome(conn);
                        form1.Show();
                        this.Visible = false;
                    }
                      
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Sai tai khoan hoac mat khau."+ex.Message);
                    
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


        private void textBoxUsr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
