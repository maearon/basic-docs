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
    public partial class XoaHLV : Form
    {
        public XoaHLV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source = MANH; Initial Catalog = test; Integrated Security = True");
            cn.Open();
            try
            {
                if (textBox1.Text != "")
                {
                    SqlCommand xoanguoidung = new SqlCommand("delete from hlv where vaitro='" + textBox1.Text + "'");
                    xoanguoidung.Connection = cn;
                    xoanguoidung.ExecuteNonQuery();
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                // Bắt lỗi
                MessageBox.Show("Xóa Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                // Đóng kết nối
                cn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
