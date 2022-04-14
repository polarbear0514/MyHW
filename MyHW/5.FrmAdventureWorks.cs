using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmAdventureWorks : Form
    {
        public FrmAdventureWorks()
        {
            InitializeComponent();
            this.productPhotoTableAdapter1.Fill(this.awDataSet1.ProductPhoto);

            SqlConnection conn1 = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorks;Integrated Security=True");
            SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT DATEPART(yyyy, ModifiedDate) AS Expr1, COUNT(*) AS Expr2 FROM   Production.ProductPhoto GROUP BY   DATEPART(yyyy, ModifiedDate) ORDER BY   Expr1", conn1);
            DataSet ds = new DataSet();
            adapter1.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i]["Expr1"]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.productPhotoTableAdapter1.FillByGetYear(this.awDataSet1.ProductPhoto, Convert.ToDecimal(comboBox1.Text));

            this.dataGridView1.DataSource = this.awDataSet1.ProductPhoto;
            this.dataGridView1.DataSource = this.bindingSource2;
            this.bindingNavigator1.BindingSource = this.bindingSource2;
            this.bindingSource2.DataSource = this.awDataSet1.ProductPhoto;
            button2.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource2.MoveFirst();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource2.MovePrevious();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource2.MoveNext();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.bindingSource2.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime s1=dateTimePicker1.Value;
            DateTime s2 = dateTimePicker2.Value;
            int dresult = DateTime.Compare(s1, s2);
            if (dresult == 1)
            {
                MessageBox.Show("請選擇正確日期", "起日晚於迄日", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.productPhotoTableAdapter1.FillByGetDate(this.awDataSet1.ProductPhoto, s1, s2);
                this.dataGridView1.DataSource = this.awDataSet1.ProductPhoto;
                this.dataGridView1.DataSource = this.bindingSource2;
                this.bindingNavigator1.BindingSource = this.bindingSource2;
                this.bindingSource2.DataSource = this.awDataSet1.ProductPhoto;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime s1 = dateTimePicker1.Value;
            DateTime s2 = dateTimePicker2.Value;
            int dresult = DateTime.Compare(s1, s2);
            if (dresult==1)
            {
                MessageBox.Show("請選擇正確日期", "起日晚於迄日", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //this.productPhotoTableAdapter1.FillByOrderDate(this.awDataSet1.ProductPhoto, s1, s2);
                //this.dataGridView1.DataSource = this.awDataSet1.ProductPhoto;
                //this.dataGridView1.DataSource = this.bindingSource2;
                //this.bindingNavigator1.BindingSource = this.bindingSource2;
                //this.bindingSource2.DataSource = this.awDataSet1.ProductPhoto;
                dataGridView1.Sort(dataGridView1.Columns["ModifiedDate"], System.ComponentModel.ListSortDirection.Ascending);
            }
            
        }

        private void bindingSource2_CurrentChanged_1(object sender, EventArgs e)
        {
            this.label4.Text = $"{this.bindingSource2.Position + 1}/{this.bindingSource2.Count}";
        }
    }
}
