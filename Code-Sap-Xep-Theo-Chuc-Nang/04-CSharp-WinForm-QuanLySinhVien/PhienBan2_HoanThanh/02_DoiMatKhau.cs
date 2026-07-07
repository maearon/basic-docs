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
    public partial class fdoimatkhau : Form
    {
        private string _ten, _mk;
        public fdoimatkhau()
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
       
        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void buttoncapnhat_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=NGOQUANGMANH\SQLEXPRESS; Initial Catalog=sinhvien; Integrated Security = True");
            cn.Open();
            
                if (textBoxmatkhaucu.Text != "" & textBoxmatkhaumoi.Text != "" & textBoxnhaplaimatkhau.Text != "")
                {
                    if (textBoxmatkhaucu.Text == mk)
                    {
                        if (textBoxmatkhaumoi.Text == textBoxnhaplaimatkhau.Text)
                        {
                            SqlCommand doimatkhau = new SqlCommand("UPDATE tabledangnhap SET matkhau='" + textBoxmatkhaumoi.Text + "' where taikhoan='" + ten + "'");
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

        private void fdoimatkhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            fQLSV f = new fQLSV();
            f.Show();
        }
    }
}
