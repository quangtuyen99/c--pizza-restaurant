using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace project4.UI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void NavBarControl2_Click(object sender, EventArgs e)
        {

        }

   

        private void BtnThemSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThemSanPham f = new frmThemSanPham();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BtnPhieuBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPhieuBanHang f = new frmPhieuBanHang();
            this.Hide();

            f.ShowDialog();
            this.Show();
        }

        private void BtnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BarButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPhieuBanHang f = new frmPhieuBanHang();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void BtnThemNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BtnDanhSachPhieuBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BtnDanhSachSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Danh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDanhSachPhieuBanHang f = new frmDanhSachPhieuBanHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BtnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BtnQuanLyNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAdmin f = new frmAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BarButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frmDanhSachSanPham f = new frmDanhSachSanPham();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BarButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void BarButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            About f = new About();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}