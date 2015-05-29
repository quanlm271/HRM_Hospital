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
            this.cb_gdlietsi = new DevExpress.XtraEditors.CheckEdit();
            this.btn_Insert = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.cb_Phai = new DevExpress.XtraEditors.CheckEdit();
            this.dtime_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.tb_tongiao = new DevExpress.XtraEditors.TextEdit();
            this.tb_bac = new DevExpress.XtraEditors.TextEdit();
            this.tb_ngach = new DevExpress.XtraEditors.TextEdit();
            this.tb_dantoc = new DevExpress.XtraEditors.TextEdit();
            this.tb_dchi = new DevExpress.XtraEditors.TextEdit();
            this.tb_loainv = new DevExpress.XtraEditors.TextEdit();
            this.tb_CMND = new DevExpress.XtraEditors.TextEdit();
            this.tb_Hoten = new DevExpress.XtraEditors.TextEdit();
            this.lb_loainv = new DevExpress.XtraEditors.LabelControl();
            this.lb_bac = new DevExpress.XtraEditors.LabelControl();
            this.lb_tongiao = new DevExpress.XtraEditors.LabelControl();
            this.lb_nghach = new DevExpress.XtraEditors.LabelControl();
            this.lb_dantoc = new DevExpress.XtraEditors.LabelControl();
            this.lb_Điachi = new DevExpress.XtraEditors.LabelControl();
            this.lb_Ngaysinh = new DevExpress.XtraEditors.LabelControl();
            this.lb_CMND = new DevExpress.XtraEditors.LabelControl();
            this.lb_giadinhlietsi = new DevExpress.XtraEditors.LabelControl();
            this.lb_Gioitinh = new DevExpress.XtraEditors.LabelControl();
            this.lb_Hoten = new DevExpress.XtraEditors.LabelControl();
            this.btn_Congtac = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Thannhan = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_phong = new DevExpress.XtraEditors.LabelControl();
            this.ccb_phong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cb_gdlietsi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Phai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tongiao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_bac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ngach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dantoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dchi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_loainv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Hoten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_gdlietsi
            // 
            this.cb_gdlietsi.Location = new System.Drawing.Point(761, 102);
            this.cb_gdlietsi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_gdlietsi.Name = "cb_gdlietsi";
            this.cb_gdlietsi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gdlietsi.Properties.Appearance.Options.UseFont = true;
            this.cb_gdlietsi.Properties.Caption = "Có";
            this.cb_gdlietsi.Size = new System.Drawing.Size(87, 20);
            this.cb_gdlietsi.TabIndex = 7;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.Appearance.Options.UseFont = true;
            this.btn_Insert.Location = new System.Drawing.Point(94, 233);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(87, 28);
            this.btn_Insert.TabIndex = 11;
            this.btn_Insert.Text = "Thêm Mới";
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Location = new System.Drawing.Point(220, 233);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(87, 28);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Cập Nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // cb_Phai
            // 
            this.cb_Phai.Location = new System.Drawing.Point(761, 27);
            this.cb_Phai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_Phai.Name = "cb_Phai";
            this.cb_Phai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Phai.Properties.Appearance.Options.UseFont = true;
            this.cb_Phai.Properties.Caption = "Nam";
            this.cb_Phai.Size = new System.Drawing.Size(87, 20);
            this.cb_Phai.TabIndex = 2;
            // 
            // dtime_Ngaysinh
            // 
            this.dtime_Ngaysinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtime_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_Ngaysinh.Location = new System.Drawing.Point(429, 23);
            this.dtime_Ngaysinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtime_Ngaysinh.Name = "dtime_Ngaysinh";
            this.dtime_Ngaysinh.Size = new System.Drawing.Size(196, 23);
            this.dtime_Ngaysinh.TabIndex = 1;
            this.dtime_Ngaysinh.Value = new System.DateTime(2015, 5, 20, 0, 0, 0, 0);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Location = new System.Drawing.Point(345, 233);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(87, 28);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Location = new System.Drawing.Point(463, 233);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(87, 28);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Hủy";
            // 
            // tb_tongiao
            // 
            this.tb_tongiao.Location = new System.Drawing.Point(429, 100);
            this.tb_tongiao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_tongiao.Name = "tb_tongiao";
            this.tb_tongiao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tongiao.Properties.Appearance.Options.UseFont = true;
            this.tb_tongiao.Size = new System.Drawing.Size(197, 22);
            this.tb_tongiao.TabIndex = 6;
            // 
            // tb_bac
            // 
            this.tb_bac.Location = new System.Drawing.Point(429, 138);
            this.tb_bac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_bac.Name = "tb_bac";
            this.tb_bac.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bac.Properties.Appearance.Options.UseFont = true;
            this.tb_bac.Size = new System.Drawing.Size(197, 22);
            this.tb_bac.TabIndex = 9;
            // 
            // tb_ngach
            // 
            this.tb_ngach.Location = new System.Drawing.Point(94, 138);
            this.tb_ngach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ngach.Name = "tb_ngach";
            this.tb_ngach.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ngach.Properties.Appearance.Options.UseFont = true;
            this.tb_ngach.Size = new System.Drawing.Size(195, 22);
            this.tb_ngach.TabIndex = 8;
            // 
            // tb_dantoc
            // 
            this.tb_dantoc.Location = new System.Drawing.Point(94, 100);
            this.tb_dantoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_dantoc.Name = "tb_dantoc";
            this.tb_dantoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dantoc.Properties.Appearance.Options.UseFont = true;
            this.tb_dantoc.Size = new System.Drawing.Size(195, 22);
            this.tb_dantoc.TabIndex = 5;
            // 
            // tb_dchi
            // 
            this.tb_dchi.Location = new System.Drawing.Point(429, 63);
            this.tb_dchi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_dchi.Name = "tb_dchi";
            this.tb_dchi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dchi.Properties.Appearance.Options.UseFont = true;
            this.tb_dchi.Size = new System.Drawing.Size(197, 22);
            this.tb_dchi.TabIndex = 4;
            // 
            // tb_loainv
            // 
            this.tb_loainv.Location = new System.Drawing.Point(94, 177);
            this.tb_loainv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_loainv.Name = "tb_loainv";
            this.tb_loainv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_loainv.Properties.Appearance.Options.UseFont = true;
            this.tb_loainv.Size = new System.Drawing.Size(195, 22);
            this.tb_loainv.TabIndex = 10;
            // 
            // tb_CMND
            // 
            this.tb_CMND.EditValue = "";
            this.tb_CMND.Location = new System.Drawing.Point(94, 63);
            this.tb_CMND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_CMND.Name = "tb_CMND";
            this.tb_CMND.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CMND.Properties.Appearance.Options.UseFont = true;
            this.tb_CMND.Properties.Mask.EditMask = "\\d{0,15}";
            this.tb_CMND.Properties.Mask.IgnoreMaskBlank = false;
            this.tb_CMND.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tb_CMND.Properties.Mask.SaveLiteral = false;
            this.tb_CMND.Size = new System.Drawing.Size(195, 22);
            this.tb_CMND.TabIndex = 3;
            // 
            // tb_Hoten
            // 
            this.tb_Hoten.Location = new System.Drawing.Point(94, 25);
            this.tb_Hoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Hoten.Name = "tb_Hoten";
            this.tb_Hoten.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Hoten.Properties.Appearance.Options.UseFont = true;
            this.tb_Hoten.Size = new System.Drawing.Size(195, 22);
            this.tb_Hoten.TabIndex = 0;
            // 
            // lb_loainv
            // 
            this.lb_loainv.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loainv.Location = new System.Drawing.Point(36, 179);
            this.lb_loainv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_loainv.Name = "lb_loainv";
            this.lb_loainv.Size = new System.Drawing.Size(52, 16);
            this.lb_loainv.TabIndex = 99;
            this.lb_loainv.Text = "Loại NV :";
            // 
            // lb_bac
            // 
            this.lb_bac.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bac.Location = new System.Drawing.Point(394, 141);
            this.lb_bac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_bac.Name = "lb_bac";
            this.lb_bac.Size = new System.Drawing.Size(29, 16);
            this.lb_bac.TabIndex = 98;
            this.lb_bac.Text = "Bậc :";
            // 
            // lb_tongiao
            // 
            this.lb_tongiao.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongiao.Location = new System.Drawing.Point(365, 103);
            this.lb_tongiao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_tongiao.Name = "lb_tongiao";
            this.lb_tongiao.Size = new System.Drawing.Size(60, 16);
            this.lb_tongiao.TabIndex = 97;
            this.lb_tongiao.Text = "Tôn Giáo :";
            // 
            // lb_nghach
            // 
            this.lb_nghach.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nghach.Location = new System.Drawing.Point(37, 141);
            this.lb_nghach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_nghach.Name = "lb_nghach";
            this.lb_nghach.Size = new System.Drawing.Size(51, 16);
            this.lb_nghach.TabIndex = 96;
            this.lb_nghach.Text = "Nghạch :";
            // 
            // lb_dantoc
            // 
            this.lb_dantoc.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dantoc.Location = new System.Drawing.Point(34, 103);
            this.lb_dantoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_dantoc.Name = "lb_dantoc";
            this.lb_dantoc.Size = new System.Drawing.Size(56, 16);
            this.lb_dantoc.TabIndex = 95;
            this.lb_dantoc.Text = "Dân Tộc :";
            // 
            // lb_Điachi
            // 
            this.lb_Điachi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Điachi.Location = new System.Drawing.Point(374, 66);
            this.lb_Điachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_Điachi.Name = "lb_Điachi";
            this.lb_Điachi.Size = new System.Drawing.Size(50, 16);
            this.lb_Điachi.TabIndex = 94;
            this.lb_Điachi.Text = "Địa Chỉ :";
            // 
            // lb_Ngaysinh
            // 
            this.lb_Ngaysinh.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ngaysinh.Location = new System.Drawing.Point(358, 30);
            this.lb_Ngaysinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_Ngaysinh.Name = "lb_Ngaysinh";
            this.lb_Ngaysinh.Size = new System.Drawing.Size(66, 16);
            this.lb_Ngaysinh.TabIndex = 93;
            this.lb_Ngaysinh.Text = "Ngày Sinh :";
            // 
            // lb_CMND
            // 
            this.lb_CMND.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CMND.Location = new System.Drawing.Point(45, 66);
            this.lb_CMND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_CMND.Name = "lb_CMND";
            this.lb_CMND.Size = new System.Drawing.Size(43, 16);
            this.lb_CMND.TabIndex = 92;
            this.lb_CMND.Text = "CMND :";
            // 
            // lb_giadinhlietsi
            // 
            this.lb_giadinhlietsi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_giadinhlietsi.Location = new System.Drawing.Point(659, 103);
            this.lb_giadinhlietsi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_giadinhlietsi.Name = "lb_giadinhlietsi";
            this.lb_giadinhlietsi.Size = new System.Drawing.Size(96, 16);
            this.lb_giadinhlietsi.TabIndex = 90;
            this.lb_giadinhlietsi.Text = "Gia Đình Liệt Sĩ :";
            // 
            // lb_Gioitinh
            // 
            this.lb_Gioitinh.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gioitinh.Location = new System.Drawing.Point(695, 28);
            this.lb_Gioitinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_Gioitinh.Name = "lb_Gioitinh";
            this.lb_Gioitinh.Size = new System.Drawing.Size(59, 16);
            this.lb_Gioitinh.TabIndex = 91;
            this.lb_Gioitinh.Text = "Giới Tính :";
            // 
            // lb_Hoten
            // 
            this.lb_Hoten.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hoten.Location = new System.Drawing.Point(20, 28);
            this.lb_Hoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_Hoten.Name = "lb_Hoten";
            this.lb_Hoten.Size = new System.Drawing.Size(67, 16);
            this.lb_Hoten.TabIndex = 89;
            this.lb_Hoten.Text = "Họ và Tên :";
            // 
            // btn_Congtac
            // 
            this.btn_Congtac.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Congtac.Appearance.Options.UseFont = true;
            this.btn_Congtac.Location = new System.Drawing.Point(883, 233);
            this.btn_Congtac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Congtac.Name = "btn_Congtac";
            this.btn_Congtac.Size = new System.Drawing.Size(159, 31);
            this.btn_Congtac.TabIndex = 16;
            this.btn_Congtac.Text = "Quá Trình Công Tác";
            this.btn_Congtac.Click += new System.EventHandler(this.btn_Congtac_Click);
            // 
            // btn_Thannhan
            // 
            this.btn_Thannhan.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thannhan.Appearance.Options.UseFont = true;
            this.btn_Thannhan.Location = new System.Drawing.Point(698, 233);
            this.btn_Thannhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Thannhan.Name = "btn_Thannhan";
            this.btn_Thannhan.Size = new System.Drawing.Size(163, 31);
            this.btn_Thannhan.TabIndex = 15;
            this.btn_Thannhan.Text = "Thông Tin Thân Nhân";
            this.btn_Thannhan.Click += new System.EventHandler(this.btn_Thannhan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 281);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1072, 219);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lb_phong
            // 
            this.lb_phong.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phong.Location = new System.Drawing.Point(379, 179);
            this.lb_phong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_phong.Name = "lb_phong";
            this.lb_phong.Size = new System.Drawing.Size(44, 16);
            this.lb_phong.TabIndex = 99;
            this.lb_phong.Text = "Phòng :";
            // 
            // ccb_phong
            // 
            this.ccb_phong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccb_phong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccb_phong.Items.AddRange(new object[] {
            ""});
            this.ccb_phong.Location = new System.Drawing.Point(430, 176);
            this.ccb_phong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ccb_phong.Name = "ccb_phong";
            this.ccb_phong.Size = new System.Drawing.Size(195, 24);
            this.ccb_phong.TabIndex = 100;
            // 
            // frm_QLNhanVien
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 500);
            this.Controls.Add(this.ccb_phong);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_gdlietsi);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.cb_Phai);
            this.Controls.Add(this.dtime_Ngaysinh);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.tb_tongiao);
            this.Controls.Add(this.tb_bac);
            this.Controls.Add(this.tb_ngach);
            this.Controls.Add(this.tb_dantoc);
            this.Controls.Add(this.tb_dchi);
            this.Controls.Add(this.tb_loainv);
            this.Controls.Add(this.tb_CMND);
            this.Controls.Add(this.tb_Hoten);
            this.Controls.Add(this.lb_phong);
            this.Controls.Add(this.lb_loainv);
            this.Controls.Add(this.lb_bac);
            this.Controls.Add(this.lb_tongiao);
            this.Controls.Add(this.lb_nghach);
            this.Controls.Add(this.lb_dantoc);
            this.Controls.Add(this.lb_Điachi);
            this.Controls.Add(this.lb_Ngaysinh);
            this.Controls.Add(this.lb_CMND);
            this.Controls.Add(this.lb_giadinhlietsi);
            this.Controls.Add(this.lb_Gioitinh);
            this.Controls.Add(this.lb_Hoten);
            this.Controls.Add(this.btn_Congtac);
            this.Controls.Add(this.btn_Thannhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_QLNhanVien";
            this.Text = "Thông Tin Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.cb_gdlietsi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Phai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tongiao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_bac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ngach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dantoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dchi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_loainv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Hoten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit cb_gdlietsi;
        private DevExpress.XtraEditors.SimpleButton btn_Insert;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.CheckEdit cb_Phai;
        private System.Windows.Forms.DateTimePicker dtime_Ngaysinh;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.TextEdit tb_tongiao;
        private DevExpress.XtraEditors.TextEdit tb_bac;
        private DevExpress.XtraEditors.TextEdit tb_ngach;
        private DevExpress.XtraEditors.TextEdit tb_dantoc;
        private DevExpress.XtraEditors.TextEdit tb_dchi;
        private DevExpress.XtraEditors.TextEdit tb_loainv;
        private DevExpress.XtraEditors.TextEdit tb_CMND;
        private DevExpress.XtraEditors.TextEdit tb_Hoten;
        private DevExpress.XtraEditors.LabelControl lb_loainv;
        private DevExpress.XtraEditors.LabelControl lb_bac;
        private DevExpress.XtraEditors.LabelControl lb_tongiao;
        private DevExpress.XtraEditors.LabelControl lb_nghach;
        private DevExpress.XtraEditors.LabelControl lb_dantoc;
        private DevExpress.XtraEditors.LabelControl lb_Điachi;
        private DevExpress.XtraEditors.LabelControl lb_Ngaysinh;
        private DevExpress.XtraEditors.LabelControl lb_CMND;
        private DevExpress.XtraEditors.LabelControl lb_giadinhlietsi;
        private DevExpress.XtraEditors.LabelControl lb_Gioitinh;
        private DevExpress.XtraEditors.LabelControl lb_Hoten;
        private DevExpress.XtraEditors.SimpleButton btn_Congtac;
        private DevExpress.XtraEditors.SimpleButton btn_Thannhan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.LabelControl lb_phong;
        private System.Windows.Forms.ComboBox ccb_phong;


    }
}