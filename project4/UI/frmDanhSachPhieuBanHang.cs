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
    public partial class frmDanhSachPhieuBanHang : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachPhieuBanHang()
        {
            InitializeComponent();
        }

        private void FrmDanhSachPhieuBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project1DataSet20.PhieuBanHang' table. You can move, or remove it, as needed.
            this.phieuBanHangTableAdapter.Fill(this.project1DataSet20.PhieuBanHang);

        }
    }
}