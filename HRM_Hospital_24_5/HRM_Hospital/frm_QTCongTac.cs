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
    public partial class frm_QTCongTac : DevExpress.XtraEditors.XtraForm
    {
        String MANV;
        QTCONGTACBLL qtct = new QTCONGTACBLL();
        PHONGKHOABLL phongkhoa = new PHONGKHOABLL();
        public frm_QTCongTac(string MANV)
        {
            this.MANV = MANV;
            InitializeComponent();
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
            Refresh_GridView();
            tb_phong.Text = "(Nope)";
            foreach (string ma in phongkhoa.get_MaPHG())
            {
                tb_phong.Items.Add(ma);
            }
            Format_Time();
        }
        public void Refresh_GridView()
        {
            this.dataGridView1.DataSource = qtct.get_QTCT(this.MANV);
        }

        public void Format_Time()
        {
            dtime_Tungay.Format = DateTimePickerFormat.Custom;
            dtime_Tungay.CustomFormat = "dd/MM/yyyy";
            dtime_Denngay.Format = DateTimePickerFormat.Custom;
            dtime_Denngay.CustomFormat = "dd/MM/yyyy";
        }
        private void Clear_Insert()
        {
            btn_Insertmoi.Enabled = true;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
            tb_MaQTCT.Enabled = true;
            tb_MaQTCT.Text = null;
            tb_Chucvu.Text = null;
            tb_phong.Text = "(Nope)";
            tb_Chucdanh.Text = null;
            dtime_Tungay.Value = dtime_Denngay.Value = DateTime.Now;
        }

        private bool KiemTraDuLieuNhap()
        {
            if (tb_MaQTCT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã quá trình công tác không được để trống,", "Thông Báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return false;
            }
          
            if (tb_phong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã phòng không được để trống", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (tb_Chucdanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chức danh không được để trống,", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (tb_Chucvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chức vụ không được để trống,", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (dtime_Denngay.Value < dtime_Tungay.Value)
            {
                MessageBox.Show("Ngày đến chưa chính xác", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Insertmoi.Enabled = false;
            btn_Update.Enabled = true;
            btn_Delete.Enabled = true;
            tb_MaQTCT.Enabled = false;
            int r = e.RowIndex;
            if (r < 0)
                return;
            if (!this.dataGridView1.Rows[r].IsNewRow)
            {
                this.dataGridView1.Rows[r].Selected = true;
                tb_MaQTCT.Text = this.dataGridView1.Rows[r].Cells["cl_Quatrinh"].Value.ToString();
                tb_phong.Text = this.dataGridView1.Rows[r].Cells["cl_Maphong"].Value.ToString();
                tb_Chucvu.Text = this.dataGridView1.Rows[r].Cells["cl_Chucvu"].Value.ToString();
                tb_Chucdanh.Text = this.dataGridView1.Rows[r].Cells["cl_Chucdanh"].Value.ToString();
                dtime_Tungay.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["cl_Tungay"].Value);
                dtime_Denngay.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["cl_Denngay"].Value);
            }
        }

        private void btn_Insertmoi_Click(object sender, EventArgs e)
        {
            qtct.Insert(tb_MaQTCT.Text, this.MANV,tb_phong.Text, dtime_Tungay.Value, dtime_Denngay.Value,tb_Chucdanh.Text,tb_Chucvu.Text);
            Refresh_GridView();
            Clear_Insert();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
            {
                return;
            }
            qtct.Update(tb_MaQTCT.Text,this.MANV, tb_phong.Text, dtime_Tungay.Value, dtime_Denngay.Value, tb_Chucdanh.Text, tb_Chucvu.Text);
            Refresh_GridView();
            Clear_Insert();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            qtct.Delete(tb_MaQTCT.Text);
            Refresh_GridView();
            Clear_Insert();
        }

        private void tb_MaTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == 32);
        }

        private void tb_Nghenghiep_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar >= 33 && e.KeyChar <= 64);
        }

        private void tb_Congtac_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar >= 33 && e.KeyChar <= 64);
        }

        private void tb_Quanhe_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == 32);
        }


     
    }
}