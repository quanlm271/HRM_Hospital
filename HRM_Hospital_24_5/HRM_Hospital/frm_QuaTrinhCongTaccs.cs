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
    public partial class frm_QuaTrinhCongTaccs : DevExpress.XtraEditors.XtraForm
    {
        String MaNV;
        QUATRINHCONGTACBLL qtct = new QUATRINHCONGTACBLL();
        PHONGKHOABLL phongkhoa = new PHONGKHOABLL();
        public frm_QuaTrinhCongTaccs(string MaNV)
        {
            this.MaNV = MaNV;
            InitializeComponent();
            btn_Capnhat.Enabled = false;
            btn_Xoa.Enabled = false;
            Refresh_GridView();
            tb_MaPHG.Text = "(Nope)";
            foreach (string ma in phongkhoa.LayMaPHG())
            {
                tb_MaPHG.Items.Add(ma);
            }
            Format_Time();
        }
        public void Refresh_GridView()
        {
            this.dataGridView1.DataSource = qtct.Get_QTCT(this.MaNV);
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
            btn_Themmoi.Enabled = true;
            btn_Capnhat.Enabled = false;
            btn_Xoa.Enabled = false;
            tb_MaQTCT.Enabled = true;
            tb_MaQTCT.Text = null;
            tb_Chucvu.Text = null;
            tb_MaPHG.Text = "(Nope)";
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
          
            if (tb_MaPHG.Text.Trim().Length == 0)
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
            btn_Themmoi.Enabled = false;
            btn_Capnhat.Enabled = true;
            btn_Xoa.Enabled = true;
            tb_MaQTCT.Enabled = false;
            int r = e.RowIndex;
            if (r < 0)
                return;
            if (!this.dataGridView1.Rows[r].IsNewRow)
            {
                this.dataGridView1.Rows[r].Selected = true;
                tb_MaQTCT.Text = this.dataGridView1.Rows[r].Cells["cl_Quatrinh"].Value.ToString();
                tb_MaPHG.Text = this.dataGridView1.Rows[r].Cells["cl_Maphong"].Value.ToString();
                tb_Chucvu.Text = this.dataGridView1.Rows[r].Cells["cl_Chucvu"].Value.ToString();
                tb_Chucdanh.Text = this.dataGridView1.Rows[r].Cells["cl_Chucdanh"].Value.ToString();
                dtime_Tungay.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["cl_Tungay"].Value);
                dtime_Denngay.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["cl_Denngay"].Value);
            }
        }

        private void btn_Themmoi_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
                return;
            if (qtct.KiemTraMaTrung(tb_MaQTCT.Text))
            {
                MessageBox.Show("Mã quá trình công tác đã tồn tại,", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return;
            }
            qtct.Them(tb_MaQTCT.Text, this.MaNV,tb_MaPHG.Text, dtime_Tungay.Value, dtime_Denngay.Value,tb_Chucdanh.Text,tb_Chucvu.Text);
            Refresh_GridView();
            Clear_Insert();
        }

        private void btn_Capnhat_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
            {
                return;
            }
            qtct.Capnhat(tb_MaQTCT.Text,this.MaNV, tb_MaPHG.Text, dtime_Tungay.Value, dtime_Denngay.Value, tb_Chucdanh.Text, tb_Chucvu.Text);
            Refresh_GridView();
            Clear_Insert();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            qtct.Xoa(tb_MaQTCT.Text);
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