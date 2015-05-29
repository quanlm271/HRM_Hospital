namespace HRM_Hospital
{
    partial class frm_PhongKhoa
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
            this.tb_tenphong = new DevExpress.XtraEditors.TextEdit();
            this.tb_khoi = new DevExpress.XtraEditors.TextEdit();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Insert = new DevExpress.XtraEditors.SimpleButton();
            this.lb_tenphong = new DevExpress.XtraEditors.LabelControl();
            this.lb_khoi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tenphong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_khoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_tenphong
            // 
            this.tb_tenphong.Location = new System.Drawing.Point(140, 55);
            this.tb_tenphong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_tenphong.Name = "tb_tenphong";
            this.tb_tenphong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenphong.Properties.Appearance.Options.UseFont = true;
            this.tb_tenphong.Size = new System.Drawing.Size(197, 22);
            this.tb_tenphong.TabIndex = 29;
            // 
            // tb_khoi
            // 
            this.tb_khoi.Location = new System.Drawing.Point(140, 102);
            this.tb_khoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_khoi.Name = "tb_khoi";
            this.tb_khoi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_khoi.Properties.Appearance.Options.UseFont = true;
            this.tb_khoi.Size = new System.Drawing.Size(197, 22);
            this.tb_khoi.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 224);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(904, 210);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Location = new System.Drawing.Point(250, 170);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(87, 28);
            this.btn_Update.TabIndex = 33;
            this.btn_Update.Text = "Cập Nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.Appearance.Options.UseFont = true;
            this.btn_Insert.Location = new System.Drawing.Point(140, 170);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(87, 28);
            this.btn_Insert.TabIndex = 32;
            this.btn_Insert.Text = "Thêm Mới";
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // lb_tenphong
            // 
            this.lb_tenphong.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenphong.Location = new System.Drawing.Point(14, 59);
            this.lb_tenphong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_tenphong.Name = "lb_tenphong";
            this.lb_tenphong.Size = new System.Drawing.Size(98, 16);
            this.lb_tenphong.TabIndex = 96;
            this.lb_tenphong.Text = "Tên Phòng Khoa:";
            // 
            // lb_khoi
            // 
            this.lb_khoi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_khoi.Location = new System.Drawing.Point(84, 106);
            this.lb_khoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_khoi.Name = "lb_khoi";
            this.lb_khoi.Size = new System.Drawing.Size(33, 16);
            this.lb_khoi.TabIndex = 96;
            this.lb_khoi.Text = "Khối :";
            // 
            // frm_PhongKhoa
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 434);
            this.Controls.Add(this.lb_khoi);
            this.Controls.Add(this.lb_tenphong);
            this.Controls.Add(this.tb_tenphong);
            this.Controls.Add(this.tb_khoi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_PhongKhoa";
            this.Text = "frm_PhongKhoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tb_tenphong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_khoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tb_tenphong;
        private DevExpress.XtraEditors.TextEdit tb_khoi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Insert;
        private DevExpress.XtraEditors.LabelControl lb_tenphong;
        private DevExpress.XtraEditors.LabelControl lb_khoi;
    }
}