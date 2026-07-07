using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahihi1
{
    public partial class ftimkiem : Form
    {
        public ftimkiem()
        {
            InitializeComponent();
        }

        private void ftimkiem_Load(object sender, EventArgs e)
        {
            laybansinhvien();

        }
        public void laybansinhvien()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("select * from tablesinhvien");
            dataGridViewketquatimkiem.DataSource = dt;
        }
        public void LoadGridByKeyWord()
        {
            KetNoi kn = new KetNoi();
            dataGridViewketquatimkiem.DataSource = kn.laybang("select * from tablesinhvien where masv like '%"+txtmasv.Text+"%'");            
        }      
        private void cmdtimkiem_Click(object sender, EventArgs e)
        {
            LoadGridByKeyWord();
        }

        private void cmdtatca_Click(object sender, EventArgs e)
        {
            laybansinhvien();
        }

        private void txtmasv_TextChanged(object sender, EventArgs e)
        {
            LoadGridByKeyWord();
        }
       
        
    }
}
