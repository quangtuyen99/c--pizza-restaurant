namespace project4.UI
{
    partial class frmAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDangNhapAd = new System.Windows.Forms.TextBox();
            this.txtMatKhauAd = new System.Windows.Forms.TextBox();
            this.txtDangNhapAd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTenDangNhapAd
            // 
            this.txtTenDangNhapAd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhapAd.Location = new System.Drawing.Point(312, 116);
            this.txtTenDangNhapAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhapAd.Name = "txtTenDangNhapAd";
            this.txtTenDangNhapAd.Size = new System.Drawing.Size(342, 32);
            this.txtTenDangNhapAd.TabIndex = 1;
            // 
            // txtMatKhauAd
            // 
            this.txtMatKhauAd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauAd.Location = new System.Drawing.Point(312, 199);
            this.txtMatKhauAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhauAd.Name = "txtMatKhauAd";
            this.txtMatKhauAd.Size = new System.Drawing.Size(342, 32);
            this.txtMatKhauAd.TabIndex = 2;
            this.txtMatKhauAd.UseSystemPasswordChar = true;
            // 
            // txtDangNhapAd
            // 
            this.txtDangNhapAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDangNhapAd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDangNhapAd.Location = new System.Drawing.Point(487, 281);
            this.txtDangNhapAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDangNhapAd.Name = "txtDangNhapAd";
            this.txtDangNhapAd.Size = new System.Drawing.Size(167, 34);
            this.txtDangNhapAd.TabIndex = 3;
            this.txtDangNhapAd.Text = "Đăng nhập";
            this.txtDangNhapAd.UseVisualStyleBackColor = false;
            this.txtDangNhapAd.Click += new System.EventHandler(this.TxtDangNhapAd_Click);
            // 
            // frmAdmin
            // 
            this.AcceptButton = this.txtDangNhapAd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 429);
            this.Controls.Add(this.txtDangNhapAd);
            this.Controls.Add(this.txtMatKhauAd);
            this.Controls.Add(this.txtTenDangNhapAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDangNhapAd;
        private System.Windows.Forms.TextBox txtMatKhauAd;
        private System.Windows.Forms.Button txtDangNhapAd;
    }
}