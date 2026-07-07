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
    public partial class fdangnhap : Form
    {
        public fdangnhap()
        {
            InitializeComponent();
        }

        private void fdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void buttondangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=NGOQUANGMANH\SQLEXPRESS;Initial Catalog=sinhvien;Integrated Security=True");
            
                conn.Open();
                string sql = "select *from tabledangnhap where Taikhoan='" + textBoxtaikhoan.Text + "' and Matkhau='" + textBoxmatkhau.Text +"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    fQLSV f = new fQLSV();
                    this.Hide();
                    f.ten = textBoxtaikhoan.Text;
                    f.mk = textBoxmatkhau.Text; ;
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình","Thông báo", MessageBoxButtons.OKCancel , MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void groupBoxthongtindangnhap_Enter(object sender, EventArgs e)
        {

        }
    }
}
