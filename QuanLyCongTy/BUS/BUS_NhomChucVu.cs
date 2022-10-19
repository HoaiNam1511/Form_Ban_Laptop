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
    public class BUS_NhomChucVu
    {
        DAL_NhomChucVu dalNhomChucVu = new DAL_NhomChucVu();
        public DataTable thongTinNhomChucVu()
        {
            return dalNhomChucVu.layThongTinNhomChucVu();
        }
        //public bool themThongTinChucVu(DTO_ChucVu thongTinChucVu)
        //{
        //    return dalChucVu.themThongTinChucVu(thongTinChucVu);
        //}
        //public bool suaThongTinChucVu(string maChucVu, DTO_ChucVu thongTinChucVu)
        //{
        //    return dalChucVu.suaThongTinChucVu(maChucVu, thongTinChucVu);
        //}
        //public bool xoaThongTinChucVu(string maChucVu)
        //{
        //    return dalChucVu.xoaThongTinChucVu(maChucVu);
        //}
    }
}
