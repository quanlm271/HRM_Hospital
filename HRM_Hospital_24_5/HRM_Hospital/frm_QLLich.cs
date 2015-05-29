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
    public partial class frm_QLLich: DevExpress.XtraEditors.XtraForm
    {
        public DevExpress.XtraTab.XtraTabPage tabpage;
        public mform mfrm;
        string MANV, MALICH;
        bool cbb_manv_clicked = false;
        bool listbox_outdays_clicked = false;
        bool cell_clicked = false;
        int outdays_index;
        MessageString msg = new MessageString();

        NHANVIENBLL bll_nhanvien = new NHANVIENBLL();
        PHONGKHOABLL bll_phongkhoa = new PHONGKHOABLL();
        BANGCHAMCONGBLL bll_bangcc = new BANGCHAMCONGBLL();
        NGAYNGHIBLL bll_ngaynghi = new NGAYNGHIBLL();
        LICHBLL bll_lich = new LICHBLL();

        public frm_QLLich()
        {
            InitializeComponent(); 

            this.refresh_ListBox();

            if(this.bll_nhanvien.check_Empty())
                return;

            foreach (string str in this.bll_nhanvien.get_MANV())
                this.cbb_manv.Items.Add(str);

            Refresh_GridView();
        }
    

        public void Refresh_GridView()
        {
            this.dataGridView1.DataSource = bll_lich.get_AllRecord();
        }

        private void reset_to_Default()
        {

            btn_Insert.Enabled = true;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;

            this.cell_clicked = false;
            this.listbox_outdays_clicked = false;
            this.cbb_manv_clicked = false;

            this.tb_diadiem.ResetText();
            this.tb_loaicv.ResetText();
            this.tb_maphong.ResetText();
            this.tb_tencv.ResetText();
            this.cb_codilam.Checked = false;
            this.cbb_manv.ResetText();

            this.MANV = "";
            this.MALICH = "";

            dtime_ngay.Value = DateTime.Now;
        }

        private void refresh_ListBox()
        {
            if (this.bll_ngaynghi.check_Empty())
                return;

            this.listb_outdays.Items.Clear();
            foreach (DateTime dt in this.bll_ngaynghi.get_AllRecord())
                this.listb_outdays.Items.Add(dt.Date);
        }
        private bool KiemTraDuLieuNhap()
        {
           if(this.cbb_manv.Text.Trim().Length == 0)
           {
                MessageBox.Show("Mã nhân viên không được để trống", "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return false;
           }
           if (this.tb_tencv.Text.Trim().Length == 0)
           {
               MessageBox.Show("Tên công việc không được để trống", "Thông báo.", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
               return false;
           }
           if (this.tb_diadiem.Text.Trim().Length == 0)
           {
               MessageBox.Show("Địa điểm không được để trống", "Thông báo.", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
               return false;
           }
           if (this.dtime_ngay.Value.DayOfWeek == DayOfWeek.Sunday
               || this.bll_ngaynghi.isOutDay(this.dtime_ngay.Value.Date))
           {
               MessageBox.Show("Nhập ngày không phải Chủ Nhật và không nằm trong danh sách ngày nghỉ", "Thông báo.",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
               return false;
           }
           return true;
        }

        private void getROW(int row)
        {
            if (row < 0)
                return;
            if (!this.dataGridView1.Rows[row].IsNewRow)
            {
                this.dataGridView1.Rows[row].Selected = true;


                this.MALICH = this.dataGridView1.Rows[row].Cells["MALICH"].Value.ToString();

               
                this.cbb_manv.Text = this.dataGridView1.Rows[row].Cells["MANV"].Value.ToString();

                this.MANV = this.cbb_manv.Text;

                this.tb_maphong.Text = this.bll_bangcc.get_MAPHG(this.bll_nhanvien.get_MABCC(this.MANV));
                this.tb_loaicv.Text = this.dataGridView1.Rows[row].Cells["LOAICV"].Value.ToString();
                this.tb_tencv.Text = this.dataGridView1.Rows[row].Cells["TENCV"].Value.ToString();
                this.tb_diadiem.Text = this.dataGridView1.Rows[row].Cells["DIADIEM"].Value.ToString();
                this.dtime_ngay.Text = this.dataGridView1.Rows[row].Cells["NGAY"].Value.ToString();
                this.dtime_thoigian.Text = this.dataGridView1.Rows[row].Cells["THOIGIAN"].Value.ToString();
                if (this.dataGridView1.Rows[row].Cells["CODILAM"].Value.ToString() == "True")
                    this.cb_codilam.Checked = true;
                else
                    this.cb_codilam.Checked = false;
            }
        }

        private void ViewByMANV(string MANV)
        {
            this.cbb_manv_clicked = false;
            this.dataGridView1.DataSource = this.bll_lich.get_MANV(MANV);
        }



        #region BUTTON HANDLE
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (this.cell_clicked)
            {
                if (MessageBox.Show("Bạn có thực sự muốn xóa: "+this.MALICH+" ?", "Question", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
                this.bll_lich.Delete(this.MALICH);
                this.reset_to_Default();
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuNhap())
                return;

            //run first
           if(!this.cb_lapthang.Checked && !this.cb_laptuan.Checked)      
              this.bll_lich.Insert(this.bll_lich.set_MALICH(), this.cbb_manv.Text, this.tb_maphong.Text,
                    this.tb_tencv.Text, this.tb_loaicv.Text, this.dtime_ngay.Value.Date,
                    this.dtime_thoigian.Value.TimeOfDay, this.tb_diadiem.Text, this.cb_codilam.Checked
                    );

            this.bll_lich.onMinifrm = true;
            if (this.cb_laptuan.Checked)
            {
                int month = this.dtime_ngay.Value.Month;
                DateTime dt = this.dtime_ngay.Value.Date;

                this.bll_lich.onMinifrm = true;
                this.mfrm = new mform(tabpage);
                this.mfrm.Text = "Thêm lịch hàng tuần...";
                this.mfrm.Show(); 
                int value =((DateTime.DaysInMonth(dt.Year, dt.Month) - dt.Day) / 7)+1;

                while (dt.Month == month)
                {
                    if (!this.bll_ngaynghi.isOutDay(dt))
                    {
                        this.mfrm.Update_ProgessBar(100 / value);
                        this.bll_lich.Insert(this.bll_lich.set_MALICH(), this.cbb_manv.Text, this.tb_maphong.Text,
                            this.tb_tencv.Text, this.tb_loaicv.Text, dt.Date, this.dtime_thoigian.Value.TimeOfDay,
                            this.tb_diadiem.Text, this.cb_codilam.Checked
                            );
                        
                    }
                    dt = dt.AddDays(7);
                }

                this.mfrm.Close();
                this.bll_lich.onMinifrm = false;
                this.cb_laptuan.Checked = false;
            }

            if (this.cb_lapthang.Checked)
            {

               DateTime dt = this.dtime_ngay.Value.Date;
               int month = dt.Month + 1;

               this.bll_lich.onMinifrm = true;
               this.mfrm = new mform(tabpage);
               this.mfrm.Text = "Thêm lịch hàng tháng...";
               this.mfrm.Show();
               int value = 12 - month;

               while(month<=12)
               {
                   if (DateTime.DaysInMonth(dt.Year, month) >= dt.Day)
                   {
                    
                       dt = new DateTime(dt.Year, month, dt.Day);
                       if (!this.bll_ngaynghi.isOutDay(dt) && !dt.DayOfWeek.Equals(DayOfWeek.Sunday))
                       {
                           this.mfrm.Update_ProgessBar(100 / value);
                           this.bll_lich.Insert(this.bll_lich.set_MALICH(), this.cbb_manv.Text, this.tb_maphong.Text,
                               this.tb_tencv.Text, this.tb_loaicv.Text, dt.Date, this.dtime_thoigian.Value.TimeOfDay,
                               this.tb_diadiem.Text, this.cb_codilam.Checked
                               );
                       }
                   } 
                    month++;

                }
               this.mfrm.Close();
               this.bll_lich.onMinifrm = false;
               this.cb_lapthang.Checked = false;
            } 
            this.ViewByMANV(cbb_manv.Text);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuNhap())
                return;

            this.bll_lich.Update(this.MALICH, this.cbb_manv.Text, this.tb_maphong.Text,
                    this.tb_tencv.Text, this.tb_loaicv.Text, this.dtime_ngay.Value.Date,
                    this.dtime_thoigian.Value.TimeOfDay, this.tb_diadiem.Text, this.cb_codilam.Checked);

            this.ViewByMANV(cbb_manv.Text);
            this.reset_to_Default();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Update.Enabled = true;
            btn_Delete.Enabled = true;
            this.cell_clicked = true;
            this.dataGridView1.ClearSelection();
            int r = e.RowIndex;
            this.getROW(r);
          
        }
       
        private void cbb_manv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbb_manv_clicked)
            {
                if (this.cbb_manv.Text != "")
                {
                    this.MANV = this.cbb_manv.Text;
                    this.tb_maphong.Text = this.bll_bangcc.get_MAPHG(this.bll_nhanvien.get_MABCC(this.MANV));
                    this.ViewByMANV(this.MANV);
                }
                else
                    this.Refresh_GridView();
            }
        }
        
        private void cbb_manv_Click(object sender, EventArgs e)
        {
            this.cbb_manv_clicked = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.reset_to_Default();
            this.dataGridView1.ClearSelection();
            DataGridViewRow row = this.dataGridView1.Rows
                        .Cast<DataGridViewRow>()
                        .Where(r => r.Cells["NGAY"].Value.Equals(this.dtime_ngay.Value.Date))
                        .FirstOrDefault();
            if (row != null)
            {
                this.dataGridView1.Rows[row.Index].Selected = true;
                this.dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
            }
            else
                MessageBox.Show("Không tìm thấy! ", "Thông báo.", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection();
            this.Refresh_GridView();
            this.reset_to_Default();
        }
        #endregion

        private void listb_outdays_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listbox_outdays_clicked = true;
            outdays_index = this.listb_outdays.SelectedIndex;
        }

        private void listb_outdays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.listbox_outdays_clicked)
            {
                if (e.KeyChar == 8 || e.KeyChar == 127)//Backspace  or Del              
                {
                    if(outdays_index > -1 && outdays_index<this.listb_outdays.Items.Count)
                    {
                        this.bll_ngaynghi.Delete(Convert.ToDateTime(this.listb_outdays.Items[outdays_index]));
                        this.refresh_ListBox();
                    }
                }

            }
        }

        private void btn_addoutdays_Click(object sender, EventArgs e)
        {
            if (this.listb_outdays.Items.IndexOf(this.dtime_outday.Value.Date) == -1)
            {
                this.bll_ngaynghi.Insert(this.dtime_outday.Value.Date);
                this.refresh_ListBox();
            }
        }

        private void frm_QLLich_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}