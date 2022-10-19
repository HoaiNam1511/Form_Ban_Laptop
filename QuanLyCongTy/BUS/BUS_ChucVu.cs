using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    
    public class BUS_ChucVu
    {
        DAL_ChucVu dalChucVu = new DAL_ChucVu();
        public DataTable layIdChucVu(string Ten_chuc_vu)
        {
            return dalChucVu.layIdChucVu(Ten_chuc_vu);
        }
        public DataTable thongTinChucVu()
        {
            return dalChucVu.layThongTinChucVu();
        }
        public DataTable thongTinMotChucVuDESC()
        {
            return dalChucVu.layThongTinMotChucVuDESC();
        }
        public DataTable thongTinChucVuNhom(string maNhomChucVu)
        {
            return dalChucVu.layThongTinChucVuNhom(maNhomChucVu);
        }
        public bool themThongTinChucVu(DTO_ChucVu thongTinChucVu)
        {
            return dalChucVu.themThongTinChucVu(thongTinChucVu);
        }
        public bool suaThongTinChucVu(string maChucVu, DTO_ChucVu thongTinChucVu)
        {
            return dalChucVu.suaThongTinChucVu(maChucVu, thongTinChucVu);
        }
        public bool xoaThongTinChucVu(string maChucVu)
        {
            return dalChucVu.xoaThongTinChucVu(maChucVu);
        }
    }
}
