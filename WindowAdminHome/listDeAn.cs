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
    public partial class listDeAn : Form
    {
        OracleConnection conn;
        public static string role;
        public static string username;

        string datagrid = "SELECT * FROM OLS_TEST1.DEAN";
        string tab = "OLS_TEST1.DEAN";
        public listDeAn(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            btAdd.Enabled = false;
            btDelete.Enabled = false;
            btUpdate.Enabled = false;
            btAdd.Visible = false;
            btDelete.Visible = false;
            btUpdate.Visible = false;
            labelMaDA.Visible = false;
            labelTenDa.Visible = false;
            labelNgayBD.Visible = false;
            labelPhong.Visible = false;
            textMaDa.Visible = false;
            textTenDA.Visible = false;
            textNgayBD.Visible = false;
            textPhong.Visible = false;
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
                    break;
                case "TRUONGDEAN":
                    // code here
                    btUpdate.Enabled = true;
                    btAdd.Enabled = true;
                    btDelete.Enabled = true;
                    btUpdate.Visible = true;
                    btDelete.Visible = true;
                    btAdd.Visible = true;
                    labelMaDA.Visible = true;
                    labelTenDa.Visible = true;
                    labelPhong.Visible = true;
                    labelNgayBD.Visible = true;
                    textMaDa.Visible = true;
                    textTenDA.Visible = true;
                    textPhong.Visible = true;
                    textNgayBD.Visible = true;
                    update_List_MAPHG();
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
                getEmps.Parameters.Add("COL", "MaDA");
                getEmps.Parameters.Add("VAL", textMaDa.Text);
                getEmps.Parameters.Add("TAB", tab);
                getEmps.ExecuteNonQuery();
                updateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tac khong hop le!"+ex.Message);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DateTime ngayBD = textNgayBD.Value;
            try
            {
                // code here
                if (this.conn.State == ConnectionState.Closed)
                    conn.Open();
                OracleCommand getEmps = conn.CreateCommand();
                getEmps.CommandText = "OLS_TEST1.PROC_INSERT_DEAN";
                getEmps.CommandType = CommandType.StoredProcedure;
                //parameter
                getEmps.Parameters.Add("p_MADA", textMaDa.Text);
                getEmps.Parameters.Add("p_TENDA", textTenDA.Text);
                getEmps.Parameters.Add("p_NGAYBD", ngayBD.ToString("MM/dd/yyyy"));
                getEmps.Parameters.Add("p_PHONG", textPhong.Text);
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
            DateTime ngayBD = textNgayBD.Value;
            try
            {
                // code here
                string[] listName = new string[] { "MADA", "TENDA", "NGAYBD","PHONG" };
                string[] listText = new string[] { textMaDa.Text, textTenDA.Text, ngayBD.ToString("MM/dd/yyyy"), textPhong.Text };
                if (this.conn.State == ConnectionState.Closed)
                    conn.Open();
                for (int i = 0; i < listText.Length; i++)
                {
                    if (this.conn.State == ConnectionState.Closed)
                        conn.Open();
                    if (listText[i] == ""|| listName[i]=="MADA")
                        continue;
                    OracleCommand getEmps = conn.CreateCommand();
                    getEmps.CommandText = "OLS_TEST1.PROC_UPDATE";
                    getEmps.CommandType = CommandType.StoredProcedure;
                    getEmps.Parameters.Add("COL", listName[i]);
                    getEmps.Parameters.Add("VAL", listText[i]);
                    getEmps.Parameters.Add("MA", textMaDa.Text);
                    getEmps.Parameters.Add("CONCOL", "MADA");
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

        private void textMaDa_TextChanged(object sender, EventArgs e)
        {
        }

        private void textNgayBD_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void update_List_MAPHG()
        {
            if (this.conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            OracleCommand getID = conn.CreateCommand();
            getID.CommandText = "select MAPB from OLS_TEST1.PHONGBAN";
            ///conn.ConnectionString
            getID.CommandType = CommandType.Text;
            OracleDataReader reader = getID.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    textPhong.Items.Add(reader["MAPB"].ToString());
                }
            }
        }
    }
}
