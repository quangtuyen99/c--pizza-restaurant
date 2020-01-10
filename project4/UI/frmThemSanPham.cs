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
using System.IO;


namespace project4.UI
{
    public partial class frmThemSanPham : DevExpress.XtraEditors.XtraForm
    {
        public frmThemSanPham()
        {
            InitializeComponent();
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtIdSanPham.Text.Trim() == "" || txtTenSanPham.Text.Trim() == "" || txtDonGia.Text.Trim() == "" || ptbAnhSanPham.Image == null)
            {
                MessageBox.Show("Chưa nhập đủ thông tin sản phẩm");
                return;
            }

            
            

                if (ThemSanPham() == true)
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                    this.Close();
                }
            
        }
        private void BtnChontep_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = openFileDialog1.Filter = "JPG files (*.jpg ) | *.jpg|All files(*.*)| *.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ptbAnhSanPham.ImageLocation = openFileDialog1.FileName;
                txtAnhSanPham.Text = openFileDialog1.FileName;
            }
        }

        private bool ThemSanPham()
        {
            bool kq = false;

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ToanCuc.KetNoi; //"Server=.\\SQLEXPRESS; database=project1; Integrated Security= SSPI";
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Insert into ThongTinSanPham (IdMatHang,TenMatHang,GhiChu,DonVi,DonGia,HinhAnh) values (@IdMatHang,@TenMatHang,@GhiChu,@DonVi,@DonGia,@HinhAnh)";
            cmd.Parameters.Add(new SqlParameter("@IdMatHang", txtIdSanPham.Text));
            cmd.Parameters.Add(new SqlParameter("@TenMatHang", txtTenSanPham.Text));
            cmd.Parameters.Add(new SqlParameter("@GhiChu", txtGhiChu.Text));
            cmd.Parameters.Add(new SqlParameter("@DonVi", txtDonVi.Text));
            cmd.Parameters.Add(new SqlParameter("@DonGia", txtDonGia.Text));
            cmd.Parameters.Add(new SqlParameter("@HinhAnh", converHinhAnhToByte()));
            int d = cmd.ExecuteNonQuery();
            cnn.Close();
            if (d > 0)
                kq = true;
            return kq;
        }

        private byte[] converHinhAnhToByte()
        {
           // byte f = 0;
            FileStream fs;
            fs = new FileStream(txtAnhSanPham.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();



            return picbyte;
        }

        private void FrmThemSanPham_Load(object sender, EventArgs e)
        {

        }

        private void TxtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTenSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtIdSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TxtAnhSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDonVi_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}