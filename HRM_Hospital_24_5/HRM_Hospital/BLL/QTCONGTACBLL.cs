using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM_Hospital.DAL;
using System.Linq;
using System.Windows.Forms;

namespace HRM_Hospital.BLL
{
    class QTCONGTACBLL:BLL
    {

        public List<QUATRINHCONGTAC> get_AllRecord()
        {
            return DB.QUATRINHCONGTACs.ToList();
        }
        public List<QUATRINHCONGTAC> get_QTCT(string MANV)
        {
            var Congtac = from primary in DB.QUATRINHCONGTACs
                          where primary.MANV == MANV
                          select primary;
            return Congtac.ToList();
        }

        public void Insert(string MAQTCT,string MANV,  string MAPHG, DateTime TUTHANG_NAM,
            DateTime DENTHANG_NAM,string CHUCDANH,string CHUCVU)
        {
            try
            {
                QUATRINHCONGTAC congtac = new QUATRINHCONGTAC();
                congtac.MAQTCT = MAQTCT;

                congtac.MANV = MANV;
                congtac.MAPHG = MAPHG;
                congtac.TUTHANG_NAM = TUTHANG_NAM;
                congtac.DENTHANG_NAM = DENTHANG_NAM;
                congtac.CHUCDANH = CHUCDANH;
                congtac.CHUCVU = CHUCVU;
                DB.QUATRINHCONGTACs.InsertOnSubmit(congtac);
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
        public void Update(string MAQTCT, string MANV, string MAPHG, DateTime TUTHANG_NAM,
            DateTime DENTHANG_NAM,string CHUCDANH,string CHUCVU)
        {
            try
            {
                var congtac = DB.QUATRINHCONGTACs.FirstOrDefault(rc => rc.MAQTCT == MAQTCT);
                congtac.MAQTCT = MAQTCT;
                congtac.MANV = MANV;
                congtac.MAPHG = MAPHG;
                congtac.TUTHANG_NAM = TUTHANG_NAM;
                congtac.DENTHANG_NAM = DENTHANG_NAM;
                congtac.CHUCDANH = CHUCDANH;
                congtac.CHUCVU = CHUCVU;
                DB.SubmitChanges();
                MessageBox.Show(msg.insert_success, "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(msg.update_fail, "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
        public void Delete(string MAQTCT)
        {
            try
            {
                var congtac = DB.QUATRINHCONGTACs.FirstOrDefault(rc => rc.MAQTCT == MAQTCT);
                DB.QUATRINHCONGTACs.DeleteOnSubmit(congtac);
                DB.SubmitChanges();
                MessageBox.Show(msg.delete_success, "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show(msg.delete_fail, "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void Delete_MANV(string MANV)
        {
            try
            {
                var QTCTAC = DB.QUATRINHCONGTACs.Where(rc => rc.MANV == MANV);
                foreach(QUATRINHCONGTAC qtct in QTCTAC)
                    DB.QUATRINHCONGTACs.DeleteOnSubmit(qtct);
                DB.SubmitChanges();
                this.Status += "\nQUATRINHCONGTAC: " + msg.delete_success;
            }
            catch
            {
                this.Status += "\nQUATRINHCONGTAC: " + msg.delete_fail;
            }
        }
    }
}
