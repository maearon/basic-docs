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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source = MANH; Initial Catalog = test; Integrated Security = True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from test where id ='" + textBox1.Text + "' and pass = '" + textBox2.Text + "'", cn);
            string sql1 = "select hoten,Quyen from test where id= '" + textBox1.Text + "'";
            SqlCommand com1 = new SqlCommand(sql1, cn); //bat dau truy van
            com1.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com1); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                this.Hide();
                Chinh main = new Chinh();
                main.ten = textBox1.Text;
                main.mk = textBox2.Text;
                main.tennd = dt.Rows[0]["hoten"].ToString();
                main.loai = dt.Rows[0]["Quyen"].ToString();
                main.Show();
            }
            else
            {
                MessageBox.Show("Tên hoặc Mật khẩu không đúng");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }
    }
}
