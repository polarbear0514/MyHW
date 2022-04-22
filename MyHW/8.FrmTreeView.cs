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
    public partial class FrmTreeView : Form
    {
        public FrmTreeView()
        {
            InitializeComponent();
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    string country = "";
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"SELECT Country, COUNT(Country) AS cnum from Customers GROUP BY Country";
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                  
                    while (dataReader.Read())
                    {
                        TreeNode tree = new TreeNode(dataReader["Country"].ToString() + "(" + dataReader["cnum"] + ")");
                        treeView1.Nodes.Add(tree);
                        country = dataReader["Country"].ToString();
                        tree.Tag = 1;
                       
                        using (SqlConnection conn1 = new SqlConnection(Settings.Default.NorthwindConnectionString))
                        {
                            SqlCommand command1 = new SqlCommand();
                            command1.CommandText = $"SELECT distinct city  from Customers where country='{country}'";
                            command1.Connection = conn1;
                            conn1.Open();
                            SqlDataReader dataReader1 = command1.ExecuteReader();
                            while (dataReader1.Read())
                            {
                                TreeNode tree1 = new TreeNode();
                                tree1= tree.Nodes.Add(dataReader1["City"].ToString());
                                tree1.Tag = 2;
                                
                            }
                        }
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int tag = (int)treeView1.SelectedNode.Tag;
            if (tag==2)
            { 
                this.customersTableAdapter1.FillBycc(this.nwDataSet1.Customers, e.Node.Text.ToString());
                this.bindingSource1.DataSource = this.nwDataSet1.Customers;
                this.dataGridView1.DataSource = this.bindingSource1;
                string s = $"共{bindingSource1.Count}個 '{e.Node.Text}'Customers";
                label1.Text = s;
            }
        }
    }
}
