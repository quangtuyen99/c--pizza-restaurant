namespace project4.UI
{
    partial class frmXoaSanPham
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
            this.txtIdSanPham = new System.Windows.Forms.TextBox();
            this.btnXoaSanPham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập mã sản phẩm";
            // 
            // txtIdSanPham
            // 
            this.txtIdSanPham.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSanPham.Location = new System.Drawing.Point(280, 87);
            this.txtIdSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdSanPham.Name = "txtIdSanPham";
            this.txtIdSanPham.Size = new System.Drawing.Size(499, 32);
            this.txtIdSanPham.TabIndex = 4;
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXoaSanPham.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSanPham.Location = new System.Drawing.Point(621, 159);
            this.btnXoaSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(160, 34);
            this.btnXoaSanPham.TabIndex = 3;
            this.btnXoaSanPham.Text = "Xóa sản phẩm";
            this.btnXoaSanPham.UseVisualStyleBackColor = false;
            this.btnXoaSanPham.Click += new System.EventHandler(this.BtnXoaSanPham_Click);
            // 
            // frmXoaSanPham
            // 
            this.AcceptButton = this.btnXoaSanPham;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdSanPham);
            this.Controls.Add(this.btnXoaSanPham);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXoaSanPham";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa sản phẩm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdSanPham;
        private System.Windows.Forms.Button btnXoaSanPham;
    }
}