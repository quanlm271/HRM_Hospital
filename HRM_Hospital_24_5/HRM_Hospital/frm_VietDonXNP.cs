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
        public int songaynghi = 15;
        public frm_Main frm_main;
        String MaNV;
        DONXINBLL bll_donxin = new DONXINBLL();
        NHANVIENBLL bll_nhanvien = new NHANVIENBLL();
        public frm_VietDonXNP(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            this.LabelLoad();
            Format_Time();
        }

        public void Format_Time()
        {
            date_denngay.Format = DateTimePickerFormat.Custom;
            date_denngay.CustomFormat = "dd/MM/yyyy";
            date_tungay.Format = DateTimePickerFormat.Custom;
            date_tungay.CustomFormat = "dd/MM/yyyy";
        }

        private void btn_NopDon_Click(object sender, EventArgs e)
        {
            if (this.Days <= this.NgayConLai && this.Days>0)
            {
                bll_donxin.Them(this.frm_main.MaNV,
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Days = this.date_denngay.Value.Subtract(this.date_tungay.Value).Days + 1;
            this.tb_songay.Text = Days.ToString();
        }
        private void LabelLoad()
        {
            this.NgayDaNghi = 0;
            List<DONXIN> donxin = new List<DONXIN>();
            donxin = bll_donxin.get_DONXIN(MaNV);
            foreach (DONXIN dx in donxin)
                this.NgayDaNghi += dx.SONGAYNGHI.Value;
            NgayConLai = songaynghi - NgayDaNghi;
            this.tb_manv.Text = MaNV;

            this.tb_ten.Text = this.bll_nhanvien.get_TEN(MaNV);
            this.lb_SoNgayDuocNghi.Text = "Số ngày được nghỉ: " + songaynghi;
            this.lb_SoNgayDaNghi.Text = "Số ngày đã nghỉ: " + NgayDaNghi;          
            this.lb_SoNgayConLai.Text = "Số ngày còn lại: " + NgayConLai;
            this.tb_ngaylapdon.Text = DateTime.Now.ToString();
            if (this.NgayConLai == 0)
                this.btn_NopDon.Enabled = false;
        }
        private void frm_VietDonXNP_Load(object sender, EventArgs e)
        {
            this.LabelLoad();
        }
    }
}