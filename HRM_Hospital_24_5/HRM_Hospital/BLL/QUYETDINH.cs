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
    class QUYETDINHBLL
    {
        QLNSDataContext DB = new QLNSDataContext();
        public List<QUYETDINH> LayTatCa()
        {
            return DB.QUYETDINHs.ToList();
        }
        public bool KiemTraMaTrung(string MAQD)
        {
            foreach (string ma in (from maqd in DB.QUYETDINHs select maqd.MAQD))
            {
                if (ma.ToLower().Contains(MAQD.ToLower()) && (ma.Trim().Length == MAQD.Trim().Length))
                {
                    return true;
                }
            }
            return false;
        }

        public void Them(string MAQD, string MAPHG, string MANV,string LOAIQD,string TENQD,DateTime NGAYRAQD)
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
                MessageBox.Show("Thêm mới thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm mới thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void Capnhat(string MAQD, string MAPHG, string MANV, string LOAIQD, string TENQD, DateTime NGAYRAQD)
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
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Xoa(string MAQD)
        {
            try
            {
                var quyetdinh = DB.QUYETDINHs.FirstOrDefault(tk => tk.MAQD == MAQD);
                DB.QUYETDINHs.DeleteOnSubmit(quyetdinh);
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
