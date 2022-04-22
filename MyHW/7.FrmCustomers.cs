using MyHW.Properties;
using System;
using System.Collections;
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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
            LoadCountryToComboBox();
            this.listView1.View = View.Details;
            CreateListViewColumn();
        }

        private void CreateListViewColumn()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select * from Customers", conn);
                    SqlDataReader dataReader = command.ExecuteReader();
                    DataTable table = dataReader.GetSchemaTable();
                    for (int i = 0; i <= table.Rows.Count - 1; i++)
                    {
                        this.listView1.Columns.Add(table.Rows[i][0].ToString());
                    }
                    this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCountryToComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("select distinct country from Customers", conn);
                    SqlDataReader dataReader = command.ExecuteReader();
                    this.comboBox1.Items.Clear();
                    this.comboBox1.Items.Add("All Country");
                    while (dataReader.Read())
                    {
                        this.comboBox1.Items.Add(dataReader["country"]);
                    }
                    this.comboBox1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    if (comboBox1.Text == "All Country")
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select * from Customers ";
                        command.Connection = conn;
                        SqlDataReader dataReader = command.ExecuteReader();
                        this.listView1.Items.Clear();
                        Random r = new Random();
                        listView1.Groups.Clear();
                        while (dataReader.Read())
                        {
                            ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());
                            lvi.ImageIndex = r.Next(0, ImageList1.Images.Count);
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.AntiqueWhite;
                            }
                            else
                            {
                                lvi.BackColor = Color.LemonChiffon;
                            }
                            for (int i = 1; i <= dataReader.FieldCount - 1; i++)
                            {
                                if (dataReader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("Null");
                                }
                                else
                                {
                                    lvi.SubItems.Add(dataReader[i].ToString());
                                }
                            }
                            
                        }
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select * from Customers where country='{this.comboBox1.Text}'";
                        command.Connection = conn;
                        SqlDataReader dataReader = command.ExecuteReader();
                        this.listView1.Items.Clear();
                        Random r = new Random();
                        listView1.Groups.Clear();
                        while (dataReader.Read())
                        {
                            ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());
                            lvi.ImageIndex = r.Next(0, ImageList1.Images.Count);
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.AntiqueWhite;
                            }
                            else
                            {
                                lvi.BackColor = Color.LemonChiffon;
                            }
                            for (int i = 1; i <= dataReader.FieldCount - 1; i++)
                            {
                                if (dataReader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("Null");
                                }
                                else
                                {
                                    lvi.SubItems.Add(dataReader[i].ToString());
                                }
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
        }

        private void customerIDAscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    if (comboBox1.Text == "All Country")
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select * from Customers order by CustomerId";
                        command.Connection = conn;
                        SqlDataReader dataReader = command.ExecuteReader();
                        this.listView1.Items.Clear();
                        Random r = new Random();
                        while (dataReader.Read())
                        {
                            ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());
                            lvi.ImageIndex = r.Next(0, ImageList1.Images.Count);
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.AntiqueWhite;
                            }
                            else
                            {
                                lvi.BackColor = Color.LemonChiffon;
                            }
                            for (int i = 1; i <= dataReader.FieldCount - 1; i++)
                            {
                                if (dataReader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("Null");
                                }
                                else
                                {
                                    lvi.SubItems.Add(dataReader[i].ToString());
                                }
                            }
                        }
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select * from Customers where country='{this.comboBox1.Text}' order by CustomerId";
                        command.Connection = conn;
                        SqlDataReader dataReader = command.ExecuteReader();
                        this.listView1.Items.Clear();
                        Random r = new Random();
                        while (dataReader.Read())
                        {
                            ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());
                            lvi.ImageIndex = r.Next(0, ImageList1.Images.Count);
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.AntiqueWhite;
                            }
                            else
                            {
                                lvi.BackColor = Color.LemonChiffon;
                            }
                            for (int i = 1; i <= dataReader.FieldCount - 1; i++)
                            {
                                if (dataReader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("Null");
                                }
                                else
                                {
                                    lvi.SubItems.Add(dataReader[i].ToString());
                                }
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

        private void customerIDDescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    if (comboBox1.Text == "All Country")
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select * from Customers order by CustomerId desc";
                        command.Connection = conn;
                        SqlDataReader dataReader = command.ExecuteReader();
                        this.listView1.Items.Clear();
                        Random r = new Random();
                        while (dataReader.Read())
                        {
                            ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());
                            lvi.ImageIndex = r.Next(0, ImageList1.Images.Count);
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.AntiqueWhite;
                            }
                            else
                            {
                                lvi.BackColor = Color.LemonChiffon;
                            }
                            for (int i = 1; i <= dataReader.FieldCount - 1; i++)
                            {
                                if (dataReader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("Null");
                                }
                                else
                                {
                                    lvi.SubItems.Add(dataReader[i].ToString());
                                }
                            }
                        }
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select * from Customers where country='{this.comboBox1.Text}' order by CustomerId desc";
                        command.Connection = conn;
                        SqlDataReader dataReader = command.ExecuteReader();
                        this.listView1.Items.Clear();
                        Random r = new Random();
                        while (dataReader.Read())
                        {
                            ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());
                            lvi.ImageIndex = r.Next(0, ImageList1.Images.Count);
                            if (lvi.Index % 2 == 0)
                            {
                                lvi.BackColor = Color.AntiqueWhite;
                            }
                            else
                            {
                                lvi.BackColor = Color.LemonChiffon;
                            }
                            for (int i = 1; i <= dataReader.FieldCount - 1; i++)
                            {
                                if (dataReader.IsDBNull(i))
                                {
                                    lvi.SubItems.Add("Null");
                                }
                                else
                                {
                                    lvi.SubItems.Add(dataReader[i].ToString());
                                }
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

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {  
                        ArrayList countrylist = new ArrayList();
                        createGroup(countrylist);
                        for (int j = 0; j <= countrylist.Count - 1; j++)
                        {
                            ListViewGroup group = new ListViewGroup(countrylist[j].ToString(), countrylist[j].ToString());
                            listView1.Groups.Add(group);
                        }
                        for (int k = 0; k <= countrylist.Count - 1; k++)
                        {
                            for (int l = 0; l < listView1.Items.Count; l++)
                            {
                                if (listView1.Items[l].SubItems[8].Text == countrylist[k].ToString())
                                {
                                    listView1.Items[l].Group = listView1.Groups[k]; ;
                                }
                            }
                        }
            ArrayList countrylist1 = new ArrayList();
            createGroupwithNum(countrylist1);
            for(int m = 0; m <= countrylist1.Count - 1; m++)
            {
                listView1.Groups[m].Header = countrylist1[m].ToString();
            }
        }
        ArrayList createGroup(ArrayList list)
        {
            try
            {            
               using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"SELECT Country, COUNT(Country) AS cnum from Customers GROUP BY Country";
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {  
                        list.Add(dataReader["Country"].ToString());
                    }         
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }
        ArrayList createGroupwithNum(ArrayList list)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"SELECT Country, COUNT(Country) AS cnum from Customers GROUP BY Country";
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        list.Add(dataReader["Country"].ToString() + "(" + dataReader["cnum"] + ")");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }
    }
}
