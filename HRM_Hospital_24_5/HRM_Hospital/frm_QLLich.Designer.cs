namespace HRM_Hospital
{
    partial class frm_QLLich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Insert = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.dtime_ngay = new System.Windows.Forms.DateTimePicker();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.tb_loaicv = new DevExpress.XtraEditors.TextEdit();
            this.tb_tencv = new DevExpress.XtraEditors.TextEdit();
            this.lb_loaicv = new DevExpress.XtraEditors.LabelControl();
            this.lb_tencv = new DevExpress.XtraEditors.LabelControl();
            this.lb_ngay = new DevExpress.XtraEditors.LabelControl();
            this.lb_Hoten = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_phong = new DevExpress.XtraEditors.LabelControl();
            this.lb_thoigian = new DevExpress.XtraEditors.LabelControl();
            this.dtime_thoigian = new System.Windows.Forms.DateTimePicker();
            this.lb_diadiem = new DevExpress.XtraEditors.LabelControl();
            this.tb_diadiem = new DevExpress.XtraEditors.TextEdit();
            this.cb_laptuan = new System.Windows.Forms.CheckBox();
            this.cb_lapthang = new System.Windows.Forms.CheckBox();
            this.cb_codilam = new System.Windows.Forms.CheckBox();
            this.cbb_manv = new System.Windows.Forms.ComboBox();
            this.tb_maphong = new DevExpress.XtraEditors.TextEdit();
            this.btn_search = new System.Windows.Forms.Button();
            this.lb_outdays = new DevExpress.XtraEditors.LabelControl();
            this.dtime_outday = new System.Windows.Forms.DateTimePicker();
            this.btn_addoutdays = new System.Windows.Forms.Button();
            this.listb_outdays = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.tb_loaicv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tencv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_diadiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_maphong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Insert
            // 
            this.btn_Insert.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.Appearance.Options.UseFont = true;
            this.btn_Insert.Location = new System.Drawing.Point(196, 246);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(87, 28);
            this.btn_Insert.TabIndex = 7;
            this.btn_Insert.Text = "Thêm Mới";
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Enabled = false;
            this.btn_Update.Location = new System.Drawing.Point(324, 246);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(87, 28);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Cập Nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dtime_ngay
            // 
            this.dtime_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_ngay.Location = new System.Drawing.Point(514, 82);
            this.dtime_ngay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtime_ngay.Name = "dtime_ngay";
            this.dtime_ngay.Size = new System.Drawing.Size(196, 23);
            this.dtime_ngay.TabIndex = 3;
            this.dtime_ngay.Value = new System.DateTime(2015, 5, 27, 17, 44, 44, 0);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(457, 246);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(87, 28);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Location = new System.Drawing.Point(586, 246);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(87, 28);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tb_loaicv
            // 
            this.tb_loaicv.Location = new System.Drawing.Point(196, 126);
            this.tb_loaicv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_loaicv.Name = "tb_loaicv";
            this.tb_loaicv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_loaicv.Properties.Appearance.Options.UseFont = true;
            this.tb_loaicv.Size = new System.Drawing.Size(195, 22);
            this.tb_loaicv.TabIndex = 4;
            // 
            // tb_tencv
            // 
            this.tb_tencv.Location = new System.Drawing.Point(196, 84);
            this.tb_tencv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_tencv.Name = "tb_tencv";
            this.tb_tencv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tencv.Properties.Appearance.Options.UseFont = true;
            this.tb_tencv.Size = new System.Drawing.Size(195, 22);
            this.tb_tencv.TabIndex = 2;
            // 
            // lb_loaicv
            // 
            this.lb_loaicv.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loaicv.Location = new System.Drawing.Point(101, 129);
            this.lb_loaicv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_loaicv.Name = "lb_loaicv";
            this.lb_loaicv.Size = new System.Drawing.Size(89, 16);
            this.lb_loaicv.TabIndex = 96;
            this.lb_loaicv.Text = "Loại công việc :";
            // 
            // lb_tencv
            // 
            this.lb_tencv.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tencv.Location = new System.Drawing.Point(103, 87);
            this.lb_tencv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_tencv.Name = "lb_tencv";
            this.lb_tencv.Size = new System.Drawing.Size(88, 16);
            this.lb_tencv.TabIndex = 95;
            this.lb_tencv.Text = "Tên công việc :";
            // 
            // lb_ngay
            // 
            this.lb_ngay.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngay.Location = new System.Drawing.Point(457, 87);
            this.lb_ngay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_ngay.Name = "lb_ngay";
            this.lb_ngay.Size = new System.Drawing.Size(37, 16);
            this.lb_ngay.TabIndex = 93;
            this.lb_ngay.Text = "Ngày :";
            // 
            // lb_Hoten
            // 
            this.lb_Hoten.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hoten.Location = new System.Drawing.Point(106, 41);
            this.lb_Hoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_Hoten.Name = "lb_Hoten";
            this.lb_Hoten.Size = new System.Drawing.Size(85, 16);
            this.lb_Hoten.TabIndex = 89;
            this.lb_Hoten.Text = "Mã nhân viên :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 300);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 199);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lb_phong
            // 
            this.lb_phong.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phong.Location = new System.Drawing.Point(451, 47);
            this.lb_phong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_phong.Name = "lb_phong";
            this.lb_phong.Size = new System.Drawing.Size(44, 16);
            this.lb_phong.TabIndex = 99;
            this.lb_phong.Text = "Phòng :";
            // 
            // lb_thoigian
            // 
            this.lb_thoigian.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thoigian.Location = new System.Drawing.Point(432, 129);
            this.lb_thoigian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_thoigian.Name = "lb_thoigian";
            this.lb_thoigian.Size = new System.Drawing.Size(62, 16);
            this.lb_thoigian.TabIndex = 93;
            this.lb_thoigian.Text = "Thời gian :";
            // 
            // dtime_thoigian
            // 
            this.dtime_thoigian.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtime_thoigian.Location = new System.Drawing.Point(513, 124);
            this.dtime_thoigian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtime_thoigian.Name = "dtime_thoigian";
            this.dtime_thoigian.Size = new System.Drawing.Size(196, 23);
            this.dtime_thoigian.TabIndex = 5;
            this.dtime_thoigian.Value = new System.DateTime(2015, 5, 20, 0, 0, 0, 0);
            // 
            // lb_diadiem
            // 
            this.lb_diadiem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diadiem.Location = new System.Drawing.Point(130, 172);
            this.lb_diadiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_diadiem.Name = "lb_diadiem";
            this.lb_diadiem.Size = new System.Drawing.Size(60, 16);
            this.lb_diadiem.TabIndex = 96;
            this.lb_diadiem.Text = "Địa điểm :";
            // 
            // tb_diadiem
            // 
            this.tb_diadiem.Location = new System.Drawing.Point(196, 169);
            this.tb_diadiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_diadiem.Name = "tb_diadiem";
            this.tb_diadiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_diadiem.Properties.Appearance.Options.UseFont = true;
            this.tb_diadiem.Size = new System.Drawing.Size(514, 22);
            this.tb_diadiem.TabIndex = 6;
            // 
            // cb_laptuan
            // 
            this.cb_laptuan.AutoSize = true;
            this.cb_laptuan.Location = new System.Drawing.Point(924, 42);
            this.cb_laptuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_laptuan.Name = "cb_laptuan";
            this.cb_laptuan.Size = new System.Drawing.Size(108, 20);
            this.cb_laptuan.TabIndex = 100;
            this.cb_laptuan.Text = "Lặp hàng tuần";
            this.cb_laptuan.UseVisualStyleBackColor = true;
            // 
            // cb_lapthang
            // 
            this.cb_lapthang.AutoSize = true;
            this.cb_lapthang.Location = new System.Drawing.Point(924, 81);
            this.cb_lapthang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_lapthang.Name = "cb_lapthang";
            this.cb_lapthang.Size = new System.Drawing.Size(115, 20);
            this.cb_lapthang.TabIndex = 100;
            this.cb_lapthang.Text = "Lặp hàng tháng";
            this.cb_lapthang.UseVisualStyleBackColor = true;
            // 
            // cb_codilam
            // 
            this.cb_codilam.AutoSize = true;
            this.cb_codilam.Checked = true;
            this.cb_codilam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_codilam.Location = new System.Drawing.Point(196, 210);
            this.cb_codilam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_codilam.Name = "cb_codilam";
            this.cb_codilam.Size = new System.Drawing.Size(81, 20);
            this.cb_codilam.TabIndex = 101;
            this.cb_codilam.Text = "Có đi làm";
            this.cb_codilam.UseVisualStyleBackColor = true;
            // 
            // cbb_manv
            // 
            this.cbb_manv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_manv.Items.AddRange(new object[] {
            ""});
            this.cbb_manv.Location = new System.Drawing.Point(196, 38);
            this.cbb_manv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_manv.Name = "cbb_manv";
            this.cbb_manv.Size = new System.Drawing.Size(195, 24);
            this.cbb_manv.TabIndex = 1;
            this.cbb_manv.SelectedIndexChanged += new System.EventHandler(this.cbb_manv_SelectedIndexChanged);
            this.cbb_manv.Click += new System.EventHandler(this.cbb_manv_Click);
            // 
            // tb_maphong
            // 
            this.tb_maphong.Enabled = false;
            this.tb_maphong.Location = new System.Drawing.Point(514, 43);
            this.tb_maphong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_maphong.Name = "tb_maphong";
            this.tb_maphong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_maphong.Properties.Appearance.Options.UseFont = true;
            this.tb_maphong.Size = new System.Drawing.Size(196, 22);
            this.tb_maphong.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(725, 82);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(43, 23);
            this.btn_search.TabIndex = 102;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lb_outdays
            // 
            this.lb_outdays.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_outdays.Location = new System.Drawing.Point(786, 129);
            this.lb_outdays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_outdays.Name = "lb_outdays";
            this.lb_outdays.Size = new System.Drawing.Size(97, 16);
            this.lb_outdays.TabIndex = 99;
            this.lb_outdays.Text = "Tránh các ngày :";
            // 
            // dtime_outday
            // 
            this.dtime_outday.CustomFormat = "true";
            this.dtime_outday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtime_outday.Location = new System.Drawing.Point(889, 124);
            this.dtime_outday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtime_outday.Name = "dtime_outday";
            this.dtime_outday.Size = new System.Drawing.Size(125, 23);
            this.dtime_outday.TabIndex = 3;
            this.dtime_outday.Value = new System.DateTime(2015, 5, 27, 17, 44, 44, 0);
            // 
            // btn_addoutdays
            // 
            this.btn_addoutdays.Location = new System.Drawing.Point(1022, 123);
            this.btn_addoutdays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addoutdays.Name = "btn_addoutdays";
            this.btn_addoutdays.Size = new System.Drawing.Size(31, 28);
            this.btn_addoutdays.TabIndex = 102;
            this.btn_addoutdays.Text = "+";
            this.btn_addoutdays.UseVisualStyleBackColor = true;
            this.btn_addoutdays.Click += new System.EventHandler(this.btn_addoutdays_Click);
            // 
            // listb_outdays
            // 
            this.listb_outdays.FormattingEnabled = true;
            this.listb_outdays.ItemHeight = 16;
            this.listb_outdays.Location = new System.Drawing.Point(787, 156);
            this.listb_outdays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listb_outdays.Name = "listb_outdays";
            this.listb_outdays.Size = new System.Drawing.Size(265, 116);
            this.listb_outdays.TabIndex = 103;
            this.listb_outdays.SelectedIndexChanged += new System.EventHandler(this.listb_outdays_SelectedIndexChanged);
            this.listb_outdays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listb_outdays_KeyPress);
            // 
            // frm_QLLich
            // 
            this.AllowMdiBar = true;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 500);
            this.Controls.Add(this.listb_outdays);
            this.Controls.Add(this.btn_addoutdays);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cb_codilam);
            this.Controls.Add(this.cb_lapthang);
            this.Controls.Add(this.cb_laptuan);
            this.Controls.Add(this.cbb_manv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.dtime_thoigian);
            this.Controls.Add(this.dtime_outday);
            this.Controls.Add(this.dtime_ngay);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.tb_diadiem);
            this.Controls.Add(this.tb_loaicv);
            this.Controls.Add(this.tb_maphong);
            this.Controls.Add(this.tb_tencv);
            this.Controls.Add(this.lb_diadiem);
            this.Controls.Add(this.lb_outdays);
            this.Controls.Add(this.lb_phong);
            this.Controls.Add(this.lb_loaicv);
            this.Controls.Add(this.lb_tencv);
            this.Controls.Add(this.lb_thoigian);
            this.Controls.Add(this.lb_ngay);
            this.Controls.Add(this.lb_Hoten);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_QLLich";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_QLLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_loaicv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tencv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_diadiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_maphong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Insert;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.TextEdit tb_loaicv;
        private DevExpress.XtraEditors.TextEdit tb_tencv;
        private DevExpress.XtraEditors.LabelControl lb_loaicv;
        private DevExpress.XtraEditors.LabelControl lb_tencv;
        private DevExpress.XtraEditors.LabelControl lb_ngay;
        private DevExpress.XtraEditors.LabelControl lb_Hoten;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.LabelControl lb_phong;
        private DevExpress.XtraEditors.LabelControl lb_thoigian;
        private System.Windows.Forms.DateTimePicker dtime_thoigian;
        private DevExpress.XtraEditors.LabelControl lb_diadiem;
        private DevExpress.XtraEditors.TextEdit tb_diadiem;
        private System.Windows.Forms.CheckBox cb_laptuan;
        private System.Windows.Forms.CheckBox cb_lapthang;
        private System.Windows.Forms.CheckBox cb_codilam;
        private System.Windows.Forms.ComboBox cbb_manv;
        private System.Windows.Forms.DateTimePicker dtime_ngay;
        private DevExpress.XtraEditors.TextEdit tb_maphong;
        private System.Windows.Forms.Button btn_search;
        private DevExpress.XtraEditors.LabelControl lb_outdays;
        private System.Windows.Forms.DateTimePicker dtime_outday;
        private System.Windows.Forms.Button btn_addoutdays;
        private System.Windows.Forms.ListBox listb_outdays;


    }
}