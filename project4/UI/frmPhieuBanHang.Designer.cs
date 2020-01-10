namespace project4.UI
{
    partial class frmPhieuBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPhieuBanHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtThanhToan = new System.Windows.Forms.TextBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cmbIdSanPham = new System.Windows.Forms.ComboBox();
            this.thongTinSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project1DataSet4 = new project4.project1DataSet4();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.thongTinSanPhamTableAdapter = new project4.project1DataSet4TableAdapters.ThongTinSanPhamTableAdapter();
            this.cmbMaGiamGia = new System.Windows.Forms.ComboBox();
            this.maGiamGiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.project1DataSet12 = new project4.project1DataSet12();
            this.maGiamGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project1DataSet5 = new project4.project1DataSet5();
            this.label14 = new System.Windows.Forms.Label();
            this.maGiamGiaTableAdapter = new project4.project1DataSet5TableAdapters.MaGiamGiaTableAdapter();
            this.maGiamGiaTableAdapter1 = new project4.project1DataSet12TableAdapters.MaGiamGiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maGiamGiaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maGiamGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã số phiếu";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtIdPhieuBanHang
            // 
            this.txtIdPhieuBanHang.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPhieuBanHang.Location = new System.Drawing.Point(222, 45);
            this.txtIdPhieuBanHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPhieuBanHang.Name = "txtIdPhieuBanHang";
            this.txtIdPhieuBanHang.Size = new System.Drawing.Size(456, 32);
            this.txtIdPhieuBanHang.TabIndex = 2;
            this.txtIdPhieuBanHang.TextChanged += new System.EventHandler(this.TxtIdPhieuBanHang_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bán";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(222, 175);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(456, 32);
            this.txtTenKhachHang.TabIndex = 4;
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.TxtTenKhachHang_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa chỉ";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(222, 235);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(456, 32);
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.TxtDiaChi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 319);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số điện thoại";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(222, 310);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(456, 32);
            this.txtSdt.TabIndex = 6;
            this.txtSdt.TextChanged += new System.EventHandler(this.TxtSdt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 389);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(222, 380);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(456, 32);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 661);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Đơn vị";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 525);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên sản phẩm";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // txtDonVi
            // 
            this.txtDonVi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.Location = new System.Drawing.Point(220, 656);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.ReadOnly = true;
            this.txtDonVi.Size = new System.Drawing.Size(456, 32);
            this.txtDonVi.TabIndex = 11;
            this.txtDonVi.TextChanged += new System.EventHandler(this.TxtDonVi_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 721);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Đơn giá";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(220, 716);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(456, 26);
            this.txtDonGia.TabIndex = 12;
            this.txtDonGia.TextChanged += new System.EventHandler(this.TxtDonGia_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(50, 586);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Số lượng";
            this.label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhToan.Location = new System.Drawing.Point(1056, 710);
            this.txtThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.ReadOnly = true;
            this.txtThanhToan.Size = new System.Drawing.Size(338, 32);
            this.txtThanhToan.TabIndex = 15;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBan.Location = new System.Drawing.Point(222, 107);
            this.dtpNgayBan.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(456, 32);
            this.dtpNgayBan.TabIndex = 3;
            this.dtpNgayBan.ValueChanged += new System.EventHandler(this.DtpNgayBan_ValueChanged);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLuong.Location = new System.Drawing.Point(222, 583);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(458, 32);
            this.numSoLuong.TabIndex = 10;
            this.numSoLuong.ValueChanged += new System.EventHandler(this.NumSoLuong_ValueChanged);
            // 
            // cmbIdSanPham
            // 
            this.cmbIdSanPham.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdSanPham.FormattingEnabled = true;
            this.cmbIdSanPham.Location = new System.Drawing.Point(220, 460);
            this.cmbIdSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIdSanPham.Name = "cmbIdSanPham";
            this.cmbIdSanPham.Size = new System.Drawing.Size(454, 32);
            this.cmbIdSanPham.TabIndex = 8;
            this.cmbIdSanPham.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // thongTinSanPhamBindingSource
            // 
            this.thongTinSanPhamBindingSource.DataMember = "ThongTinSanPham";
            this.thongTinSanPhamBindingSource.DataSource = this.project1DataSet4;
            // 
            // project1DataSet4
            // 
            this.project1DataSet4.DataSetName = "project1DataSet4";
            this.project1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(844, 709);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(178, 34);
            this.btnThanhToan.TabIndex = 14;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.BtnThanhToan_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 465);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "Mã sản phẩm";
            this.label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.Location = new System.Drawing.Point(219, 520);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.ReadOnly = true;
            this.txtTenSanPham.Size = new System.Drawing.Size(456, 32);
            this.txtTenSanPham.TabIndex = 9;
            this.txtTenSanPham.TextChanged += new System.EventHandler(this.TxtTenSanPham_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(846, 808);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(178, 34);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // thongTinSanPhamTableAdapter
            // 
            this.thongTinSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // cmbMaGiamGia
            // 
            this.cmbMaGiamGia.DataSource = this.maGiamGiaBindingSource1;
            this.cmbMaGiamGia.DisplayMember = "MaGiamGia";
            this.cmbMaGiamGia.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaGiamGia.FormattingEnabled = true;
            this.cmbMaGiamGia.Location = new System.Drawing.Point(1056, 653);
            this.cmbMaGiamGia.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaGiamGia.Name = "cmbMaGiamGia";
            this.cmbMaGiamGia.Size = new System.Drawing.Size(338, 32);
            this.cmbMaGiamGia.TabIndex = 18;
            this.cmbMaGiamGia.ValueMember = "GiamGia";
            this.cmbMaGiamGia.SelectedIndexChanged += new System.EventHandler(this.CmbMaGiamGia_SelectedIndexChanged);
            // 
            // maGiamGiaBindingSource1
            // 
            this.maGiamGiaBindingSource1.DataMember = "MaGiamGia";
            this.maGiamGiaBindingSource1.DataSource = this.project1DataSet12;
            // 
            // project1DataSet12
            // 
            this.project1DataSet12.DataSetName = "project1DataSet12";
            this.project1DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maGiamGiaBindingSource
            // 
            this.maGiamGiaBindingSource.DataMember = "MaGiamGia";
            this.maGiamGiaBindingSource.DataSource = this.project1DataSet5;
            // 
            // project1DataSet5
            // 
            this.project1DataSet5.DataSetName = "project1DataSet5";
            this.project1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(901, 653);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 24);
            this.label14.TabIndex = 19;
            this.label14.Text = "Mã giảm giá";
            this.label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // maGiamGiaTableAdapter
            // 
            this.maGiamGiaTableAdapter.ClearBeforeFill = true;
            // 
            // maGiamGiaTableAdapter1
            // 
            this.maGiamGiaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmPhieuBanHang
            // 
            this.AcceptButton = this.btnThanhToan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1436, 807);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbMaGiamGia);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.cmbIdSanPham);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.dtpNgayBan);
            this.Controls.Add(this.txtThanhToan);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdPhieuBanHang);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuBanHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHIẾU BÁN HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPhieuBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maGiamGiaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maGiamGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdPhieuBanHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtThanhToan;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.ComboBox cmbIdSanPham;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Button btnThoat;
        private project1DataSet4 project1DataSet4;
        private System.Windows.Forms.BindingSource thongTinSanPhamBindingSource;
        private project1DataSet4TableAdapters.ThongTinSanPhamTableAdapter thongTinSanPhamTableAdapter;
        private System.Windows.Forms.ComboBox cmbMaGiamGia;
        private System.Windows.Forms.Label label14;
        private project1DataSet5 project1DataSet5;
        private System.Windows.Forms.BindingSource maGiamGiaBindingSource;
        private project1DataSet5TableAdapters.MaGiamGiaTableAdapter maGiamGiaTableAdapter;
        private project1DataSet12 project1DataSet12;
        private System.Windows.Forms.BindingSource maGiamGiaBindingSource1;
        private project1DataSet12TableAdapters.MaGiamGiaTableAdapter maGiamGiaTableAdapter1;
    }
}