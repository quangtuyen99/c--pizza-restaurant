namespace project4.UI
{
    partial class frmDangNhap
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.project1DataSet6 = new project4.project1DataSet6();
            this.maGiamGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maGiamGiaTableAdapter = new project4.project1DataSet6TableAdapters.MaGiamGiaTableAdapter();
            this.project1DataSet7 = new project4.project1DataSet7();
            this.maGiamGiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.maGiamGiaTableAdapter1 = new project4.project1DataSet7TableAdapters.MaGiamGiaTableAdapter();
            this.project1DataSet8 = new project4.project1DataSet8();
            this.maGiamGiaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.maGiamGiaTableAdapter2 = new project4.project1DataSet8TableAdapters.MaGiamGiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maGiamGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maGiamGiaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maGiamGiaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdmin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(13, 13);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(346, 164);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "QUẢN LÝ";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNhanVien.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Location = new System.Drawing.Point(13, 185);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(346, 164);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "NHÂN VIÊN";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.BtnNhanVien_Click);
            // 
            // project1DataSet6
            // 
            this.project1DataSet6.DataSetName = "project1DataSet6";
            this.project1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maGiamGiaBindingSource
            // 
            this.maGiamGiaBindingSource.DataMember = "MaGiamGia";
            this.maGiamGiaBindingSource.DataSource = this.project1DataSet6;
            // 
            // maGiamGiaTableAdapter
            // 
            this.maGiamGiaTableAdapter.ClearBeforeFill = true;
            // 
            // project1DataSet7
            // 
            this.project1DataSet7.DataSetName = "project1DataSet7";
            this.project1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maGiamGiaBindingSource1
            // 
            this.maGiamGiaBindingSource1.DataMember = "MaGiamGia";
            this.maGiamGiaBindingSource1.DataSource = this.project1DataSet7;
            // 
            // maGiamGiaTableAdapter1
            // 
            this.maGiamGiaTableAdapter1.ClearBeforeFill = true;
            // 
            // project1DataSet8
            // 
            this.project1DataSet8.DataSetName = "project1DataSet8";
            this.project1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maGiamGiaBindingSource2
            // 
            this.maGiamGiaBindingSource2.DataMember = "MaGiamGia";
            this.maGiamGiaBindingSource2.DataSource = this.project1DataSet8;
            // 
            // maGiamGiaTableAdapter2
            // 
            this.maGiamGiaTableAdapter2.ClearBeforeFill = true;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 378);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnAdmin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maGiamGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maGiamGiaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project1DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maGiamGiaBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnNhanVien;
        private project1DataSet6 project1DataSet6;
        private System.Windows.Forms.BindingSource maGiamGiaBindingSource;
        private project1DataSet6TableAdapters.MaGiamGiaTableAdapter maGiamGiaTableAdapter;
        private project1DataSet7 project1DataSet7;
        private System.Windows.Forms.BindingSource maGiamGiaBindingSource1;
        private project1DataSet7TableAdapters.MaGiamGiaTableAdapter maGiamGiaTableAdapter1;
        private project1DataSet8 project1DataSet8;
        private System.Windows.Forms.BindingSource maGiamGiaBindingSource2;
        private project1DataSet8TableAdapters.MaGiamGiaTableAdapter maGiamGiaTableAdapter2;
    }
}