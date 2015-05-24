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
        private string MANV;
        Boolean ViewInMonth, ViewByDay;
        LICHBLL bll_lich = new LICHBLL();
        DateTime date = new DateTime();
        public frm_LichLamViec(string MANV)
        {
            InitializeComponent();
            this.MANV = MANV;
            var listNgay = bll_lich.get_WorkDate(this.MANV);
            foreach (DateTime dt in listNgay)
                this.monthCalendar1.AddBoldedDate(dt.Date);
           // datePK_ngay.Format = DateTimePickerFormat.Custom;
           // datePK_ngay.CustomFormat = "dd/MM/yyyy";
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.date = this.monthCalendar1.SelectionStart.Date;
            this.dataGridView1.DataSource = this.bll_lich.ViewByDate(this.MANV, this.date);            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBox1.Text!="(Nope)")
                 this.dataGridView1.DataSource = this.bll_lich.ViewByMonth(this.MANV, 
                     Int16.Parse(this.comboBox1.Text)); 
        }
    }
}