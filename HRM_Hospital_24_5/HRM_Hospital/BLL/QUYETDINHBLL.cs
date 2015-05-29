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
    class QUYETDINHBLL:BLL
    {
        public List<QUYETDINH> get_AllRecord()
        {
            return DB.QUYETDINHs.ToList();
        }

        public void Insert(string MAQD, string MAPHG, string MANV,string LOAIQD,string TENQD,DateTime NGAYRAQD)
        {
            try
            {
                QUYETDINH quyetdinh = new QUYETDINH();
                quyetdinh.MAQD = MAQD;
                quyetdinh.MAPHG = MAPHG;
                quyetdinh.MANV = MANV;
                quyetdinh.LOAIQD = LOAIQD;
                quyetdinh.TENQD = TENQD;
                quyetdinh.NGAYRAQD = NGAYRAQD;
                DB.QUYETDINHs.InsertOnSubmit(quyetdinh);
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
        public void Update(string MAQD, string MAPHG, string MANV, string LOAIQD, string TENQD, DateTime NGAYRAQD)
        {
            try
            {
                var quyetdinh = DB.QUYETDINHs.FirstOrDefault(tk => tk.MAQD == MAQD);
                quyetdinh.MAQD = MAQD;
                quyetdinh.MAPHG = MAPHG;
                quyetdinh.MANV = MANV;
                quyetdinh.LOAIQD = LOAIQD;
                quyetdinh.TENQD = TENQD;
                quyetdinh.NGAYRAQD = NGAYRAQD;
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
        public void Delete(string MAQD)
        {
            try
            {
                var quyetdinh = DB.QUYETDINHs.FirstOrDefault(tk => tk.MAQD == MAQD);
                DB.QUYETDINHs.DeleteOnSubmit(quyetdinh);
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
                var QD = DB.QUYETDINHs.Where(rc => rc.MANV == MANV);
                foreach (QUYETDINH qd in QD)
                    DB.QUYETDINHs.DeleteOnSubmit(qd);
                DB.SubmitChanges();
                
                this.Status += "\nQUYETDINH: " + msg.delete_success;

            }
            catch
            {
                this.Status += "\nQUYETDINH: " + msg.delete_fail;
            }
        }
    }
}
