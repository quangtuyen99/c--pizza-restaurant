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
using System.Data.SqlClient;

namespace project4.UI
{
    public partial class frmDanhSachSanPham : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachSanPham()
        {
            InitializeComponent();
        }

        private void FrmDanhSachSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project1DataSet10.ThongTinSanPham' table. You can move, or remove it, as needed.
            this.thongTinSanPhamTableAdapter1.Fill(this.project1DataSet10.ThongTinSanPham);
            // TODO: This line of code loads data into the 'project1DataSet1.ThongTinSanPham' table. You can move, or remove it, as needed.
            this.thongTinSanPhamTableAdapter.Fill(this.project1DataSet1.ThongTinSanPham);

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmThemSanPham f = new frmThemSanPham();
            f.ShowDialog();
        }

        private void BtnXoaSanPham_Click(object sender, EventArgs e)
        {
            frmXoaSanPham f = new frmXoaSanPham();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BtnSuaSanPham_Click(object sender, EventArgs e)
        {

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}