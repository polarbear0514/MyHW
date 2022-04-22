using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmDataSet結構 : Form
    {
        public FrmDataSet結構()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.customersTableAdapter1.Fill(this.nwDataSet1.Customers);
            this.dataGridView4.DataSource = this.nwDataSet1.Products;
            this.dataGridView5.DataSource = this.nwDataSet1.Categories;
            this.dataGridView6.DataSource = this.nwDataSet1.Customers;

            this.listBox2.Items.Clear();
            for (int i = 0; i <= this.nwDataSet1.Tables.Count - 1; i++)
            {
                DataTable table = this.nwDataSet1.Tables[i];
                this.listBox2.Items.Add(table.TableName);

                string s = "";
                for (int column = 0; column <= table.Columns.Count - 1; column++)
                {
                    s += $"{table.Columns[column].ColumnName,-40}";
                }
                this.listBox2.Items.Add(s);

                for (int row = 0; row <= table.Rows.Count - 1; row++)
                {
                    string ss = "";
                    for (int j = 0; j <= table.Columns.Count - 1; j++)
                    {
                        ss += $"{table.Rows[row][j],-40}";
                    }
                    this.listBox2.Items.Add(ss);


                }
                this.listBox2.Items.Add("======================================");
            }

        }
    }
}
