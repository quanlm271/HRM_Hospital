using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM_Hospital.DAL;
using System.Windows.Forms;
namespace HRM_Hospital.BLL
{
    class COTNBLL:BLL
    {

        public void Insert(String MANV, String MATN)
        {
            try
            {
                COTN CTN = new COTN();
                CTN.MANV = MANV;
                CTN.MATN = MATN;
                DB.COTNs.InsertOnSubmit(CTN);
                DB.SubmitChanges();
                MessageBox.Show(msg.insert_success, "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show(msg.insert_fail, "Thông báo", MessageBoxButtons.OK);
            }
           
          
        }
        public void Delete(String MATN)
        {
            try
            {
                var CTN = DB.COTNs.FirstOrDefault(rc => rc.MATN == MATN);
                DB.COTNs.DeleteOnSubmit(CTN);
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
                var CTN = DB.COTNs.Where(rc => rc.MANV == MANV);
                foreach (COTN cotn in CTN)
                {
                    DB.COTNs.DeleteOnSubmit(cotn);
                    DB.SubmitChanges();
                    THANNHANBLL TN = new THANNHANBLL();
                    TN.Delete(cotn.MATN);
                }
                this.Status += "\nCOTN: " + msg.delete_success;
            }                  
            catch
            {
                this.Status += "\nCOTN: " + msg.delete_fail; ;
            }            
        }
    }
}
