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
using DevExpress.XtraTab;
using HRM_Hospital.BLL;

namespace HRM_Hospital
{
    public partial class frm_QLNhanVien : DevExpress.XtraEditors.XtraForm 
    {
        public frm_Main frm_Main;
        string MANV, MABCC;
        NHANVIENBLL bll_nhanvien = new NHANVIENBLL();
        PHONGKHOABLL bll_phongkhoa = new PHONGKHOABLL();
        BANGCHAMCONGBLL bll_bchamcong = new BANGCHAMCONGBLL();
        public frm_QLNhanVien()
        {
            InitializeComponent();
            btn_Update.Enabled = false;
            btn_Thannhan.Enabled = false;
            btn_Congtac.Enabled = false;
            btn_Delete.Enabled = false;

            if (this.bll_phongkhoa.check_Empty())
                return;

            foreach (string str in this.bll_phongkhoa.get_MaPHG())
                this.ccb_phong.Items.Add(str);
            Refresh_GridView();
            Format_Time();
        }
    

        public void Refresh_GridView()
        {
            this.dataGridView1.DataSource = bll_nhanvien.get_AllRecord();
        }

        public void Format_Time()
        {
            dtime_Ngaysinh.Format = DateTimePickerFormat.Custom;
            dtime_Ngaysinh.CustomFormat = "dd/MM/yyyy";
        }

        private void Clear_Insert()
        {
            btn_Insert.Enabled = true;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Thannhan.Enabled = false;
            tb_Hoten.Text = null;
            tb_dchi.Text = null;
            tb_CMND.Text = null;
            tb_loainv.Text = null;
            this.tb_bac.ResetText();
            this.tb_ngach.ResetText();
            this.tb_tongiao.ResetText();
            this.tb_dantoc.ResetText();
            this.ccb_phong.SelectedIndex = -1;
            btn_Congtac.Enabled = false;
            cb_Phai.Checked = false;
            cb_gdlietsi.Checked = false;
            dtime_Ngaysinh.Value = DateTime.Now;
        }

        private bool KiemTraDuLieuNhap()
        {
            if (tb_Hoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ tên không được để trống.", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (DateTime.Now.Year - dtime_Ngaysinh.Value.Year < 18)
            {
                MessageBox.Show("Ngày sinh chưa chính xác.", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (tb_CMND.Text.Trim().Length < 9)
            {
                MessageBox.Show("Số chứng minh nhân dân chưa chính xác.", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (tb_dchi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Địa Chỉ không được để trống.", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
           
            if (tb_dantoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Dân tộc không được để trống.", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (tb_tongiao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tôn giáo không được để trống.", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (tb_ngach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nghạch không được để trống.", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (tb_bac.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bậc không được để trống.", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (tb_loainv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Loại không được để trống.", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (ccb_phong.Text == "")
            {
                MessageBox.Show("Phòng không được để trống.", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
           return true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Question", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            bll_nhanvien.Status = "";
            bll_nhanvien.onMinifrm = true;
            bll_nhanvien.Delete(MANV);
            Refresh_GridView();
            Clear_Insert();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
                return;
            this.MANV = this.bll_nhanvien.set_MANV();
            this.MABCC = this.bll_bchamcong.set_MABCC();
            //insert table BANGCC
            bll_bchamcong.Insert(this.MABCC, DateTime.Now.Month, this.ccb_phong.Text, 0);
            //insert table NHANVIEN
            bll_nhanvien.Insert(this.MANV, tb_Hoten.Text, dtime_Ngaysinh.Value.Date, this.cb_Phai.Checked,
                tb_CMND.Text, tb_dchi.Text, this.tb_dantoc.Text, this.tb_tongiao.Text,
                this.cb_gdlietsi.Checked, this.tb_ngach.Text, this.tb_bac.Text, tb_loainv.Text, this.MABCC);
            Refresh_GridView();
            Clear_Insert();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
            {
                return;
            }
            //Update MAPHONG BANGCC
            bll_bchamcong.Update_MAPHG(this.MABCC, this.ccb_phong.Text);
            //Update NHANVIEN
            bll_nhanvien.Update(this.MANV, tb_Hoten.Text, dtime_Ngaysinh.Value.Date, this.cb_Phai.Checked,
                tb_CMND.Text, tb_dchi.Text, this.tb_dantoc.Text, this.tb_tongiao.Text,
                this.cb_gdlietsi.Checked, this.tb_ngach.Text, this.tb_bac.Text, tb_loainv.Text);
            Refresh_GridView();
            Clear_Insert();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Thannhan.Enabled = true;
            btn_Insert.Enabled = false;
            btn_Update.Enabled = true;
            btn_Congtac.Enabled = true;
            btn_Delete.Enabled = true;
            int r = e.RowIndex;
            if (r < 0)
                return;
            if (!this.dataGridView1.Rows[r].IsNewRow)
            {
                this.dataGridView1.Rows[r].Selected = true;

                this.MANV = this.dataGridView1.Rows[r].Cells["MANV"].Value.ToString();
                this.MABCC = this.bll_nhanvien.get_MABCC(this.MANV);

                tb_Hoten.Text = this.dataGridView1.Rows[r].Cells["HOTENNV"].Value.ToString();
                tb_CMND.Text = this.dataGridView1.Rows[r].Cells["CMND"].Value.ToString();
                tb_loainv.Text = this.dataGridView1.Rows[r].Cells["LOAINV"].Value.ToString();
                tb_dchi.Text = this.dataGridView1.Rows[r].Cells["NOIOHIENTAI"].Value.ToString();
                cb_Phai.Checked = (bool)dataGridView1.Rows[r].Cells["PHAI"].Value;
                this.tb_bac.Text = this.dataGridView1.Rows[r].Cells["BAC"].Value.ToString();
                this.tb_ngach.Text = this.dataGridView1.Rows[r].Cells["NGACH"].Value.ToString();
                this.tb_bac.Text = this.dataGridView1.Rows[r].Cells["BAC"].Value.ToString();
                this.tb_tongiao.Text = this.dataGridView1.Rows[r].Cells["TONGIAO"].Value.ToString();
                this.tb_dantoc.Text = this.dataGridView1.Rows[r].Cells["DANTOC"].Value.ToString();
                dtime_Ngaysinh.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NGAYSINH"].Value);

                this.ccb_phong.Text = bll_bchamcong.get_BANGCC(
                                this.dataGridView1.Rows[r].Cells["MA_BANGCC"].Value.ToString()).FirstOrDefault().MAPHG;
            }
        }

        private void tb_MANV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == 32);
        }

        private void tb_Hoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar >= 33 && e.KeyChar <= 64);
        }

        private void tb_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb_Chucvu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar >= 33 && e.KeyChar <= 64);
        }

        private void tb_Diachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar >= 33 && e.KeyChar <= 64);
        }

        private void btn_Thannhan_Click(object sender, EventArgs e)
        {
            this.frm_Main.tab_index++;
            frm_NhanThan frm = new frm_NhanThan(this.MANV);
            XtraTabPage tabpage = new XtraTabPage();
            tabpage.Text = "Nhân Thân";
            this.frm_Main.Add_TabPage(frm, tabpage);
        }

        private void btn_Congtac_Click(object sender, EventArgs e)
        {
            this.frm_Main.tab_index++;
            frm_QTCongTac frm = new frm_QTCongTac(this.MANV);
            XtraTabPage tabpage = new XtraTabPage();
            tabpage.Text = "Quá Trình Công Tác";
            this.frm_Main.Add_TabPage(frm, tabpage);
        }
    }
}