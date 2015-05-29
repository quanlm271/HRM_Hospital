using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM_Hospital.DAL;
using System.Windows.Forms;

namespace HRM_Hospital.BLL
{
    class TRINHDOBLL:BLL
    {
        public void Delete_MANV(string MANV)
        {
            try
            {
                var TD = DB.TRINHDONGHIEPVUs.FirstOrDefault(rc => rc.MANV == MANV);
                if (TD != null)
                {
                    DB.TRINHDONGHIEPVUs.DeleteOnSubmit(TD);
                    DB.SubmitChanges();
                    this.Status += "\nTRINHDO: "+msg.delete_success;
                }

            }
            catch
            {
                    this.Status += "\nTRINHDO: " + msg.delete_fail;
            }
        }
    }
}
