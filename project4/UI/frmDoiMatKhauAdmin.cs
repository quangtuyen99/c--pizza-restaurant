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
    public partial class frmDoiMatKhauAdmin : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhauAdmin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Nhp tên đăng nhập ");
                return;
            }

            if (txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                return;
            }
            if (txtMatKhauMoi.Text == txtMatKhauCu.Text)
            {
                MessageBox.Show("Mật khẩu mới trùng với mật khẩu cũ! ");
                return;
            }
            if (txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return;
            }
            


            if (DoiMatKhau() == true)
            {
                MessageBox.Show("Đổi mật khẩu thành công");

            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại");

            }
        }

        private bool DoiMatKhau()
        {


            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ToanCuc.KetNoi; //"Server=.\\SQLEXPRESS; database=project1; Integrated Security = SSPI ";
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Update Admin SET MatKhauAd =@MatKhauAd where TenDangNhapAd=@TenDangNhapAd ";
            cmd.Parameters.Add(new SqlParameter("@TenDangNhapAd", txtTenDangNhap.Text));
            cmd.Parameters.Add(new SqlParameter("@MatKhauAd", txtNhapLaiMatKhau.Text));

            int d = cmd.ExecuteNonQuery();
            cnn.Close();

            if (d > 0)
            {
                return true;
            }
            return false;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}