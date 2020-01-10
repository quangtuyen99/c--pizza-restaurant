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
    public partial class frmDanhSachNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void FrmDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project1DataSet11.NguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungTableAdapter1.Fill(this.project1DataSet11.NguoiDung);
            // TODO: This line of code loads data into the 'project1DataSet3.NguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungTableAdapter.Fill(this.project1DataSet3.NguoiDung);

        }
    }
}