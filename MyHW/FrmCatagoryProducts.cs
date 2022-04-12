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
    public partial class FrmCatagoryProducts : Form
    {
        public FrmCatagoryProducts()
        {
            InitializeComponent();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                string query = $"select CategoryName from Categories";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string s = $"{dataReader["CategoryName"]}";
                    comboBox1.Items.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                string query = $"select ProductName from Products as p join Categories as c on p.CategoryID = c.CategoryID where CategoryName = '{comboBox1.Text}'";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader dataReader = command.ExecuteReader();

                this.listBox1.Items.Clear();
                while (dataReader.Read())
                {
                    string s = $"{dataReader["ProductName"]}";
                    this.listBox1.Items.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
