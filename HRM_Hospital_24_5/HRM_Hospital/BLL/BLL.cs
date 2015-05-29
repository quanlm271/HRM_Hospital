using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM_Hospital.BLL;
using HRM_Hospital.DAL;

namespace HRM_Hospital.BLL
{
    class BLL
    {
        protected QLNSDataContext DB = new QLNSDataContext();
        public string Status;
        public Boolean onMinifrm = false;
        protected MessageString msg = new MessageString();
    }
}
