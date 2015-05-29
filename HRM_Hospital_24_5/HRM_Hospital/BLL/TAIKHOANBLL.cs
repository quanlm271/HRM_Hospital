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
      
        public List<TAIKHOAN> get_AllRecord()
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

        //For UM form to load MANV of all user
        public List<String> get_MANV()
        {
            var taikhoan = (from Table in DB.NHANVIENs
                            select (Table.MANV)).ToList();
            return taikhoan;
        }

        //For Login form to load user's MANV 
        public string get_MANV(string TENDANGNHAP)
        {
            var taikhoan = DB.TAIKHOANs.Where(tk => tk.TENDANGNHAP == TENDANGNHAP).FirstOrDefault();
            return taikhoan.MANV;
        }

        public int check_Login(string TENDANGNHAP, string MATKHAU)
        {
            try
            {
                if (TENDANGNHAP =="root") //is root
                {
                    if (MATKHAU == "123456")
                        return -1;
                }
                else
                {
                    var taikhoan = DB.TAIKHOANs.Where(tk => tk.TENDANGNHAP == TENDANGNHAP
                        && tk.MATKHAU == MATKHAU).FirstOrDefault();
                    if (taikhoan != null)
                    {
                        if (taikhoan.QUYENTRUYCAP == true) //is admin
                            return 1;
                        else
                            return 0;
                    }
                }
            }
            catch
            {
                MessageBox.Show(msg.check_login_fail, "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            return 2;
        }

        public void Insert(string TENDANGNHAP, string MANV, string MATKHAU, bool QUYENTRUYCAP)
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
                MessageBox.Show(msg.insert_success, "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(msg.insert_fail, "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            
        }

        public void Update(string TENDANGNHAP, string MANV, string MATKHAU, bool QUYENTRUYCAP)
        {
            try
            {
                var taikhoan = DB.TAIKHOANs.FirstOrDefault(tk => tk.MANV == MANV);
                taikhoan.MATKHAU = MATKHAU;
                taikhoan.QUYENTRUYCAP = QUYENTRUYCAP;
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

        public void Delete(string MANV)
        {
            try
            {
                var taikhoan = DB.TAIKHOANs.FirstOrDefault(rc => rc.MANV == MANV);
                if (taikhoan != null)
                {
                    DB.TAIKHOANs.DeleteOnSubmit(taikhoan);
                    DB.SubmitChanges();
                    if (!onMinifrm)
                        MessageBox.Show(msg.delete_success, "Thông báo.", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        this.Status += "\nTAIKHOAN: " + msg.delete_success;
                }
                   
            }
            catch
            {
                if (!onMinifrm)
                    MessageBox.Show(msg.delete_fail, "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    this.Status += "\nTAIKHOAN: " + msg.delete_fail;
            }
        }
    }
}
