using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM_Hospital.DAL;
using System.Windows.Forms;

namespace HRM_Hospital.BLL
{
    class PHONGKHOABLL:BLL
    {
        public Boolean check_Empty()
        {
            return this.get_AllRecord().Count == 0;
        }
        public List<PHONGKHOA> get_AllRecord()
        {
            try
            {
                return DB.PHONGKHOAs.ToList();
            }
            catch
            {
                MessageBox.Show(msg.get_fail, "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            return null;
        }
        public List<string> get_MaPHG()
        {
            try
            {
                var phong = from tb in DB.PHONGKHOAs
                            select (tb.MAPHG);
                return phong.ToList();
            }
            catch
            {
                MessageBox.Show(msg.get_fail, "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            return null;
        }


        public string set_MAPHG()
        {
            string str;
            var AllRecord = this.get_AllRecord();
            if (!check_Empty())
            {
                int max = 0;
                int index = 0;
                foreach (PHONGKHOA rc in AllRecord)
                {
                    str = String.Concat(rc.MAPHG.Where(char.IsDigit));
                    index = Int16.Parse(str);
                    if (index > max)
                        max = index;
                }
                return "PH" + (max + 1);
            }
            return "PH1";
        }

        public void Insert(string MaPHG, string TENPHG, string KHOI)
        {
            try
            {
                PHONGKHOA nv = new PHONGKHOA();
                nv.MAPHG = MaPHG;
                nv.TENPHG = TENPHG;
                nv.KHOI = KHOI;
                DB.PHONGKHOAs.InsertOnSubmit(nv);
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
        public void Update(string MaPHG, string TENPHG, string KHOI)
        {
            try
            {
                var nv = DB.PHONGKHOAs.FirstOrDefault(rc => rc.MAPHG == MaPHG);
                nv.MAPHG = MaPHG;
                nv.TENPHG = TENPHG;
                nv.KHOI = KHOI;
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
    }
}
