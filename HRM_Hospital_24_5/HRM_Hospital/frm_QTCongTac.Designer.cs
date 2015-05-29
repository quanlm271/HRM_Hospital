namespace HRM_Hospital
{
    partial class frm_QTCongTac
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
            this.tb_phong = new System.Windows.Forms.ComboBox();
            this.dtime_Denngay = new System.Windows.Forms.DateTimePicker();
            this.dtime_Tungay = new System.Windows.Forms.DateTimePicker();
            this.tb_Chucvu = new DevExpress.XtraEditors.TextEdit();
            this.tb_Chucdanh = new DevExpress.XtraEditors.TextEdit();
            this.tb_MaQTCT = new DevExpress.XtraEditors.TextEdit();
            this.lb_Congtac = new DevExpress.XtraEditors.LabelControl();
            this.cl_Denngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Tungay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Chucdanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Quatrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lb_Nghenghiep = new DevExpress.XtraEditors.LabelControl();
            this.lb_Ngaysinh = new DevExpress.XtraEditors.LabelControl();
            this.lb_Quanhe = new DevExpress.XtraEditors.LabelControl();
            this.lb_MaTN = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Insertmoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Chucvu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Chucdanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaQTCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_phong
            // 
            this.tb_phong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phong.FormattingEnabled = true;
            this.tb_phong.Items.AddRange(new object[] {
            "(Nope)"});
            this.tb_phong.Location = new System.Drawing.Point(569, 28);
            this.tb_phong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_phong.MaxDropDownItems = 12;
            this.tb_phong.Name = "tb_phong";
            this.tb_phong.Size = new System.Drawing.Size(196, 24);
            this.tb_phong.TabIndex = 1;
            // 
            // dtime_Denngay
            // 
            this.dtime_Denngay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtime_Denngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_Denngay.Location = new System.Drawing.Point(569, 115);
            this.dtime_Denngay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtime_Denngay.Name = "dtime_Denngay";
            this.dtime_Denngay.Size = new System.Drawing.Size(196, 23);
            this.dtime_Denngay.TabIndex = 5;
            this.dtime_Denngay.Value = new System.DateTime(2015, 5, 20, 0, 0, 0, 0);
            // 
            // dtime_Tungay
            // 
            this.dtime_Tungay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtime_Tungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_Tungay.Location = new System.Drawing.Point(569, 68);
            this.dtime_Tungay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtime_Tungay.Name = "dtime_Tungay";
            this.dtime_Tungay.Size = new System.Drawing.Size(196, 23);
            this.dtime_Tungay.TabIndex = 3;
            this.dtime_Tungay.Value = new System.DateTime(2015, 5, 20, 0, 0, 0, 0);
            // 
            // tb_Chucvu
            // 
            this.tb_Chucvu.Location = new System.Drawing.Point(164, 116);
            this.tb_Chucvu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Chucvu.Name = "tb_Chucvu";
            this.tb_Chucvu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Chucvu.Properties.Appearance.Options.UseFont = true;
            this.tb_Chucvu.Size = new System.Drawing.Size(197, 22);
            this.tb_Chucvu.TabIndex = 4;
            // 
            // tb_Chucdanh
            // 
            this.tb_Chucdanh.Location = new System.Drawing.Point(164, 71);
            this.tb_Chucdanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Chucdanh.Name = "tb_Chucdanh";
            this.tb_Chucdanh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Chucdanh.Properties.Appearance.Options.UseFont = true;
            this.tb_Chucdanh.Size = new System.Drawing.Size(197, 22);
            this.tb_Chucdanh.TabIndex = 2;
            // 
            // tb_MaQTCT
            // 
            this.tb_MaQTCT.Location = new System.Drawing.Point(164, 28);
            this.tb_MaQTCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_MaQTCT.Name = "tb_MaQTCT";
            this.tb_MaQTCT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaQTCT.Properties.Appearance.Options.UseFont = true;
            this.tb_MaQTCT.Size = new System.Drawing.Size(197, 22);
            this.tb_MaQTCT.TabIndex = 0;
            // 
            // lb_Congtac
            // 
            this.lb_Congtac.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Congtac.Location = new System.Drawing.Point(89, 119);
            this.lb_Congtac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_Congtac.Name = "lb_Congtac";
            this.lb_Congtac.Size = new System.Drawing.Size(57, 16);
            this.lb_Congtac.TabIndex = 42;
            this.lb_Congtac.Text = "Chức Vụ :";
            // 
            // cl_Denngay
            // 
            this.cl_Denngay.DataPropertyName = "DENTHANG_NAM";
            this.cl_Denngay.HeaderText = "Đến ngày";
            this.cl_Denngay.Name = "cl_Denngay";
            this.cl_Denngay.ReadOnly = true;
            // 
            // cl_Tungay
            // 
            this.cl_Tungay.DataPropertyName = "TUTHANG_NAM";
            this.cl_Tungay.HeaderText = "Từ Ngày";
            this.cl_Tungay.Name = "cl_Tungay";
            this.cl_Tungay.ReadOnly = true;
            // 
            // cl_Maphong
            // 
            this.cl_Maphong.DataPropertyName = "MAPHG";
            this.cl_Maphong.HeaderText = "Mã Phòng";
            this.cl_Maphong.Name = "cl_Maphong";
            this.cl_Maphong.ReadOnly = true;
            // 
            // cl_Chucvu
            // 
            this.cl_Chucvu.DataPropertyName = "CHUCVU";
            this.cl_Chucvu.HeaderText = "Chức Vụ";
            this.cl_Chucvu.Name = "cl_Chucvu";
            this.cl_Chucvu.ReadOnly = true;
            // 
            // cl_Chucdanh
            // 
            this.cl_Chucdanh.DataPropertyName = "CHUCDANH";
            this.cl_Chucdanh.HeaderText = "Chức Danh";
            this.cl_Chucdanh.Name = "cl_Chucdanh";
            this.cl_Chucdanh.ReadOnly = true;
            // 
            // cl_Quatrinh
            // 
            this.cl_Quatrinh.DataPropertyName = "MAQTCT";
            this.cl_Quatrinh.HeaderText = "Mã QTCT";
            this.cl_Quatrinh.Name = "cl_Quatrinh";
            this.cl_Quatrinh.ReadOnly = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(483, 119);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "Đến Ngày :";
            // 
            // lb_Nghenghiep
            // 
            this.lb_Nghenghiep.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nghenghiep.Location = new System.Drawing.Point(75, 73);
            this.lb_Nghenghiep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_Nghenghiep.Name = "lb_Nghenghiep";
            this.lb_Nghenghiep.Size = new System.Drawing.Size(71, 16);
            this.lb_Nghenghiep.TabIndex = 41;
            this.lb_Nghenghiep.Text = "Chức Danh :";
            // 
            // lb_Ngaysinh
            // 
            this.lb_Ngaysinh.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ngaysinh.Location = new System.Drawing.Point(490, 73);
            this.lb_Ngaysinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_Ngaysinh.Name = "lb_Ngaysinh";
            this.lb_Ngaysinh.Size = new System.Drawing.Size(57, 16);
            this.lb_Ngaysinh.TabIndex = 40;
            this.lb_Ngaysinh.Text = "Từ Ngày :";
            // 
            // lb_Quanhe
            // 
            this.lb_Quanhe.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Quanhe.Location = new System.Drawing.Point(503, 31);
            this.lb_Quanhe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_Quanhe.Name = "lb_Quanhe";
            this.lb_Quanhe.Size = new System.Drawing.Size(44, 16);
            this.lb_Quanhe.TabIndex = 39;
            this.lb_Quanhe.Text = "Phòng :";
            // 
            // lb_MaTN
            // 
            this.lb_MaTN.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaTN.Location = new System.Drawing.Point(83, 31);
            this.lb_MaTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_MaTN.Name = "lb_MaTN";
            this.lb_MaTN.Size = new System.Drawing.Size(63, 16);
            this.lb_MaTN.TabIndex = 38;
            this.lb_MaTN.Text = "Mã QTCT :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 219);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(906, 193);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Location = new System.Drawing.Point(290, 171);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(87, 28);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Cập Nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insertmoi
            // 
            this.btn_Insertmoi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insertmoi.Appearance.Options.UseFont = true;
            this.btn_Insertmoi.Location = new System.Drawing.Point(164, 171);
            this.btn_Insertmoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Insertmoi.Name = "btn_Insertmoi";
            this.btn_Insertmoi.Size = new System.Drawing.Size(87, 28);
            this.btn_Insertmoi.TabIndex = 6;
            this.btn_Insertmoi.Text = "Thêm Mới";
            this.btn_Insertmoi.Click += new System.EventHandler(this.btn_Insertmoi_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Location = new System.Drawing.Point(411, 171);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(87, 28);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // frm_QTCongTac
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 412);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insertmoi);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.tb_phong);
            this.Controls.Add(this.dtime_Denngay);
            this.Controls.Add(this.tb_MaQTCT);
            this.Controls.Add(this.dtime_Tungay);
            this.Controls.Add(this.lb_MaTN);
            this.Controls.Add(this.tb_Chucvu);
            this.Controls.Add(this.lb_Quanhe);
            this.Controls.Add(this.tb_Chucdanh);
            this.Controls.Add(this.lb_Ngaysinh);
            this.Controls.Add(this.lb_Nghenghiep);
            this.Controls.Add(this.lb_Congtac);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_QTCongTac";
            this.Text = "frm_QuaTrinhCongTaccs";
            ((System.ComponentModel.ISupportInitialize)(this.tb_Chucvu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Chucdanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaQTCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tb_phong;
        private System.Windows.Forms.DateTimePicker dtime_Denngay;
        private System.Windows.Forms.DateTimePicker dtime_Tungay;
        private DevExpress.XtraEditors.TextEdit tb_Chucvu;
        private DevExpress.XtraEditors.TextEdit tb_Chucdanh;
        private DevExpress.XtraEditors.TextEdit tb_MaQTCT;
        private DevExpress.XtraEditors.LabelControl lb_Congtac;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Denngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Tungay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Chucdanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Quatrinh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lb_Nghenghiep;
        private DevExpress.XtraEditors.LabelControl lb_Ngaysinh;
        private DevExpress.XtraEditors.LabelControl lb_Quanhe;
        private DevExpress.XtraEditors.LabelControl lb_MaTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Insertmoi;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;


    }
}