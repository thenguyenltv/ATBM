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
    public partial class ImplementRole : Form
    {
        OracleConnection conn;
        public ImplementRole(
        OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Drop_bt_Click(object sender, EventArgs e)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "implement_role";
            getEmps.CommandType = CommandType.StoredProcedure;
            //parameter
            getEmps.Parameters.Add("priv", "drop");
            getEmps.Parameters.Add("rolename", name.Text);
            getEmps.Parameters.Add("pass", "");
            try
            {
                getEmps.ExecuteNonQuery();
                MessageBox.Show("Xoa thanh cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ten role khong ton tai! ");
            }
            conn.Close();
            this.Close();
        }

        private void Create_bt_Click(object sender, EventArgs e)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "implement_role";
            getEmps.CommandType = CommandType.StoredProcedure;
            //parameter
            getEmps.Parameters.Add("priv", "create");
            getEmps.Parameters.Add("rolename", name.Text);
            if (passwordBox1.Text == "") 
                getEmps.Parameters.Add("pass", " ");
            else
                getEmps.Parameters.Add("pass", passwordBox1.Text);
            try
            {
                getEmps.ExecuteNonQuery();
                MessageBox.Show("Tao thanh cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ten role da ton tai! ");
            }
            conn.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "implement_role";
            getEmps.CommandType = CommandType.StoredProcedure;
            //parameter
            getEmps.Parameters.Add("priv", "alter");
            getEmps.Parameters.Add("rolename", name.Text);
            if (passwordBox1.Text == "")
                getEmps.Parameters.Add("pass", " ");
            else
                getEmps.Parameters.Add("pass", passwordBox1.Text);
            try
            {
                getEmps.ExecuteNonQuery();
                MessageBox.Show("Change password successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ten role da ton tai! ");
            }
            conn.Close();
            this.Close();
        }
    }
}
