using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM_Hospital.DAL;
using System.Windows.Forms;

namespace HRM_Hospital.BLL
{
    class LUONGBLL:BLL
    {
        public string get_TenNV(string MANV)
        {
            return DB.NHANVIENs.Where(nv => nv.MANV == MANV).Select(nv => nv.HOTENNV).ToString();
        }
        public void Xoa(string MANV)
        {
            try
            {
                var LUO = DB.LUONGs.Where(lg => lg.MANV == MANV);
                foreach (LUONG luo in LUO)
                    DB.LUONGs.DeleteOnSubmit(luo);
                DB.SubmitChanges();
                if (!onMinifrm)
                    MessageBox.Show("Xóa thông tin thành công.", "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    this.Status += "\nXóa trong Bảng LUONG: THÀNH CÔNG";
            }
            catch
            {
                if (!onMinifrm)
                    MessageBox.Show("Xóa thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    this.Status += "\nXóa trong Bảng LUONG: THẤT BẠI";
            }
        }
    }
    
}
