using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HRM_Hospital.BLL;
namespace HRM_Hospital
{
    public partial class frm_PhongKhoa : DevExpress.XtraEditors.XtraForm
    {
        PHONGKHOABLL bll_phongkhoa = new PHONGKHOABLL();
        string MAPHG;
        public frm_PhongKhoa()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = bll_phongkhoa.get_AllRecord();
        }

        private bool KiemTraDuLieuNhap()
        {
            if (this.tb_tenphong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên phòng không được để trống", "Thông Báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return false;
            }
            if (this.tb_khoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên khối không được để trống", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void Clear_Insert()
        {
            tb_tenphong.ResetText();
            this.tb_khoi.ResetText();
            this.btn_Insert.Enabled = true;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (this.KiemTraDuLieuNhap())
                bll_phongkhoa.Insert(bll_phongkhoa.set_MAPHG(), this.tb_tenphong.Text, this.tb_khoi.Text);
            this.Clear_Insert();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (this.KiemTraDuLieuNhap())
                bll_phongkhoa.Update(this.MAPHG, this.tb_tenphong.Text, this.tb_khoi.Text);
            this.Clear_Insert();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btn_Insert.Enabled = false;
            int r = e.RowIndex;
            if (r < 0)
                return;
            if (!this.dataGridView1.Rows[r].IsNewRow)
            {
                this.dataGridView1.Rows[r].Selected = true;
                this.MAPHG = this.dataGridView1.Rows[r].Cells["MAPHG"].Value.ToString().Trim();
                this.tb_tenphong.Text = this.dataGridView1.Rows[r].Cells["TENPHG"].Value.ToString().Trim();
                this.tb_khoi.Text = this.dataGridView1.Rows[r].Cells["KHOI"].Value.ToString();
            }
        }
    }
}