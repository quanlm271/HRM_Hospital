using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM_Hospital.DAL;

namespace HRM_Hospital.BLL
{
    class LUONGBLL
    {
        QLNSDataContext DB = new QLNSDataContext();
        public string get_TenNV(string MANV)
        {
            return DB.NHANVIENs.Where(nv => nv.MANV == MANV).Select(nv => nv.HOTENNV).ToString();
        }
    }
    
}
