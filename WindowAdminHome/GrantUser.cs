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
    public partial class GrantUser : Form
    {
        OracleConnection conn;
        string str = "";
        string str1 = "";
        ///string strUpd = "";
        int cnt = 0;
        bool cUpd = false;
        public GrantUser(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            update_List_table();
        }


        private void Grant_bt_Click(object sender, EventArgs e)
        {
            if (this.conn.State == ConnectionState.Closed)
                conn.Open();
            OracleCommand getEmps = conn.CreateCommand();
            getEmps.CommandText = "usp_grant";
            getEmps.CommandType = CommandType.StoredProcedure;
            //parameter
            getEmps.Parameters.Add("priv", str);
            getEmps.Parameters.Add("usrname", usrn_grant.Text);
            if (str1 == "")
                getEmps.Parameters.Add("opt", "");
            else
                getEmps.Parameters.Add("opt", "with grant option");
            getEmps.Parameters.Add("tab", comboBox1.Text);
            try {
                getEmps.ExecuteNonQuery();
                MessageBox.Show("Cap quyen thanh cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ten nguoi dung hoac bang thuoc tinh khong ton tai! ");
            }
            conn.Close();
            this.Close();
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


        private void wgrant_check_CheckedChanged(object sender, EventArgs e)
        {
            
            if(this.label4.Visible == true
             && this.wgrant_check.Visible == true)
            if (wgrant_check.Checked == true)
            {
                str1 = "with grant option";
                ///MessageBox.Show(str1);
            }
            else
            {
                str1 = "";
                ///MessageBox.Show(str1);
            }
            else
            {
                str1 = "";
                MessageBox.Show("not select");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (cnt != 0)
                {
                    str += ",";
                }
                str += "select";
                cnt++;
                ///MessageBox.Show(str);
                this.label4.Visible = true;
                this.wgrant_check.Visible = true;
            }
            else
            {
                //str = tmp;
                int tmp=0;
                int end = 6;
                for(int i=0;i<str.Length;i++)
                {
                    if(str[i]=='s' && str[i+1]=='e' && str[i+2]=='l')
                    {
                        if (i == 0)
                        {
                            tmp = i;
                            if (str.Length > 6) end = 7;
                        }
                        else
                        {
                            tmp = i - 1;
                            end=7;
                        }
                    }
                }
                str=str.Remove(tmp,end);
                cnt--;
                ///MessageBox.Show(str);
                if (cnt == 0)
                {
                    this.label4.Visible = false;
                    this.wgrant_check.Visible = false;
                }
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string strUpd = "";
            if (checkBox2.Checked == true)
            {
                if (cnt != 0)
                {
                    str += ",";
                }
                str += "update";
                if(textBox1.Text!="")
                {
                    strUpd = "( " + textBox1.Text + " )";
                    str += strUpd;
                    cUpd = true;
                }
                cnt++;
                ///MessageBox.Show(str);
                this.label4.Visible = true;
                this.wgrant_check.Visible = true;
            }
            else
            {
                //str = tmp;
                int tmp = 0;
                int end = 6;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 'u' && str[i + 1] == 'p' && str[i + 2] == 'd')
                    {
                        if (i == 0)
                        {
                            tmp = i;
                            if (str.Length > 6) end = 7;
                        }
                        else
                        {
                            tmp = i - 1;
                            end = 7;
                        }
                    }
                }
                if(textBox1.Text!="")
                {
                    end += 2 + textBox1.Text.Length + 2;
                }
                str = str.Remove(tmp, end);
                cnt--;
                ///MessageBox.Show(str);
                if (cnt == 0)
                {
                    this.label4.Visible = false;
                    this.wgrant_check.Visible = false;

                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox3.Checked == true)
            {
                if (cnt != 0)
                {
                    str += ",";
                }
                str += "insert";
                cnt++;
                ///MessageBox.Show(str);
                this.label4.Visible = true;
                this.wgrant_check.Visible = true;
            }
            else
            {
                //str = tmp;
                int tmp = 0;
                int end = 6;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 'i' && str[i + 1] == 'n' && str[i + 2] == 's')
                    {
                        if (i == 0) 
                        {
                            tmp = i;
                            if (str.Length > 6) end = 7;
                        }
                        else
                        {
                            tmp = i - 1;
                            end = 7;
                        }
                    }
                }
                str = str.Remove(tmp, end);
                cnt--;
                ///MessageBox.Show(str);
                if (cnt == 0)
                {
                    this.label4.Visible = false;
                    this.wgrant_check.Visible = false;
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox4.Checked == true)
            {
                if (cnt != 0)
                {
                    str += ",";
                }
                str += "delete";
                cnt++;
                ///MessageBox.Show(str);
                this.label4.Visible = true;
                this.wgrant_check.Visible = true;
            }
            else
            {
                //str = tmp;
                int tmp = 0;
                int end = 6;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 'd' && str[i + 1] == 'e' && str[i + 2] == 'l')
                    {
                        if (i == 0)
                        {
                            tmp = i;
                            if (str.Length > 6) end = 7;
                        }
                        else
                        {
                            tmp = i - 1;
                            end = 7;
                        }
                    }
                }
                str = str.Remove(tmp, end);
                cnt--;
                ///MessageBox.Show(str);
                if (cnt == 0)
                {
                    this.label4.Visible = false;
                    this.wgrant_check.Visible = false;
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox5.Checked==true)
            {
                this.textBox1.Visible = true;
                this.label9.Visible = true;
            }
            else
            {
                this.textBox1.Visible = false;
                this.label9.Visible = false;
                textBox1.Text = "";
            }
        }

        private void grant_role_bt_Click(object sender, EventArgs e)
        {
            GrantRole form = new GrantRole(conn);
            form.Show();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox6.Checked==true)
            {
                checkBox7.AutoCheck = false;
                wgrant_check.AutoCheck = true;
            }
            else
            {
                checkBox7.AutoCheck = true;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox6.AutoCheck = false;
                wgrant_check.AutoCheck = false;
                wgrant_check.Checked = false;
            }
            else
            {
                checkBox6.AutoCheck = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///update_List_table();
            ///MessageBox.Show(comboBox1.Text);
            
            ///MessageBox.Show(conn.ConnectionString.Substring(cnt,str.Length-1-cnt));
        }
        private void update_List_table()
        {
            if(this.conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            string str = conn.ConnectionString;
            int cnt = 0;
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str[i] == ' ' && str[i + 1] == 'I' && str[i + 2] == 'D')
                {
                    cnt = i + 4;
                    break;
                }
            }
            string ans = conn.ConnectionString.Substring(cnt, str.Length - 1 - cnt);
            OracleCommand getTable = conn.CreateCommand();
            getTable.CommandText = "select table_name TABLE01 from dba_tables where owner='" + ans.ToUpper()+"'";
            ///conn.ConnectionString
            getTable.CommandType = CommandType.Text;
            OracleDataReader reader = getTable.ExecuteReader();
            while(reader.Read())
            {
                if(reader.HasRows)
                {
                    comboBox1.Items.Add(reader["TABLE01"].ToString());
                }
            }
        }
    }
}
