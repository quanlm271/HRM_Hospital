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
        string MaNV;
        NHANVIENBLL bll_NV = new NHANVIENBLL();
        public frm_QLNhanVien()
        {
            InitializeComponent();
            btn_Capnhat.Enabled = false;
            btn_Thannhan.Enabled = false;
            btn_Congtac.Enabled = false;
            btn_Xoa.Enabled = false;
            Refresh_GridView();
            Format_Time();
        }
    

        public void Refresh_GridView()
        {
            this.dataGridView1.DataSource = bll_NV.LayTatCa();
        }

        public void Format_Time()
        {
            dtime_Ngaysinh.Format = DateTimePickerFormat.Custom;
            dtime_Ngaysinh.CustomFormat = "dd/MM/yyyy";
        }

        private void Clear_Insert()
        {
            btn_Themmoi.Enabled = true;
            btn_Capnhat.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Thannhan.Enabled = false;
            tb_Hoten.Text = null;
            tb_Chucvu.Text = null;
            tb_CMND.Text = null;
            tb_Quequan.Text = null;
            btn_Congtac.Enabled = false;
            cb_Phai.Checked = false;
            dtime_Ngaysinh.Value = DateTime.Now;
        }

        private bool KiemTraDuLieuNhap()
        {
            if (tb_Hoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ tên không được để trống,", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (tb_CMND.Text.Trim().Length < 9)
            {
                MessageBox.Show("Số chứng minh nhân dân chưa chính xác,", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (tb_Quequan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Địa chỉ không được để trống,", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (tb_Chucvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chức vụ không được để trống,", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
           if (DateTime.Now.Year - dtime_Ngaysinh.Value.Year < 18)
            {
                MessageBox.Show("Ngày sinh chưa chính xác", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
           return true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            bll_NV.Xoa(this.MaNV);
            Refresh_GridView();
            Clear_Insert();
        }

        private void btn_Themmoi_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
                return;
            this.MaNV = this.bll_NV.set_MANV();
            bll_NV.Them(this.MaNV, tb_Hoten.Text, tb_CMND.Text, cb_Phai.Checked == true ? true : false,dtime_Ngaysinh.Value,tb_Quequan.Text,tb_Chucvu.Text);
            Refresh_GridView();
            Clear_Insert();
        }

        private void btn_Capnhat_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
            {
                return;
            }
            bll_NV.Capnhat(this.MaNV, tb_Hoten.Text, tb_CMND.Text, cb_Phai.Checked == true ? true : false, dtime_Ngaysinh.Value, tb_Quequan.Text, tb_Chucvu.Text);
            Refresh_GridView();
            Clear_Insert();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Thannhan.Enabled = true;
            btn_Themmoi.Enabled = false;
            btn_Capnhat.Enabled = true;
            btn_Congtac.Enabled = true;
            btn_Xoa.Enabled = true;
            int r = e.RowIndex;
            if (r < 0)
                return;
            if (!this.dataGridView1.Rows[r].IsNewRow)
            {
                this.dataGridView1.Rows[r].Selected = true;
               this.MaNV = this.dataGridView1.Rows[r].Cells["cl_MaNV"].Value.ToString();
                tb_Hoten.Text = this.dataGridView1.Rows[r].Cells["cl_Hoten"].Value.ToString();
                tb_CMND.Text = this.dataGridView1.Rows[r].Cells["cl_CMND"].Value.ToString();
                tb_Chucvu.Text = this.dataGridView1.Rows[r].Cells["cl_Quequan"].Value.ToString();
                tb_Quequan.Text = this.dataGridView1.Rows[r].Cells["cl_Chucvu"].Value.ToString();
                cb_Phai.Checked = (bool)dataGridView1.Rows[r].Cells["cl_Gioitinh"].Value;
                dtime_Ngaysinh.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["cl_Ngaysinh"].Value);
            }
        }

        private void tb_MaNV_KeyPress(object sender, KeyPressEventArgs e)
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
            frm_NhanThan frm = new frm_NhanThan(this.MaNV);
            XtraTabPage tabpage = new XtraTabPage();
            tabpage.Text = "Nhân Thân";
            this.frm_Main.Add_TabPage(frm, tabpage);
        }

        private void btn_Congtac_Click(object sender, EventArgs e)
        {
            this.frm_Main.tab_index++;
            frm_QuaTrinhCongTaccs frm = new frm_QuaTrinhCongTaccs(this.MaNV);
            XtraTabPage tabpage = new XtraTabPage();
            tabpage.Text = "Quá Trình Công Tác";
            this.frm_Main.Add_TabPage(frm, tabpage);
        }
    }
}