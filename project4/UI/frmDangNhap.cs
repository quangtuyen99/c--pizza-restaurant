using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace project4.UI
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void BtnNhanVien_Click(object sender, EventArgs e)
        {
            frmDangNhapNhanVien f = new frmDangNhapNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            frmDangNhapAdmin f = new frmDangNhapAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
            
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project1DataSet8.MaGiamGia' table. You can move, or remove it, as needed.
            this.maGiamGiaTableAdapter2.Fill(this.project1DataSet8.MaGiamGia);
            // TODO: This line of code loads data into the 'project1DataSet7.MaGiamGia' table. You can move, or remove it, as needed.
            this.maGiamGiaTableAdapter1.Fill(this.project1DataSet7.MaGiamGia);
            // TODO: This line of code loads data into the 'project1DataSet6.MaGiamGia' table. You can move, or remove it, as needed.
            this.maGiamGiaTableAdapter.Fill(this.project1DataSet6.MaGiamGia);

        }

       
        

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}