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
    public partial class listPhongBan : Form
    {
        OracleConnection conn;
        public static string role;
        public static string username;
        string datagrid = "SELECT * FROM OLS_TEST1.PHONGBAN";
        string tab = "OLS_TEST1.PHONGBAN";

        public listPhongBan(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            btUpdate.Enabled = false;
            btDelete.Enabled = false;
            btAdd.Enabled = false;
            btUpdate.Visible = false;
            btDelete.Visible = false;
            btAdd.Visible = false;
            labelMaPB.Visible = false;
            labelTenPB.Visible = false;
            labelLead.Visible = false;
            textMaPB.Visible = false;
            textTenPB.Visible = false;
            textTrgPhg.Visible = false;
            switch (role)
            {
                case "NHANVIEN":
                    // code here
                    break;
                case "QUANLYTRUCTIEP":
                    // code here
                    break;
                case "TRUONGPHONG":
                    // code here
                    break;
                case "TAICHINH":
                    // code here
                    break;
                case "NHANSU":
                    // code here
                    btUpdate.Enabled = true;
                    btAdd.Enabled = true;
                    btDelete.Enabled = true;
                    btUpdate.Visible = true;
                    btAdd.Visible = true;
                    //btDelete.Visible = true;
                    labelMaPB.Visible = true;
                    labelTenPB.Visible = true;
                    labelLead.Visible = true;
                    textMaPB.Visible = true;
                    textTenPB.Visible = true;
                    textTrgPhg.Visible = true;
                    update_List_TrgPhg();
                    break;
                case "TRUONGDEAN":
                    // code here
                    break;
                case "BANGIAMDOC":
                    // code here
                    break;
                    /*default:
                        // code here*/
            }
            updateGrid();
        }
        private void updateGrid()
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = datagrid;
            try
            {
                getEmps.CommandType = CommandType.Text;
                OracleDataReader reader = getEmps.ExecuteReader();
                DataTable empDT = new DataTable();
                empDT.Load(reader);
                Priv_List.DataSource = empDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nguoi dung khong co quyen truy cap! "+ex.Message);
            }
            conn.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // code here
                if (this.conn.State == ConnectionState.Closed)
                    conn.Open();
                OracleCommand getEmps = conn.CreateCommand();
                getEmps.CommandText = "OLS_TEST1.PROC_INSERT_PHONGBAN";
                getEmps.CommandType = CommandType.StoredProcedure;
                //parameter
                getEmps.Parameters.Add("p_MAPB", textMaPB.Text);
                getEmps.Parameters.Add("p_TENPB", textTenPB.Text);
                getEmps.Parameters.Add("p_TRPHG", textTrgPhg.Text);
                getEmps.ExecuteNonQuery();
                updateGrid();
                MessageBox.Show("them thanh cong!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thao tac khong hop le!"+ex.Message);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // code here
                string[] listName = new string[] { "MAPB", "TENPB", "TRPHG" };
                string[] listText = new string[] { textMaPB.Text, textTenPB.Text, textTrgPhg.Text };
                if (this.conn.State == ConnectionState.Closed)
                    conn.Open();
                for (int i = 0; i < listText.Length; i++)
                {
                    if (this.conn.State == ConnectionState.Closed)
                        conn.Open();
                    if (listText[i] == ""||listName[i]=="MAPB")
                        continue;
                    OracleCommand getEmps = conn.CreateCommand();
                    getEmps.CommandText = "OLS_TEST1.PROC_UPDATE";
                    getEmps.CommandType = CommandType.StoredProcedure;
                    getEmps.Parameters.Add("COL", listName[i]);
                    getEmps.Parameters.Add("VAL", listText[i]);
                    getEmps.Parameters.Add("MA", textMaPB.Text);
                    getEmps.Parameters.Add("CONCOL", "MAPB");
                    getEmps.Parameters.Add("TAB", tab);
                    getEmps.ExecuteNonQuery();
                    if(i == listText.Length - 1)
                        MessageBox.Show("Cap nhat thanh cong!");
                    updateGrid();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thao tac khong hop le!"+ex.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // code here
                if (this.conn.State == ConnectionState.Closed)
                    conn.Open();
                OracleCommand getEmps = conn.CreateCommand();
                getEmps.CommandText = "OLS_TEST1.PROC_DELETE";
                getEmps.CommandType = CommandType.StoredProcedure;
                getEmps.Parameters.Add("COL", "MaPB");
                getEmps.Parameters.Add("VAL", textMaPB.Text);
                getEmps.Parameters.Add("TAB", tab);
                getEmps.ExecuteNonQuery();
                updateGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thao tac khong hop le!"+ex.Message);
            }
        }
        private void update_List_TrgPhg()
        {
            if (this.conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            OracleCommand getID = conn.CreateCommand();
            getID.CommandText = "select MANV from OLS_TEST1.V_NHANVIEN where UPPER(VAITRO)='TRUONGPHONG' ORDER BY 1";
            ///conn.ConnectionString
            getID.CommandType = CommandType.Text;
            OracleDataReader reader = getID.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    textTrgPhg.Items.Add(reader["MANV"].ToString());
                }
            }
        }

        private void textTrgPhg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
