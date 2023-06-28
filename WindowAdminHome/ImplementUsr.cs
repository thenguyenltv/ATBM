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
    public partial class ImplementUsr : Form
    {
        OracleConnection conn;
        string str = "";
        public ImplementUsr(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void Cancel_bt_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure about that?"
                , "Confirm"
                , MessageBoxButtons.YesNo
                );
            if (res == System.Windows.Forms.DialogResult.No)
            {
                // I have to cancel button click event here
                return;

            }
            this.Close();
        }


        private void Drop_bt_Click(object sender, EventArgs e)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "implement_usr";
            getEmps.CommandType = CommandType.StoredProcedure;
            //parameter
            getEmps.Parameters.Add("priv", "drop");
            getEmps.Parameters.Add("usrname", name.Text);
            getEmps.Parameters.Add("tab", "");
            try
            {
                MessageBox.Show("success");
                getEmps.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("invalid User/Attributes ");
            }
            conn.Close();
            this.Close();
        }

        private void Create_bt_Click(object sender, EventArgs e)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "implement_usr";
            getEmps.CommandType = CommandType.StoredProcedure;
            //parameter
            getEmps.Parameters.Add("priv", "Create");
            getEmps.Parameters.Add("usrname", name.Text);
            getEmps.Parameters.Add("tab", passwordBox1.Text);
            try
            {
                getEmps.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username already exists! ");
            }
            conn.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "implement_usr";
            getEmps.CommandType = CommandType.StoredProcedure;
            //parameter
            getEmps.Parameters.Add("priv", "alter");
            getEmps.Parameters.Add("usrname", name.Text);
            getEmps.Parameters.Add("tab", passwordBox1.Text);
            try
            {
                getEmps.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username already exists! ");
            }
            conn.Close();
            this.Close();
        }
    }
}
