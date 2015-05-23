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
    class NHANVIENBLL
    {
        QLNSDataContext DB = new QLNSDataContext();
        public List<NHANVIEN> LayTatCa()
        {
            return DB.NHANVIENs.ToList();
        }


        public List<string> LayMaNV()
        {
            List<string> str = new List<string>();
            foreach (string ma in (from MaNV1 in DB.NHANVIENs select MaNV1.MANV))
            {
                str.Add(ma);
            }
            return str;
        }

        public bool KiemTraMaTrung(string Ma_NHANVIEN)
        {
            foreach (string nv in (from record in DB.NHANVIENs select record.MANV))
            {
                if ((nv.ToLower().Contains(Ma_NHANVIEN.ToLower()) == true) && (nv.Trim().Length == Ma_NHANVIEN.Trim().Length))
                {
                    return true;
                }
            }
            return false;
        }

        public void Them(string MANV, string HOTENNV, string CMND, bool PHAI, DateTime NGAYSINH, string QUEQUAN,string DANHHIEU)
        {
            try
            {
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = MANV;
                nv.HOTENNV = HOTENNV;
                nv.CMND = CMND;
                nv.PHAI = PHAI;
                nv.NGAYSINH = NGAYSINH;        
                nv.QUEQUAN = QUEQUAN;
                nv.DANHHIEU = DANHHIEU;
                DB.NHANVIENs.InsertOnSubmit(nv);
                DB.SubmitChanges();
                MessageBox.Show("Thêm mới thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm mới thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void Capnhat(string MANV, string HOTENNV, string CMND, bool PHAI, DateTime NGAYSINH, string QUEQUAN, string DANHHIEU)
        {
            try
            {
                var nv = DB.NHANVIENs.FirstOrDefault(tk => tk.MANV == MANV);
                nv.MANV = MANV;
                nv.HOTENNV = HOTENNV;
                nv.CMND = CMND;
                nv.PHAI = PHAI;
                nv.NGAYSINH = NGAYSINH;
                nv.QUEQUAN = QUEQUAN;
                nv.DANHHIEU = DANHHIEU;
                DB.SubmitChanges();
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cập nhật thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Xoa(string MANHANVIEN)
        {
            try
            {
                var nv = DB.NHANVIENs.FirstOrDefault(tk => tk.MANV == MANHANVIEN);
                DB.NHANVIENs.DeleteOnSubmit(nv);
                DB.SubmitChanges();
                MessageBox.Show("Xóa thông tin thành công.", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Xóa thông tin thất bại.", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public string set_MANV()
        {
            return "N" + (DB.NHANVIENs.Count() + 1);
        }
        public string get_MABCC(string MANV)
        {
            var nhanvien = DB.NHANVIENs.FirstOrDefault(nv => nv.MANV == MANV);
            return nhanvien.MA_BANGCC;
        }
        public string get_TEN(string MANV)
        {
            var nhanvien = DB.NHANVIENs.FirstOrDefault(nv => nv.MANV == MANV);
            return nhanvien.HOTENNV;
        }
    }
}
