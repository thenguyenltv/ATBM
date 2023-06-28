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
    public partial class RevokeRole : Form
    {
        OracleConnection conn;
        public RevokeRole(
        OracleConnection conn)
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

        private void Grant_bt_Click(object sender, EventArgs e)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "revoke_role_from_usr";
            getEmps.CommandType = CommandType.StoredProcedure;
            //parameter
            getEmps.Parameters.Add("rolename", Rolen.Text);
            getEmps.Parameters.Add("usrname", usrn.Text);
            try
            {
                getEmps.ExecuteNonQuery();
                MessageBox.Show("thu hoi thanh cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ten nguoi dung hoac role khong ton tai! ");
            }
            conn.Close();
            this.Close();
        }
    }
}
