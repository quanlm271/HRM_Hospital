namespace HRM_Hospital
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labletendangnhap = new DevExpress.XtraEditors.LabelControl();
            this.tb_tendangnhap = new DevExpress.XtraEditors.TextEdit();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.lablematkhau = new DevExpress.XtraEditors.LabelControl();
            this.labledangnhap = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_dangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tendangnhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labletendangnhap);
            this.groupBox2.Controls.Add(this.tb_tendangnhap);
            this.groupBox2.Controls.Add(this.tb_matkhau);
            this.groupBox2.Controls.Add(this.lablematkhau);
            this.groupBox2.Location = new System.Drawing.Point(40, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 183);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Đăng Nhập";
            // 
            // labletendangnhap
            // 
            this.labletendangnhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labletendangnhap.Location = new System.Drawing.Point(19, 34);
            this.labletendangnhap.Name = "labletendangnhap";
            this.labletendangnhap.Size = new System.Drawing.Size(130, 22);
            this.labletendangnhap.TabIndex = 8;
            this.labletendangnhap.Text = "Tên Đăng Nhập";
            // 
            // tb_tendangnhap
            // 
            this.tb_tendangnhap.EditValue = "ntqcuong";
            this.tb_tendangnhap.Location = new System.Drawing.Point(97, 69);
            this.tb_tendangnhap.Name = "tb_tendangnhap";
            this.tb_tendangnhap.Properties.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.tb_tendangnhap.Properties.Appearance.Options.UseBackColor = true;
            this.tb_tendangnhap.Size = new System.Drawing.Size(208, 20);
            this.tb_tendangnhap.TabIndex = 4;
            this.tb_tendangnhap.ToolTip = "ID bạn được cấp phát";
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.BackColor = System.Drawing.Color.GhostWhite;
            this.tb_matkhau.Location = new System.Drawing.Point(97, 142);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.PasswordChar = '*';
            this.tb_matkhau.Size = new System.Drawing.Size(208, 21);
            this.tb_matkhau.TabIndex = 9;
            this.tb_matkhau.Text = "123456";
            // 
            // lablematkhau
            // 
            this.lablematkhau.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablematkhau.Location = new System.Drawing.Point(19, 112);
            this.lablematkhau.Name = "lablematkhau";
            this.lablematkhau.Size = new System.Drawing.Size(83, 22);
            this.lablematkhau.TabIndex = 2;
            this.lablematkhau.Text = "Mật Khẩu";
            // 
            // labledangnhap
            // 
            this.labledangnhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labledangnhap.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labledangnhap.Location = new System.Drawing.Point(94, 21);
            this.labledangnhap.Name = "labledangnhap";
            this.labledangnhap.Size = new System.Drawing.Size(303, 26);
            this.labledangnhap.TabIndex = 14;
            this.labledangnhap.Text = "Phần Mềm Quản Lý Nhân Sự";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelControl1.Location = new System.Drawing.Point(59, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(366, 26);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Bệnh Viện Đa Khoa Tỉnh Sóc Trăng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::HRM_Hospital.Properties.Resources.doctor_2561;
            this.pictureBox1.Location = new System.Drawing.Point(501, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.Appearance.Options.UseFont = true;
            this.btn_dangnhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_dangnhap.Image")));
            this.btn_dangnhap.Location = new System.Drawing.Point(516, 231);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(178, 33);
            this.btn_dangnhap.TabIndex = 7;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.ToolTip = "Đăng Nhập";
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(516, 270);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(178, 33);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.ToolTip = "Thoát Chương Trình";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 335);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labledangnhap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.btn_thoat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ĐĂNG NHẬP";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tendangnhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_dangnhap;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labletendangnhap;
        private DevExpress.XtraEditors.TextEdit tb_tendangnhap;
        private System.Windows.Forms.TextBox tb_matkhau;
        private DevExpress.XtraEditors.LabelControl lablematkhau;
        private DevExpress.XtraEditors.LabelControl labledangnhap;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}