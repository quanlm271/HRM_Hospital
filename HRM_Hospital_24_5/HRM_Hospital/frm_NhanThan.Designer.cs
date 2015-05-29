namespace HRM_Hospital
{
    partial class frm_NhanThan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Insertmoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.tb_Quanhe = new DevExpress.XtraEditors.TextEdit();
            this.dtime_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tb_Congtac = new DevExpress.XtraEditors.TextEdit();
            this.tb_Nghenghiep = new DevExpress.XtraEditors.TextEdit();
            this.tb_Hoten = new DevExpress.XtraEditors.TextEdit();
            this.lb_Congtac = new DevExpress.XtraEditors.LabelControl();
            this.lb_Nghenghiep = new DevExpress.XtraEditors.LabelControl();
            this.lb_Ngaysinh = new DevExpress.XtraEditors.LabelControl();
            this.lb_Quanhe = new DevExpress.XtraEditors.LabelControl();
            this.lb_tennhanvien = new DevExpress.XtraEditors.LabelControl();
            this.lb_Hoten = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Quanhe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Congtac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Nghenghiep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Hoten.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 241);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(906, 171);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Location = new System.Drawing.Point(316, 205);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(87, 28);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Cập Nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insertmoi
            // 
            this.btn_Insertmoi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insertmoi.Appearance.Options.UseFont = true;
            this.btn_Insertmoi.Location = new System.Drawing.Point(194, 205);
            this.btn_Insertmoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Insertmoi.Name = "btn_Insertmoi";
            this.btn_Insertmoi.Size = new System.Drawing.Size(87, 28);
            this.btn_Insertmoi.TabIndex = 5;
            this.btn_Insertmoi.Text = "Thêm Mới";
            this.btn_Insertmoi.Click += new System.EventHandler(this.btn_Insertmoi_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Location = new System.Drawing.Point(438, 205);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(87, 28);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // tb_Quanhe
            // 
            this.tb_Quanhe.Location = new System.Drawing.Point(194, 111);
            this.tb_Quanhe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Quanhe.Name = "tb_Quanhe";
            this.tb_Quanhe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quanhe.Properties.Appearance.Options.UseFont = true;
            this.tb_Quanhe.Size = new System.Drawing.Size(197, 22);
            this.tb_Quanhe.TabIndex = 2;
            // 
            // dtime_Ngaysinh
            // 
            this.dtime_Ngaysinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtime_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_Ngaysinh.Location = new System.Drawing.Point(586, 67);
            this.dtime_Ngaysinh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtime_Ngaysinh.Name = "dtime_Ngaysinh";
            this.dtime_Ngaysinh.Size = new System.Drawing.Size(196, 23);
            this.dtime_Ngaysinh.TabIndex = 1;
            this.dtime_Ngaysinh.Value = new System.DateTime(2015, 5, 28, 0, 0, 0, 0);
            // 
            // tb_Congtac
            // 
            this.tb_Congtac.Location = new System.Drawing.Point(194, 154);
            this.tb_Congtac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Congtac.Name = "tb_Congtac";
            this.tb_Congtac.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Congtac.Properties.Appearance.Options.UseFont = true;
            this.tb_Congtac.Size = new System.Drawing.Size(197, 22);
            this.tb_Congtac.TabIndex = 4;
            // 
            // tb_Nghenghiep
            // 
            this.tb_Nghenghiep.Location = new System.Drawing.Point(586, 110);
            this.tb_Nghenghiep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Nghenghiep.Name = "tb_Nghenghiep";
            this.tb_Nghenghiep.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nghenghiep.Properties.Appearance.Options.UseFont = true;
            this.tb_Nghenghiep.Size = new System.Drawing.Size(197, 22);
            this.tb_Nghenghiep.TabIndex = 3;
            // 
            // tb_Hoten
            // 
            this.tb_Hoten.Location = new System.Drawing.Point(194, 68);
            this.tb_Hoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Hoten.Name = "tb_Hoten";
            this.tb_Hoten.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Hoten.Properties.Appearance.Options.UseFont = true;
            this.tb_Hoten.Size = new System.Drawing.Size(197, 22);
            this.tb_Hoten.TabIndex = 0;
            // 
            // lb_Congtac
            // 
            this.lb_Congtac.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Congtac.Location = new System.Drawing.Point(54, 157);
            this.lb_Congtac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_Congtac.Name = "lb_Congtac";
            this.lb_Congtac.Size = new System.Drawing.Size(105, 16);
            this.lb_Congtac.TabIndex = 38;
            this.lb_Congtac.Text = "Đơn Vị Công Tác :";
            // 
            // lb_Nghenghiep
            // 
            this.lb_Nghenghiep.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nghenghiep.Location = new System.Drawing.Point(480, 113);
            this.lb_Nghenghiep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_Nghenghiep.Name = "lb_Nghenghiep";
            this.lb_Nghenghiep.Size = new System.Drawing.Size(81, 16);
            this.lb_Nghenghiep.TabIndex = 37;
            this.lb_Nghenghiep.Text = "Nghề Nghiệp :";
            // 
            // lb_Ngaysinh
            // 
            this.lb_Ngaysinh.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ngaysinh.Location = new System.Drawing.Point(495, 69);
            this.lb_Ngaysinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_Ngaysinh.Name = "lb_Ngaysinh";
            this.lb_Ngaysinh.Size = new System.Drawing.Size(66, 16);
            this.lb_Ngaysinh.TabIndex = 36;
            this.lb_Ngaysinh.Text = "Ngày Sinh :";
            // 
            // lb_Quanhe
            // 
            this.lb_Quanhe.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Quanhe.Location = new System.Drawing.Point(101, 113);
            this.lb_Quanhe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_Quanhe.Name = "lb_Quanhe";
            this.lb_Quanhe.Size = new System.Drawing.Size(58, 16);
            this.lb_Quanhe.TabIndex = 35;
            this.lb_Quanhe.Text = "Quan Hệ :";
            // 
            // lb_tennhanvien
            // 
            this.lb_tennhanvien.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tennhanvien.Location = new System.Drawing.Point(27, 15);
            this.lb_tennhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_tennhanvien.Name = "lb_tennhanvien";
            this.lb_tennhanvien.Size = new System.Drawing.Size(202, 16);
            this.lb_tennhanvien.TabIndex = 33;
            this.lb_tennhanvien.Text = "Khai báo nhân thân của nhân viên: ";
            // 
            // lb_Hoten
            // 
            this.lb_Hoten.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hoten.Location = new System.Drawing.Point(92, 69);
            this.lb_Hoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_Hoten.Name = "lb_Hoten";
            this.lb_Hoten.Size = new System.Drawing.Size(67, 16);
            this.lb_Hoten.TabIndex = 34;
            this.lb_Hoten.Text = "Họ và Tên :";
            // 
            // frm_NhanThan
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 412);
            this.Controls.Add(this.tb_Quanhe);
            this.Controls.Add(this.dtime_Ngaysinh);
            this.Controls.Add(this.tb_Congtac);
            this.Controls.Add(this.tb_Nghenghiep);
            this.Controls.Add(this.tb_Hoten);
            this.Controls.Add(this.lb_Congtac);
            this.Controls.Add(this.lb_Nghenghiep);
            this.Controls.Add(this.lb_Ngaysinh);
            this.Controls.Add(this.lb_Quanhe);
            this.Controls.Add(this.lb_tennhanvien);
            this.Controls.Add(this.lb_Hoten);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insertmoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frm_NhanThan";
            this.Text = "frm_NhanThan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Quanhe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Congtac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Nghenghiep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Hoten.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Insertmoi;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.TextEdit tb_Quanhe;
        private System.Windows.Forms.DateTimePicker dtime_Ngaysinh;
        private DevExpress.XtraEditors.TextEdit tb_Congtac;
        private DevExpress.XtraEditors.TextEdit tb_Nghenghiep;
        private DevExpress.XtraEditors.TextEdit tb_Hoten;
        private DevExpress.XtraEditors.LabelControl lb_Congtac;
        private DevExpress.XtraEditors.LabelControl lb_Nghenghiep;
        private DevExpress.XtraEditors.LabelControl lb_Ngaysinh;
        private DevExpress.XtraEditors.LabelControl lb_Quanhe;
        private DevExpress.XtraEditors.LabelControl lb_tennhanvien;
        private DevExpress.XtraEditors.LabelControl lb_Hoten;

    }
}