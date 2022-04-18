using MyHW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmLogon : Form
    {
        public FrmLogon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = this.UsernameTextBox.Text;
                string password = this.PasswordTextBox.Text;

                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "InsertMember";
                    command.Connection = conn;
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = userName;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = password;

                    SqlParameter p1 = new SqlParameter();
                    p1.ParameterName = "@Return_Value";
                    p1.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(p1);
                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("建立帳號成功 MemberID= " + p1.Value);
                } // Auto conn.Close()
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = this.UsernameTextBox.Text;
                string password = this.PasswordTextBox.Text;

                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "MemberLogOn";
                    command.Connection = conn;
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = userName;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = password;

                    conn.Open();
                    command.ExecuteNonQuery();
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("Member LogOn successfully");
                        FrmCustomers fc = new FrmCustomers();
                        fc.Show();
                    }
                    else
                    {
                        MessageBox.Show("Log on failed");
                    }
                } // Auto conn.Close()
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.UsernameTextBox.Text = "";
            this.PasswordTextBox.Text = "";
        }

        private void FrmLogon_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.C)
            {
                this.UsernameTextBox.Text = "";
                this.PasswordTextBox.Text = "";
            }
        }
    }
}
