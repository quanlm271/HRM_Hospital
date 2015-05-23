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
    class TAIKHOANBLL
    {
        QLNSDataContext DB = new QLNSDataContext();
        public List<TAIKHOAN> LayTatCa()
        {
            return DB.TAIKHOANs.ToList();
        }
        public bool KiemTraMaTrung(string TenDN)
        {
            foreach (string nv in (from record in DB.TAIKHOANs select record.TENDANGNHAP))
            {
                if ((nv.ToLower().Contains(TenDN.ToLower()) == true) && (nv.Trim().Length == TenDN.Trim().Length))
                {
                    return true;
                }
            }
            return false;
        }

        public bool KiemTraNV(string MaNV)
        {
            foreach (string nv in (from record in DB.TAIKHOANs select record.MANV))
            {
                if ((nv.ToLower().Contains(MaNV.ToLower()) == true) && (nv.Trim().Length == MaNV.Trim().Length))
                {
                    return true;
                }
            }
            return false;
        }

        public string LayMaNV(string TENDANGNHAP,  string MATKHAU)
        {
            try
            {
                var taikhoan = DB.TAIKHOANs.Where(tk => tk.TENDANGNHAP == TENDANGNHAP && tk.MATKHAU == MATKHAU).FirstOrDefault();
                return taikhoan.MANV.ToString(); 
            }
            catch
            {
                MessageBox.Show("Kiểm tra đăng nhập thất bại.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return "";
        }
        public int KiemTra_DangNhap(string TENDANGNHAP, string MATKHAU)
        {
            try
            {
                var taikhoan = DB.TAIKHOANs.Where(tk => tk.TENDANGNHAP == TENDANGNHAP && tk.MATKHAU == MATKHAU).FirstOrDefault();
                if(taikhoan!=null)
                {
                    if (taikhoan.QUYENTRUYCAP == true) //la admin
                        return 1;
                    else
                        return 0;
                }
            }
            catch
            {
                MessageBox.Show("Kiểm tra đăng nhập thất bại.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return -1;
        }

        public void Them(string TENDANGNHAP, string MANV, string MATKHAU, bool QUYENTRUYCAP)
        {
            try
            {
                TAIKHOAN taikhoan = new TAIKHOAN();
                taikhoan.TENDANGNHAP = TENDANGNHAP;
                taikhoan.MANV = MANV;
                taikhoan.MATKHAU = MATKHAU;
                taikhoan.QUYENTRUYCAP = QUYENTRUYCAP;
                DB.TAIKHOANs.InsertOnSubmit(taikhoan);
                DB.SubmitChanges();
                MessageBox.Show("Thêm mới thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Chưa có mã nhân viên tương ứng.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public void Capnhat(string TENDANGNHAP, string MANV, string MATKHAU, bool QUYENTRUYCAP)
        {
            try
            {
                var taikhoan = DB.TAIKHOANs.FirstOrDefault(tk => tk.MANV == MANV);
                taikhoan.MATKHAU = MATKHAU;
                taikhoan.QUYENTRUYCAP = QUYENTRUYCAP;
                DB.SubmitChanges();
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cập nhật thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void Xoa(string TENDANGNHAP)
        {
            try
            {
                var taikhoan = DB.TAIKHOANs.FirstOrDefault(tk => tk.TENDANGNHAP == TENDANGNHAP);
                DB.TAIKHOANs.DeleteOnSubmit(taikhoan);
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
