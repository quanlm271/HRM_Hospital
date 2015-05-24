using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM_Hospital.DAL;
using System.Windows.Forms;

namespace HRM_Hospital.BLL
{
    class PHONGKHOABLL:BLL
    {
        public List<PHONGKHOA> LayTatCa()
        {
            return DB.PHONGKHOAs.ToList();
        }
        public List<string> LayMaPHG()
        {
            List<string> str = new List<string>();
            foreach (string ma in (from MaPH in DB.PHONGKHOAs select MaPH.MAPHG))
            {
                str.Add(ma);
            }
            return str;
        }

        public bool KiemTraMaTrung(string Ma_PHG)
        {
            foreach (string nv in (from record in DB.PHONGKHOAs select record.MAPHG))
            {
                if ((nv.ToLower().Contains(Ma_PHG.ToLower()) == true) && (nv.Trim().Length == Ma_PHG.Trim().Length))
                {
                    return true;
                }
            }
            return false;
        }
        public void Them(string MaPHG,string TENPHG,string KHOI)
        {
            try
            {
                PHONGKHOA nv = new PHONGKHOA();
                nv.MAPHG = MaPHG;
                nv.TENPHG = TENPHG;
                nv.KHOI = KHOI;
                DB.PHONGKHOAs.InsertOnSubmit(nv);
                DB.SubmitChanges();
                MessageBox.Show("Thêm mới thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm mới thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
        public void Capnhat(string MaPHG, string TENPHG, string KHOI)
        {
            try
            {
                var nv = DB.PHONGKHOAs.FirstOrDefault(tk => tk.MAPHG == MaPHG);
                nv.MAPHG = MaPHG;
                nv.TENPHG = TENPHG;
                nv.KHOI = KHOI;
                DB.SubmitChanges();
                MessageBox.Show("Thêm mới thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm mới thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
        public void Xoa(string MaPHG)
        {
            try
            {
                var nv = DB.PHONGKHOAs.FirstOrDefault(tk => tk.MAPHG == MaPHG);
                DB.PHONGKHOAs.DeleteOnSubmit(nv);
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
