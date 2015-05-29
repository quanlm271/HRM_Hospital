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
    public partial class frm_NhanThan : DevExpress.XtraEditors.XtraForm
    {
        THANNHANBLL bll_TN = new THANNHANBLL();
        COTNBLL bll_CTN = new COTNBLL();
        NHANVIENBLL bll_nhanvien = new NHANVIENBLL();
        String MANV, MaTN;
        public frm_NhanThan(string MANV)
        {
            InitializeComponent();
            
            this.MANV = MANV;
            this.lb_tennhanvien.Text += bll_nhanvien.get_TEN(MANV);
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
            Refresh_GridView();
            Format_Time();
         
        }

        public void Refresh_GridView()
        {
            
            this.dataGridView1.DataSource = bll_TN.get_ThanNhan(this.MANV);
        }

        public void Format_Time()
        {
            dtime_Ngaysinh.Format = DateTimePickerFormat.Custom;
            dtime_Ngaysinh.CustomFormat = "dd/MM/yyyy";
        }

        private void Clear_Insert()
        {
            btn_Insertmoi.Enabled = true;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
            tb_Hoten.Text = null;
            tb_Congtac.Text = null;
            tb_Quanhe.Text = null;
            tb_Nghenghiep.Text = null;
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
            if (tb_Quanhe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Quan hệ nhân dân chưa chính xác,", "Thông Báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            if (tb_Nghenghiep.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nghề nghiệp không được để trống,", "Thông Báo", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return false;
            }
            if (tb_Congtac.Text.Trim().Length == 0)
            {
                MessageBox.Show("Đơn vị công tác không được để trống,", "Thông Báo", MessageBoxButtons.OK,
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Insertmoi.Enabled = false;
            btn_Update.Enabled = true;
            btn_Delete.Enabled = true;
            int r = e.RowIndex;
            if (r < 0)
                return;
            if (!this.dataGridView1.Rows[r].IsNewRow)
            {
                this.dataGridView1.Rows[r].Selected = true;
                this.MaTN = this.dataGridView1.Rows[r].Cells["MATN"].Value.ToString();
                tb_Hoten.Text = this.dataGridView1.Rows[r].Cells["HOTENTN"].Value.ToString();
                tb_Quanhe.Text = this.dataGridView1.Rows[r].Cells["QUANHE"].Value.ToString();
                tb_Congtac.Text = this.dataGridView1.Rows[r].Cells["DVCONGTAC"].Value.ToString();
                tb_Nghenghiep.Text = this.dataGridView1.Rows[r].Cells["NGHENGHIEP"].Value.ToString();              
                dtime_Ngaysinh.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NAMSINH"].Value);
            }
        }

        private void btn_Insertmoi_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
                return;
            this.MaTN = this.bll_TN.set_MaTN(this.MANV);
            bll_TN.Insert(this.MaTN, tb_Hoten.Text, dtime_Ngaysinh.Value ,tb_Quanhe.Text, tb_Nghenghiep.Text,tb_Congtac.Text);
            bll_CTN.Insert(this.MANV, this.MaTN);
            Refresh_GridView();
            Clear_Insert();
       } 

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
            {
                return;
            }
            bll_TN.Update(this.MaTN, tb_Hoten.Text, dtime_Ngaysinh.Value, tb_Quanhe.Text, tb_Nghenghiep.Text, tb_Congtac.Text);
            Refresh_GridView();
            Clear_Insert();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            bll_CTN.Delete(this.MaTN);
            bll_TN.Delete(this.MaTN);
            Refresh_GridView();
            Clear_Insert();
        }

        private void tb_Hoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar >= 33 && e.KeyChar <= 64);
        }

        private void tb_Quanhe_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar >= 33 && e.KeyChar <= 64);
        }

        private void tb_Nghenghiep_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar >= 33 && e.KeyChar <= 64);
        }

        private void tb_Congtac_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar >= 33 && e.KeyChar <= 64);
        }

        private void tb_Hoten_Click(object sender, EventArgs e)
        {
            Clear_Insert();
        }
    }
}