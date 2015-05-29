using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM_Hospital.DAL;
using System.Windows.Forms;

namespace HRM_Hospital.BLL
{
    class NGAYNGHIBLL:BLL
    {
        public bool isOutDay(DateTime dt)
        {

            return DB.NGAYNGHIs.Select(rc => rc.NGAY).ToList().IndexOf(dt.Date) > -1;
        }

        public Boolean check_Empty()
        {
            return this.get_AllRecord().Count == 0;
        }
 
        public List<DateTime> get_AllRecord()
        {
            try
            {

                return DB.NGAYNGHIs.Select(rc => rc.NGAY).ToList();
            }
            catch
            {
                MessageBox.Show(msg.get_fail, "Thông báo.", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            return null;
        }
        public void Insert(DateTime dt)
        {
            try
            {
                DB.SubmitChanges();
                NGAYNGHI nn = new NGAYNGHI();
                nn.NGAY = dt.Date;
                if (this.get_AllRecord().ToList().IndexOf(dt.Date) == -1)
                {
                    DB.NGAYNGHIs.InsertOnSubmit(nn);
                    DB.SubmitChanges();
                }
            }
            catch
            {
                MessageBox.Show(msg.insert_fail, "Thông báo.", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
        }
        public void Delete(DateTime dt)
        {
            try
            {
                DB.SubmitChanges();
                var nn = DB.NGAYNGHIs.Where(rc => rc.NGAY == dt.Date).FirstOrDefault();
                DB.NGAYNGHIs.DeleteOnSubmit(nn);
                DB.SubmitChanges();
            }
            catch
            {
                MessageBox.Show(msg.delete_fail, "Thông báo.", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
        
        }

    }
}
