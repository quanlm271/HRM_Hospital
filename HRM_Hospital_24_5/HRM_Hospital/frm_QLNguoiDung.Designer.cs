namespace HRM_Hospital
{
    partial class frm_QLNguoiDung
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
            this.cbb_MANV = new System.Windows.Forms.ComboBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.tb_TDN = new DevExpress.XtraEditors.TextEdit();
            this.lb_QA = new DevExpress.XtraEditors.LabelControl();
            this.cb_Admin = new DevExpress.XtraEditors.CheckEdit();
            this.lb_MK = new DevExpress.XtraEditors.LabelControl();
            this.lb_MNV = new DevExpress.XtraEditors.LabelControl();
            this.lb_TDN = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Capnhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Themmoi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Admin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbb_MANV);
            this.panelControl1.Controls.Add(this.tb_matkhau);
            this.panelControl1.Controls.Add(this.tb_TDN);
            this.panelControl1.Controls.Add(this.lb_QA);
            this.panelControl1.Controls.Add(this.cb_Admin);
            this.panelControl1.Controls.Add(this.lb_MK);
            this.panelControl1.Controls.Add(this.lb_MNV);
            this.panelControl1.Controls.Add(this.lb_TDN);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(737, 104);
            this.panelControl1.TabIndex = 0;
            // 
            // cbb_MANV
            // 
            this.cbb_MANV.FormattingEnabled = true;
            this.cbb_MANV.Items.AddRange(new object[] {
            "(Nope)"});
            this.cbb_MANV.Location = new System.Drawing.Point(509, 21);
            this.cbb_MANV.Name = "cbb_MANV";
            this.cbb_MANV.Size = new System.Drawing.Size(121, 21);
            this.cbb_MANV.TabIndex = 8;
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(190, 59);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.PasswordChar = '*';
            this.tb_matkhau.Size = new System.Drawing.Size(169, 21);
            this.tb_matkhau.TabIndex = 7;
            this.tb_matkhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_matkhau_KeyPress);
            // 
            // tb_TDN
            // 
            this.tb_TDN.Location = new System.Drawing.Point(190, 22);
            this.tb_TDN.Name = "tb_TDN";
            this.tb_TDN.Size = new System.Drawing.Size(169, 20);
            this.tb_TDN.TabIndex = 5;
            this.tb_TDN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_TDN_KeyPress);
            // 
            // lb_QA
            // 
            this.lb_QA.Location = new System.Drawing.Point(400, 59);
            this.lb_QA.Name = "lb_QA";
            this.lb_QA.Size = new System.Drawing.Size(86, 13);
            this.lb_QA.TabIndex = 4;
            this.lb_QA.Text = "Quyền Truy Cập :";
            // 
            // cb_Admin
            // 
            this.cb_Admin.Location = new System.Drawing.Point(509, 57);
            this.cb_Admin.Name = "cb_Admin";
            this.cb_Admin.Properties.Caption = "Admin";
            this.cb_Admin.Size = new System.Drawing.Size(75, 19);
            this.cb_Admin.TabIndex = 3;
            // 
            // lb_MK
            // 
            this.lb_MK.Location = new System.Drawing.Point(87, 60);
            this.lb_MK.Name = "lb_MK";
            this.lb_MK.Size = new System.Drawing.Size(52, 13);
            this.lb_MK.TabIndex = 2;
            this.lb_MK.Text = "Mật Khẩu :";
            // 
            // lb_MNV
            // 
            this.lb_MNV.Location = new System.Drawing.Point(400, 25);
            this.lb_MNV.Name = "lb_MNV";
            this.lb_MNV.Size = new System.Drawing.Size(72, 13);
            this.lb_MNV.TabIndex = 1;
            this.lb_MNV.Text = "Mã Nhân Viên :";
            // 
            // lb_TDN
            // 
            this.lb_TDN.Location = new System.Drawing.Point(78, 25);
            this.lb_TDN.Name = "lb_TDN";
            this.lb_TDN.Size = new System.Drawing.Size(82, 13);
            this.lb_TDN.TabIndex = 0;
            this.lb_TDN.Text = "Tên Đăng Nhập :";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dataGridView1);
            this.panelControl2.Controls.Add(this.btn_Xoa);
            this.panelControl2.Controls.Add(this.btn_Capnhat);
            this.panelControl2.Controls.Add(this.btn_Themmoi);
            this.panelControl2.Location = new System.Drawing.Point(12, 122);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(737, 197);
            this.panelControl2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(733, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(258, 160);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Capnhat
            // 
            this.btn_Capnhat.Location = new System.Drawing.Point(143, 160);
            this.btn_Capnhat.Name = "btn_Capnhat";
            this.btn_Capnhat.Size = new System.Drawing.Size(75, 23);
            this.btn_Capnhat.TabIndex = 3;
            this.btn_Capnhat.Text = "Cập Nhật";
            this.btn_Capnhat.Click += new System.EventHandler(this.btn_Capnhat_Click);
            // 
            // btn_Themmoi
            // 
            this.btn_Themmoi.Location = new System.Drawing.Point(35, 160);
            this.btn_Themmoi.Name = "btn_Themmoi";
            this.btn_Themmoi.Size = new System.Drawing.Size(75, 23);
            this.btn_Themmoi.TabIndex = 2;
            this.btn_Themmoi.Text = "Thêm Mới";
            this.btn_Themmoi.Click += new System.EventHandler(this.btn_Themmoi_Click);
            // 
            // frm_QLNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 335);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QLNguoiDung";
            this.Text = "Quản Trị Người Dùng";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Admin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lb_MK;
        private DevExpress.XtraEditors.LabelControl lb_MNV;
        private DevExpress.XtraEditors.LabelControl lb_TDN;
        private DevExpress.XtraEditors.LabelControl lb_QA;
        private DevExpress.XtraEditors.CheckEdit cb_Admin;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit tb_TDN;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Capnhat;
        private DevExpress.XtraEditors.SimpleButton btn_Themmoi;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbb_MANV;
    }
}