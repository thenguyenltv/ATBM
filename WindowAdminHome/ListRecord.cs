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
    public partial class ListRecord : Form
    {
        OracleConnection conn;
        public ListRecord(OracleConnection conn)
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
            getEmps.CommandText = "SELECT DBUSERNAME, ACTION_NAME, OBJECT_NAME,SQL_TEXT FROM UNIFIED_AUDIT_TRAIL WHERE AUDIT_TYPE='FineGrainedAudit'";
            try
            {
                getEmps.CommandType = CommandType.Text;
                OracleDataReader reader = getEmps.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(reader);
                Record_list.DataSource = empDT;
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
            getEmps.CommandText = "SELECT DBUSERNAME, ACTION_NAME, OBJECT_NAME,SQL_TEXT FROM UNIFIED_AUDIT_TRAIL WHERE AUDIT_TYPE='FineGrainedAudit' AND OBJECT_NAME like '" + Search.Text.ToUpper() + "%'";

            getEmps.CommandType = CommandType.Text;
            OracleDataReader reader = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(reader);
            Record_list.DataSource = empDT;
            conn.Close();
        }
    }
}
