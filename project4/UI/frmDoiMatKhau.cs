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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void BtnDoiMatKhau_Click(object sender, EventArgs e)

        {
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Nhập tên đăng nhập ");
                return;
            }

            if(txtMatKhauCu.Text=="" || txtMatKhauMoi.Text=="")
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                return;
            }
            if(txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return;
            }
            if (txtMatKhauMoi.Text == txtMatKhauCu.Text)
            {
                MessageBox.Show("Mật khẩu mới trùng với mật khẩu cũ! ");
                return;
            }


            if (DoiMatKhau() == true)
                {
                MessageBox.Show("Đổi mật khẩu thành công");

            }
            else {
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
            cmd.CommandText = "Update NguoiDung SET MatKhau=@MatKhau where TenDangNhap=@TenDangNhap ";
            cmd.Parameters.Add(new SqlParameter("@TenDangNhap", txtTenDangNhap.Text));
            cmd.Parameters.Add(new SqlParameter("@MatKhau", txtNhapLaiMatKhau.Text));

            int d = cmd.ExecuteNonQuery();
            cnn.Close();

            if (d > 0)
            {
                return true;
            }
            return false    ;
        }

        private void TxtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Nhap tên đăng nhập ");
                return;
            }

            if (txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                return;
            }
            if (txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
            }


            if (DoiMatKhau() == true)
            {
                MessageBox.Show("Đổi mật khẩu thành công");

            }

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}