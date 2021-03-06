﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRM_Hospital.BLL;
namespace HRM_Hospital
{
    public partial class frm_DangNhap : Form
    {
        public frm_Main frmMain;
        TAIKHOANBLL bll_taikhoan = new TAIKHOANBLL();
        MessageString msg = new MessageString();
        public DevExpress.XtraTab.XtraTabControl xtratabControl1;
        public frm_DangNhap()
        {
            
            InitializeComponent();
            this.btn_dangnhap.Focus();

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {

            int result =  bll_taikhoan.check_Login(this.tb_tendangnhap.Text, this.tb_matkhau.Text);
            switch (result)
            {
                case -1:
                    this.frmMain.admin= true;
                    this.frmMain.MANV = "";
                    MessageBox.Show(msg.login_success, "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
                case 0:
                    this.frmMain.user = true;
                    this.frmMain.MANV = bll_taikhoan.get_MANV(this.tb_tendangnhap.Text);
                    MessageBox.Show(msg.login_success, "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.xtratabControl1.TabPages.RemoveAt(this.xtratabControl1.SelectedTabPageIndex);
                    break;
                case 1:
                    this.frmMain.admin = true;
                    this.frmMain.MANV = bll_taikhoan.get_MANV(this.tb_tendangnhap.Text);
                    MessageBox.Show(msg.login_success, "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.xtratabControl1.TabPages.RemoveAt(this.xtratabControl1.SelectedTabPageIndex);
                    break;
                case 2:
                    MessageBox.Show(msg.login_fail, "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
               
            }
            this.frmMain.frm_Main_Load(null, e);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
