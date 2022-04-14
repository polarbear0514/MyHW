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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            //this.dataGridView1.DataSource = this.nwDataSet1.Products;
            //this.bindingSource1.DataSource = this.nwDataSet1.Products;
           
        }
        int num;
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.label2.Text = $"{this.bindingSource1.Position+1}/{this.bindingSource1.Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveFirst();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                
                bool isNum = int.TryParse(textBox1.Text, out num);
                bool isNum1 = int.TryParse(textBox2.Text, out num);
                if (!isNum || !isNum1)
                {
                    MessageBox.Show("請輸入完整數值範圍");
                }
                else
                {
                    this.dataGridView1.DataSource = this.bindingSource1;
                    this.bindingNavigator1.BindingSource = this.bindingSource1;
                    this.bindingSource1.DataSource = this.nwDataSet1.Products;
                    int n1 = int.Parse(textBox1.Text);
                    int n2 = int.Parse(textBox2.Text);
                    this.productsTableAdapter1.FillByUnitPrice(this.nwDataSet1.Products, n1, n2);
                    this.dataGridView1.DataSource = this.nwDataSet1.Products;
                    lblResult.Text = "搜尋結果" + "\n" + "UntiPrice:" + n1.ToString() + " ~ " + n2.ToString() + "共" + this.bindingSource1.Count + "筆";
                }
            }
            else
            {
                bool isNum = int.TryParse(textBox1.Text, out num);
                bool isNum1 = int.TryParse(textBox2.Text, out num);
                if (!isNum || !isNum1)
                {
                    MessageBox.Show("請輸入完整數值範圍");
                }
                else
                {
                    this.dataGridView1.DataSource = this.bindingSource1;
                    this.bindingNavigator1.BindingSource = this.bindingSource1;
                    this.bindingSource1.DataSource = this.nwDataSet1.Products;
                    int n1 = int.Parse(textBox1.Text);
                    int n2 = int.Parse(textBox2.Text);
                    string s = textBox3.Text;
                    this.productsTableAdapter1.FillByProductPrice(this.nwDataSet1.Products, s, n1, n2);
                    lblResult.Text = "搜尋結果" + "\n" + "Products:" + s + "\n" + "UntiPrice:" + n1.ToString() + " ~ " + n2.ToString() + "共" + this.bindingSource1.Count + "筆";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("請輸入產品名稱");
            }
            else if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox1.Text))
            {
                this.dataGridView1.DataSource = this.bindingSource1;
                this.bindingNavigator1.BindingSource = this.bindingSource1;
                this.bindingSource1.DataSource = this.nwDataSet1.Products;
                string s = textBox3.Text;
                this.productsTableAdapter1.FillByProductName(this.nwDataSet1.Products, s);
                this.dataGridView1.DataSource = this.nwDataSet1.Products;
                this.dataGridView1.DataSource = this.nwDataSet1.Products;
                lblResult.Text = "搜尋結果" + "\n" + "Products:" + s + "共" + this.bindingSource1.Count + "筆";
            }
            else
            {
                bool isNum = int.TryParse(textBox1.Text, out num);
                bool isNum1 = int.TryParse(textBox2.Text, out num);
                if (!isNum || !isNum1)
                {
                    MessageBox.Show("請輸入完整數值範圍");
                }
                else
                {
                    this.dataGridView1.DataSource = this.bindingSource1;
                    this.bindingNavigator1.BindingSource = this.bindingSource1;
                    this.bindingSource1.DataSource = this.nwDataSet1.Products;
                    int n1 = int.Parse(textBox1.Text);
                    int n2 = int.Parse(textBox2.Text);
                    string s = textBox3.Text;
                    this.productsTableAdapter1.FillByProductPrice(this.nwDataSet1.Products, s, n1, n2);
                    lblResult.Text = "搜尋結果" + "\n" + "Products:" + s + "\n" + "UntiPrice:" + n1.ToString() + " ~ " + n2.ToString() + "共" + this.bindingSource1.Count + "筆";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            lblResult.Text = "搜尋結果";
            dataGridView1.DataSource = null;
            this.bindingNavigator1.BindingSource = null;
            this.bindingSource1.DataSource = null;
        }
    }
}
