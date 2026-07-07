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
using System.Data;

namespace ahihi1
{
    public partial class fQLSV : Form
    {
        private string _ten, _mk;
        public fQLSV()
        {
            InitializeComponent();
        }
        public string ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        
        public string mk
        {
            get { return _mk; }
            set { _mk = value; }
        }
        
        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fdoimatkhau f = new fdoimatkhau();
            this.Hide();
            f.ten = _ten;
            f.mk = _mk;
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftimkiem f = new ftimkiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fcapnhat f = new fcapnhat();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=NGOQUANGMANH\SQLEXPRESS;Initial Catalog=sinhvien;Integrated Security=True");
        private void KetNoiCSDL()
        {
            con.Open();
            string sql = "Select * from tablesinhvien";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();
            dataGridView1.DataSource = dt;
        }
        private void fQLSV_Load(object sender, EventArgs e)
        {
            label1.Text = "Xin chao nguoi dung " + _ten + "";
            KetNoiCSDL();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Selected = true;
            }
            catch { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fQLSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            fdangnhap f = new fdangnhap();
            f.Show();
        }
    }
}
