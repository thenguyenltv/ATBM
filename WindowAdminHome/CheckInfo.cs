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
    public partial class CheckInfo : Form
    {
        OracleConnection conn;
        public CheckInfo(
        OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            updateGrid();
        }
        private void updateGrid()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "SELECT grantee, owner, table_name,grantor, privilege, grantable FROM dba_tab_privs";
            try
            {
                getEmps.CommandType = CommandType.Text;
                OracleDataReader reader = getEmps.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(reader);
                Check_list.DataSource = empDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nguoi dung khong co quyen truy cap! ");
            }
            conn.Close();
        }
        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "SELECT grantee, owner, table_name,grantor, privilege, grantable FROM dba_tab_privs where grantee like '" + Search.Text.ToUpper() + "%'";

            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);
            Check_list.DataSource = empDT;
            conn.Close();
        }

        private void labelUsr_Click(object sender, EventArgs e)
        {

        }
    }
}
