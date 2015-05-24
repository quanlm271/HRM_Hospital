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
    class LICHBLL : BLL
    {
        public List<LICH> LayTatCa()
        {
            return DB.LICHes.ToList();
        }
        public bool KiemTraMaTrung(string Ma_Lich)
        {
            foreach (string lich in (from record in DB.LICHes select record.MALICH))
            {
                if (lich.ToLower().Contains(Ma_Lich.ToLower()) && (lich.Trim().Length == Ma_Lich.Trim().Length))
                {
                    return true;
                }
            }
            return false;
        }
        public List<LICH> ViewByMonth(string MANV, int month)
        {
            var LICH = from table in DB.LICHes
                       where (table.MANV == MANV && table.NGAY.Value.Month==month 
                       && table.NGAY.Value.Year == DateTime.Now.Year)
                       select (table);
            return LICH.ToList();
            
        }
        public List<DateTime> get_WorkDate(string MANV)
        {
            var LICH = from table in DB.LICHes
                       where (table.MANV == MANV)
                       select (table.NGAY.Value);
            return LICH.ToList();

        }
        public List<LICH> ViewByDate(string MANV, DateTime dt)
        {
            var LICH = DB.LICHes.Where(rc=> rc.NGAY.Value == dt.Date && rc.MANV == MANV);
            return LICH.ToList();
        }
        public void Them(string MALICH, string MANV, string MAPHG, string TENCV, 
            string LOAICV, DateTime NGAY, DateTime THOIGIAN, string DIADIEM)
        {
            try
            {
                LICH lich = new LICH();
                lich.MALICH = MALICH;
                lich.MANV = MANV;
                lich.MAPHG = MAPHG;
                lich.TENCV = TENCV;
                lich.LOAICV = LOAICV;
                lich.NGAY = NGAY;
                lich.THOIGIAN = THOIGIAN;
                lich.DIADIEM = DIADIEM;
                DB.LICHes.InsertOnSubmit(lich);
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
        public void Capnhat(string MALICH, string MANV, string MAPHG, string TENCV, 
            string LOAICV, DateTime NGAY, DateTime THOIGIAN, string DIADIEM)
        {
            try
            {
                var lich = DB.LICHes.FirstOrDefault(tk => tk.MALICH == MALICH);
                lich.MALICH = MALICH;
                lich.MANV = MANV;
                lich.MAPHG = MAPHG;
                lich.TENCV = TENCV;
                lich.LOAICV = LOAICV;
                lich.NGAY = NGAY;
                lich.THOIGIAN = THOIGIAN;
                lich.DIADIEM = DIADIEM;
                DB.SubmitChanges();
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
        public void Xoa(string MALICH)
        {
            try
            {
                var lich = DB.LICHes.FirstOrDefault(tk => tk.MALICH == MALICH);
                DB.LICHes.DeleteOnSubmit(lich);
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
                var lich = DB.LICHes.Where(li => li.MANV == MANV);
                foreach (LICH li in lich)
                    DB.LICHes.DeleteOnSubmit(li);
                DB.SubmitChanges();
                this.Status += "\nXóa trong bảng LICH: THÀNH CÔNG";
            }
            catch
            {
                this.Status += "\nXóa trong bảng LICH: THẤT BẠI";
            }

        }
    }
}

