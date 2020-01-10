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
    public partial class frmXoaNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmXoaNhanVien()
        {
            InitializeComponent();
        }

        private void BtnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if(XoaNhanVien()==false)
            {
                MessageBox.Show("Sai thong tin");

            }
            else
            {
                MessageBox.Show("Xóa nhân viên thành công");
            }

        }

        private bool XoaNhanVien()
        {
            bool kq = false;
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ToanCuc.KetNoi; //"Server=.\\SQLEXPRESS; database=project1; Integrated Security = SSPI ";
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Delete From NguoiDung Where TenDangNhap=@TenDangNhap";
            cmd.Parameters.Add(new SqlParameter("@TenDangNhap", txtTenDangNhap.Text));
           
            
            
            int d = cmd.ExecuteNonQuery();
            cnn.Close();

            if (d>0)
                kq = true;

            return kq;
        }
    }
}