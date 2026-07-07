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
    public partial class SuaND : Form
    {
        public SuaND()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source = MANH; Initial Catalog = test; Integrated Security = True");
            cn.Open();
            try
            {
                if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & comboBox1.SelectedItem.ToString() != "")
                {

                    SqlCommand themnguoidung = new SqlCommand("update test set id='" + textBox1.Text + "',Pass='" + textBox2.Text + "',hoten='" + textBox3.Text + "', quyen='" + comboBox1.SelectedItem.ToString() + "' where ID='" + textBox1.Text + "'");
                    themnguoidung.Connection = cn;
                    themnguoidung.ExecuteNonQuery();
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Điền Thông Tin Và Chọn Quyền", "Sửa Không Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                // Bắt lỗi
                MessageBox.Show("Trùng Tên Hoặc Chưa Chọn Quyền", "Sửa Không Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                // Đóng kết nối
                cn.Close();
            }
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
