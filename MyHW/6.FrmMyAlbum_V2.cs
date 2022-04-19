using MyHW.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmMyAlbum_V2 : Form
    {
        public FrmMyAlbum_V2()
        {
            InitializeComponent();
            this.areaTableAdapter1.Fill(this.maDataSet1.Area);
            this.pictureTableAdapter1.Fill(this.maDataSet1.Picture);
            this.maDataSet1.Area[0].AreaName.ToString();
            this.pictureBox1.AllowDrop = true;
            this.pictureBox1.DragEnter += PictureBox1_DragEnter;
            this.pictureBox1.DragDrop += PictureBox1_DragDrop;
            this.flowLayoutPanel3.AllowDrop = true;
            this.flowLayoutPanel3.DragEnter += FlowLayoutPanel3_DragEnter;
            this.flowLayoutPanel3.DragDrop += FlowLayoutPanel3_DragDrop;
            SqlConnection conn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Desktop\MyHW\MyHW\bin\Debug\MyAlbumDB.mdf;Integrated Security=True");
            SqlDataAdapter adapter1 = new SqlDataAdapter("select * from Area", conn1);
            DataSet ds = new DataSet();
            adapter1.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i]["AreaName"]);
            }
            ArrayList s = new ArrayList();
            for (int i = 0; i <= this.maDataSet1.Tables.Count - 2; i++)
            {
                DataTable table = this.maDataSet1.Tables[i];
                for (int row = 0; row <= table.Rows.Count - 1; row++)
                {
                    s.Add(this.maDataSet1.Area[row].AreaName.ToString());
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
                flowLayoutPanel2.Controls.Add(link);
            }
        }

        private void FlowLayoutPanel3_DragDrop(object sender, DragEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("請選擇分類");
            }
            else
            {
                this.areaTableAdapter1.FillByAntoAi(this.maDataSet1.Area, comboBox1.Text);
                string z = this.maDataSet1.Area[0].AreaId.ToString();
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                for (int i = 0; i <= files.Length - 1; i++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(files[i]);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Width = 120;
                    pic.Height = 160;
                    pic.Click += Pic_Click;
                    this.flowLayoutPanel3.Controls.Add(pic);

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumDBConnectionString))
                        {
                            SqlCommand command = new SqlCommand();
                            command.CommandText = "Insert into Picture (AreaId,Picture) Values(@AId,@Picture)";
                            command.Connection = conn;
                            byte[] bytes;
                            System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            bytes = ms.GetBuffer();
                            command.Parameters.Add("@AId", SqlDbType.Int).Value = z;
                            command.Parameters.Add("@Picture", SqlDbType.Image).Value = bytes;
                            conn.Open();
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }
        private void Pic_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.BackgroundImage = ((PictureBox)sender).Image;
            f.BackgroundImageLayout = ImageLayout.Zoom;
            f.Width = 420;
            f.Height = 460;
            f.Show();
        }
        private void FlowLayoutPanel3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.pictureBox1.Image = Image.FromFile(files[0]);
        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void X_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            LinkLabel x = sender as LinkLabel;
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumDBConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select * from  Picture p join Area a on p.AreaId=a.AreaId  where AreaName='{x.Text}'";
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        byte[] bytes = (byte[])dataReader["Picture"];
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                        PictureBox pic = new PictureBox();
                        pic.Image = Image.FromStream(ms);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 120;
                        pic.Height = 160;
                        pic.Click += Pic_Click;
                        this.flowLayoutPanel1.Controls.Add(pic);
                        this.pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                this.pictureBox1.Image = this.pictureBox1.ErrorImage;
            }

        }
        private void ShowImage(string areaName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumDBConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select * from  Picture p join Area a on p.AreaId=a.AreaId  where AreaName='{areaName}'";
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        dataReader.Read();
                        byte[] bytes = (byte[])dataReader["Picture"];
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                        this.pictureBox1.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        MessageBox.Show("No Record");
                    }
                } // Auto conn.Close()
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                this.pictureBox1.Image = this.pictureBox1.ErrorImage;
            }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "*.jpg|*.jpg|*.png|*.png";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumDBConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = "Insert into Picture (AreaId,Description,Picture) Values(@AId,@Desc,@Picture)";
                    command.Connection = conn;
                    byte[] bytes;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bytes = ms.GetBuffer();
                    command.Parameters.Add("@AId", SqlDbType.Int).Value = this.textBox1.Text;
                    command.Parameters.Add("@Desc", SqlDbType.Text).Value = this.textBox4.Text;
                    command.Parameters.Add("@Picture", SqlDbType.Image).Value = bytes;
                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Insert Image successfully ");
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string files = comboBox1.Text;
            ShowImage(files);
            this.flowLayoutPanel3.Controls.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumDBConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select * from  Picture p join Area a on p.AreaId=a.AreaId  where AreaName='{files}'";
                    command.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read()) 
                    {
                        byte[] bytes = (byte[])dataReader["Picture"];
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                        PictureBox pic = new PictureBox();
                        pic.Image = Image.FromStream(ms);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 120;
                        pic.Height = 160;
                        pic.Click += Pic_Click;
                        this.flowLayoutPanel3.Controls.Add(pic);
                        this.pictureBox1.Image = Image.FromStream(ms);
                    }
                } 
            }
            catch (Exception ex)
            {
                this.pictureBox1.Image = this.pictureBox1.ErrorImage;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("請選擇分類");
            }
            else 
            { 
            this.areaTableAdapter1.FillByAntoAi(this.maDataSet1.Area, comboBox1.Text);
            string z = this.maDataSet1.Area[0].AreaId.ToString();
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            this.flowLayoutPanel3.Controls.Clear();
            dialog.Description = "請選擇所在資料夾";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string[] files = Directory.GetFiles(dialog.SelectedPath, "*", SearchOption.TopDirectoryOnly);
                    List<Image> lstImg = new List<Image>();

                    foreach (string fileName in files)
                    {
                        lstImg.Add(Bitmap.FromFile(fileName));
                    }
                    for (int i = 0; i <= lstImg.Count - 1; i++)
                    {
                        PictureBox pic = new PictureBox();
                        pic.Image = Image.FromFile(files[i]);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 120;
                        pic.Height = 160;
                        pic.Click += Pic_Click;
                        this.flowLayoutPanel3.Controls.Add(pic);
                        try
                        {
                            using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumDBConnectionString))
                            {
                                SqlCommand command = new SqlCommand();
                                command.CommandText = "Insert into Picture (AreaId,Picture) Values(@AId,@Picture)";
                                command.Connection = conn;
                                byte[] bytes;
                                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                                pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                bytes = ms.GetBuffer();
                                command.Parameters.Add("@AId", SqlDbType.Int).Value = z;
                                command.Parameters.Add("@Picture", SqlDbType.Image).Value = bytes;
                                conn.Open();
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    if (string.IsNullOrEmpty(dialog.SelectedPath))
                    {
                        MessageBox.Show(this, "資料夾路徑不能為空", "提示");
                        return;
                    }
                }
            }
        }
    }
}
