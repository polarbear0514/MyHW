using System;
using System.Collections;
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
    public partial class FrmMyAlbum_V1 : Form
    {
        public FrmMyAlbum_V1()
        {
            InitializeComponent();
            this.areaTableAdapter1.Fill(this.maDataSet1.Area);
            this.pictureTableAdapter1.Fill(this.maDataSet1.Picture);
            this.maDataSet1.Area[0].AreaName.ToString();
            ArrayList s=new ArrayList();
            for (int i = 0; i <= this.maDataSet1.Tables.Count - 2; i++)
            {
                DataTable table = this.maDataSet1.Tables[i];
                for (int row = 0; row <= table.Rows.Count - 1; row++)
                {
                    s.Add ( this.maDataSet1.Area[row].AreaName.ToString());
                }
            }


            for (int i = 0; i < s.Count; i++)
            {
                LinkLabel link = new LinkLabel();
                link.Text = s[i].ToString();
                link.Left = 5;
                link.Top = 30 * i;
                link.Tag = i;
                link.Click += X_Click;
                panel1.Controls.Add(link);
            }
        }
        private void X_Click(object sender, EventArgs e)
        {
            LinkLabel x = sender as LinkLabel;
            if (x != null)
            {
                //MessageBox.Show(x.Text + " - " + x.Tag);
                this.pictureTableAdapter1.FillByGetAreaName(this.maDataSet1.Picture, x.Text);
                this.pictureDataGridView.DataSource = this.maDataSet1.Picture;
                this.pictureDataGridView.DataSource = this.pictureBindingSource;
                this.areaNameTextBox.Text = x.Text;
            }




        }

        private void areaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.areaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.maDataSet1);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
