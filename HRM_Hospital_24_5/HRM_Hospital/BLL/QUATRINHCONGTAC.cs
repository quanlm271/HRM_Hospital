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
    class QUATRINHCONGTACBLL
    {
        QLNSDataContext DB = new QLNSDataContext();
        public List<QUATRINHCONGTAC> LayTatCa()
        {
            return DB.QUATRINHCONGTACs.ToList();
        }
        public List<QUATRINHCONGTAC> Get_QTCT(string MaNV)
        {
            var Congtac = from primary in DB.QUATRINHCONGTACs
                          where primary.MANV == MaNV
                          select primary;
            return Congtac.ToList();
        }
        public bool KiemTraMaTrung(string MAQTCT)
        {
            foreach (string ma in (from maqtct in DB.QUATRINHCONGTACs select maqtct.MAQTCT))
            {
                if (ma.ToLower().Contains(MAQTCT.ToLower()) && (ma.Trim().Length == MAQTCT.Trim().Length))
                {
                    return true;
                }
            }
            return false;
        }
    

        public void Them(string MAQTCT,string MANV,  string MAPHG, DateTime TUTHANG_NAM,DateTime DENTHANG_NAM,string CHUCDANH,string CHUCVU)
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
                MessageBox.Show("Thêm mới thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm mới thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void Capnhat(string MAQTCT, string MANV, string MAPHG, DateTime TUTHANG_NAM,DateTime DENTHANG_NAM,string CHUCDANH,string CHUCVU)
        {
            try
            {
                var congtac = DB.QUATRINHCONGTACs.FirstOrDefault(tk => tk.MAQTCT == MAQTCT);
                congtac.MAQTCT = MAQTCT;
                congtac.MANV = MANV;
                congtac.MAPHG = MAPHG;
                congtac.TUTHANG_NAM = TUTHANG_NAM;
                congtac.DENTHANG_NAM = DENTHANG_NAM;
                congtac.CHUCDANH = CHUCDANH;
                congtac.CHUCVU = CHUCVU;
                DB.SubmitChanges();
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Xoa(string MAQTCT)
        {
            try
            {
                var congtac = DB.QUATRINHCONGTACs.FirstOrDefault(tk => tk.MAQTCT == MAQTCT);
                DB.QUATRINHCONGTACs.DeleteOnSubmit(congtac);
                DB.SubmitChanges();
                MessageBox.Show("Xóa thông tin thành công.", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Xóa thông tin thất bại.", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
