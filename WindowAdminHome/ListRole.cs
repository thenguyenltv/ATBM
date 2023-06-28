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
    public partial class ListRole : Form
    {
        OracleConnection conn;
        public ListRole(
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
            //getEmps.CommandText = "SELECT role, owner, table_name,privilege,grantable FROM role_tab_privs";
            getEmps.CommandText = "SELECT * from dba_roles";

            try
            {
                getEmps.CommandType = CommandType.Text;
                OracleDataReader reader = getEmps.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(reader);
                Role_list.DataSource = empDT;
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
            //getEmps.CommandText = "SELECT role, owner, table_name,privilege,grantable FROM role_tab_privs where role like '" + Search.Text.ToUpper() + "%'";
            getEmps.CommandText = "SELECT * from dba_roles where role like '" + Search.Text.ToUpper() + "%'";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);
            Role_list.DataSource = empDT;
            conn.Close();
        }

        private void Role_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
