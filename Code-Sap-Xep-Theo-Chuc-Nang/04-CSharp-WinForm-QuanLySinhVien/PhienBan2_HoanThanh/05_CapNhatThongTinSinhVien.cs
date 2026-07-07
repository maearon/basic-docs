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

namespace ahihi1
{
    public partial class fcapnhat : Form
    {
        public fcapnhat()
        {
            InitializeComponent();
        }

        private void fcapnhat_Load(object sender, EventArgs e)
        {
            laymakhoa();
            laybangsinhvien();
        }
        public void laybangsinhvien()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt=kn.laybang("select * from tablesinhvien");
            GridViewDSSV.DataSource = dt;
        }
        public void laymakhoa()
        {
            KetNoi kn = new KetNoi();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = kn.kn;
            mysqlcommand.CommandText = "select khoa from tablesinhvien";
            kn.kn_csdl();
            SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            mysqladatareader.SelectCommand = mysqlcommand;
            DataSet mydataset = new DataSet();
            mysqladatareader.Fill(mydataset, "KQ");
            DataTable table_MK = new DataTable();
            table_MK = mydataset.Tables["KQ"];
            cbkhoa.DataSource = table_MK;
            cbkhoa.DisplayMember = table_MK.Columns["khoa"].ToString();
            //cbkhoa.ValueMember = table_MK.Columns["khoa"].ToString();


            kn.kn.Close();

        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            if(txthoten.Text =="")
            {
                errorProvider1.SetError(txthoten, "Bạn chưa nhập tên");
            }
            if(txtmasv.Text =="")
            {
                errorProvider1.SetError(txtmasv, "Bạn chưa nhập mã SV");
            }
            if(txthoten.Text != "" && txtmasv.Text != "")
            {
                KetNoi kn = new KetNoi();
              int kq= kn.xulydulieu("insert into tablesinhvien(masv,hoten,khoa,lop,gioitinh,ngaysinh,diachi,sdt) values ('"+txtmasv.Text+"',N'"+txthoten.Text+"','"+cbkhoa.Text+"','"+txtlop.Text+"',N'"+cbgioitinh.Text+"','"+dtngaysinh.Text+"',N'"+txtdiachi.Text+"','"+txtsdt.Text+"')");
              if(kq>0)
              {
                    MessageBox.Show("Thêm thành công");
                    laybangsinhvien();
              }
              else
              {
                  MessageBox.Show("Thất bại, vui lòng kiểm tra lại");
              }
            }
        }

        private void GridViewDSSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                row = GridViewDSSV.Rows[e.RowIndex];
                txtmasv.Text = row.Cells[0].Value.ToString();
                txthoten.Text = row.Cells[1].Value.ToString();
                cbkhoa.Text = row.Cells[2].Value.ToString();
                txtlop.Text = row.Cells[3].Value.ToString();
                cbgioitinh.Text = row.Cells[4].Value.ToString();
                dtngaysinh.Text = row.Cells[5].Value.ToString();
                txtdiachi.Text = row.Cells[6].Value.ToString();
                txtsdt.Text = row.Cells[7].Value.ToString();
            }
            catch
            {

            }
        }

        private void GridViewDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();

                row = GridViewDSSV.Rows[e.RowIndex];
                txtmasv.Text = row.Cells[0].Value.ToString();
                txthoten.Text = row.Cells[1].Value.ToString();
                cbkhoa.Text = row.Cells[2].Value.ToString();
                txtlop.Text = row.Cells[3].Value.ToString();
                cbgioitinh.Text = row.Cells[4].Value.ToString();
                dtngaysinh.Text = row.Cells[5].Value.ToString();
                txtdiachi.Text = row.Cells[6].Value.ToString();
                txtsdt.Text = row.Cells[7].Value.ToString();
            }
            catch
            {

            }
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            if (txthoten.Text == "")
            {
                errorProvider1.SetError(txthoten, "Bạn chưa nhập tên");
            }
            if (txtmasv.Text == "")
            {
                errorProvider1.SetError(txtmasv, "Bạn chưa nhập mã SV");
            }
            if (txthoten.Text != "" && txtmasv.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("delete from tablesinhvien where masv='"+txtmasv.Text+"'");
                if (kq > 0)
                {
                    MessageBox.Show("Xoá thành công");
                    laybangsinhvien();
                }
                else
                {
                    MessageBox.Show("Thất bại, vui lòng kiểm tra lại");
                }
            }
        }

        private void cmdsua_Click(object sender, EventArgs e)
        {
            if (txthoten.Text == "")
            {
                errorProvider1.SetError(txthoten, "Bạn chưa nhập tên");
            }
            if (txtmasv.Text == "")
            {
                errorProvider1.SetError(txtmasv, "Bạn chưa nhập mã SV");
            }
            if (txthoten.Text != "" && txtmasv.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("update tablesinhvien set hoten=N'"+txthoten.Text+"', khoa='"+cbkhoa.Text+"', lop='"+txtlop.Text+"', gioitinh=N'"+cbgioitinh.Text+"', ngaysinh='"+dtngaysinh.Text+"', diachi=N'"+txtdiachi.Text+"', sdt='"+txtsdt.Text+"' where masv='"+txtmasv.Text+"'");
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    laybangsinhvien();
                }
                else
                {
                    MessageBox.Show("Thất bại, vui lòng kiểm tra lại");
                }
            }
        }
    }
}
