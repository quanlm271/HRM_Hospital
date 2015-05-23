using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM_Hospital.DAL;
using System.Windows.Forms;
namespace HRM_Hospital.BLL
{
    class COTNBLL
    {
        QLNSDataContext DB = new QLNSDataContext();
        public void Them(String MANV, String MATN)
        {
                COTN CTN = new COTN();
                CTN.MANV = MANV;
                CTN.MATN = MATN;
                DB.COTNs.InsertOnSubmit(CTN);
                DB.SubmitChanges();
           
          
        }
        public void Xoa(String MATN)
        {
                var CTN = DB.COTNs.FirstOrDefault(tk => tk.MATN == MATN);
                DB.COTNs.DeleteOnSubmit(CTN);
                DB.SubmitChanges();
            
        }

    }
}
