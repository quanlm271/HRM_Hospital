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
    class THANNHANBLL:BLL
    {
        private Boolean check_Empty()
        {
            return this.get_AllRecord().Count == 0;
        }
        COTNBLL bll_CTN = new COTNBLL();
        public List<THANNHAN> get_AllRecord()
        {
            return DB.THANNHANs.ToList();
        }
        public List<THANNHAN> get_ThanNhan(String MANV)
        {
            var ThanNhan = from CONT in DB.COTNs
                           from TN in DB.THANNHANs
                           where (CONT.MANV == MANV && TN.MATN == CONT.MATN)
                           select (TN);
            return ThanNhan.ToList();
        }
        public string set_MaTN(string MANV)
        {
            string str;
            var AllRecord = this.get_AllRecord();
            if (!check_Empty())
            {
                int max = 0;
                int index = 0;
                foreach (THANNHAN rc in AllRecord)
                {
                    str = String.Concat(rc.MATN.Where(char.IsDigit));
                    index = Int16.Parse(str);
                    if (index > max)
                        max = index;
                }
                return "TN" + (max + 1);
            }
            return "TN1";
            //EX: NV2TN1
        }
        public string get_MaTN(string MANV)
        {
            var ThanNhan = DB.COTNs.Where(rc => rc.MANV == MANV);
            return "T" + (ThanNhan.Count() + 1);
            //Ex: NV02TN01
        }
        public void Insert(string MATN, string HOTENTN, DateTime NAMSINH, string QUANHE,
            string NGHENGHIEP,string DVCONGTAC)
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
                MessageBox.Show(msg.insert_success, "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(msg.insert_fail, "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }

        }
        public void Update(string MATN, string HOTENTN, DateTime NAMSINH, string QUANHE, 
            string NGHENGHIEP, string DVCONGTAC)
        {
            try
            {
                var thannhan = DB.THANNHANs.FirstOrDefault(rc => rc.MATN == MATN);
                thannhan.MATN = MATN;
                thannhan.HOTENTN = HOTENTN;
                thannhan.NAMSINH = NAMSINH;
                thannhan.QUANHE = QUANHE;
                thannhan.NGHENGHIEP = NGHENGHIEP;
                thannhan.DVCONGTAC = DVCONGTAC;
                DB.SubmitChanges();
                MessageBox.Show(msg.update_success, "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cập nhật thông tin thất bại", "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        public void Delete(string MATN)
        {
            try
            {
                var thannhan = DB.THANNHANs.FirstOrDefault(rc => rc.MATN == MATN);
                DB.THANNHANs.DeleteOnSubmit(thannhan);
                DB.SubmitChanges();
                if (!onMinifrm)
                    MessageBox.Show(msg.delete_success, "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    this.Status += "\nXóa trong bảng THANNHAN: THÀNH CÔNG";
            }
            catch
            {
                if (!onMinifrm)
                    MessageBox.Show("Xóa thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                else
                    this.Status += "\nXóa trong bảng THANNHAN: THẤT BẠI";
            }
        }
    }
}
