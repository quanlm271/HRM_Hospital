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
    class BANGCHAMCONGBLL
    {
        QLNSDataContext DB = new QLNSDataContext();
        NHANVIENBLL bll_NV = new NHANVIENBLL();
        public List<BANGCHAMCONG> LayTatCa()
        {
            return DB.BANGCHAMCONGs.ToList();
        }
        public int get_SoNgayCC(string MANV)
        {
            string mabcc = bll_NV.get_MABCC(MANV);

            return Int16.Parse(DB.BANGCHAMCONGs.Where(bcc => bcc.MA_BANGCC == mabcc).FirstOrDefault().ToString());

        }

    }
}
