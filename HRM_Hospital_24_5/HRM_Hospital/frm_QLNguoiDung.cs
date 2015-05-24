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
    public partial class frm_QLNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        TAIKHOANBLL bll_taikhoan = new TAIKHOANBLL();
        public frm_QLNguoiDung()
        {
            
            InitializeComponent();
            btn_Capnhat.Enabled = false;
            btn_Xoa.Enabled = false;
            Refresh_GridView();
            cbb_MANV.Text = "(Nope)";
            var listMANV = bll_taikhoan.LayMANV();
            foreach (String str in listMANV)
                this.cbb_MANV.Items.Add(str);
         
        }

        public void Refresh_GridView()
        {
            this.dataGridView1.DataSource = bll_taikhoan.LayTatCa();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbb_MANV.Enabled = false;
            btn_Themmoi.Enabled = false;
            btn_Capnhat.Enabled = true;
            btn_Xoa.Enabled = true;
            int r = e.RowIndex;
            if (r < 0)
                return;
            if (!this.dataGridView1.Rows[r].IsNewRow)
            {
                this.dataGridView1.Rows[r].Selected = true;
                cbb_MANV.Text = this.dataGridView1.Rows[r].Cells["MANV"].Value.ToString();
                tb_TDN.Text = this.dataGridView1.Rows[r].Cells["TENDANGNHAP"].Value.ToString().Trim();
                tb_matkhau.Text = this.dataGridView1.Rows[r].Cells["MATKHAU"].Value.ToString();
                if (dataGridView1.Rows[r].Cells["QUYENTRUYCAP"].Value.ToString() == "True")
                {
                    cb_Admin.Checked = true;
                }
                else
                {
                    cb_Admin.Checked = false;
                }
            }
        }

        private bool KiemTraDuLieuNhap()
        {
            if (cbb_MANV.Text == "(Nope)")
            {
                MessageBox.Show("Mã nhân viên chưa được xác nhận", "Thông Báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return false;
            }
            if (tb_TDN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (tb_matkhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }  
            return true;
        }

        private void btn_Themmoi_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
                return;
            if (bll_taikhoan.KiemTraMaTrung(tb_TDN.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return;
            }
            if (bll_taikhoan.KiemTraNV(cbb_MANV.Text))
            {
                MessageBox.Show("Một tài khoản tương ứng với một nhân viên", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return;
            }
            bll_taikhoan.Them(tb_TDN.Text, cbb_MANV.Text, tb_matkhau.Text, cb_Admin.Checked == true ? true : false);      
            Refresh_GridView();
        }

        public void Clear_Insert()
        {
            cbb_MANV.Enabled = true;
            btn_Themmoi.Enabled = true;
            btn_Capnhat.Enabled = false;
            btn_Xoa.Enabled = false;
            cbb_MANV.Text = "(Nope)";
            tb_matkhau.Text = null;
            tb_TDN.Text = null;
            cb_Admin.Checked = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            bll_taikhoan.Xoa(this.cbb_MANV.Text);
            Refresh_GridView();
            Clear_Insert();
        }

        private void btn_Capnhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuNhap())
                return;
            bll_taikhoan.Capnhat(tb_TDN.Text, cbb_MANV.Text, tb_matkhau.Text, cb_Admin.Checked == true ? true : false);
            Refresh_GridView();
            Clear_Insert();
        }

        private void tb_TDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == 32);
        }

        private void tb_matkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == 32);
        }
    }
}