namespace HRM_Hospital
{
    partial class frm_BangCC
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
            this.tb_workdays = new DevExpress.XtraEditors.TextEdit();
            this.tb_countoffdays = new DevExpress.XtraEditors.TextEdit();
            this.lb_countoffdays = new DevExpress.XtraEditors.LabelControl();
            this.lb_workdays = new DevExpress.XtraEditors.LabelControl();
            this.lb_manv = new DevExpress.XtraEditors.LabelControl();
            this.lb_offdays = new DevExpress.XtraEditors.LabelControl();
            this.tb_offdays = new System.Windows.Forms.TextBox();
            this.btn_updateMonth_person = new System.Windows.Forms.Button();
            this.lb_title = new DevExpress.XtraEditors.LabelControl();
            this.ccb_manv = new System.Windows.Forms.ComboBox();
            this.btn_updateMonth_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_workdays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_countoffdays.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 245);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(891, 156);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.Visible = false;
            // 
            // tb_workdays
            // 
            this.tb_workdays.Enabled = false;
            this.tb_workdays.Location = new System.Drawing.Point(216, 101);
            this.tb_workdays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_workdays.Name = "tb_workdays";
            this.tb_workdays.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_workdays.Properties.Appearance.Options.UseFont = true;
            this.tb_workdays.Size = new System.Drawing.Size(153, 22);
            this.tb_workdays.TabIndex = 101;
            // 
            // tb_countoffdays
            // 
            this.tb_countoffdays.Enabled = false;
            this.tb_countoffdays.Location = new System.Drawing.Point(216, 140);
            this.tb_countoffdays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_countoffdays.Name = "tb_countoffdays";
            this.tb_countoffdays.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_countoffdays.Properties.Appearance.Options.UseFont = true;
            this.tb_countoffdays.Size = new System.Drawing.Size(153, 22);
            this.tb_countoffdays.TabIndex = 102;
            // 
            // lb_countoffdays
            // 
            this.lb_countoffdays.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_countoffdays.Location = new System.Drawing.Point(82, 143);
            this.lb_countoffdays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_countoffdays.Name = "lb_countoffdays";
            this.lb_countoffdays.Size = new System.Drawing.Size(114, 16);
            this.lb_countoffdays.TabIndex = 105;
            this.lb_countoffdays.Text = "Tổng số ngày nghỉ :\r\n";
            // 
            // lb_workdays
            // 
            this.lb_workdays.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_workdays.Location = new System.Drawing.Point(102, 104);
            this.lb_workdays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_workdays.Name = "lb_workdays";
            this.lb_workdays.Size = new System.Drawing.Size(94, 16);
            this.lb_workdays.TabIndex = 104;
            this.lb_workdays.Text = "Số ngày đi làm :";
            // 
            // lb_manv
            // 
            this.lb_manv.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_manv.Location = new System.Drawing.Point(111, 70);
            this.lb_manv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(85, 16);
            this.lb_manv.TabIndex = 103;
            this.lb_manv.Text = "Mã nhân viên :";
            // 
            // lb_offdays
            // 
            this.lb_offdays.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_offdays.Location = new System.Drawing.Point(534, 40);
            this.lb_offdays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_offdays.Name = "lb_offdays";
            this.lb_offdays.Size = new System.Drawing.Size(107, 16);
            this.lb_offdays.TabIndex = 105;
            this.lb_offdays.Text = "Các ngày đã nghỉ :";
            // 
            // tb_offdays
            // 
            this.tb_offdays.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_offdays.Location = new System.Drawing.Point(534, 64);
            this.tb_offdays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_offdays.Multiline = true;
            this.tb_offdays.Name = "tb_offdays";
            this.tb_offdays.ReadOnly = true;
            this.tb_offdays.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_offdays.Size = new System.Drawing.Size(280, 95);
            this.tb_offdays.TabIndex = 106;
            // 
            // btn_updateMonth_person
            // 
            this.btn_updateMonth_person.Enabled = false;
            this.btn_updateMonth_person.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateMonth_person.Location = new System.Drawing.Point(534, 180);
            this.btn_updateMonth_person.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_updateMonth_person.Name = "btn_updateMonth_person";
            this.btn_updateMonth_person.Size = new System.Drawing.Size(107, 47);
            this.btn_updateMonth_person.TabIndex = 107;
            this.btn_updateMonth_person.Text = "Cập nhật tháng hiện tại";
            this.btn_updateMonth_person.UseVisualStyleBackColor = true;
            this.btn_updateMonth_person.Visible = false;
            this.btn_updateMonth_person.Click += new System.EventHandler(this.btn_updateMonth_person_Click);
            // 
            // lb_title
            // 
            this.lb_title.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lb_title.Location = new System.Drawing.Point(24, 15);
            this.lb_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(215, 19);
            this.lb_title.TabIndex = 104;
            this.lb_title.Text = "BẢNG CHẤM CÔNG THÁNG : ";
            // 
            // ccb_manv
            // 
            this.ccb_manv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccb_manv.Enabled = false;
            this.ccb_manv.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccb_manv.ForeColor = System.Drawing.Color.Red;
            this.ccb_manv.FormattingEnabled = true;
            this.ccb_manv.Location = new System.Drawing.Point(216, 62);
            this.ccb_manv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ccb_manv.Name = "ccb_manv";
            this.ccb_manv.Size = new System.Drawing.Size(152, 24);
            this.ccb_manv.TabIndex = 108;
            this.ccb_manv.SelectedIndexChanged += new System.EventHandler(this.ccb_manv_SelectedIndexChanged);
            // 
            // btn_updateMonth_all
            // 
            this.btn_updateMonth_all.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateMonth_all.ForeColor = System.Drawing.Color.Red;
            this.btn_updateMonth_all.Location = new System.Drawing.Point(649, 180);
            this.btn_updateMonth_all.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_updateMonth_all.Name = "btn_updateMonth_all";
            this.btn_updateMonth_all.Size = new System.Drawing.Size(167, 47);
            this.btn_updateMonth_all.TabIndex = 107;
            this.btn_updateMonth_all.Text = "Cập nhật tháng hiện tại cho tất cả nhân viên\r\n";
            this.btn_updateMonth_all.UseVisualStyleBackColor = true;
            this.btn_updateMonth_all.Visible = false;
            this.btn_updateMonth_all.Click += new System.EventHandler(this.btn_updateMonth_all_Click);
            // 
            // frm_BangCC
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 401);
            this.Controls.Add(this.ccb_manv);
            this.Controls.Add(this.btn_updateMonth_all);
            this.Controls.Add(this.btn_updateMonth_person);
            this.Controls.Add(this.tb_offdays);
            this.Controls.Add(this.tb_workdays);
            this.Controls.Add(this.tb_countoffdays);
            this.Controls.Add(this.lb_offdays);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.lb_countoffdays);
            this.Controls.Add(this.lb_workdays);
            this.Controls.Add(this.lb_manv);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_BangCC";
            this.Text = "Lịch Làm Việc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_BangCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_workdays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_countoffdays.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.TextEdit tb_workdays;
        private DevExpress.XtraEditors.TextEdit tb_countoffdays;
        private DevExpress.XtraEditors.LabelControl lb_countoffdays;
        private DevExpress.XtraEditors.LabelControl lb_workdays;
        private DevExpress.XtraEditors.LabelControl lb_manv;
        private DevExpress.XtraEditors.LabelControl lb_offdays;
        private System.Windows.Forms.TextBox tb_offdays;
        private System.Windows.Forms.Button btn_updateMonth_person;
        private DevExpress.XtraEditors.LabelControl lb_title;
        private System.Windows.Forms.ComboBox ccb_manv;
        private System.Windows.Forms.Button btn_updateMonth_all;
    }
}