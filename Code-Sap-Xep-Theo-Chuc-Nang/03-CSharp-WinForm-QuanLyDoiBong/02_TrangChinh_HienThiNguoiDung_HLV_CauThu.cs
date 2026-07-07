using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication7
{
    public partial class Chinh : Form
    {
        private string _ten, _mk, _loai, _tennd;
        public Chinh()
        {
            InitializeComponent();
        }
        public string ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        public string tennd
        {
            get { return _tennd; }
            set { _tennd = value; }
        }
        public string mk
        {
            get { return _mk; }
            set { _mk = value; }
        }
        public string loai
        {
            get { return _loai; }
            set { _loai = value; }
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=manh;Initial Catalog=test;Integrated Security=True");
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql1 = "select * from test";// lay het du lieu trong bang nguoi dung
            string sql2 = "select * from cauthu";// lay het du lieu trong bang sinh vien
            string sql3 = "select * from hlv";// lay het du lieu trong bang giang vien
            SqlCommand com1 = new SqlCommand(sql1, cnn); //bat dau truy van
            com1.CommandType = CommandType.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(com1); //chuyen du lieu ve
            DataTable dt1 = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da1.Fill(dt1);  // đổ dữ liệu vào kho

            SqlCommand com2 = new SqlCommand(sql2, cnn); //bat dau truy van
            com2.CommandType = CommandType.Text;
            SqlDataAdapter da2 = new SqlDataAdapter(com2); //chuyen du lieu ve
            DataTable dt2 = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da2.Fill(dt2);  // đổ dữ liệu vào kho

            SqlCommand com3 = new SqlCommand(sql3, cnn); //bat dau truy van
            com3.CommandType = CommandType.Text;
            SqlDataAdapter da3 = new SqlDataAdapter(com3); //chuyen du lieu ve
            DataTable dt3 = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da3.Fill(dt3);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt1;//đổ dữ liệu vào datagridview1
            dataGridView2.DataSource = dt2;//đổ dữ liệu vào datagridview2
            dataGridView3.DataSource = dt3;//đổ dữ liệu vào datagridview3
        }

        private void Chinh_Load(object sender, EventArgs e)
        {
            /*#region Nhạc khởi động form
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"E:\Blank-Disfigure.wav"); 
            sp.Play();
            #endregion  */
            label1.Text = "Xin chao " + _loai + " " + _tennd + "";
            ketnoicsdl();
            if (_loai == "quan ly")
            {
                thêmNDToolStripMenuItem.Enabled = true;
                sửaNDToolStripMenuItem.Enabled = true;
                xóaNDToolStripMenuItem.Enabled = true;
                thêmHLVToolStripMenuItem.Enabled = true;
                sửaHLVToolStripMenuItem.Enabled = true;
                xóaHLVToolStripMenuItem.Enabled = true;
                thêmCTToolStripMenuItem.Enabled = true;
                sửaCTToolStripMenuItem.Enabled = true;
                xóaCTToolStripMenuItem.Enabled = true;
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void trangChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trangChínhToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void trangChínhToolStripMenuItem_Click_2(object sender, EventArgs e)
        {

        }

        private void arsenalcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://arsenal.com");
        }

        private void thêmNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form main = new ThemND();
            main.Show();
        }

        private void sửaNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form main = new SuaND();
            main.Show();
        }

        private void xóaNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form main = new XoaND();
            main.Show();
        }

        private void thêmHLVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form main = new ThemHLV();
            main.Show();
        }

        private void sửaHLVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form main = new SuaHLV();
            main.Show();
        }

        private void xóaHLVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form main = new XoaHLV();
            main.Show();
        }

        private void thêmCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form main = new ThemCT();
            main.Show();
        }

        private void sửaCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form main = new SuaCT();
            main.Show();
        }

        private void xóaCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form main = new XoaCT();
            main.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form main = new Form1();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void lịchThiĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hLVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
