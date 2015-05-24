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

        public void Them(String MANV, String MATN)
        {
            try
            {
                COTN CTN = new COTN();
                CTN.MANV = MANV;
                CTN.MATN = MATN;
                DB.COTNs.InsertOnSubmit(CTN);
                DB.SubmitChanges();
                MessageBox.Show("Thêm thông tin thành công.", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Thêm thông tin thất bại.", "Thông báo", MessageBoxButtons.OK);
            }
           
          
        }
        public void Xoa(String MATN)
        {
            try
            {
                var CTN = DB.COTNs.FirstOrDefault(rc => rc.MATN == MATN);
                DB.COTNs.DeleteOnSubmit(CTN);
                DB.SubmitChanges();

                MessageBox.Show("Xóa thông tin thành công.", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Xóa thông tin thất bại.", "Thông báo", MessageBoxButtons.OK);
            } 
        }
        public void Xoa_MANV(string MANV)
        {
            try
            {
                var CTN = DB.COTNs.Where(rc => rc.MANV == MANV);
                foreach (COTN cotn in CTN)
                {
                    DB.COTNs.DeleteOnSubmit(cotn);
                    DB.SubmitChanges();
                    THANNHANBLL TN = new THANNHANBLL();
                    TN.Xoa(cotn.MATN);
                }
                this.Status += "\nXóa trong Bảng COTN: THÀNH CÔNG";
            }                  
            catch
            {
                this.Status += "\nXóa trong Bảng COTN: THẤT BẠI";
            }            
        }
    }
}
