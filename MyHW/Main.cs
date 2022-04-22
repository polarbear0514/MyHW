using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace MyHW
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmHomeWork fh = new FrmHomeWork();
            fh.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(fh);
            fh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmCatagoryProducts fp = new FrmCatagoryProducts();
            fp.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(fp);
            fp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmAdventureWorks fa = new FrmAdventureWorks();
            fa.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(fa);
            fa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmMyAlbum_V2 fab = new FrmMyAlbum_V2();
            fab.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(fab);
            fab.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmDataSet結構 fd = new FrmDataSet結構();
            fd.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(fd);
            fd.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmLogon fl = new FrmLogon();
            fl.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(fl);
            fl.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            FrmTreeView ft = new FrmTreeView();
            ft.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(ft);
            ft.Show();
        }
    }
}
