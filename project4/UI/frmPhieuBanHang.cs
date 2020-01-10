using System;
using System.IO;
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
using System.Reflection;
using word = Microsoft.Office.Interop.Word;

namespace project4.UI
{
    public partial class frmPhieuBanHang : DevExpress.XtraEditors.XtraForm
    {


        SqlConnection cnn = new SqlConnection(Properties.Settings.Default.project1ConnectionString);
        SqlCommand cmd;
        public frmPhieuBanHang()
        {
            InitializeComponent();
        }

        /*
        private void frmPhieuBanHang_Load(object sender, EventArgs e)
        {
            cmbIdSanPham.Items.Clear();
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select IdMatHang From ThongTinSanPham";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                cmbIdSanPham.Items.Add(dr["IdMatHang"].ToString());
            }
            cnn.Close();

        }*/

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * From ThongTinSanPham");
            cmd = new SqlCommand("Select * From ThongTinSanPham where IdMatHang = '" + cmbIdSanPham.Text + "'", cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string TenSanPham = (string)dr["TenMatHang"].ToString();
                txtTenSanPham.Text = TenSanPham;
                string DonVi = (string)dr["DonVi"].ToString();
                txtDonVi.Text = DonVi;
                string DonGia = (string)dr["DonGia"].ToString();
                txtDonGia.Text = DonGia;
               



            }
            cnn.Close();
           



        }
        /*
        private bool Xuat()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Server=.\\SQLEXPRESS; database=project1; Integrated Security = SSPI ";
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cmd = new SqlCommand("Select * From ThongTinSanPham where IdMatHang = '" + cmbIdSanPham.Text + "'", cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string TenSanPham = (string)dr["TenMatHang"].ToString();
                txtTenSanPham.Text = TenSanPham;


            }
            cnn.Close();
            return;
        }
        */

        private void FrmPhieuBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project1DataSet12.MaGiamGia' table. You can move, or remove it, as needed.
            this.maGiamGiaTableAdapter1.Fill(this.project1DataSet12.MaGiamGia);
            // TODO: This line of code loads data into the 'project1DataSet5.MaGiamGia' table. You can move, or remove it, as needed.
            this.maGiamGiaTableAdapter.Fill(this.project1DataSet5.MaGiamGia);
            // TODO: This line of code loads data into the 'project1DataSet4.ThongTinSanPham' table. You can move, or remove it, as needed.
            this.thongTinSanPhamTableAdapter.Fill(this.project1DataSet4.ThongTinSanPham);
            cmbIdSanPham.Items.Clear();
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select IdMatHang From ThongTinSanPham";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbIdSanPham.Items.Add(dr["IdMatHang"].ToString());
            }
            cnn.Close();

        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            if(txtIdPhieuBanHang.Text.Trim()=="")

            {
                MessageBox.Show("Chưa nhập mã phiếu bán hàng. ");
                return;
            }
            if(txtTenKhachHang.Text.Trim()=="")
            {
                MessageBox.Show("Chưa nhập tên khách hàng. ");
                return;
            }
            
            Decimal s = 0;
        
            Decimal a = Convert.ToDecimal(numSoLuong.Value);
            Decimal b = Convert.ToDecimal(txtDonGia.Text);
            Decimal c = Convert.ToDecimal(cmbMaGiamGia.SelectedValue.ToString());
            s = a * b *c ; 
            
            txtThanhToan.Text = Convert.ToString(s);

            if (ThemPhieuBanHang() == true)
            {
                MessageBox.Show("Thanh toán thành công :) ");
                CreateWordDocument(@"C:\Users\User\Desktop\fileXuat\temp.docx", @"C:\Users\User\Desktop\fileXuat\HoaDon.docx");
                this.Close();



            }
            


        }

        private bool ThemPhieuBanHang()
        {
            bool kq = false;

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ToanCuc.KetNoi; //"Server=.\\SQLEXPRESS; database=project1; Integrated Security= SSPI";
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "Insert into PhieuBanHang (IdPhieuBanHang,NgayBan,TenKhachHang,DiaChi,Sdt,Email,IdMatHang,TenMatHang,DonGia,DonVi,SoLuong,MaGiamGia,TongTien) values (@IdPhieuBanHang,@NgayBan,@TenKhachHang,@DiaChi,@Sdt,@Email,@IdMatHang,@TenMatHang,@DonGia,@DonVi,@SoLuong,@MaGiamGia,@TongTien)";
            cmd.Parameters.Add(new SqlParameter("@IdPhieuBanHang", txtIdPhieuBanHang.Text));
            cmd.Parameters.Add(new SqlParameter("@NgayBan", dtpNgayBan.Value.ToString()));
            cmd.Parameters.Add(new SqlParameter("@TenKhachHang", txtTenKhachHang.Text));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", txtDiaChi.Text));
            cmd.Parameters.Add(new SqlParameter("@Sdt", txtSdt.Text));
            cmd.Parameters.Add(new SqlParameter("@Email", txtEmail.Text));
            cmd.Parameters.Add(new SqlParameter("@IdMatHang", cmbIdSanPham.Text));
            cmd.Parameters.Add(new SqlParameter("@TenMatHang", txtTenSanPham.Text));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", Convert.ToInt32(numSoLuong.Value)));
            cmd.Parameters.Add(new SqlParameter("@DonVi", txtDonVi.Text));
            cmd.Parameters.Add(new SqlParameter("@DonGia", Convert.ToDecimal(txtDonGia.Text)));
            cmd.Parameters.Add(new SqlParameter("@MaGiamGia", cmbMaGiamGia.Text));
            cmd.Parameters.Add(new SqlParameter("@TongTien", txtThanhToan.Text));

            int d = cmd.ExecuteNonQuery();
            cnn.Close();
            if (d > 0)
                kq = true;
            return kq;
        }

       

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FindAndReplace(word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

        //tạo file word
        private void CreateWordDocument(object filename, object SaveAs)
        {
            word.Application wordApp = new word.Application();
            object missing = Missing.Value;
            word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                this.FindAndReplace(wordApp, "<TenKhachHang>", txtTenKhachHang.Text);
                this.FindAndReplace(wordApp, "<MaHoaDon>", txtIdPhieuBanHang.Text);
                this.FindAndReplace(wordApp, "<DiaChi>", txtDiaChi.Text);
                this.FindAndReplace(wordApp, "<date>", dtpNgayBan.Text);
                this.FindAndReplace(wordApp, "<TenSanPham>", txtTenSanPham.Text);
                this.FindAndReplace(wordApp, "<SoLuong>", numSoLuong.Value.ToString());
                this.FindAndReplace(wordApp, "<DonGia>", txtDonGia.Text);
                this.FindAndReplace(wordApp, "<MaGiam>", cmbMaGiamGia.SelectedValue.ToString());
                this.FindAndReplace(wordApp, "<ThanhTien>", txtThanhToan.Text);

            }
            else
            {
                MessageBox.Show("Không tìm thấy file!");
            }

            //Lưu
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("Xuất hóa đơn thành công!");
        }











        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void CmbMaGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DtpNgayBan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumSoLuong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TxtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void TxtSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtTenSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void TxtDonVi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void TxtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtIdPhieuBanHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}