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
    class LICHBLL : BLL
    {
        private Boolean check_Empty()
        {
            return this.get_AllRecord().Count == 0;
        }
        public List<LICH> get_AllRecord()
        {
            return DB.LICHes.OrderBy(rc=>rc.MANV).ToList();
        }

        public List<DateTime> get_WorkDate(string MANV)
        {
            var LICH = from table in DB.LICHes
                       where (table.MANV == MANV)
                       select (table.NGAY.Value);
            return LICH.ToList();

        }

        public List<LICH> ViewByMonth(string MANV, int month)
        {
            var LICH = from table in DB.LICHes
                       where (table.MANV == MANV && table.NGAY.Value.Month==month 
                       && table.NGAY.Value.Year == DateTime.Now.Year)
                       select (table);
            return LICH.OrderBy(rc => rc.NGAY).ToList();
            
            
        }

        public List<LICH> ViewByDate(string MANV, DateTime dt)
        {
           return DB.LICHes.Where(rc => rc.NGAY.Value == dt.Date && rc.MANV == MANV).OrderBy(rc => rc.NGAY).ToList() ;
        }

        public string set_MALICH()
        {
            string str;
            var AllRecord = this.get_AllRecord();
            if (!check_Empty())
            {
                int max = 0;
                int index = 0;
                foreach (LICH li in AllRecord)
                {
                    str = String.Concat(li.MALICH.Where(char.IsDigit));
                    index = Int16.Parse(str);
                    if (index > max)
                        max = index;
                }
                return "L" + (max+1);
            }
            return "L1";
        }
        public List<LICH> get_MANV(string MANV)
        {
            try
            {
                return DB.LICHes.Where(rc => rc.MANV == MANV).OrderBy(rc => rc.NGAY).ToList();

            }
            catch
            {
                MessageBox.Show(msg.get_fail, "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            return null;
        }
        public bool check_isDuplicateDT(string MANV, string MALICH, string DIADIEM, DateTime dt, TimeSpan t)
        {
            try
            {

                //duplicate day and time
                var li = DB.LICHes.Where(rc => rc.MANV == MANV
                    && rc.MALICH != MALICH
                    && rc.NGAY.Value.Date == dt.Date
                    && rc.THOIGIAN.Value == t).FirstOrDefault();
                if (li != null)
                    return true;                
            }
            catch
            {
                MessageBox.Show(msg.check_fail, "Thông báo.", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        public void Insert(string MALICH, string MANV, string MAPHG, string TENCV, 
            string LOAICV, DateTime NGAY, TimeSpan THOIGIAN, string DIADIEM, bool CODILAM)
        {
            string day = NGAY.Date.ToShortDateString();
            string time = THOIGIAN.ToString();
            try
            {
                DB.SubmitChanges();
                if (!this.check_isDuplicateDT(MANV, MALICH, DIADIEM, NGAY, THOIGIAN))
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
                    lich.CODILAM = CODILAM;
                    DB.LICHes.InsertOnSubmit(lich);
                    DB.SubmitChanges();
                    if(!onMinifrm)
                        MessageBox.Show(msg.insert_success, "Thông báo.", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã có việc vào: "+ time +" Ngày: "+ day, "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    DB.SubmitChanges();
                }

            }
            catch
            {
                MessageBox.Show(msg.insert_fail, "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }
        public void Update(string MALICH, string MANV, string MAPHG, string TENCV, 
            string LOAICV, DateTime NGAY, TimeSpan THOIGIAN, string DIADIEM, bool CODILAM)
        {
            try
            {
                if (!this.check_isDuplicateDT(MANV, MALICH, DIADIEM, NGAY, THOIGIAN))
                {
                    var lich = DB.LICHes.FirstOrDefault(rc => rc.MALICH == MALICH);
                    lich.MAPHG = MAPHG;
                    lich.TENCV = TENCV;
                    lich.LOAICV = LOAICV;
                    lich.NGAY = NGAY;
                    lich.THOIGIAN = THOIGIAN;
                    lich.DIADIEM = DIADIEM;
                    lich.CODILAM = CODILAM;
                    DB.SubmitChanges();
                    MessageBox.Show(msg.update_success, "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã có việc cho ngày và giờ này", "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    DB.SubmitChanges();
                }
            }
            catch
            {
                MessageBox.Show(msg.update_fail, "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
        public void Delete(string MALICH)
        {
            try
            {
                var lich = DB.LICHes.FirstOrDefault(tk => tk.MALICH == MALICH);
                DB.LICHes.DeleteOnSubmit(lich);
                DB.SubmitChanges();
                MessageBox.Show(msg.delete_success, "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show(msg.delete_fail, "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void Delete_MANV(string MANV)
        {
            try
            {
                var lich = DB.LICHes.Where(li => li.MANV == MANV);
                foreach (LICH li in lich)
                    DB.LICHes.DeleteOnSubmit(li);
                DB.SubmitChanges();
                this.Status += "\nLICH: " + msg.delete_success;
            }
            catch
            {
                this.Status += "\nLICH: " + msg.delete_fail;
            }

        }
    }
}

