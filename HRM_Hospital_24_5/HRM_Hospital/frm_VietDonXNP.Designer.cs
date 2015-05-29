namespace HRM_Hospital
{
    partial class frm_VietDonXNP
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
            this.tb_lydo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date_denngay = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.date_tungay = new System.Windows.Forms.DateTimePicker();
            this.labelngaythangnam = new DevExpress.XtraEditors.LabelControl();
            this.tb_ngaylapdon = new DevExpress.XtraEditors.TextEdit();
            this.tb_songay = new DevExpress.XtraEditors.TextEdit();
            this.tb_ten = new DevExpress.XtraEditors.TextEdit();
            this.tb_MANV = new DevExpress.XtraEditors.TextEdit();
            this.btn_NopDon = new DevExpress.XtraEditors.SimpleButton();
            this.lb_SoNgayConLai = new DevExpress.XtraEditors.LabelControl();
            this.lb_SoNgayDaNghi = new DevExpress.XtraEditors.LabelControl();
            this.lb_SoNgayDuocNghi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lb_MaNhanVien = new DevExpress.XtraEditors.LabelControl();
            this.lb_lydo = new DevExpress.XtraEditors.LabelControl();
            this.lb_HoTen = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ngaylapdon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_songay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MANV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_lydo
            // 
            this.tb_lydo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lydo.Location = new System.Drawing.Point(407, 193);
            this.tb_lydo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_lydo.Multiline = true;
            this.tb_lydo.Name = "tb_lydo";
            this.tb_lydo.Size = new System.Drawing.Size(437, 70);
            this.tb_lydo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 100;
            this.label1.Text = "Ngày lập đơn:";
            // 
            // date_denngay
            // 
            this.date_denngay.AccessibleDescription = "";
            this.date_denngay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_denngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_denngay.Location = new System.Drawing.Point(145, 193);
            this.date_denngay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_denngay.Name = "date_denngay";
            this.date_denngay.Size = new System.Drawing.Size(202, 23);
            this.date_denngay.TabIndex = 1;
            this.date_denngay.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(65, 250);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 16);
            this.labelControl3.TabIndex = 97;
            this.labelControl3.Text = "Số ngày:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(56, 201);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 16);
            this.labelControl2.TabIndex = 96;
            this.labelControl2.Text = "Đến ngày:";
            // 
            // date_tungay
            // 
            this.date_tungay.AccessibleDescription = "";
            this.date_tungay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_tungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_tungay.Location = new System.Drawing.Point(145, 148);
            this.date_tungay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_tungay.Name = "date_tungay";
            this.date_tungay.Size = new System.Drawing.Size(202, 23);
            this.date_tungay.TabIndex = 0;
            this.date_tungay.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelngaythangnam
            // 
            this.labelngaythangnam.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelngaythangnam.Location = new System.Drawing.Point(61, 155);
            this.labelngaythangnam.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelngaythangnam.Name = "labelngaythangnam";
            this.labelngaythangnam.Size = new System.Drawing.Size(56, 16);
            this.labelngaythangnam.TabIndex = 95;
            this.labelngaythangnam.Text = "Từ ngày :";
            // 
            // tb_ngaylapdon
            // 
            this.tb_ngaylapdon.Enabled = false;
            this.tb_ngaylapdon.Location = new System.Drawing.Point(145, 297);
            this.tb_ngaylapdon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ngaylapdon.Name = "tb_ngaylapdon";
            this.tb_ngaylapdon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ngaylapdon.Properties.Appearance.Options.UseFont = true;
            this.tb_ngaylapdon.Size = new System.Drawing.Size(203, 22);
            this.tb_ngaylapdon.TabIndex = 7;
            // 
            // tb_songay
            // 
            this.tb_songay.Enabled = false;
            this.tb_songay.Location = new System.Drawing.Point(145, 246);
            this.tb_songay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_songay.Name = "tb_songay";
            this.tb_songay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_songay.Properties.Appearance.Options.UseFont = true;
            this.tb_songay.Size = new System.Drawing.Size(203, 22);
            this.tb_songay.TabIndex = 9;
            // 
            // tb_ten
            // 
            this.tb_ten.Enabled = false;
            this.tb_ten.Location = new System.Drawing.Point(145, 108);
            this.tb_ten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ten.Properties.Appearance.Options.UseFont = true;
            this.tb_ten.Size = new System.Drawing.Size(203, 22);
            this.tb_ten.TabIndex = 1;
            // 
            // tb_MANV
            // 
            this.tb_MANV.Enabled = false;
            this.tb_MANV.Location = new System.Drawing.Point(145, 68);
            this.tb_MANV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_MANV.Name = "tb_MANV";
            this.tb_MANV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MANV.Properties.Appearance.Options.UseFont = true;
            this.tb_MANV.Size = new System.Drawing.Size(203, 22);
            this.tb_MANV.TabIndex = 1;
            // 
            // btn_NopDon
            // 
            this.btn_NopDon.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NopDon.Appearance.Options.UseFont = true;
            this.btn_NopDon.Location = new System.Drawing.Point(145, 345);
            this.btn_NopDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_NopDon.Name = "btn_NopDon";
            this.btn_NopDon.Size = new System.Drawing.Size(112, 34);
            this.btn_NopDon.TabIndex = 3;
            this.btn_NopDon.Text = "Nộp Đơn";
            this.btn_NopDon.Click += new System.EventHandler(this.btn_NopDon_Click);
            // 
            // lb_SoNgayConLai
            // 
            this.lb_SoNgayConLai.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoNgayConLai.Location = new System.Drawing.Point(640, 112);
            this.lb_SoNgayConLai.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lb_SoNgayConLai.Name = "lb_SoNgayConLai";
            this.lb_SoNgayConLai.Size = new System.Drawing.Size(102, 16);
            this.lb_SoNgayConLai.TabIndex = 89;
            this.lb_SoNgayConLai.Text = "Số Ngày Còn Lại :";
            // 
            // lb_SoNgayDaNghi
            // 
            this.lb_SoNgayDaNghi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoNgayDaNghi.Location = new System.Drawing.Point(637, 86);
            this.lb_SoNgayDaNghi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lb_SoNgayDaNghi.Name = "lb_SoNgayDaNghi";
            this.lb_SoNgayDaNghi.Size = new System.Drawing.Size(105, 16);
            this.lb_SoNgayDaNghi.TabIndex = 88;
            this.lb_SoNgayDaNghi.Text = "Số Ngày Đã Nghỉ :";
            // 
            // lb_SoNgayDuocNghi
            // 
            this.lb_SoNgayDuocNghi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoNgayDuocNghi.Location = new System.Drawing.Point(623, 60);
            this.lb_SoNgayDuocNghi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lb_SoNgayDuocNghi.Name = "lb_SoNgayDuocNghi";
            this.lb_SoNgayDuocNghi.Size = new System.Drawing.Size(119, 16);
            this.lb_SoNgayDuocNghi.TabIndex = 87;
            this.lb_SoNgayDuocNghi.Text = "Số Ngày Được Nghỉ :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(352, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(205, 23);
            this.labelControl1.TabIndex = 86;
            this.labelControl1.Text = "ĐƠN XIN NGHỈ PHÉP";
            // 
            // lb_MaNhanVien
            // 
            this.lb_MaNhanVien.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaNhanVien.Location = new System.Drawing.Point(33, 71);
            this.lb_MaNhanVien.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lb_MaNhanVien.Name = "lb_MaNhanVien";
            this.lb_MaNhanVien.Size = new System.Drawing.Size(85, 16);
            this.lb_MaNhanVien.TabIndex = 85;
            this.lb_MaNhanVien.Text = "Mã nhân viên :";
            // 
            // lb_lydo
            // 
            this.lb_lydo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lydo.Location = new System.Drawing.Point(407, 169);
            this.lb_lydo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lb_lydo.Name = "lb_lydo";
            this.lb_lydo.Size = new System.Drawing.Size(39, 16);
            this.lb_lydo.TabIndex = 84;
            this.lb_lydo.Text = "Lý do :";
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HoTen.Location = new System.Drawing.Point(70, 112);
            this.lb_HoTen.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(46, 16);
            this.lb_HoTen.TabIndex = 83;
            this.lb_HoTen.Text = "Họ tên :";
            // 
            // frm_VietDonXNP
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 412);
            this.Controls.Add(this.tb_lydo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_denngay);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.date_tungay);
            this.Controls.Add(this.labelngaythangnam);
            this.Controls.Add(this.tb_ngaylapdon);
            this.Controls.Add(this.tb_songay);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.tb_MANV);
            this.Controls.Add(this.btn_NopDon);
            this.Controls.Add(this.lb_SoNgayConLai);
            this.Controls.Add(this.lb_SoNgayDaNghi);
            this.Controls.Add(this.lb_SoNgayDuocNghi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lb_MaNhanVien);
            this.Controls.Add(this.lb_lydo);
            this.Controls.Add(this.lb_HoTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_VietDonXNP";
            this.Text = "Đơn Xin Nghỉ Phép";
            this.Load += new System.EventHandler(this.frm_VietDonXNP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_ngaylapdon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_songay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MANV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_lydo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_denngay;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker date_tungay;
        private DevExpress.XtraEditors.LabelControl labelngaythangnam;
        private DevExpress.XtraEditors.TextEdit tb_ngaylapdon;
        private DevExpress.XtraEditors.TextEdit tb_songay;
        private DevExpress.XtraEditors.TextEdit tb_ten;
        private DevExpress.XtraEditors.TextEdit tb_MANV;
        private DevExpress.XtraEditors.SimpleButton btn_NopDon;
        private DevExpress.XtraEditors.LabelControl lb_SoNgayConLai;
        private DevExpress.XtraEditors.LabelControl lb_SoNgayDaNghi;
        private DevExpress.XtraEditors.LabelControl lb_SoNgayDuocNghi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lb_MaNhanVien;
        private DevExpress.XtraEditors.LabelControl lb_lydo;
        private DevExpress.XtraEditors.LabelControl lb_HoTen;




    }
}