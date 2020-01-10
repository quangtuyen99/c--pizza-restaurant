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
    public partial class frmQuanLiNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanLiNhanVien()
        {
            InitializeComponent();
        }

        private void BtnThemNhanVien_Click(object sender, EventArgs e)
        {
            frmThemNhanVien f = new frmThemNhanVien();
            f.ShowDialog();
        }

        private void BtnDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            frmDanhSachNhanVien f =new frmDanhSachNhanVien();
            f.ShowDialog();
        }

        private void BtnDoiMatKhauAd_Click(object sender, EventArgs e)
        {
            frmDoiMatKhauAdmin f = new frmDoiMatKhauAdmin();
            f.ShowDialog();
        }

        private void BtnXoaNhanVien_Click(object sender, EventArgs e)
        {
            frmXoaNhanVien f =new  frmXoaNhanVien(); 
            f.ShowDialog();
        }
    }
}