using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HRM_Hospital.DAL;
using HRM_Hospital.BLL;
using System.Linq;
using System.Windows.Forms;


namespace HRM_Hospital.BLL
{
    class BANGCHAMCONGBLL:BLL
    {
        LICHBLL bll_lich = new LICHBLL();
        DONXINBLL bll_donxin = new DONXINBLL();
        private Boolean check_Empty()
        {
            return this.get_AllRecord().Count == 0;
        }
        public List<BANGCHAMCONG> get_AllRecord()
        {
            try
            {
                return DB.BANGCHAMCONGs.ToList();
            }
            catch
            {
                MessageBox.Show(msg.get_fail, "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            return null;
        }
        public string set_MABCC()
        {
            string str;
            var AllRecord = this.get_AllRecord();
            if (!check_Empty())
            {
                int max = 0;
                int index = 0;
                foreach (BANGCHAMCONG rc in AllRecord)
                {
                    str = String.Concat(rc.MA_BANGCC.Where(char.IsDigit));
                    index = Int16.Parse(str);
                    if (index > max)
                        max = index;
                }
                return "B" + (max + 1);
            }
            return "B1";
        }
        public string get_MAPHG(string MABBC)
        {
            try
            {
                return DB.BANGCHAMCONGs.Where(rc => rc.MA_BANGCC == MABBC).FirstOrDefault().MAPHG;
            }
            catch
            {
                MessageBox.Show(msg.get_fail, "Thông báo.", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            return null;
        }
        public List<BANGCHAMCONG> get_BANGCC(string MABBC)
        {
            try
            {
                return DB.BANGCHAMCONGs.Where(rc => rc.MA_BANGCC == MABBC).ToList();
            }
            catch
            {
                MessageBox.Show(msg.get_fail, "Thông báo.", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            return null;
        }
        public string get_MANV(string MABCC)
        {
            try
            {
                return DB.NHANVIENs.Where(rc => rc.MA_BANGCC == MABCC).FirstOrDefault().MANV;
            }
            catch
            {
                MessageBox.Show(msg.get_fail, "Thông báo.", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            return null;
        }
        public void Insert(string MABCC, int THANG, string MAPHG, int SONGAY)
        {
            try
            {
                DB.SubmitChanges();
                BANGCHAMCONG BCC = new BANGCHAMCONG();
                BCC.MA_BANGCC = MABCC;
                BCC.THANG = THANG;
                BCC.MAPHG = MAPHG;
                BCC.SONGAYCC = SONGAY;
                DB.BANGCHAMCONGs.InsertOnSubmit(BCC);
                DB.SubmitChanges();
                MessageBox.Show(msg.insert_success, "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(msg.insert_fail, "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        //update MAPHONG
        public void Update_MAPHG(string MABCC, string MAPHG)
        {
            try
            {
                DB.SubmitChanges();
                var BCC = DB.BANGCHAMCONGs.FirstOrDefault(rc => rc.MA_BANGCC == MABCC);
                BCC.MAPHG = MAPHG;
                DB.SubmitChanges();
                MessageBox.Show(msg.update_success, "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(msg.update_fail, "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public void Update_THANG(string MABCC, int THANG)
        {
            try
            {
                DB.SubmitChanges();
                var BCC = DB.BANGCHAMCONGs.FirstOrDefault(rc => rc.MA_BANGCC == MABCC);
                BCC.THANG = THANG;
                DB.SubmitChanges();
                if(!onMinifrm)
                    MessageBox.Show(msg.update_success, "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(msg.update_fail, "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        public void Update_SONGAYCC(string MABCC)
        {
            try
            {
                DB.SubmitChanges();
                var BCC = DB.BANGCHAMCONGs.FirstOrDefault(rc => rc.MA_BANGCC == MABCC);

                int workdays = bll_lich.ViewByMonth(this.get_MANV(BCC.MA_BANGCC), BCC.THANG.Value)
                    .Where(rc => rc.CODILAM == true)
                    .Count();

              //  int offdays = bll_donxin.get_OffDays(this.get_MANV(BCC.MA_BANGCC), BCC.THANG.Value).Count;
                BCC.SONGAYCC = workdays;
                DB.SubmitChanges();
                if(!this.onMinifrm)
                    MessageBox.Show(msg.update_success, "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(msg.update_fail, "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        public void Delete(string MABCC)
        {
            try
            {
                DB.SubmitChanges();
                var BCC = DB.BANGCHAMCONGs.FirstOrDefault(rc => rc.MA_BANGCC == MABCC);
                DB.BANGCHAMCONGs.DeleteOnSubmit(BCC);
                DB.SubmitChanges();
                this.Status += "\nBANGCC: " + msg.delete_success;
            }
            catch
            {
                this.Status += "\nBANGCC: " + msg.delete_fail; ;
            }            
        }

    }
}
