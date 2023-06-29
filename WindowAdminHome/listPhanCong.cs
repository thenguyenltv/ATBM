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
    public partial class listPhanCong : Form
    {
        OracleConnection conn;
        public static string role;
        public static string username;
        string datagrid = "";
        string tab = "OLS_TEST1.PHANCONG";

        public listPhanCong(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            string v_nhanvien_phancong = "SELECT *  FROM OLS_TEST1.V_NHANVIEN_PHANCONG ORDER BY 1";
            string phancong = "SELECT * FROM OLS_TEST1.PHANCONG ORDER BY 1";
            btUpdate.Enabled = false;
            btDelete.Enabled = false;
            btAdd.Enabled = false;
            btUpdate.Visible = false;
            btDelete.Visible = false;
            btAdd.Visible = false;
            labelMaDA.Visible = false;
            labelMaNV.Visible = false;
            labelTime.Visible = false;
            textMaDA.Visible = false;
            textMaNV.Visible = false;
            textTime.Visible = false;
            switch (role)
            {
                case "NHANVIEN":
                    datagrid = v_nhanvien_phancong;
                    // code here
                    break;
                case "QUANLYTRUCTIEP":
                    datagrid = phancong;
                    // code here
                    break;
                case "TRUONGPHONG":
                    // code here
                    datagrid = phancong;
                    btUpdate.Enabled = true;
                    btDelete.Enabled = true;
                    btAdd.Enabled = true;
                    btUpdate.Visible = true;
                    btDelete.Visible = true;
                    btAdd.Visible = true;
                    labelTime.Visible = true;
                    labelMaDA.Visible = true;
                    labelMaNV.Visible = true;
                    textMaNV.Visible = true;
                    textMaDA.Visible = true;
                    textTime.Visible = true;
                    update_List_MADA();
                    update_List_MANV();
                    break;
                case "TAICHINH":
                    datagrid = phancong;
                    // code here
                    break;
                case "NHANSU":
                    datagrid = v_nhanvien_phancong;
                    // code here
                    break;
                case "TRUONGDEAN":
                    datagrid = v_nhanvien_phancong;
                    // code here
                    break;
                case "BANGIAMDOC":
                    datagrid = phancong;
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
                MessageBox.Show("Nguoi dung khong co quyen truy cap! ");
            }
            conn.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DateTime time=textTime.Value;
            try
            {
                // code here
                if (this.conn.State == ConnectionState.Closed)
                    conn.Open();
                OracleCommand getEmps = conn.CreateCommand();
                getEmps.CommandText = "OLS_TEST1.PROC_INSERT_PHANCONG";
                getEmps.CommandType = CommandType.StoredProcedure;
                //parameter
                getEmps.Parameters.Add("p_MANV", textMaNV.Text);
                getEmps.Parameters.Add("p_MADA", textMaDA.Text);
                getEmps.Parameters.Add("p_THOIGIAN", time.ToString("MM/dd/yyyy"));
                getEmps.ExecuteNonQuery();
                MessageBox.Show("them thanh cong!");
                updateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tac khong hop le!"+ex.Message);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            DateTime time= textTime.Value;
            try
            {
                // code here
                string[] listName = new string[] { "MANV","MADA","THOIGIAN" };
                string[] listText = new string[] { textMaNV.Text,textMaDA.Text,time.ToString("MM/dd/yyyy") };
                if (this.conn.State == ConnectionState.Closed)
                    conn.Open();
                for (int i = 0; i < listText.Length; i++)
                {
                    if (this.conn.State == ConnectionState.Closed)
                        conn.Open();
                    if (listText[i] == "" || listName[i]=="MANV"||listName[i]=="MADA")
                        continue;
                    //MessageBox.Show(listName[i] + listText[i]);
                    OracleCommand getEmps = conn.CreateCommand();
                    getEmps.CommandText = "OLS_TEST1.PROC_UPDATE_PHANCONG";
                    getEmps.CommandType = CommandType.StoredProcedure;
                    getEmps.Parameters.Add("COL", listName[i]);
                    getEmps.Parameters.Add("VAL", listText[i]);
                    getEmps.Parameters.Add("MA", textMaNV.Text);
                    getEmps.Parameters.Add("MDA", textMaDA.Text);
                    getEmps.Parameters.Add("TAB", tab);
                    getEmps.ExecuteNonQuery();
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
                getEmps.CommandText = "OLS_TEST1.PROC_DELETE_PHANCONG";
                getEmps.CommandType = CommandType.StoredProcedure;
                getEmps.Parameters.Add("VAL1", textMaNV.Text);
                getEmps.Parameters.Add("VAL2", textMaDA.Text);
                getEmps.ExecuteNonQuery();
                updateGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thao tac khong hop le!"+ex.Message);
            }
        }
        private void update_List_MADA()
        {
            if (this.conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            OracleCommand getIDDA = conn.CreateCommand();
            getIDDA.CommandText = "select MADA from OLS_TEST1.DEAN where PHONG=(SELECT DISTINCT PHG FROM OLS_TEST1.V_NHANVIEN_NHANVIEN WHERE 'NV'||MANV=USER) ORDER BY 1";
            ///conn.ConnectionString
            getIDDA.CommandType = CommandType.Text;
            OracleDataReader reader = getIDDA.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    textMaDA.Items.Add(reader["MADA"].ToString());
                }
            }
        }

        private void update_List_MANV()
        {
            if (this.conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            OracleCommand getID = conn.CreateCommand();
            getID.CommandText = "select MANV from OLS_TEST1.V_NHANVIEN where PHG=(SELECT DISTINCT PHG FROM OLS_TEST1.V_NHANVIEN_NHANVIEN WHERE 'NV'||MANV=USER) ORDER BY 1";
            ///conn.ConnectionString
            getID.CommandType = CommandType.Text;
            //MessageBox.Show(getID.CommandText);
            OracleDataReader reader = getID.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    textMaNV.Items.Add(reader["MANV"].ToString());
                }
            }
        }
    }
}
