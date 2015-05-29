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
    class NHANVIENBLL:BLL
    {

        public Boolean check_Empty()
        {
            return this.get_AllRecord().Count == 0;
        }
        public List<NHANVIEN> get_AllRecord()
        {
            try
            {

                return DB.NHANVIENs.ToList();
            }
            catch
            {
                MessageBox.Show(msg.get_fail, "Thông báo.", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            return null;
        }


        public List<string> get_MANV()
        {
            try
            {
                if (check_Empty())
                    return null;
                var listMANV = from table in DB.NHANVIENs select table.MANV;
                return listMANV.ToList();
            }
            catch
            {
                MessageBox.Show(msg.get_fail, "Thông báo.", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            return null;
        }
        public void Insert(string MANV, string HOTENNV, DateTime NGAYSINH, bool PHAI, string CMND, 
           string QUEQUAN, string DANTOC, string TONGIAO, bool GIADINHLIETSI,
           string NGACH, string BAC, string LOAINV, string MABANGCC)
        {
            
            try
            {
                DB.SubmitChanges();
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = MANV;
                nv.HOTENNV = HOTENNV;
                nv.CMND = CMND;
                nv.PHAI = PHAI;
                nv.NGAYSINH = NGAYSINH;        
                nv.NOIOHIENTAI = QUEQUAN;
                nv.TONGIAO = TONGIAO;
                nv.DANTOC = DANTOC;
                nv.NGACH = NGACH;
                nv.BAC = BAC;
                nv.GIADINHLIETSI = GIADINHLIETSI;
                nv.LOAINV = LOAINV;
                nv.MA_BANGCC = MABANGCC;
                DB.NHANVIENs.InsertOnSubmit(nv);
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
        public void Update(string MANV, string HOTENNV, DateTime NGAYSINH, bool PHAI, string CMND,
           string QUEQUAN, string DANTOC, string TONGIAO, bool GIADINHLIETSI,
           string NGACH, string BAC, string LOAINV)
        {
            
            try
            {
                DB.SubmitChanges();
                var nv = DB.NHANVIENs.FirstOrDefault(rc => rc.MANV == MANV);
                nv.MANV = MANV;
                nv.HOTENNV = HOTENNV;
                nv.CMND = CMND;
                nv.PHAI = PHAI;
                nv.NGAYSINH = NGAYSINH;
                nv.NOIOHIENTAI = QUEQUAN;
                nv.TONGIAO = TONGIAO;
                nv.DANTOC = DANTOC;
                nv.NGACH = NGACH;
                nv.BAC = BAC;
                nv.GIADINHLIETSI = GIADINHLIETSI;
                nv.LOAINV = LOAINV;
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
        public void Delete(string MANV)
        {
           
            try
            {
                DB.SubmitChanges();
                //ORDER DELETION, PLEASE DO NOT CHANGE  

                //1. Delete MANV in DONXINs
                DONXINBLL DX = new DONXINBLL();
                DX.onMinifrm = this.onMinifrm;
                DX.Delete(MANV);
                this.Status+=(DX.Status);


                //2. Delete MANV in TAIKHOANs
                TAIKHOANBLL TK = new TAIKHOANBLL();
                TK.onMinifrm = this.onMinifrm;
                TK.Delete(MANV);
                this.Status+=(TK.Status);


                //4. Delete MANV in QTCONGTACs
                QTCONGTACBLL QTCT = new QTCONGTACBLL();
                QTCT.onMinifrm = this.onMinifrm;
                QTCT.Delete_MANV(MANV);
                this.Status+=(QTCT.Status);

                //5. Delete MANV in LICHs
                LICHBLL LI = new LICHBLL();
                LI.onMinifrm = this.onMinifrm;
                LI.Delete_MANV(MANV);
                this.Status+=(LI.Status);

                //6. Delete MANV in COTNs
                COTNBLL COTN = new COTNBLL();
                COTN.onMinifrm = this.onMinifrm;
                COTN.Delete_MANV(MANV);
                this.Status+=(COTN.Status);
                
                //7. Delete MANV in QUYETDINHs
                QUYETDINHBLL QD = new QUYETDINHBLL();
                QD.onMinifrm = this.onMinifrm;
                QD.Delete_MANV(MANV);
                this.Status+=(QD.Status);

                //8. Delete MANV in TRINHDONGHIEPVUs
                TRINHDOBLL TD = new TRINHDOBLL();
                TD.onMinifrm = this.onMinifrm;
                TD.Delete_MANV(MANV);
                this.Status+=(TD.Status);

                var NVIEN = DB.NHANVIENs.FirstOrDefault(rc => rc.MANV == MANV);
                DB.NHANVIENs.DeleteOnSubmit(NVIEN);
                DB.SubmitChanges();
                //3. Delete MABCC in BANGCCs
                BANGCHAMCONGBLL BCC = new BANGCHAMCONGBLL();
                BCC.onMinifrm = this.onMinifrm;
                BCC.Delete(this.get_MABCC(MANV));
                this.Status += (BCC.Status);


                this.Status+="\nNHANVIEN: " + msg.delete_success;

                MessageBox.Show(this.Status, "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            catch
            {
                this.Status += "\nNHANVIEN: " + msg.delete_fail;
                 MessageBox.Show(this.Status, "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public string set_MANV()
        {
            string str;
            var AllRecord = this.get_AllRecord();
            if (!check_Empty())
            {
                int max = 0;
                int index = 0;
                foreach (NHANVIEN rc in AllRecord)
                {
                    str = String.Concat(rc.MANV.Where(char.IsDigit));
                    index = Int16.Parse(str);
                    if (index > max)
                        max = index;
                }
                return "NV" + (max + 1);
            }
            return "NV1";
        }
        public string get_MABCC(string MANV)
        {
            try
            {
                if (check_Empty())
                    return null;
                var nhanvien = DB.NHANVIENs.FirstOrDefault(rc => rc.MANV == MANV);
                return nhanvien.MA_BANGCC;
            }
            catch
            {
                MessageBox.Show(msg.get_fail, "Thông báo.", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            return null;
        }
        public string get_TEN(string MANV)
        {
            try
            {
                if (check_Empty() || MANV=="")
                    return null ;
                var nhanvien = DB.NHANVIENs.FirstOrDefault(rc => rc.MANV == MANV);
                return nhanvien.HOTENNV;
            }
            catch
            {
                MessageBox.Show(msg.get_fail, "Thông báo.", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            return null;
        }
    }
}
