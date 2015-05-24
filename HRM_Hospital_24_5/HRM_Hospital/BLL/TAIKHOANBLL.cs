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
    class TAIKHOANBLL:BLL
    {
      
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

        public bool KiemTraNV(string MANV)
        {
            foreach (string nv in (from record in DB.TAIKHOANs select record.MANV))
            {
                if ((nv.ToLower().Contains(MANV.ToLower()) == true) && (nv.Trim().Length == MANV.Trim().Length))
                {
                    return true;
                }
            }
            return false;
        }

        //For UM form to load MANV of all user
        public List<String> LayMANV()
        {
            try
            {
                var taikhoan = (from Table in DB.NHANVIENs
                               select (Table.MANV)).ToList();
                return taikhoan;
            }
            catch
            {
                MessageBox.Show("Error!", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;
        }

        //For Login form to load user's MANV 
        public string LayMANV(string TENDANGNHAP)
        {
            try
            {
                var taikhoan = DB.TAIKHOANs.Where(tk => tk.TENDANGNHAP == TENDANGNHAP).FirstOrDefault();
                return taikhoan.MANV;
            }
            catch
            {
                MessageBox.Show("Error!", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return "";
        }

        public int KiemTra_DangNhap(string TENDANGNHAP, string MATKHAU)
        {
            try
            {
                var taikhoan = DB.TAIKHOANs.Where(tk => tk.TENDANGNHAP == TENDANGNHAP 
                    && tk.MATKHAU == MATKHAU).FirstOrDefault();
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
                MessageBox.Show("Kiểm tra đăng nhập thất bại.", "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
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
                MessageBox.Show("Thêm mới thông tin thành công.", "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm mới thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
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
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cập nhật thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }

        }

        public void Xoa(string MANV)
        {
            try
            {
                var taikhoan = DB.TAIKHOANs.FirstOrDefault(rc => rc.MANV == MANV);
                if (taikhoan != null)
                {
                    DB.TAIKHOANs.DeleteOnSubmit(taikhoan);
                    DB.SubmitChanges();
                    if (!onMinifrm)
                        MessageBox.Show("Xóa thông tin thành công.", "Thông báo.", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        this.Status += "\nXóa trong Bảng TAIKHOAN: THÀNH CÔNG";
                }
                   
            }
            catch
            {
                if (!onMinifrm)
                    MessageBox.Show("Thêm mới thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    this.Status += "\nXóa trong Bảng TAIKHOAN: THẤT BẠI";
            }
        }
    }
}
