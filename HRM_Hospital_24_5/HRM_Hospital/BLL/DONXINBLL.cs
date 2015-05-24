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
    class DONXINBLL: BLL
    {
        public List<DONXIN> LayTatCa()
        {
            return DB.DONXINs.ToList();
        }

        public string set_MADONXIN()
        {
            string str;
            var DX = DB.DONXINs.ToList();
            if (DX.Count>0)
            {
                str = DX.Last().MADONXIN;
                str = String.Concat(str.Where(char.IsDigit));
                return "D" + (Int16.Parse(str) + 1);
            }
            return "D1";
        }
        public List<DONXIN> get_DONXIN(string MANV)
        {
            return DB.DONXINs.Where(nv => nv.MANV == MANV).ToList();
        }
        public void Them(string MANV, int SONGAY, string LYDO, DateTime TUNGAY, DateTime DENNGAY, DateTime NGAYLAPDON )
        {
            try
            {
                DONXIN donxin = new DONXIN();
                donxin.MADONXIN = this.set_MADONXIN();
                donxin.MANV = MANV;
                donxin.LYDO = LYDO;
                donxin.TUNGAY = TUNGAY;
                donxin.DENNGAY = DENNGAY;
                donxin.SONGAYNGHI = SONGAY;
                donxin.NGAYLAPDON = NGAYLAPDON;
                DB.DONXINs.InsertOnSubmit(donxin);
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
        public void Xoa(String MANV)
        {    
            try
            {
                var DX = (from table in DB.DONXINs
                         where table.MANV == MANV
                         select (table)).ToList();
                foreach (DONXIN d in DX)
                    DB.DONXINs.DeleteOnSubmit(d);
                DB.SubmitChanges();
                if (!onMinifrm)
                    MessageBox.Show("Xoá thông tin thành công.", "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    this.Status += "\nXóa trong Bảng DONXINPHEP: THÀNH CÔNG";
            }
            catch
            {
                if (!onMinifrm)
                    MessageBox.Show("Xóa thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    this.Status += "\nXóa trong Bảng DONXINPHEP: THẤT BẠI";
            }
        }

    }
}
