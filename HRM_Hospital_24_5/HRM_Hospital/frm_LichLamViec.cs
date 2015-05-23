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
    public partial class frm_LichLamViec : DevExpress.XtraEditors.XtraForm
    {
        public frm_Main frmMain;
        public frm_LichLamViec()
        {
            InitializeComponent();
            datePK_ngay.Format = DateTimePickerFormat.Custom;
            datePK_ngay.CustomFormat = "dd/MM/yyyy";
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            LICHBLL BLL = new LICHBLL();
            
            this.dataGridView1.DataSource = BLL.XemLich(this.frmMain.MaNV, this.datePK_ngay.Value);
        }
    }
}