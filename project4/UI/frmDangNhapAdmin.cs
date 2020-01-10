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
    public partial class frmDangNhapAdmin : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhapAdmin()
        {
            InitializeComponent();
        }

        private void TxtDangNhapAd_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhapAd.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên đăng nhập");
                return;
            }
            if (txtMatKhauAd.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu.");
                return;
            }
            
                if (KiemTraDangNhap() == false)
                {
                    MessageBox.Show("Kiểm tra thông tin đăng nhập.");
                }
                else
                {
                    frmMain f = new frmMain();
                
                    f.ShowDialog();
                this.Close();
                //this.Show();
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
            cmd.CommandText = "Select * From Admin Where TenDangNhapAd=@TenDangNhapAd and MatKhauAd=@MatKhauAd";
            cmd.Parameters.Add(new SqlParameter("@TenDangNhapAd", txtTenDangNhapAd.Text));
            cmd.Parameters.Add(new SqlParameter("@MatKhauAd", txtMatKhauAd.Text));

            SqlDataAdapter dd = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dd.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
                kq = true;


            return kq;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDangNhapAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}