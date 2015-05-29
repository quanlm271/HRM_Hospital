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
using HRM_Hospital.DAL;

namespace HRM_Hospital
{
    public partial class frm_VietDonXNP : DevExpress.XtraEditors.XtraForm
    {
        int Days = 0;
        int NgayConLai;
        int NgayDaNghi=0;
        public int songaynghi = 7;
        public frm_Main frm_main;
        String MANV;
        DONXINBLL bll_donxin = new DONXINBLL();
        NHANVIENBLL bll_nhanvien = new NHANVIENBLL();
        public frm_VietDonXNP(string MANV)
        {
            InitializeComponent();
            this.MANV = MANV;
            this.FillData();
        }

        private void btn_NopDon_Click(object sender, EventArgs e)
        {
            if (this.Days <= this.NgayConLai && this.Days>0)
            {
                bll_donxin.Insert(this.frm_main.MANV,
                                Int16.Parse(this.tb_songay.Text),
                                this.tb_lydo.Text,
                                this.date_tungay.Value,
                                this.date_denngay.Value,
                                DateTime.Now);
                this.frm_VietDonXNP_Load(null, e);
            }
            else
                MessageBox.Show("Số ngày xin nghỉ không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cal_Date()
        {
            Days = 0;
            int dueday = this.date_denngay.Value.Date.Subtract(this.date_tungay.Value.Date).Days + 1;
            int temp = 0;
            
            while (temp++ < dueday)
            {
                if (!this.date_tungay.Value.Date.AddDays(temp).DayOfWeek.Equals(DayOfWeek.Sunday))
                    Days++;
            }
            this.tb_songay.Text = Days.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.cal_Date();
        }
      
        private void FillData()
        {
            this.NgayDaNghi = 0;
            var donxin = bll_donxin.get_DONXIN(MANV);
            foreach (DONXIN dx in donxin)
                this.NgayDaNghi += dx.SONGAYNGHI.Value;
            NgayConLai = songaynghi - NgayDaNghi;

            this.cal_Date();
            this.tb_MANV.Text = MANV;
            this.tb_ten.Text = this.bll_nhanvien.get_TEN(MANV);
            this.lb_SoNgayDuocNghi.Text = "Số ngày được nghỉ: " + songaynghi;
            this.lb_SoNgayDaNghi.Text = "Số ngày đã nghỉ: " + NgayDaNghi;          
            this.lb_SoNgayConLai.Text = "Số ngày còn lại: " + NgayConLai;
            this.tb_ngaylapdon.Text = DateTime.Now.ToString();
            if (this.NgayConLai == 0)
                this.btn_NopDon.Enabled = false;
        }
        private void frm_VietDonXNP_Load(object sender, EventArgs e)
        {
            this.FillData();
        }
    }
}