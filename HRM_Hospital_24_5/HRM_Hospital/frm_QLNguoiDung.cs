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
        TAIKHOANBLL taikhoan = new TAIKHOANBLL();
        NHANVIENBLL nhanvien = new NHANVIENBLL();
        public frm_QLNguoiDung()
        {
            
            InitializeComponent();
            btn_Capnhat.Enabled = false;
            btn_Xoa.Enabled = false;
            Refresh_GridView();
            tb_MaNV.Text = "(Nope)";
            foreach(string str in nhanvien.LayMaNV())
            {
                tb_MaNV.Items.Add(str);
            }
            
        }

        public void Refresh_GridView()
        {
            this.dataGridView1.DataSource = taikhoan.LayTatCa();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_MaNV.Enabled = false;
            btn_Themmoi.Enabled = false;
            btn_Capnhat.Enabled = true;
            btn_Xoa.Enabled = true;
            int r = e.RowIndex;
            if (r < 0)
                return;
            if (!this.dataGridView1.Rows[r].IsNewRow)
            {
                this.dataGridView1.Rows[r].Selected = true;
                tb_MaNV.Text = this.dataGridView1.Rows[r].Cells["MANV"].Value.ToString();
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
            if (tb_MaNV.Text == "(Nope)")
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
            if (taikhoan.KiemTraMaTrung(tb_TDN.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return;
            }
            if (taikhoan.KiemTraNV(tb_MaNV.Text))
            {
                MessageBox.Show("Một tài khoản tương ứng với một nhân viên", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return;
            }
            taikhoan.Them(tb_TDN.Text, tb_MaNV.Text, tb_matkhau.Text, cb_Admin.Checked == true ? true : false);      
            Refresh_GridView();
        }

        public void Clear_Insert()
        {
            tb_MaNV.Enabled = true;
            btn_Themmoi.Enabled = true;
            btn_Capnhat.Enabled = false;
            btn_Xoa.Enabled = false;
            tb_MaNV.Text = "(Nope)";
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
            taikhoan.Xoa(tb_TDN.Text);
            Refresh_GridView();
            Clear_Insert();
        }

        private void btn_Capnhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuNhap())
                return;
            taikhoan.Capnhat(tb_TDN.Text, tb_MaNV.Text, tb_matkhau.Text, cb_Admin.Checked == true ? true : false);
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