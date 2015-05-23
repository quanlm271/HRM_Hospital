namespace HRM_Hospital
{
    partial class frm_QuaTrinhCongTaccs
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
            this.lb_Nghenghiep = new DevExpress.XtraEditors.LabelControl();
            this.lb_Ngaysinh = new DevExpress.XtraEditors.LabelControl();
            this.lb_Quanhe = new DevExpress.XtraEditors.LabelControl();
            this.lb_MaTN = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Capnhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Themmoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.tb_MaQTCT = new DevExpress.XtraEditors.TextEdit();
            this.dtime_Tungay = new System.Windows.Forms.DateTimePicker();
            this.tb_Chucvu = new DevExpress.XtraEditors.TextEdit();
            this.tb_Chucdanh = new DevExpress.XtraEditors.TextEdit();
            this.lb_Congtac = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtime_Denngay = new System.Windows.Forms.DateTimePicker();
            this.tb_MaPHG = new System.Windows.Forms.ComboBox();
            this.cl_Quatrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Chucdanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Tungay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Denngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaQTCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Chucvu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Chucdanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Nghenghiep
            // 
            this.lb_Nghenghiep.Location = new System.Drawing.Point(63, 43);
            this.lb_Nghenghiep.Name = "lb_Nghenghiep";
            this.lb_Nghenghiep.Size = new System.Drawing.Size(60, 13);
            this.lb_Nghenghiep.TabIndex = 26;
            this.lb_Nghenghiep.Text = "Chức Danh :";
            // 
            // lb_Ngaysinh
            // 
            this.lb_Ngaysinh.Location = new System.Drawing.Point(405, 43);
            this.lb_Ngaysinh.Name = "lb_Ngaysinh";
            this.lb_Ngaysinh.Size = new System.Drawing.Size(48, 13);
            this.lb_Ngaysinh.TabIndex = 25;
            this.lb_Ngaysinh.Text = "Từ Ngày :";
            // 
            // lb_Quanhe
            // 
            this.lb_Quanhe.Location = new System.Drawing.Point(405, 8);
            this.lb_Quanhe.Name = "lb_Quanhe";
            this.lb_Quanhe.Size = new System.Drawing.Size(54, 13);
            this.lb_Quanhe.TabIndex = 24;
            this.lb_Quanhe.Text = "Mã Phòng :";
            // 
            // lb_MaTN
            // 
            this.lb_MaTN.Location = new System.Drawing.Point(63, 8);
            this.lb_MaTN.Name = "lb_MaTN";
            this.lb_MaTN.Size = new System.Drawing.Size(51, 13);
            this.lb_MaTN.TabIndex = 21;
            this.lb_MaTN.Text = "Mã QTCT :";
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
            this.panel1.Location = new System.Drawing.Point(28, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 187);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_Quatrinh,
            this.cl_Chucdanh,
            this.cl_Chucvu,
            this.cl_Maphong,
            this.cl_Tungay,
            this.cl_Denngay});
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
            // tb_MaQTCT
            // 
            this.tb_MaQTCT.Location = new System.Drawing.Point(157, 5);
            this.tb_MaQTCT.Name = "tb_MaQTCT";
            this.tb_MaQTCT.Size = new System.Drawing.Size(169, 20);
            this.tb_MaQTCT.TabIndex = 28;
            this.tb_MaQTCT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_MaTN_KeyPress);
            // 
            // dtime_Tungay
            // 
            this.dtime_Tungay.Location = new System.Drawing.Point(504, 37);
            this.dtime_Tungay.Name = "dtime_Tungay";
            this.dtime_Tungay.Size = new System.Drawing.Size(169, 21);
            this.dtime_Tungay.TabIndex = 33;
            this.dtime_Tungay.Value = new System.DateTime(2015, 5, 20, 0, 0, 0, 0);
            // 
            // tb_Chucvu
            // 
            this.tb_Chucvu.Location = new System.Drawing.Point(157, 76);
            this.tb_Chucvu.Name = "tb_Chucvu";
            this.tb_Chucvu.Size = new System.Drawing.Size(169, 20);
            this.tb_Chucvu.TabIndex = 32;
            this.tb_Chucvu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Congtac_KeyPress);
            // 
            // tb_Chucdanh
            // 
            this.tb_Chucdanh.Location = new System.Drawing.Point(157, 40);
            this.tb_Chucdanh.Name = "tb_Chucdanh";
            this.tb_Chucdanh.Size = new System.Drawing.Size(169, 20);
            this.tb_Chucdanh.TabIndex = 31;
            this.tb_Chucdanh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Nghenghiep_KeyPress);
            // 
            // lb_Congtac
            // 
            this.lb_Congtac.Location = new System.Drawing.Point(63, 79);
            this.lb_Congtac.Name = "lb_Congtac";
            this.lb_Congtac.Size = new System.Drawing.Size(47, 13);
            this.lb_Congtac.TabIndex = 27;
            this.lb_Congtac.Text = "Chức Vụ :";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.tb_MaPHG);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dtime_Denngay);
            this.panelControl1.Controls.Add(this.dtime_Tungay);
            this.panelControl1.Controls.Add(this.tb_Chucvu);
            this.panelControl1.Controls.Add(this.tb_Chucdanh);
            this.panelControl1.Controls.Add(this.tb_MaQTCT);
            this.panelControl1.Controls.Add(this.lb_Congtac);
            this.panelControl1.Controls.Add(this.lb_Nghenghiep);
            this.panelControl1.Controls.Add(this.lb_Ngaysinh);
            this.panelControl1.Controls.Add(this.lb_Quanhe);
            this.panelControl1.Controls.Add(this.lb_MaTN);
            this.panelControl1.Location = new System.Drawing.Point(28, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(737, 130);
            this.panelControl1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(404, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Đến Ngày :";
            // 
            // dtime_Denngay
            // 
            this.dtime_Denngay.Location = new System.Drawing.Point(504, 73);
            this.dtime_Denngay.Name = "dtime_Denngay";
            this.dtime_Denngay.Size = new System.Drawing.Size(169, 21);
            this.dtime_Denngay.TabIndex = 35;
            this.dtime_Denngay.Value = new System.DateTime(2015, 5, 20, 0, 0, 0, 0);
            // 
            // tb_MaPHG
            // 
            this.tb_MaPHG.FormattingEnabled = true;
            this.tb_MaPHG.Items.AddRange(new object[] {
            "(Nope)"});
            this.tb_MaPHG.Location = new System.Drawing.Point(504, 5);
            this.tb_MaPHG.Name = "tb_MaPHG";
            this.tb_MaPHG.Size = new System.Drawing.Size(121, 21);
            this.tb_MaPHG.TabIndex = 37;
            // 
            // cl_Quatrinh
            // 
            this.cl_Quatrinh.DataPropertyName = "MAQTCT";
            this.cl_Quatrinh.HeaderText = "Mã QTCT";
            this.cl_Quatrinh.Name = "cl_Quatrinh";
            this.cl_Quatrinh.ReadOnly = true;
            // 
            // cl_Chucdanh
            // 
            this.cl_Chucdanh.DataPropertyName = "CHUCDANH";
            this.cl_Chucdanh.HeaderText = "Chức Danh";
            this.cl_Chucdanh.Name = "cl_Chucdanh";
            this.cl_Chucdanh.ReadOnly = true;
            // 
            // cl_Chucvu
            // 
            this.cl_Chucvu.DataPropertyName = "CHUCVU";
            this.cl_Chucvu.HeaderText = "Chức Vụ";
            this.cl_Chucvu.Name = "cl_Chucvu";
            this.cl_Chucvu.ReadOnly = true;
            // 
            // cl_Maphong
            // 
            this.cl_Maphong.DataPropertyName = "MAPHG";
            this.cl_Maphong.HeaderText = "Mã Phòng";
            this.cl_Maphong.Name = "cl_Maphong";
            this.cl_Maphong.ReadOnly = true;
            // 
            // cl_Tungay
            // 
            this.cl_Tungay.DataPropertyName = "TUTHANG_NAM";
            this.cl_Tungay.HeaderText = "Từ Ngày";
            this.cl_Tungay.Name = "cl_Tungay";
            this.cl_Tungay.ReadOnly = true;
            // 
            // cl_Denngay
            // 
            this.cl_Denngay.DataPropertyName = "DENTHANG_NAM";
            this.cl_Denngay.HeaderText = "Đến ngày";
            this.cl_Denngay.Name = "cl_Denngay";
            this.cl_Denngay.ReadOnly = true;
            // 
            // frm_QuaTrinhCongTaccs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 346);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QuaTrinhCongTaccs";
            this.Text = "frm_QuaTrinhCongTaccs";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaQTCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Chucvu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Chucdanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lb_Nghenghiep;
        private DevExpress.XtraEditors.LabelControl lb_Ngaysinh;
        private DevExpress.XtraEditors.LabelControl lb_Quanhe;
        private DevExpress.XtraEditors.LabelControl lb_MaTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btn_Capnhat;
        private DevExpress.XtraEditors.SimpleButton btn_Themmoi;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.TextEdit tb_MaQTCT;
        private System.Windows.Forms.DateTimePicker dtime_Tungay;
        private DevExpress.XtraEditors.TextEdit tb_Chucvu;
        private DevExpress.XtraEditors.TextEdit tb_Chucdanh;
        private DevExpress.XtraEditors.LabelControl lb_Congtac;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dtime_Denngay;
        private System.Windows.Forms.ComboBox tb_MaPHG;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Quatrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Chucdanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Tungay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Denngay;

    }
}