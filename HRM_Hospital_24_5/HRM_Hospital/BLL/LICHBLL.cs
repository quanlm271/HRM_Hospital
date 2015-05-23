﻿using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM_Hospital.DAL;
using System.Linq;
using System.Windows.Forms;


namespace HRM_Hospital.BLL
{
    class LICHBLL
    {
        QLNSDataContext DB = new QLNSDataContext();
        public List<LICH> LayTatCa()
        {
            return DB.LICHes.ToList();
        }
        public bool KiemTraMaTrung(string Ma_Lich)
        {
            foreach (string lich in (from record in DB.LICHes select record.MALICH))
            {
                if (lich.ToLower().Contains(Ma_Lich.ToLower()) && (lich.Trim().Length == Ma_Lich.Trim().Length ))
                {
                    return true;
                }
            }
            return false;
        }
        public List<LICH> XemLich(string MaNV, DateTime dt)
        {
            var LICH = DB.LICHes.Where(lich => lich.NGAY.Value == dt.Date && lich.MANV == MaNV);
            return LICH.ToList();
        }
        public void Them(string MALICH, string MANV, string MAPHG, string TENCV, string LOAICV, DateTime NGAY, DateTime THOIGIAN, string DIADIEM)
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
                MessageBox.Show("Thêm mới thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm mới thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void Capnhat(string MALICH, string MANV, string MAPHG, string TENCV, string LOAICV, DateTime NGAY, DateTime THOIGIAN, string DIADIEM)
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
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Xoa(string MALICH)
        {
            try
            {
                var lich = DB.LICHes.FirstOrDefault(tk => tk.MALICH == MALICH);
                DB.LICHes.DeleteOnSubmit(lich);
                DB.SubmitChanges();
                MessageBox.Show("Xóa thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Xóa thông tin khách hàng thất bại.", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
