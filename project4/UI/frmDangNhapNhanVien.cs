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
    public partial class frmDangNhapNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhapNhanVien()
        {
            InitializeComponent();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {

            if (txtTenDangNhap.Text.Trim() == "") MessageBox.Show("Chưa nhập tên đăng nhập");

            else if(txtMatKhau.Text.Trim() == "") MessageBox.Show("Chưa nhập mật khẩu.");

            else
            {
                if (KiemTraDangNhap() == false)
                {
                    MessageBox.Show("Kiểm tra thông tin đăng nhập.");
                }
                else
                {
                    frmMain f = new frmMain();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
            }
        }
        private bool KiemTraDangNhap()
        {
            bool kq = false;

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ToanCuc.KetNoi; //"Server=.\\SQLEXPRESS; database=project1; Integrated Security = SSPI ";
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Select * From NguoiDung Where TenDangNhap=@TenDangNhap and MatKhau=@MatKhau";
            cmd.Parameters.Add(new SqlParameter("@TenDangNhap", txtTenDangNhap.Text));
            cmd.Parameters.Add(new SqlParameter("@MatKhau", txtMatKhau.Text));

            SqlDataAdapter dd = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dd.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                kq = true;


            return kq;
        }

        private void FrmDangNhapNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}