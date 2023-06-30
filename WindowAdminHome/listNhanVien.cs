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
            foreach (Control control in Controls)
            {
                control.Cursor = Cursors.Arrow;
            }
            string v_nhanvien_nhanvien = "SELECT *  FROM OLS_TEST1.V_NHANVIEN_NHANVIEN ORDER BY 1";
            string v_nhanvien = "SELECT * FROM OLS_TEST1.V_NHANVIEN ORDER BY 1";
            string nhanvien = "SELECT * FROM OLS_TEST1.NHANVIEN ORDER BY 1";
            
            this.conn = conn;
            // Hide all object of Panel "Nhan Vien" 
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
                    datagrid = v_nhanvien_nhanvien;
                    tab = "OLS_TEST1.V_NHANVIEN_NHANVIEN";
                    //MessageBox.Show("dddd");
                    btUpdate.Enabled = true;
                    btUpdate.Visible = true;
                    labelAddrMe.Visible = true;
                    textAddrMe.Visible = true;
                    labelPhoneMe.Visible = true;
                    textPhoneMe.Visible = true;
                    labelBirthMe.Visible = true;
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
                    //labelAddr.Visible = true;
                    //textAddr.Visible = true;
                    //labelPhone.Visible = true;
                    //textPhone.Visible = true;
                    //labelBirth.Visible = true;
                    //textBirth.Visible = true;
                    //
                    labelSalary.Visible = true;
                    textSalary.Visible = true;
                    labelPhuCap.Visible = true;
                    textPhuCap.Visible = true;
                    labelMaNV.Visible = true;
                    textMaNV.Visible=true;
                    btNhanVien.Enabled = true;
                    //
                    break;
                case "NHANSU":
                    // code here
                    datagrid = v_nhanvien;
                    tab = "OLS_TEST1.V_NHANVIEN";

                    btNhanVien.Enabled = true;
                    // Show button
                    btUpdate.Enabled = true;
                    btUpdate.Visible = true;
                    btInsert.Enabled = true;
                    btInsert.Visible = true;
                    btDelete.Visible = true;
                    btDelete.Enabled = true;

                    // Show label & text
                    labelAddr.Visible = true;
                    textAddr.Visible = true;
                    labelPhone.Visible = true;
                    textPhone.Visible = true;
                    labelBirth.Visible = true;
                    textBirth.Visible = true;
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
                    
                    update_List_MAPHG();
                    update_List_VaiTro();
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
            // Panel "Toi" show
            panelMe.Visible = true;
            btMe.BackColor = Color.White;

            // Panel "Nhan Vien" hide
            panelNhanVien.Visible = false;
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

                //Priv_List.Rows.Add("MaNV", TenNV, Phai, NgaySinh, DiaChi, SDT, Luong, PhuCap, VaiTro, MaNQL, PHG, LinhVuc, ChiNhanh, LabelQLNV);
                Priv_List.Rows.Clear();
                int rowIndex = 0;
                while(reader.Read()){
                    rowIndex++;
                    string MaNV = reader.IsDBNull(0) ? "NULL" : reader.GetString(0);
                    string TenNV = reader.IsDBNull(1) ? "NULL" : reader.GetString(1);
                    string Phai = reader.IsDBNull(2) ? "NULL" : reader.GetString(2);
                    string NgaySinh = reader.IsDBNull(3) ? "NULL" : reader.GetString(3);
                    string DiaChi = reader.IsDBNull(4) ? "NULL" : reader.GetString(4);
                    string SDT = reader.IsDBNull(5) ? "NULL" : reader.GetString(5);
                    string Luong = "NULL";
                    string PhuCap = "NULL";

                    RSA rsa = new RSA(512);
                    if (rsa.ImportPrivateKeyFromFile("../../keys/" + MaNV + ".xml") == 1)
                    {
                        if (!reader.IsDBNull(6))
                        {
                            long bufferSize = reader.GetBytes(6, 0, null, 0, 0); ;
                            byte[] buffer = new byte[bufferSize];
                            reader.GetBytes(6, 0, buffer, 0, (int)bufferSize);
                            Luong = rsa.Decrypt(buffer);
                        }
                        else
                        {
                            Luong = "NULL";
                        }

                        if (!reader.IsDBNull(7))
                        {
                            long bufferSize = reader.GetBytes(7, 0, null, 0, 0);
                            byte[] buffer = new byte[bufferSize];
                            reader.GetBytes(7, 0, buffer, 0, (int)bufferSize);
                            PhuCap = rsa.Decrypt(buffer);
                        }
                        else
                        {
                            PhuCap = "NULL";
                        }
                    }
                    string VaiTro = reader.IsDBNull(8) ? "NULL" : reader.GetString(8);
                    string MaNQL = reader.IsDBNull(9) ? "NULL" : reader.GetString(9);
                    string PHG = reader.IsDBNull(10) ? "NULL" : reader.GetString(10);

                    //DataTable empDT = new DataTable();
                    //empDT.Load(reader);
                    //Priv_List.DataSource = empDT;
       
                    string[] rows = new string[] { MaNV, TenNV, Phai, NgaySinh, DiaChi, SDT, Luong, PhuCap, VaiTro, MaNQL, PHG };
                    Priv_List.Rows.Add(rows);
                }
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
                getEmps.Parameters.Add("p_NGAYSINH", textBirth.Value.ToString("MM/dd/yyyy"));
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
                string[] listName = new string[] {"MANV", "PHAI", "NGAYSINH", "DIACHI", "SODT", "LUONG", "PHUCAP", "VAITRO", "MANQL", "PHG" };
                string[] listText =new string[] {textMaNV.Text, textPhai.Text, textBirth.Value.ToString("MM/dd/yyyy"), textAddr.Text, textPhone.Text, textSalary.Text, textPhuCap.Text, textVaiTro.Text, textMaNQL.Text, textPhg.Text };
                if (this.conn.State == ConnectionState.Closed)
                    conn.Open();
                for (int i = 0; i < listText.Length; i++)
                {
                    if (this.conn.State == ConnectionState.Closed)
                        conn.Open();
                    if (listText[i]=="")
                        continue;
                    OracleCommand getEmps = conn.CreateCommand();
                    getEmps.CommandText = "OLS_TEST1.PROC_UPDATE";
                    getEmps.CommandType = CommandType.StoredProcedure;
                    getEmps.Parameters.Add("COL", listName[i]);
                    getEmps.Parameters.Add("VAL", listText[i]);
                    //getEmps.Parameters.Add("MA", username.Substring(2,4));//CHO ROLE KO PHAI LA NHANSU VA TAICHINH
                    getEmps.Parameters.Add("MA", textMaNV.Text);//CHO ROLE NHANSU VA TAICHINH
                    getEmps.Parameters.Add("CONCOL", "MANV");
                    getEmps.Parameters.Add("TAB", tab);
                    getEmps.ExecuteNonQuery();
                    updateGrid();
                }
                MessageBox.Show("Cap nhat thanh cong!");
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
                getEmps.Parameters.Add("COL", "MANV");
                getEmps.Parameters.Add("VAL", textMaNV.Text);
                getEmps.Parameters.Add("TAB", tab);
                getEmps.ExecuteNonQuery();
                updateGrid();
                MessageBox.Show("Xoa thanh cong!");

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
            panelMe.Visible = false;
            panelNhanVien.Visible = true;
        }

        private void btMe_Click(object sender, EventArgs e)
        {
            btMe.BackColor = Color.White;
            btNhanVien.BackColor = Color.FromArgb(224, 224, 224);

            panelMe.Visible = true;
            panelNhanVien.Visible = false;

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
                    textPhg.Items.Add(reader["MAPB"].ToString());
                }
            }
        }
        private void update_List_VaiTro()
        {
            if (this.conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            OracleCommand getID = conn.CreateCommand();
            getID.CommandText = "select DISTINCT VAITRO from "+tab+" WHERE UPPER(VAITRO)='BANGIAMDOC'";
            ///conn.ConnectionString
            getID.CommandType = CommandType.Text;
            OracleDataReader reader = getID.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    textVaiTro.Items.Add(reader["VAITRO"].ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // code here
                string[] listName = new string[] { "NGAYSINH", "DIACHI", "SODT" };
                string[] listText = new string[] { textBirthMe.Value.ToString("MM/dd/yyyy"), textAddrMe.Text, textPhoneMe.Text };
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
                    getEmps.Parameters.Add("CONCOL", "MANV");
                    getEmps.Parameters.Add("TAB", tab);
                    getEmps.ExecuteNonQuery();
                    updateGrid();
                }
                MessageBox.Show("Cap nhat thanh cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tac khong hop le!" + ex.Message + datagrid);
            }
        }

        private void Priv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && !Priv_List.Rows[e.RowIndex].Selected)
            {
                DataGridViewRow clickedRow = Priv_List.Rows[e.RowIndex];

                clickedRow.Selected = true;
            }
        }

        private void Priv_List_SelectionChanged(object sender, EventArgs e)
        {
            if (Priv_List.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Priv_List.SelectedRows[0];
                textBirthMe.Value = DateTime.Parse(selectedRow.Cells["NGAYSINH"].Value.ToString());
                textAddrMe.Text = selectedRow.Cells["DIACHI"].Value.ToString();
                textPhoneMe.Text = selectedRow.Cells["SDT"].Value.ToString();
            }

        }

        private void textBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelNhanVien_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
