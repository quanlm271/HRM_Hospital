namespace HRM_Hospital
{
    partial class frm_QLNhanVien
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cb_Phai = new DevExpress.XtraEditors.CheckEdit();
            this.dtime_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tb_Chucvu = new DevExpress.XtraEditors.TextEdit();
            this.tb_Quequan = new DevExpress.XtraEditors.TextEdit();
            this.tb_CMND = new DevExpress.XtraEditors.TextEdit();
            this.tb_Hoten = new DevExpress.XtraEditors.TextEdit();
            this.lb_Chucvu = new DevExpress.XtraEditors.LabelControl();
            this.lb_Điachi = new DevExpress.XtraEditors.LabelControl();
            this.lb_Ngaysinh = new DevExpress.XtraEditors.LabelControl();
            this.lb_CMND = new DevExpress.XtraEditors.LabelControl();
            this.lb_Gioitinh = new DevExpress.XtraEditors.LabelControl();
            this.lb_Hoten = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Capnhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Themmoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Congtac = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Thannhan = new DevExpress.XtraEditors.SimpleButton();
            this.cl_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Phai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Chucvu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Quequan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Hoten.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.cb_Phai);
            this.panelControl1.Controls.Add(this.dtime_Ngaysinh);
            this.panelControl1.Controls.Add(this.tb_Chucvu);
            this.panelControl1.Controls.Add(this.tb_Quequan);
            this.panelControl1.Controls.Add(this.tb_CMND);
            this.panelControl1.Controls.Add(this.tb_Hoten);
            this.panelControl1.Controls.Add(this.lb_Chucvu);
            this.panelControl1.Controls.Add(this.lb_Điachi);
            this.panelControl1.Controls.Add(this.lb_Ngaysinh);
            this.panelControl1.Controls.Add(this.lb_CMND);
            this.panelControl1.Controls.Add(this.lb_Gioitinh);
            this.panelControl1.Controls.Add(this.lb_Hoten);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(737, 130);
            this.panelControl1.TabIndex = 1;
            // 
            // cb_Phai
            // 
            this.cb_Phai.Location = new System.Drawing.Point(160, 72);
            this.cb_Phai.Name = "cb_Phai";
            this.cb_Phai.Properties.Caption = "Nam";
            this.cb_Phai.Size = new System.Drawing.Size(75, 19);
            this.cb_Phai.TabIndex = 34;
            // 
            // dtime_Ngaysinh
            // 
            this.dtime_Ngaysinh.Location = new System.Drawing.Point(504, 73);
            this.dtime_Ngaysinh.Name = "dtime_Ngaysinh";
            this.dtime_Ngaysinh.Size = new System.Drawing.Size(169, 21);
            this.dtime_Ngaysinh.TabIndex = 33;
            this.dtime_Ngaysinh.Value = new System.DateTime(2015, 5, 20, 0, 0, 0, 0);
            // 
            // tb_Chucvu
            // 
            this.tb_Chucvu.Location = new System.Drawing.Point(504, 40);
            this.tb_Chucvu.Name = "tb_Chucvu";
            this.tb_Chucvu.Size = new System.Drawing.Size(169, 20);
            this.tb_Chucvu.TabIndex = 32;
            this.tb_Chucvu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Chucvu_KeyPress);
            // 
            // tb_Quequan
            // 
            this.tb_Quequan.Location = new System.Drawing.Point(504, 5);
            this.tb_Quequan.Name = "tb_Quequan";
            this.tb_Quequan.Size = new System.Drawing.Size(169, 20);
            this.tb_Quequan.TabIndex = 31;
            this.tb_Quequan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Diachi_KeyPress);
            // 
            // tb_CMND
            // 
            this.tb_CMND.EditValue = "";
            this.tb_CMND.Location = new System.Drawing.Point(160, 41);
            this.tb_CMND.Name = "tb_CMND";
            this.tb_CMND.Properties.Mask.EditMask = "\\d{0,15}";
            this.tb_CMND.Properties.Mask.IgnoreMaskBlank = false;
            this.tb_CMND.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tb_CMND.Properties.Mask.SaveLiteral = false;
            this.tb_CMND.Size = new System.Drawing.Size(169, 20);
            this.tb_CMND.TabIndex = 30;
            this.tb_CMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CMND_KeyPress);
            // 
            // tb_Hoten
            // 
            this.tb_Hoten.Location = new System.Drawing.Point(160, 5);
            this.tb_Hoten.Name = "tb_Hoten";
            this.tb_Hoten.Size = new System.Drawing.Size(169, 20);
            this.tb_Hoten.TabIndex = 29;
            this.tb_Hoten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Hoten_KeyPress);
            // 
            // lb_Chucvu
            // 
            this.lb_Chucvu.Location = new System.Drawing.Point(432, 43);
            this.lb_Chucvu.Name = "lb_Chucvu";
            this.lb_Chucvu.Size = new System.Drawing.Size(47, 13);
            this.lb_Chucvu.TabIndex = 27;
            this.lb_Chucvu.Text = "Chức Vụ :";
            // 
            // lb_Điachi
            // 
            this.lb_Điachi.Location = new System.Drawing.Point(438, 8);
            this.lb_Điachi.Name = "lb_Điachi";
            this.lb_Điachi.Size = new System.Drawing.Size(56, 13);
            this.lb_Điachi.TabIndex = 26;
            this.lb_Điachi.Text = "Quê Quán :";
            // 
            // lb_Ngaysinh
            // 
            this.lb_Ngaysinh.Location = new System.Drawing.Point(424, 79);
            this.lb_Ngaysinh.Name = "lb_Ngaysinh";
            this.lb_Ngaysinh.Size = new System.Drawing.Size(55, 13);
            this.lb_Ngaysinh.TabIndex = 25;
            this.lb_Ngaysinh.Text = "Ngày Sinh :";
            // 
            // lb_CMND
            // 
            this.lb_CMND.Location = new System.Drawing.Point(86, 43);
            this.lb_CMND.Name = "lb_CMND";
            this.lb_CMND.Size = new System.Drawing.Size(36, 13);
            this.lb_CMND.TabIndex = 24;
            this.lb_CMND.Text = "CMND :";
            // 
            // lb_Gioitinh
            // 
            this.lb_Gioitinh.Location = new System.Drawing.Point(75, 75);
            this.lb_Gioitinh.Name = "lb_Gioitinh";
            this.lb_Gioitinh.Size = new System.Drawing.Size(47, 13);
            this.lb_Gioitinh.TabIndex = 23;
            this.lb_Gioitinh.Text = "Giới Tính :";
            // 
            // lb_Hoten
            // 
            this.lb_Hoten.Location = new System.Drawing.Point(66, 8);
            this.lb_Hoten.Name = "lb_Hoten";
            this.lb_Hoten.Size = new System.Drawing.Size(56, 13);
            this.lb_Hoten.TabIndex = 22;
            this.lb_Hoten.Text = "Họ và Tên :";
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
            this.panel1.Controls.Add(this.btn_Congtac);
            this.panel1.Controls.Add(this.btn_Thannhan);
            this.panel1.Location = new System.Drawing.Point(12, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 187);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_MaNV,
            this.cl_Hoten,
            this.cl_CMND,
            this.cl_Gioitinh,
            this.cl_Quequan,
            this.cl_Chucvu,
            this.cl_Ngaysinh});
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
            this.btn_Capnhat.TabIndex = 22;
            this.btn_Capnhat.Text = "Cập Nhật";
            this.btn_Capnhat.Click += new System.EventHandler(this.btn_Capnhat_Click);
            // 
            // btn_Themmoi
            // 
            this.btn_Themmoi.Location = new System.Drawing.Point(16, 146);
            this.btn_Themmoi.Name = "btn_Themmoi";
            this.btn_Themmoi.Size = new System.Drawing.Size(75, 23);
            this.btn_Themmoi.TabIndex = 21;
            this.btn_Themmoi.Text = "Thêm Mới";
            this.btn_Themmoi.Click += new System.EventHandler(this.btn_Themmoi_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(220, 147);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Congtac
            // 
            this.btn_Congtac.Location = new System.Drawing.Point(588, 145);
            this.btn_Congtac.Name = "btn_Congtac";
            this.btn_Congtac.Size = new System.Drawing.Size(136, 25);
            this.btn_Congtac.TabIndex = 2;
            this.btn_Congtac.Text = "Quá Trình Công Tác";
            this.btn_Congtac.Click += new System.EventHandler(this.btn_Congtac_Click);
            // 
            // btn_Thannhan
            // 
            this.btn_Thannhan.Location = new System.Drawing.Point(433, 145);
            this.btn_Thannhan.Name = "btn_Thannhan";
            this.btn_Thannhan.Size = new System.Drawing.Size(140, 25);
            this.btn_Thannhan.TabIndex = 1;
            this.btn_Thannhan.Text = "Thông Tin Thân Nhân";
            this.btn_Thannhan.Click += new System.EventHandler(this.btn_Thannhan_Click);
            // 
            // cl_MaNV
            // 
            this.cl_MaNV.DataPropertyName = "MANV";
            this.cl_MaNV.HeaderText = "Mã Nhân Viên";
            this.cl_MaNV.Name = "cl_MaNV";
            this.cl_MaNV.ReadOnly = true;
            // 
            // cl_Hoten
            // 
            this.cl_Hoten.DataPropertyName = "HOTENNV";
            this.cl_Hoten.HeaderText = "Họ Tên";
            this.cl_Hoten.Name = "cl_Hoten";
            this.cl_Hoten.ReadOnly = true;
            // 
            // cl_CMND
            // 
            this.cl_CMND.DataPropertyName = "CMND";
            this.cl_CMND.HeaderText = "CMND";
            this.cl_CMND.Name = "cl_CMND";
            this.cl_CMND.ReadOnly = true;
            // 
            // cl_Gioitinh
            // 
            this.cl_Gioitinh.DataPropertyName = "PHAI";
            this.cl_Gioitinh.HeaderText = "Giới Tính";
            this.cl_Gioitinh.Name = "cl_Gioitinh";
            this.cl_Gioitinh.ReadOnly = true;
            // 
            // cl_Quequan
            // 
            this.cl_Quequan.DataPropertyName = "QUEQUAN";
            this.cl_Quequan.HeaderText = "Quê Quán";
            this.cl_Quequan.Name = "cl_Quequan";
            this.cl_Quequan.ReadOnly = true;
            // 
            // cl_Chucvu
            // 
            this.cl_Chucvu.DataPropertyName = "DANHHIEU";
            this.cl_Chucvu.HeaderText = "Chức Vụ";
            this.cl_Chucvu.Name = "cl_Chucvu";
            this.cl_Chucvu.ReadOnly = true;
            // 
            // cl_Ngaysinh
            // 
            this.cl_Ngaysinh.DataPropertyName = "NGAYSINH";
            this.cl_Ngaysinh.HeaderText = "Ngày Sinh";
            this.cl_Ngaysinh.Name = "cl_Ngaysinh";
            this.cl_Ngaysinh.ReadOnly = true;
            // 
            // frm_QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 335);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QLNhanVien";
            this.Text = "Thông Tin Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Phai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Chucvu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Quequan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Hoten.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckEdit cb_Phai;
        private System.Windows.Forms.DateTimePicker dtime_Ngaysinh;
        private DevExpress.XtraEditors.TextEdit tb_Chucvu;
        private DevExpress.XtraEditors.TextEdit tb_Quequan;
        private DevExpress.XtraEditors.TextEdit tb_Hoten;
        private DevExpress.XtraEditors.LabelControl lb_Chucvu;
        private DevExpress.XtraEditors.LabelControl lb_Điachi;
        private DevExpress.XtraEditors.LabelControl lb_Ngaysinh;
        private DevExpress.XtraEditors.LabelControl lb_CMND;
        private DevExpress.XtraEditors.LabelControl lb_Gioitinh;
        private DevExpress.XtraEditors.LabelControl lb_Hoten;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_Capnhat;
        private DevExpress.XtraEditors.SimpleButton btn_Themmoi;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Congtac;
        private DevExpress.XtraEditors.SimpleButton btn_Thannhan;
        private DevExpress.XtraEditors.TextEdit tb_CMND;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Ngaysinh;
    }
}