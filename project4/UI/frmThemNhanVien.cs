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
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void BtnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text.Trim() == ""  )
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên! ");
                return;
            }
            if (txtTenDangNhapNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên Đăng Nhập! ");
                return;
            }
            if (txtMatKhauNhanVien.Text.Trim() == "" || txtReMatKhau.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu! ");
                return;
            }



            if (txtMatKhauNhanVien.Text != txtReMatKhau.Text)
                {
                    MessageBox.Show("Mật Khẩu không khớp.");
                return;
                }


            if (DaTonTai() == true)
            {
                MessageBox.Show("Tên người dùng đã được sử dụng");
                //this.Close();

            }
            else
            {

                if (ThemNguoiDung() == true)
                {

                    MessageBox.Show("Đăng ký thành công!");
                    this.Close();

                }
            }
                    
                

            


        }

        private bool ThemNguoiDung()
        {
            bool kq = false;

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ToanCuc.KetNoi; //"Server=.\\SQLEXPRESS; database=project1; Integrated Security = SSPI ";
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Insert into NguoiDung (TenDangNhap, MatKhau,TenNhanVien) values(@TenDangNhap,@MatKhau,@TenNhanVien) ";
            cmd.Parameters.Add(new SqlParameter("@TenDangNhap", txtTenDangNhapNhanVien.Text));
            cmd.Parameters.Add(new SqlParameter("@MatKhau", txtMatKhauNhanVien.Text));
            cmd.Parameters.Add(new SqlParameter("@TenNhanVien", txtTenNhanVien.Text));
            int d = cmd.ExecuteNonQuery();
            cnn.Close();

            if (d > 0)
                kq = true;

            return kq;
        }
        private bool DaTonTai()
        {
            bool kq = false;
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Server=.\\SQLEXPRESS; database=project1; Integrated Security = SSPI ";
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Select * From NguoiDung Where TenDangNhap=@TenDangNhap";
            cmd.Parameters.Add(new SqlParameter("@TenDangNhap", txtTenDangNhapNhanVien.Text));
            SqlDataAdapter dd = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dd.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
                kq = true;

            return kq;
        }
    }
}