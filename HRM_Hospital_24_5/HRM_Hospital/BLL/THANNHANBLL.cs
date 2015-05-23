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
    class THANNHANBLL
    {
        QLNSDataContext DB = new QLNSDataContext();
        COTNBLL bll_CTN = new COTNBLL();
        public List<THANNHAN> LayTatCa()
        {
            return DB.THANNHANs.ToList();
        }
        public List<THANNHAN> get_ThanNhan(String MaNV)
        {
            var ThanNhan = from CONT in DB.COTNs
                           from TN in DB.THANNHANs
                           where (CONT.MANV == MaNV && TN.MATN == CONT.MATN)
                           select (TN);
            return ThanNhan.ToList();
        }
        public bool KiemTraMaTrung(string MATN)
        {
            foreach (string ma in (from matn in DB.THANNHANs select matn.MATN))
            {
                if (ma.ToLower().Contains(MATN.ToLower()) && (ma.Trim().Length == MATN.Trim().Length))
                {
                    return true;
                }
            }
            return false;
        }
        public string set_MaTN(string MANV)
        {
            var ThanNhan = from CONT in DB.COTNs
                           where (CONT.MANV == MANV)
                           select (CONT);
            return"T"+(ThanNhan.Count()+1);
            //Ex: NV02TN01
        }
        public string get_MaTN(string MANV)
        {
            var ThanNhan = from CONT in DB.COTNs
                           where (CONT.MANV == MANV)
                           select (CONT);
            return "T" + (ThanNhan.Count() + 1);
            //Ex: NV02TN01
        }
        public void Them(string MATN, string HOTENTN, DateTime NAMSINH, string QUANHE,string NGHENGHIEP,string DVCONGTAC)
        {
            try
            {
                THANNHAN thannhan = new THANNHAN();
                thannhan.MATN = MATN;
                thannhan.HOTENTN = HOTENTN;
                thannhan.NAMSINH = NAMSINH;
                thannhan.QUANHE = QUANHE;
                thannhan.NGHENGHIEP = NGHENGHIEP;
                thannhan.DVCONGTAC = DVCONGTAC;
                DB.THANNHANs.InsertOnSubmit(thannhan);
                DB.SubmitChanges();
                MessageBox.Show("Thêm mới thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm mới thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void Capnhat(string MATN, string HOTENTN, DateTime NAMSINH, string QUANHE, string NGHENGHIEP, string DVCONGTAC)
        {
            try
            {
                var thannhan = DB.THANNHANs.FirstOrDefault(tn => tn.MATN == MATN);
                thannhan.MATN = MATN;
                thannhan.HOTENTN = HOTENTN;
                thannhan.NAMSINH = NAMSINH;
                thannhan.QUANHE = QUANHE;
                thannhan.NGHENGHIEP = NGHENGHIEP;
                thannhan.DVCONGTAC = DVCONGTAC;
                DB.SubmitChanges();
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cập nhật thông tin thất bại", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Xoa(string MATN)
        {
            try
            {
                var thannhan = DB.THANNHANs.FirstOrDefault(tk => tk.MATN == MATN);
                DB.THANNHANs.DeleteOnSubmit(thannhan);
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
