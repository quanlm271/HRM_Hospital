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
    public partial class frm_QLTienLuong : DevExpress.XtraEditors.XtraForm
    {
        public frm_Main frm_main;
        LUONGBLL bll_LUONG = new LUONGBLL();
        BANGCHAMCONGBLL bll_BCC = new BANGCHAMCONGBLL();
        public frm_QLTienLuong()
        {
            InitializeComponent();
            //this.txt_TenNV.Text = BLL.get_TenNV();
            //this.txt_SoNgayLamViec.Text = bll_BCC.get_SoNgayCC(this.frm_main.MaNV).ToString();
        }
    }
}