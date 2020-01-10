namespace project4.UI
{
    partial class frmDangNhapAdmin
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
            this.txtDangNhapAd = new System.Windows.Forms.Button();
            this.txtMatKhauAd = new System.Windows.Forms.TextBox();
            this.txtTenDangNhapAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDangNhapAd
            // 
            this.txtDangNhapAd.AccessibleDescription = "btnDangNhap";
            this.txtDangNhapAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDangNhapAd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDangNhapAd.Location = new System.Drawing.Point(531, 239);
            this.txtDangNhapAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDangNhapAd.Name = "txtDangNhapAd";
            this.txtDangNhapAd.Size = new System.Drawing.Size(154, 34);
            this.txtDangNhapAd.TabIndex = 3;
            this.txtDangNhapAd.Text = "Đăng nhập";
            this.txtDangNhapAd.UseVisualStyleBackColor = false;
            this.txtDangNhapAd.Click += new System.EventHandler(this.TxtDangNhapAd_Click);
            // 
            // txtMatKhauAd
            // 
            this.txtMatKhauAd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauAd.Location = new System.Drawing.Point(278, 157);
            this.txtMatKhauAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhauAd.Multiline = true;
            this.txtMatKhauAd.Name = "txtMatKhauAd";
            this.txtMatKhauAd.Size = new System.Drawing.Size(407, 32);
            this.txtMatKhauAd.TabIndex = 2;
            this.txtMatKhauAd.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhapAd
            // 
            this.txtTenDangNhapAd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhapAd.Location = new System.Drawing.Point(278, 76);
            this.txtTenDangNhapAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhapAd.Multiline = true;
            this.txtTenDangNhapAd.Name = "txtTenDangNhapAd";
            this.txtTenDangNhapAd.Size = new System.Drawing.Size(407, 33);
            this.txtTenDangNhapAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(278, 239);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(153, 34);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // frmDangNhapAdmin
            // 
            this.AcceptButton = this.txtDangNhapAd;
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(813, 357);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtDangNhapAd);
            this.Controls.Add(this.txtMatKhauAd);
            this.Controls.Add(this.txtTenDangNhapAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhapAdmin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.FrmDangNhapAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtDangNhapAd;
        private System.Windows.Forms.TextBox txtMatKhauAd;
        private System.Windows.Forms.TextBox txtTenDangNhapAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
    }
}