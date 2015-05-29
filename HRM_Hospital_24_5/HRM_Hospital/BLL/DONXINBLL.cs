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
        NGAYNGHIBLL bll_ngaynghi = new NGAYNGHIBLL();
        private Boolean check_Empty()
        {
            return this.get_AllRecord().Count == 0;
        }
        public List<DONXIN> get_AllRecord()
        {
            return DB.DONXINs.ToList();
        }

        public string set_MADONXIN()
        {
            string str;
            var AllRecord = this.get_AllRecord();
            if (!check_Empty())
            {
                int max = 0;
                int index = 0;
                foreach (DONXIN rc in AllRecord)
                {
                    str = String.Concat(rc.MADONXIN.Where(char.IsDigit));
                    index = Int16.Parse(str);
                    if (index > max)
                        max = index;
                }
                return "DX" + (max + 1);
            }
            return "DX1";
        }
        public List<DONXIN> get_DONXIN(string MANV)
        {
            return DB.DONXINs.Where(nv => nv.MANV == MANV).ToList();
        }

        public List<string> get_OffDays(string MANV, int THANG)
        {
            List<string> list = new List<string>();
            var DX = DB.DONXINs.Where(rc => rc.MANV == MANV 
                && (rc.TUNGAY.Value.Month == THANG || rc.DENNGAY.Value.Month == THANG)
                ).ToList();
            foreach (DONXIN dx in DX)
            {
                if (dx.DUOCDUYET.Value)
                {
                    int dueday = dx.SONGAYNGHI.Value;
                    int d = 0;
                    while (d++ < dueday)
                    {
                        DateTime dt = dx.TUNGAY.Value.AddDays(d);
                        if (!dt.DayOfWeek.Equals(DayOfWeek.Sunday)
                            && !this.bll_ngaynghi.isOutDay(dt)
                            && dt.Month == THANG)
                            list.Add(dt.DayOfWeek + ": " + dt.Date.ToShortDateString());
                        else
                            dueday++;
                    }
                }
            }
            return list;
        }
        public void Insert(string MANV, int SONGAY, string LYDO, DateTime TUNGAY, DateTime DENNGAY, DateTime NGAYLAPDON )
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
                MessageBox.Show(msg.insert_success, "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(msg.insert_fail, "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
        public void Delete(String MANV)
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
                    MessageBox.Show(msg.delete_success, "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    this.Status += "\nDONXIN: " + msg.delete_success;
            }
            catch
            {
                if (!onMinifrm)
                    MessageBox.Show(msg.delete_fail, "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    this.Status += "\nDONXIN: " + msg.delete_fail;
            }
        }

    }
}
