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
        public List<NHANVIEN> LayTatCa()
        {
            return DB.NHANVIENs.ToList();
        }


        public List<string> LayMANV()
        {
            var listMANV = from table in DB.NHANVIENs select table.MANV;
            return listMANV.ToList();
        }

        public bool KiemTraMaTrung(string Ma_NHANVIEN)
        {
            foreach (string nv in (from record in DB.NHANVIENs select record.MANV))
            {
                if ((nv.ToLower().Contains(Ma_NHANVIEN.ToLower()) == true)
                    && (nv.Trim().Length == Ma_NHANVIEN.Trim().Length))
                {
                    return true;
                }
            }
            return false;
        }

        public void Them(string MANV,
                         string HOTENNV,
                         string CMND,
                         bool PHAI,
                         DateTime NGAYSINH,
                         string QUEQUAN,
                         string DANHHIEU)
        {
            try
            {
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = MANV;
                nv.HOTENNV = HOTENNV;
                nv.CMND = CMND;
                nv.PHAI = PHAI;
                nv.NGAYSINH = NGAYSINH;        
                nv.QUEQUAN = QUEQUAN;
                nv.DANHHIEU = DANHHIEU;
                DB.NHANVIENs.InsertOnSubmit(nv);
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
        public void Capnhat(string MANV, string HOTENNV, string CMND, bool PHAI, 
            DateTime NGAYSINH, string QUEQUAN, string DANHHIEU)
        {
            try
            {
                var nv = DB.NHANVIENs.FirstOrDefault(tk => tk.MANV == MANV);
                nv.MANV = MANV;
                nv.HOTENNV = HOTENNV;
                nv.CMND = CMND;
                nv.PHAI = PHAI;
                nv.NGAYSINH = NGAYSINH;
                nv.QUEQUAN = QUEQUAN;
                nv.DANHHIEU = DANHHIEU;
                DB.SubmitChanges();
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cập nhật thông tin thất bại.", "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
        public void Xoa(string MANV)
        {
            try
            {
                //ORDER DELETION, PLEASE DO NOT CHANGE  

                //1. Delete MANV in DONXINs
                DONXINBLL DX = new DONXINBLL();
                DX.onMinifrm = this.onMinifrm;
                DX.Xoa(MANV);
                this.Status+=(DX.Status);


                //2. Delete MANV in TAIKHOANs
                TAIKHOANBLL TK = new TAIKHOANBLL();
                TK.onMinifrm = this.onMinifrm;
                TK.Xoa(MANV);
                this.Status+=(TK.Status);

                //3. Delete MANV in LUONGs
                LUONGBLL LUO = new LUONGBLL();
                LUO.onMinifrm = this.onMinifrm;
                LUO.Xoa(MANV);
                this.Status+=(LUO.Status);

                //4. Delete MANV in QTCONGTACs
                QTCONGTACBLL QTCT = new QTCONGTACBLL();
                QTCT.onMinifrm = this.onMinifrm;
                QTCT.Xoa_MANV(MANV);
                this.Status+=(QTCT.Status);

                //5. Delete MANV in LICHs
                LICHBLL LI = new LICHBLL();
                LI.onMinifrm = this.onMinifrm;
                LI.Xoa_MANV(MANV);
                this.Status+=(LI.Status);

                //6. Delete MANV in COTNs
                COTNBLL COTN = new COTNBLL();
                COTN.onMinifrm = this.onMinifrm;
                COTN.Xoa_MANV(MANV);
                this.Status+=(COTN.Status);
                
                //7. Delete MANV in QUYETDINHs
                QUYETDINHBLL QD = new QUYETDINHBLL();
                QD.onMinifrm = this.onMinifrm;
                QD.Xoa_MANV(MANV);
                this.Status+=(QD.Status);

                //8. Delete MANV in TRINHDONGHIEPVUs
                TRINHDOBLL TD = new TRINHDOBLL();
                TD.onMinifrm = this.onMinifrm;
                TD.Xoa_MANV(MANV);
                this.Status+=(TD.Status);

                var NVIEN = DB.NHANVIENs.FirstOrDefault(nv => nv.MANV == MANV);
                DB.NHANVIENs.DeleteOnSubmit(NVIEN);

                DB.SubmitChanges();
                this.Status+="\nĐã xóa thành công nhân viên: " + MANV;

                MessageBox.Show(this.Status, "Thông báo.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            catch
            {
                 this.Status +="\nXóa thất bại!";
                 MessageBox.Show(this.Status, "Thông báo.", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        public string set_MANV()
        {
            string str;
            var lastNV = DB.NHANVIENs.ToList();
            str = lastNV.Last().MANV;
            str = String.Concat(str.Where(char.IsDigit));
            return "NV" + (Int16.Parse(str) + 1);
        }
        public string get_MABCC(string MANV)
        {
            var nhanvien = DB.NHANVIENs.FirstOrDefault(nv => nv.MANV == MANV);
            return nhanvien.MA_BANGCC;
        }
        public string get_TEN(string MANV)
        {
            var nhanvien = DB.NHANVIENs.FirstOrDefault(nv => nv.MANV == MANV);
            return nhanvien.HOTENNV;
        }
    }
}
