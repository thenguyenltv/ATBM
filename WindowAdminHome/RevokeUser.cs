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
    public partial class RevokeUser : Form
    {
        string str = "";
        int cnt = 0;
        OracleConnection conn;
        public RevokeUser(
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
            getEmps.CommandText = "usp_revoke";
            getEmps.CommandType = CommandType.StoredProcedure;
            //parameter
            getEmps.Parameters.Add("priv", str);
            getEmps.Parameters.Add("usrname", usrn_revoke.Text);
            getEmps.Parameters.Add("tab", Table.Text);
            try
            {
                getEmps.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Permissions that you have not granted cannot be revoked! ");
            }
            conn.Close();
            this.Close();
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
            }
            else
            {
                //str = tmp;
                int tmp = 0;
                int end = 6;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 's' && str[i + 1] == 'e' && str[i + 2] == 'l')
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
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (cnt != 0)
                {
                    str += ",";
                }
                str += "select";
                cnt++;
                ///MessageBox.Show(str);
            }
            else
            {
                //str = tmp;
                int tmp = 0;
                int end = 6;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 's' && str[i + 1] == 'e' && str[i + 2] == 'l')
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
                str += "select";
                cnt++;
                ///MessageBox.Show(str);
            }
            else
            {
                //str = tmp;
                int tmp = 0;
                int end = 6;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 's' && str[i + 1] == 'e' && str[i + 2] == 'l')
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
                str += "select";
                cnt++;
                ///MessageBox.Show(str);
            }
            else
            {
                //str = tmp;
                int tmp = 0;
                int end = 6;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 's' && str[i + 1] == 'e' && str[i + 2] == 'l')
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RevokeRole form = new RevokeRole(conn);
            form.Show();
        }
    }
}
