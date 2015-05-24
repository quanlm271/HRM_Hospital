using System;
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
        public DevExpress.XtraTab.XtraTabControl xtratabControl1;
        public frm_DangNhap()
        {
            
            InitializeComponent();
            this.btn_dangnhap.Focus();

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {

            int result =  bll_taikhoan.KiemTra_DangNhap(this.tb_tendangnhap.Text, this.tb_matkhau.Text);
            switch (result)
            { 
                case 0:
                    this.frmMain.user = true;
                    this.frmMain.MANV = bll_taikhoan.LayMANV(this.tb_tendangnhap.Text);
                    MessageBox.Show("Đăng nhập quyền user thành công", "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.xtratabControl1.TabPages.RemoveAt(this.xtratabControl1.SelectedTabPageIndex);
                    break;
                case 1:
                    this.frmMain.admin = true;
                    this.frmMain.user = true;
                    this.frmMain.MANV = bll_taikhoan.LayMANV(this.tb_tendangnhap.Text);
                    MessageBox.Show("Đăng nhập quyền admin thành công", "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.xtratabControl1.TabPages.RemoveAt(this.xtratabControl1.SelectedTabPageIndex);
                    break;
                case -1:
                    MessageBox.Show("Đăng nhập không thành công", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
