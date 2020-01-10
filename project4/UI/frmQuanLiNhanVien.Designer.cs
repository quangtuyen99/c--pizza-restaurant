namespace project4.UI
{
    partial class frmQuanLiNhanVien
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
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.btnXoaNhanVien = new System.Windows.Forms.Button();
            this.btnDoiMatKhauAd = new System.Windows.Forms.Button();
            this.btnDanhSachNhanVien = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThemNhanVien.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhanVien.Location = new System.Drawing.Point(4, 4);
            this.btnThemNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(262, 118);
            this.btnThemNhanVien.TabIndex = 0;
            this.btnThemNhanVien.Text = "Thêm nhân viên";
            this.btnThemNhanVien.UseVisualStyleBackColor = false;
            this.btnThemNhanVien.Click += new System.EventHandler(this.BtnThemNhanVien_Click);
            // 
            // btnXoaNhanVien
            // 
            this.btnXoaNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoaNhanVien.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNhanVien.Location = new System.Drawing.Point(274, 130);
            this.btnXoaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaNhanVien.Name = "btnXoaNhanVien";
            this.btnXoaNhanVien.Size = new System.Drawing.Size(263, 119);
            this.btnXoaNhanVien.TabIndex = 0;
            this.btnXoaNhanVien.Text = "Xóa nhân viên";
            this.btnXoaNhanVien.UseVisualStyleBackColor = false;
            this.btnXoaNhanVien.Click += new System.EventHandler(this.BtnXoaNhanVien_Click);
            // 
            // btnDoiMatKhauAd
            // 
            this.btnDoiMatKhauAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDoiMatKhauAd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhauAd.Location = new System.Drawing.Point(274, 4);
            this.btnDoiMatKhauAd.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoiMatKhauAd.Name = "btnDoiMatKhauAd";
            this.btnDoiMatKhauAd.Size = new System.Drawing.Size(263, 118);
            this.btnDoiMatKhauAd.TabIndex = 0;
            this.btnDoiMatKhauAd.Text = "Đổi mật khẩu quản lý";
            this.btnDoiMatKhauAd.UseVisualStyleBackColor = false;
            this.btnDoiMatKhauAd.Click += new System.EventHandler(this.BtnDoiMatKhauAd_Click);
            // 
            // btnDanhSachNhanVien
            // 
            this.btnDanhSachNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDanhSachNhanVien.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachNhanVien.Location = new System.Drawing.Point(4, 130);
            this.btnDanhSachNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnDanhSachNhanVien.Name = "btnDanhSachNhanVien";
            this.btnDanhSachNhanVien.Size = new System.Drawing.Size(262, 119);
            this.btnDanhSachNhanVien.TabIndex = 0;
            this.btnDanhSachNhanVien.Text = "Danh sách nhân viên";
            this.btnDanhSachNhanVien.UseVisualStyleBackColor = false;
            this.btnDanhSachNhanVien.Click += new System.EventHandler(this.BtnDanhSachNhanVien_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnThemNhanVien, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDanhSachNhanVien, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDoiMatKhauAd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnXoaNhanVien, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(61, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(541, 253);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // frmQuanLiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLiNhanVien";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Button btnXoaNhanVien;
        private System.Windows.Forms.Button btnDoiMatKhauAd;
        private System.Windows.Forms.Button btnDanhSachNhanVien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}