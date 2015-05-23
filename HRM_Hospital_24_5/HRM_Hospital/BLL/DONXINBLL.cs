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
    class DONXINBLL
    {
        QLNSDataContext DB = new QLNSDataContext();

        public List<DONXIN> LayTatCa()
        {
            return DB.DONXINs.ToList();
        }

        public int set_MADONXIN()
        {
            return DB.DONXINs.Count()+1;
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
                donxin.MADONXIN = this.set_MADONXIN().ToString();
                donxin.MANV = MANV;
                donxin.LYDO = LYDO;
                donxin.TUNGAY = TUNGAY;
                donxin.DENNGAY = DENNGAY;
                donxin.SONGAYNGHI = SONGAY;
                donxin.NGAYLAPDON = NGAYLAPDON;
                DB.DONXINs.InsertOnSubmit(donxin);
                DB.SubmitChanges();
                MessageBox.Show("Thêm mới thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm mới thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}
