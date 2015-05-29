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
    public partial class frm_BangCC : DevExpress.XtraEditors.XtraForm
    {
        public DevExpress.XtraTab.XtraTabPage tabpage;
        public mform mfrm;
        private string MANV;
        int THANG;
        public bool admin;
        BANGCHAMCONGBLL bll_bangcc = new BANGCHAMCONGBLL();
        LICHBLL bll_lich = new LICHBLL();
        NHANVIENBLL bll_nhanvien = new NHANVIENBLL();
        DONXINBLL bll_donxin = new DONXINBLL();

        public frm_BangCC(string MANV)
        {

            InitializeComponent();

            if (this.bll_nhanvien.check_Empty())
                return;

            foreach (string str in bll_nhanvien.get_MANV())
                this.ccb_manv.Items.Add(str);
            this.MANV = MANV;
           
        }

        private void frm_BangCC_Load(object sender, EventArgs e)
        {
            if (this.admin)
            {
                this.btn_updateMonth_person.Visible = true;
                this.btn_updateMonth_all.Visible = true;
                this.dataGridView1.Visible = true;
                this.ccb_manv.Enabled = true;
                this.bll_bangcc.onMinifrm = true;
                this.mfrm = new mform(tabpage);
                this.mfrm.Text = "Cập nhật ngày chấm công...";
                this.mfrm.Show(); 
                foreach (string str in this.ccb_manv.Items)
                {
                    this.bll_bangcc.Update_SONGAYCC(bll_nhanvien.get_MABCC(str));
                    this.mfrm.Update_ProgessBar( 100 / this.ccb_manv.Items.Count );
                    this.Validate();
                }
                this.mfrm.Close();
                
            }
            else
            {
                this.ccb_manv.Items.Clear();
                this.ccb_manv.Items.Add(this.MANV);
                this.ccb_manv.SelectedIndex = 0;
            }

        }

        private void ccb_manv_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MANV = ccb_manv.Text;
            this.tb_offdays.ResetText();
            if (this.MANV != "")
            {
                this.btn_updateMonth_person.Enabled = true;
                this.THANG = bll_bangcc.get_BANGCC(bll_nhanvien.get_MABCC(MANV)).FirstOrDefault().THANG.Value;
                this.lb_title.Text = "BẢNG CHẤM CÔNG THÁNG: " + THANG + " NĂM "+ DateTime.Now.Year; 
                this.tb_workdays.Text = this.bll_lich.ViewByMonth(MANV,THANG).Where(rc => rc.CODILAM == true).Count().ToString();


                int countoffdays = 0;
                foreach (string str in this.bll_donxin.get_OffDays(MANV, THANG))
                {
                    this.tb_offdays.Text += str + "\r\n" ;
                    countoffdays++;
                }
                this.tb_countoffdays.Text = countoffdays.ToString();
                this.dataGridView1.DataSource = bll_bangcc.get_BANGCC(this.bll_nhanvien.get_MABCC(this.MANV));
            }
        }

        private void btn_updateMonth_person_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cập nhật tháng chấm công: " + DateTime.Now.Month + " cho nhân viên "+this.MANV+" ?", "Question",
                     MessageBoxButtons.OKCancel,
                     MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            this.bll_bangcc.onMinifrm = false;
            this.bll_bangcc.Update_THANG(bll_nhanvien.get_MABCC(this.MANV), DateTime.Now.Month);
        }

        private void btn_updateMonth_all_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cập nhật tháng chấm công: "+DateTime.Now.Month+" cho toàn bộ nhân viên?", "Question",
                      MessageBoxButtons.OKCancel,
                      MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            this.mfrm = new mform(tabpage);
            this.mfrm.Text = "Cập nhật tháng chấm công: " + DateTime.Now.Month;
            this.mfrm.Show();
            this.bll_bangcc.onMinifrm = true;
            foreach( string str in this.ccb_manv.Items)
            {
                this.bll_bangcc.Update_THANG(bll_nhanvien.get_MABCC(str), DateTime.Now.Month);
                this.mfrm.Update_ProgessBar(100 / this.ccb_manv.Items.Count);
            }
            this.mfrm.Close();
        }


    }
}