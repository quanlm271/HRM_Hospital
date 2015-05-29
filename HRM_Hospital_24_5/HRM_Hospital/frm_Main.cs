using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
namespace HRM_Hospital
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Boolean user = false;
        public Boolean admin = false;
        public string MANV;
        public int tab_index = 0;
        public frm_Main()
        {
            InitializeComponent();
            tab_index++;
            this.CallLoginForm();
           
        }
        private void CallLoginForm()
        {
            frm_DangNhap frm = new frm_DangNhap();
            frm.frmMain = this;
            frm.xtratabControl1 = this.xtraTabControl1;
            XtraTabPage tabpage = new XtraTabPage();
            tabpage.Text = "Đăng Nhập";
            this.Add_TabPage(frm, tabpage);
        }
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            tab_index--;
            XtraTabControl TabControl = (XtraTabControl)sender;
            int i = TabControl.SelectedTabPageIndex;
            TabControl.TabPages.RemoveAt(TabControl.SelectedTabPageIndex);
            TabControl.SelectedTabPageIndex = i - 1;
            
        }

        private void btn_QTNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tab_index++;
            frm_QLNguoiDung frm = new frm_QLNguoiDung();
            XtraTabPage tabpage = new XtraTabPage();
            tabpage.Text = "Quản Lý ND";
            this.Add_TabPage(frm, tabpage);

        }

        private void btn_ThongTinNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tab_index++;
            frm_QLNhanVien frm = new frm_QLNhanVien();
            frm.frm_Main = this;
            XtraTabPage tabpage = new XtraTabPage();
            tabpage.Text = "QL Thông Tin Nhân Viên";
            this.Add_TabPage(frm, tabpage);
        }
        private void btn_LichLamViec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tab_index++;
            frm_LichLamViec frm = new frm_LichLamViec(this.MANV);
            XtraTabPage tabpage = new XtraTabPage();
            tabpage.Text = "Xem Lịch";
            this.Add_TabPage(frm, tabpage);
        }

        private void btn_DonNghiPhep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tab_index++;
            frm_VietDonXNP frm = new frm_VietDonXNP(this.MANV);
            frm.frm_main = this;
            XtraTabPage tabpage = new XtraTabPage();
            tabpage.Text = "Đơn Xin Nghỉ Phép";
            this.Add_TabPage(frm, tabpage);
        }

        private void btn_DangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = this.xtraTabControl1.TabPages.Count();
            while (index-- > 0)
                this.xtraTabControl1.TabPages.RemoveAt(index);
            this.MANV = null;
            this.ribbon_user.Visible = false;
            this.ribbon_admin.Visible = false;
            this.user = false;
            this.admin = false;
            this.btn_DangXuat.Enabled = false;
            this.CallLoginForm();
        }
        private void btn_BangChamCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tab_index++;
            frm_BangCC frm = new frm_BangCC(this.MANV);
            frm.admin = this.admin;
            XtraTabPage tabpage = new XtraTabPage();
            tabpage.Text = "Bảng Chấm Công";  
            frm.tabpage = tabpage;
            this.Add_TabPage(frm, tabpage);
        }


        private void btn_phongkhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tab_index++;
            frm_PhongKhoa frm = new frm_PhongKhoa();
            XtraTabPage tabpage = new XtraTabPage();
            tabpage.Text = "Phòng Khoa";
            this.Add_TabPage(frm, tabpage);
        }


        private void btn_qllich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tab_index++;
            frm_QLLich frm = new frm_QLLich();
            XtraTabPage tabpage = new XtraTabPage();
            tabpage.Text = "QL Lịch NV";
            frm.tabpage = tabpage;
            this.Add_TabPage(frm, tabpage);
        }


        public void Add_TabPage(Form frm, XtraTabPage tabpage)
        {
            frm.TopLevel = false;
            frm.AutoScroll = false;
            frm.Parent = tabpage;
            this.xtraTabControl1.TabPages.Add(tabpage);
            this.xtraTabControl1.SelectedTabPageIndex = tab_index;
            frm.Show();
        }


        public void frm_Main_Load(object sender, EventArgs e)
        {
            if (this.user || this.admin)
            {
                this.ribbon_user.Visible = true;
                this.btn_DangXuat.Enabled = true;
                if (this.admin)
                {
                    this.ribbon_admin.Visible = true;
                    this.btn_DonNghiPhep_ItemClick(null, null);

                }
            }
            
        }

        private void btn_QLDonXinNghiPhep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


       
    }
}
