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
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Insertmoi = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_MANV = new System.Windows.Forms.ComboBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.tb_TDN = new DevExpress.XtraEditors.TextEdit();
            this.lb_QA = new DevExpress.XtraEditors.LabelControl();
            this.cb_Admin = new DevExpress.XtraEditors.CheckEdit();
            this.lb_MK = new DevExpress.XtraEditors.LabelControl();
            this.lb_MNV = new DevExpress.XtraEditors.LabelControl();
            this.lb_TDN = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Admin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Location = new System.Drawing.Point(412, 148);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(87, 28);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Location = new System.Drawing.Point(287, 148);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(87, 28);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Cập Nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insertmoi
            // 
            this.btn_Insertmoi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insertmoi.Appearance.Options.UseFont = true;
            this.btn_Insertmoi.Location = new System.Drawing.Point(164, 148);
            this.btn_Insertmoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Insertmoi.Name = "btn_Insertmoi";
            this.btn_Insertmoi.Size = new System.Drawing.Size(87, 28);
            this.btn_Insertmoi.TabIndex = 4;
            this.btn_Insertmoi.Text = "Thêm Mới";
            this.btn_Insertmoi.Click += new System.EventHandler(this.btn_Insertmoi_Click);
            // 
            // cbb_MANV
            // 
            this.cbb_MANV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_MANV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_MANV.FormattingEnabled = true;
            this.cbb_MANV.Items.AddRange(new object[] {
            ""});
            this.cbb_MANV.Location = new System.Drawing.Point(537, 34);
            this.cbb_MANV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_MANV.Name = "cbb_MANV";
            this.cbb_MANV.Size = new System.Drawing.Size(140, 24);
            this.cbb_MANV.TabIndex = 1;
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_matkhau.Location = new System.Drawing.Point(164, 81);
            this.tb_matkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.PasswordChar = '*';
            this.tb_matkhau.Size = new System.Drawing.Size(196, 23);
            this.tb_matkhau.TabIndex = 2;
            // 
            // tb_TDN
            // 
            this.tb_TDN.Location = new System.Drawing.Point(164, 36);
            this.tb_TDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_TDN.Name = "tb_TDN";
            this.tb_TDN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TDN.Properties.Appearance.Options.UseFont = true;
            this.tb_TDN.Size = new System.Drawing.Size(197, 22);
            this.tb_TDN.TabIndex = 0;
            // 
            // lb_QA
            // 
            this.lb_QA.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QA.Location = new System.Drawing.Point(412, 81);
            this.lb_QA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_QA.Name = "lb_QA";
            this.lb_QA.Size = new System.Drawing.Size(101, 16);
            this.lb_QA.TabIndex = 13;
            this.lb_QA.Text = "Quyền Truy Cập :";
            // 
            // cb_Admin
            // 
            this.cb_Admin.Location = new System.Drawing.Point(535, 79);
            this.cb_Admin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_Admin.Name = "cb_Admin";
            this.cb_Admin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Admin.Properties.Appearance.Options.UseFont = true;
            this.cb_Admin.Properties.Caption = "Admin";
            this.cb_Admin.Size = new System.Drawing.Size(87, 20);
            this.cb_Admin.TabIndex = 3;
            // 
            // lb_MK
            // 
            this.lb_MK.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MK.Location = new System.Drawing.Point(84, 85);
            this.lb_MK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_MK.Name = "lb_MK";
            this.lb_MK.Size = new System.Drawing.Size(62, 16);
            this.lb_MK.TabIndex = 11;
            this.lb_MK.Text = "Mật Khẩu :";
            // 
            // lb_MNV
            // 
            this.lb_MNV.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MNV.Location = new System.Drawing.Point(428, 38);
            this.lb_MNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_MNV.Name = "lb_MNV";
            this.lb_MNV.Size = new System.Drawing.Size(88, 16);
            this.lb_MNV.TabIndex = 10;
            this.lb_MNV.Text = "Mã Nhân Viên :";
            // 
            // lb_TDN
            // 
            this.lb_TDN.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TDN.Location = new System.Drawing.Point(48, 37);
            this.lb_TDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_TDN.Name = "lb_TDN";
            this.lb_TDN.Size = new System.Drawing.Size(98, 16);
            this.lb_TDN.TabIndex = 9;
            this.lb_TDN.Text = "Tên Đăng Nhập :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 197);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(891, 215);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frm_QLNguoiDung
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 412);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbb_MANV);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insertmoi);
            this.Controls.Add(this.tb_TDN);
            this.Controls.Add(this.lb_TDN);
            this.Controls.Add(this.lb_QA);
            this.Controls.Add(this.lb_MNV);
            this.Controls.Add(this.cb_Admin);
            this.Controls.Add(this.lb_MK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_QLNguoiDung";
            this.Text = "Quản Trị Người Dùng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tb_TDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Admin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Insertmoi;
        private System.Windows.Forms.ComboBox cbb_MANV;
        private System.Windows.Forms.TextBox tb_matkhau;
        private DevExpress.XtraEditors.TextEdit tb_TDN;
        private DevExpress.XtraEditors.LabelControl lb_QA;
        private DevExpress.XtraEditors.CheckEdit cb_Admin;
        private DevExpress.XtraEditors.LabelControl lb_MK;
        private DevExpress.XtraEditors.LabelControl lb_MNV;
        private DevExpress.XtraEditors.LabelControl lb_TDN;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}