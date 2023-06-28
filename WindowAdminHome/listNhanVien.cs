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
    public partial class listNhanVien : Form
    {
        OracleConnection conn;
        public static string role;
        public static string username;
        string datagrid = "";
        string tab = "";
        public listNhanVien(OracleConnection conn)
        {
            InitializeComponent();
            customDesign();
            string v_nhanvien_nhanvien = "SELECT *  FROM OLS_TEST1.V_NHANVIEN_NHANVIEN ORDER BY 1";
            string v_nhanvien = "SELECT * FROM OLS_TEST1.V_NHANVIEN ORDER BY 1";
            string nhanvien = "SELECT * FROM OLS_TEST1.NHANVIEN ORDER BY 1";
            
            this.conn = conn;
            btDelete.Enabled = false;
            btInsert.Enabled = false;
            btUpdate.Enabled = false;
            btInsert.Visible = false;
            btDelete.Visible = false;
            btUpdate.Visible = false;
            labelAddr.Visible = false;
            labelBirth.Visible = false;
            labelMaNQL.Visible = false;
            labelMaNV.Visible = false;
            labelPhg.Visible = false;
            labelPhone.Visible = false;
            labelPhuCap.Visible = false;
            labelSalary.Visible = false;
            labelSex.Visible = false;
            labelTenNV.Visible = false;
            labelVaiTro.Visible = false;
            textAddr.Visible = false;
            textBirth.Visible = false;
            textMaNQL.Visible = false;
            textMaNV.Visible = false;
            textPhai.Visible = false;
            textPhg.Visible = false;
            textPhone.Visible = false;
            textPhuCap.Visible = false;
            textSalary.Visible = false;
            textTenNV.Visible = false;
            textVaiTro.Visible = false;
            //btNhanVien.Visible = false;
            btNhanVien.Enabled = false;
            switch (role)
            {
                case "NHANVIEN":
                    // code here
                    datagrid = v_nhanvien_nhanvien;
                    tab = "OLS_TEST1.V_NHANVIEN_NHANVIEN";
                    btUpdate.Enabled = true;
                    btUpdate.Visible = true;
                    labelAddr.Visible = true;
                    textAddr.Visible = true;
                    labelPhone.Visible = true;
                    textPhone.Visible = true;
                    labelBirth.Visible = true;
                    textBirth.Visible = true;
                    break;
                case "QUANLYTRUCTIEP":
                    // code here
                    datagrid = v_nhanvien;
                    tab = "OLS_TEST1.V_NHANVIEN";
                    btUpdate.Enabled = true;
                    btUpdate.Visible = true;
                    labelAddr.Visible = true;
                    textAddr.Visible = true;
                    labelPhone.Visible = true;
                    textPhone.Visible = true;
                    labelBirth.Visible = true;
                    textBirth.Visible = true;
                    break;
                case "TRUONGPHONG":
                    // code here
                    datagrid = v_nhanvien;
                    tab = "OLS_TEST1.V_NHANVIEN";
                    btUpdate.Enabled = true;
                    btUpdate.Visible = true;
                    labelAddr.Visible = true;
                    textAddr.Visible = true;
                    labelPhone.Visible = true;
                    textPhone.Visible = true;
                    labelBirth.Visible = true;
                    textBirth.Visible = true;
                    break;
                case "TAICHINH":
                    // code here
                    datagrid = nhanvien;
                    tab = "OLS_TEST1.NHANVIEN";
                    btUpdate.Enabled = true;
                    btUpdate.Visible = true;
                    labelAddr.Visible = true;
                    textAddr.Visible = true;
                    labelPhone.Visible = true;
                    textPhone.Visible = true;
                    labelBirth.Visible = true;
                    textBirth.Visible = true;
                    //
                    labelSalary.Visible = true;
                    textSalary.Visible = true;
                    labelPhuCap.Visible = true;
                    textPhuCap.Visible = true;
                    labelMaNV.Visible = true;
                    textMaNV.Visible=true;
                    btNhanVien.Enabled = true;
                    panelNhanVien.Visible = true;
                    //
                    break;
                case "NHANSU":
                    // code here
                    datagrid = v_nhanvien;
                    tab = "OLS_TEST1.V_NHANVIEN";
                    btUpdate.Enabled = true;
                    btUpdate.Visible = true;
                    labelAddr.Visible = true;
                    textAddr.Visible = true;
                    labelPhone.Visible = true;
                    textPhone.Visible = true;
                    labelBirth.Visible = true;
                    textBirth.Visible = true;
                    //
                    btInsert.Enabled = true;
                    btInsert.Visible = true;
                    labelMaNV.Visible = true;
                    labelTenNV.Visible = true;
                    labelSex.Visible = true;
                    labelVaiTro.Visible = true;
                    labelMaNQL.Visible = true;
                    labelPhg.Visible = true;
                    textMaNV.Visible = true;
                    textTenNV.Visible = true;
                    textPhai.Visible = true;
                    textVaiTro.Visible = true;
                    textMaNQL.Visible = true;
                    textPhg.Visible = true;
                    btNhanVien.Enabled = true;
                    btNhanVien.Cursor = default;
                    panelNhanVien.Visible = true;
                    //
                    //OPTION
                    btDelete.Visible = true;
                    btDelete.Enabled = true;
                    break;
                case "TRUONGDEAN":
                    // code here
                    datagrid = v_nhanvien_nhanvien;
                    tab = "OLS_TEST1.V_NHANVIEN_NHANVIEN";
                    btUpdate.Enabled = true;
                    btUpdate.Visible = true;
                    labelAddr.Visible = true;
                    textAddr.Visible = true;
                    labelPhone.Visible = true;
                    textPhone.Visible = true;
                    labelBirth.Visible = true;
                    textBirth.Visible = true;
                    break;
                case "BANGIAMDOC":
                    // code here
                    datagrid = nhanvien;
                    tab = "OLS_TEST1.NHANVIEN";
                    btMe.Enabled = false;
                    panelMe.Visible = false;
                    break;
                /*default:
                    // code here*/
            }
            updateGrid();
        }
        
        public void customDesign()
        {
            panelNhanVien.Visible = false;
            btMe.BackColor = Color.White;
            btMe.Enabled = true;
            panelMe.Visible = true;
            btNhanVien.Visible = true;
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
                MessageBox.Show("Nguoi dung khong co quyen truy cap! " + ex.Message);
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
                getEmps.CommandText = "OLS_TEST1.PROC_INSERT_NHANSU";
                getEmps.CommandType = CommandType.StoredProcedure;
                //parameter
                getEmps.Parameters.Add("p_MANV", textMaNV.Text);
                getEmps.Parameters.Add("p_TENNV", textTenNV.Text);
                getEmps.Parameters.Add("p_PHAI", textPhai.Text);
                getEmps.Parameters.Add("p_NGAYSINH", textBirth.Text);
                getEmps.Parameters.Add("p_DIACHI", textAddr.Text);
                getEmps.Parameters.Add("p_SODT", textPhone.Text);
                getEmps.Parameters.Add("p_VAITRO", textVaiTro.Text);
                getEmps.Parameters.Add("p_MANQL", textMaNQL.Text);
                getEmps.Parameters.Add("p_PHG", textPhg.Text);
                //getEmps.Parameters.Add("TAB", tab);
                getEmps.ExecuteNonQuery();
                updateGrid();
                MessageBox.Show("them thanh cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tac khong hop le!"+ex.Message);
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // code here
                string[] listName = new string[] {"TENNV", "MANV", "PHAI", "NGAYSINH", "DIACHI", "SODT", "LUONG", "PHUCAP", "VAITRO", "MANQL", "PHG" };
                string[] listText =new string[] { textTenNV.Text, textMaNV.Text, textPhai.Text, textBirth.Text, textAddr.Text, textPhone.Text, textSalary.Text, textPhuCap.Text, textVaiTro.Text, textMaNQL.Text, textPhg.Text };
                if (this.conn.State == ConnectionState.Closed)
                    conn.Open();
                for (int i = 0; i < listText.Length; i++)
                {
                    if (this.conn.State == ConnectionState.Closed)
                        conn.Open();
                    if (listText[i] == "")
                        continue;
                    OracleCommand getEmps = conn.CreateCommand();
                    getEmps.CommandText = "OLS_TEST1.PROC_UPDATE";
                    getEmps.CommandType = CommandType.StoredProcedure;
                    getEmps.Parameters.Add("COL", listName[i]);
                    getEmps.Parameters.Add("VAL", listText[i]);
                    //getEmps.Parameters.Add("MA", username.Substring(2,4));//CHO ROLE KO PHAI LA NHANSU VA TAICHINH
                    getEmps.Parameters.Add("MA", textMaNV.Text);//CHO ROLE NHANSU VA TAICHINH
                    getEmps.Parameters.Add("TAB", tab);
                    getEmps.ExecuteNonQuery();
                    MessageBox.Show("Cap nhat thanh cong!");
                    updateGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tac khong hop le!"+ex.Message+datagrid);
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
                getEmps.Parameters.Add("COL", "MaNV");
                getEmps.Parameters.Add("VAL", textMaNV.Text);
                getEmps.Parameters.Add("TAB", tab);
                updateGrid();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Thao tac khong hop le!"+ex.Message);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                // code here
                if (this.conn.State == ConnectionState.Closed)
                    conn.Open();
                OracleCommand getEmps = conn.CreateCommand();
                getEmps.CommandText = "OLS_TEST1.PROC_SAVE";
                getEmps.CommandType = CommandType.StoredProcedure;
                getEmps.ExecuteNonQuery();
                MessageBox.Show("Luu thanh cong!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thao tac khong hop le!"+ex.Message);
            }
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            btNhanVien.BackColor = Color.White;
            btMe.BackColor = Color.FromArgb(224, 224, 224);
            if (panelMe.Visible)
                panelMe.Visible = false;
            if(!panelNhanVien.Visible)
                panelNhanVien.Visible = true;
        }

        private void btMe_Click(object sender, EventArgs e)
        {
            btMe.BackColor = Color.White;
            btNhanVien.BackColor = Color.FromArgb(224, 224, 224);

            if (panelNhanVien.Visible)
                panelNhanVien.Visible = false;
            if (!panelMe.Visible)
                panelMe.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // code here
                string[] listName = new string[] { "NGAYSINH", "DIACHI", "SODT" };
                string[] listText = new string[] { textBirthMe.Text, textAddrMe.Text, textPhoneMe.Text };
                if (this.conn.State == ConnectionState.Closed)
                    conn.Open();
                for (int i = 0; i < listText.Length; i++)
                {
                    if (this.conn.State == ConnectionState.Closed)
                        conn.Open();
                    if (listText[i] == "")
                        continue;
                    OracleCommand getEmps = conn.CreateCommand();
                    getEmps.CommandText = "OLS_TEST1.PROC_UPDATE";
                    getEmps.CommandType = CommandType.StoredProcedure;
                    getEmps.Parameters.Add("COL", listName[i]);
                    getEmps.Parameters.Add("VAL", listText[i]);
                    getEmps.Parameters.Add("MA", username.Substring(2,4));//CHO ROLE KO PHAI LA NHANSU VA TAICHINH
                    //getEmps.Parameters.Add("MA", textMaNV.Text);//CHO ROLE NHANSU VA TAICHINH
                    getEmps.Parameters.Add("TAB", tab);
                    getEmps.ExecuteNonQuery();
                    MessageBox.Show("Cap nhat thanh cong!");
                    updateGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tac khong hop le!" + ex.Message + datagrid);
            }
        }
    }
}
