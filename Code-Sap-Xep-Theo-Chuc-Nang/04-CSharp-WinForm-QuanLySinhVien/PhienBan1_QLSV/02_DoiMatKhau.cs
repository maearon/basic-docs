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


namespace WindowsFormsApplication7
{
    public partial class doimatkhau : Form
    {
        private string _ten, _mk, _loai, _tennd;
        public doimatkhau()
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
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-3QNAF94\SQL; Initial Catalog=sinhvien; Integrated Security = True");
            cn.Open();
            try
            {
                if (textBox1.Text!="" & textBox2.Text !="" & textBox3.Text != "" )
                {
                    if (textBox1.Text == _mk)
                    {
                        if (textBox2.Text == textBox3.Text)
                        {
                            SqlCommand doimatkhau = new SqlCommand("UPDATE tabledangnhap SET matkhau='" + textBox2.Text + "' where taikhoan='" + _ten + "'");
                            doimatkhau.Connection = cn;
                            doimatkhau.ExecuteNonQuery();
                            MessageBox.Show("Đổi Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Mật khẩu mới chưa trùng nhau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Mật khẩu không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Điền Thông Tin", "Đổi Không Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                // Bắt lỗi
                MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                // Đóng kết nối
                cn.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
