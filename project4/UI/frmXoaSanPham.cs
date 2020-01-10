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
    public partial class frmXoaSanPham : DevExpress.XtraEditors.XtraForm
    {
        public frmXoaSanPham()
        {
            InitializeComponent();
        }

        private void BtnXoaSanPham_Click(object sender, EventArgs e)
        {
            if(XoaSanPham()==false)
            {
                MessageBox.Show("Sai thông tin");
            }
            else
            {
                MessageBox.Show("Xóa thành công");
                
            }

        }

        private bool XoaSanPham()
        {
            bool kq = false;
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ToanCuc.KetNoi; //"Server=.\\SQLEXPRESS; database=project1; Integrated Security = SSPI ";
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Delete From ThongTinSanPham Where IdMatHang=@IdMatHang";
            cmd.Parameters.Add(new SqlParameter("@IdMatHang", txtIdSanPham.Text));



            int d = cmd.ExecuteNonQuery();
            cnn.Close();

            if (d > 0)
                kq = true;

            return kq;
        }
    }
}