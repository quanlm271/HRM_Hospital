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
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.dtime_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tb_Congtac = new DevExpress.XtraEditors.TextEdit();
            this.tb_Nghenghiep = new DevExpress.XtraEditors.TextEdit();
            this.tb_Hoten = new DevExpress.XtraEditors.TextEdit();
            this.lb_Congtac = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Capnhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Themmoi = new DevExpress.XtraEditors.SimpleButton();
            this.lb_Nghenghiep = new DevExpress.XtraEditors.LabelControl();
            this.lb_Ngaysinh = new DevExpress.XtraEditors.LabelControl();
            this.lb_Quanhe = new DevExpress.XtraEditors.LabelControl();
            this.lb_Hoten = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tb_Quanhe = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_tennhanvien = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Congtac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Nghenghiep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Hoten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Quanhe.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(213, 146);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // dtime_Ngaysinh
            // 
            this.dtime_Ngaysinh.Location = new System.Drawing.Point(504, 85);
            this.dtime_Ngaysinh.Name = "dtime_Ngaysinh";
            this.dtime_Ngaysinh.Size = new System.Drawing.Size(169, 21);
            this.dtime_Ngaysinh.TabIndex = 4;
            this.dtime_Ngaysinh.Value = new System.DateTime(2015, 5, 20, 0, 0, 0, 0);
            // 
            // tb_Congtac
            // 
            this.tb_Congtac.Location = new System.Drawing.Point(504, 50);
            this.tb_Congtac.Name = "tb_Congtac";
            this.tb_Congtac.Size = new System.Drawing.Size(169, 20);
            this.tb_Congtac.TabIndex = 3;
            this.tb_Congtac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Congtac_KeyPress);
            // 
            // tb_Nghenghiep
            // 
            this.tb_Nghenghiep.Location = new System.Drawing.Point(504, 15);
            this.tb_Nghenghiep.Name = "tb_Nghenghiep";
            this.tb_Nghenghiep.Size = new System.Drawing.Size(169, 20);
            this.tb_Nghenghiep.TabIndex = 1;
            this.tb_Nghenghiep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Nghenghiep_KeyPress);
            // 
            // tb_Hoten
            // 
            this.tb_Hoten.Location = new System.Drawing.Point(159, 50);
            this.tb_Hoten.Name = "tb_Hoten";
            this.tb_Hoten.Size = new System.Drawing.Size(169, 20);
            this.tb_Hoten.TabIndex = 0;
            this.tb_Hoten.Click += new System.EventHandler(this.tb_Hoten_Click);
            this.tb_Hoten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Hoten_KeyPress);
            // 
            // lb_Congtac
            // 
            this.lb_Congtac.Location = new System.Drawing.Point(393, 53);
            this.lb_Congtac.Name = "lb_Congtac";
            this.lb_Congtac.Size = new System.Drawing.Size(86, 13);
            this.lb_Congtac.TabIndex = 27;
            this.lb_Congtac.Text = "Đơn Vị Công Tác :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(737, 139);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Capnhat
            // 
            this.btn_Capnhat.Location = new System.Drawing.Point(113, 146);
            this.btn_Capnhat.Name = "btn_Capnhat";
            this.btn_Capnhat.Size = new System.Drawing.Size(75, 23);
            this.btn_Capnhat.TabIndex = 1;
            this.btn_Capnhat.Text = "Cập Nhật";
            this.btn_Capnhat.Click += new System.EventHandler(this.btn_Capnhat_Click);
            // 
            // btn_Themmoi
            // 
            this.btn_Themmoi.Location = new System.Drawing.Point(16, 146);
            this.btn_Themmoi.Name = "btn_Themmoi";
            this.btn_Themmoi.Size = new System.Drawing.Size(75, 23);
            this.btn_Themmoi.TabIndex = 0;
            this.btn_Themmoi.Text = "Thêm Mới";
            this.btn_Themmoi.Click += new System.EventHandler(this.btn_Themmoi_Click);
            // 
            // lb_Nghenghiep
            // 
            this.lb_Nghenghiep.Location = new System.Drawing.Point(411, 18);
            this.lb_Nghenghiep.Name = "lb_Nghenghiep";
            this.lb_Nghenghiep.Size = new System.Drawing.Size(68, 13);
            this.lb_Nghenghiep.TabIndex = 26;
            this.lb_Nghenghiep.Text = "Nghề Nghiệp :";
            // 
            // lb_Ngaysinh
            // 
            this.lb_Ngaysinh.Location = new System.Drawing.Point(424, 91);
            this.lb_Ngaysinh.Name = "lb_Ngaysinh";
            this.lb_Ngaysinh.Size = new System.Drawing.Size(55, 13);
            this.lb_Ngaysinh.TabIndex = 25;
            this.lb_Ngaysinh.Text = "Ngày Sinh :";
            // 
            // lb_Quanhe
            // 
            this.lb_Quanhe.Location = new System.Drawing.Point(79, 91);
            this.lb_Quanhe.Name = "lb_Quanhe";
            this.lb_Quanhe.Size = new System.Drawing.Size(49, 13);
            this.lb_Quanhe.TabIndex = 24;
            this.lb_Quanhe.Text = "Quan Hệ :";
            // 
            // lb_Hoten
            // 
            this.lb_Hoten.Location = new System.Drawing.Point(72, 53);
            this.lb_Hoten.Name = "lb_Hoten";
            this.lb_Hoten.Size = new System.Drawing.Size(56, 13);
            this.lb_Hoten.TabIndex = 22;
            this.lb_Hoten.Text = "Họ và Tên :";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.tb_Quanhe);
            this.panelControl1.Controls.Add(this.dtime_Ngaysinh);
            this.panelControl1.Controls.Add(this.tb_Congtac);
            this.panelControl1.Controls.Add(this.tb_Nghenghiep);
            this.panelControl1.Controls.Add(this.tb_Hoten);
            this.panelControl1.Controls.Add(this.lb_Congtac);
            this.panelControl1.Controls.Add(this.lb_Nghenghiep);
            this.panelControl1.Controls.Add(this.lb_Ngaysinh);
            this.panelControl1.Controls.Add(this.lb_Quanhe);
            this.panelControl1.Controls.Add(this.lb_tennhanvien);
            this.panelControl1.Controls.Add(this.lb_Hoten);
            this.panelControl1.Location = new System.Drawing.Point(20, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(737, 130);
            this.panelControl1.TabIndex = 3;
            // 
            // tb_Quanhe
            // 
            this.tb_Quanhe.Location = new System.Drawing.Point(159, 85);
            this.tb_Quanhe.Name = "tb_Quanhe";
            this.tb_Quanhe.Size = new System.Drawing.Size(169, 20);
            this.tb_Quanhe.TabIndex = 2;
            this.tb_Quanhe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Quanhe_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_Capnhat);
            this.panel1.Controls.Add(this.btn_Themmoi);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Location = new System.Drawing.Point(20, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 187);
            this.panel1.TabIndex = 4;
            // 
            // lb_tennhanvien
            // 
            this.lb_tennhanvien.Location = new System.Drawing.Point(16, 18);
            this.lb_tennhanvien.Name = "lb_tennhanvien";
            this.lb_tennhanvien.Size = new System.Drawing.Size(170, 13);
            this.lb_tennhanvien.TabIndex = 22;
            this.lb_tennhanvien.Text = "Khai báo nhân thân của nhân viên: ";
            // 
            // frm_NhanThan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 335);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_NhanThan";
            this.Text = "frm_NhanThan";
            ((System.ComponentModel.ISupportInitialize)(this.tb_Congtac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Nghenghiep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Hoten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Quanhe.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private System.Windows.Forms.DateTimePicker dtime_Ngaysinh;
        private DevExpress.XtraEditors.TextEdit tb_Congtac;
        private DevExpress.XtraEditors.TextEdit tb_Nghenghiep;
        private DevExpress.XtraEditors.TextEdit tb_Hoten;
        private DevExpress.XtraEditors.LabelControl lb_Congtac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btn_Capnhat;
        private DevExpress.XtraEditors.SimpleButton btn_Themmoi;
        private DevExpress.XtraEditors.LabelControl lb_Nghenghiep;
        private DevExpress.XtraEditors.LabelControl lb_Ngaysinh;
        private DevExpress.XtraEditors.LabelControl lb_Quanhe;
        private DevExpress.XtraEditors.LabelControl lb_Hoten;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit tb_Quanhe;
        private DevExpress.XtraEditors.LabelControl lb_tennhanvien;
    }
}