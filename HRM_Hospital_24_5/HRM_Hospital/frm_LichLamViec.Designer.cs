namespace HRM_Hospital
{
    partial class frm_LichLamViec
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
            this.datePK_ngay = new System.Windows.Forms.DateTimePicker();
            this.btn_xem = new DevExpress.XtraEditors.SimpleButton();
            this.labelngaythangnam = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // datePK_ngay
            // 
            this.datePK_ngay.AccessibleDescription = "";
            this.datePK_ngay.Location = new System.Drawing.Point(79, 9);
            this.datePK_ngay.Name = "datePK_ngay";
            this.datePK_ngay.Size = new System.Drawing.Size(211, 21);
            this.datePK_ngay.TabIndex = 16;
            // 
            // btn_xem
            // 
            this.btn_xem.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xem.Appearance.Options.UseFont = true;
            this.btn_xem.Location = new System.Drawing.Point(310, 8);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(71, 24);
            this.btn_xem.TabIndex = 15;
            this.btn_xem.Text = "Xem";
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // labelngaythangnam
            // 
            this.labelngaythangnam.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelngaythangnam.Location = new System.Drawing.Point(13, 13);
            this.labelngaythangnam.Margin = new System.Windows.Forms.Padding(4);
            this.labelngaythangnam.Name = "labelngaythangnam";
            this.labelngaythangnam.Size = new System.Drawing.Size(59, 13);
            this.labelngaythangnam.TabIndex = 14;
            this.labelngaythangnam.Text = "Chọn ngày :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // frm_LichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 335);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.datePK_ngay);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.labelngaythangnam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_LichLamViec";
            this.Text = "Lịch Làm Việc";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePK_ngay;
        private DevExpress.XtraEditors.SimpleButton btn_xem;
        private DevExpress.XtraEditors.LabelControl labelngaythangnam;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}