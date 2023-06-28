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
    public partial class GrantRole : Form
    {
        OracleConnection conn;
        public GrantRole(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            update_List_Role();
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

        private void Grant_bt_Click(object sender, EventArgs e)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "grant_role_2_usr";
            getEmps.CommandType = CommandType.StoredProcedure;
            //parameter
            getEmps.Parameters.Add("rolename", comboBox1.Text);
            getEmps.Parameters.Add("usrname", usrn.Text);
            try
            {
                getEmps.ExecuteNonQuery();
                MessageBox.Show("Cap quyen thanh cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ten nguoi dung hoac role khong ton tai! ");
            }
            conn.Close();
            this.Close();
        }
        private void update_List_Role()
        {
            if (this.conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            OracleCommand getRole = conn.CreateCommand();
            getRole.CommandText = "select granted_role ROLE from user_role_privs where admin_option='YES'";
            ///conn.ConnectionString
            getRole.CommandType = CommandType.Text;
            OracleDataReader reader = getRole.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    comboBox1.Items.Add(reader["ROLE"].ToString());
                }
            }
        }
    }
}
