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
    
    public class BUS_HauQua
    {
        DAL_HauQua dal_HauQua = new DAL_HauQua();
        public DataTable thongTinHauQua()
        {
            return dal_HauQua.thongTinHauQua();
        }
        public bool themThongTinHauQua(DTO_HauQua thongTinHauQua)
        {
            return dal_HauQua.themHauQua(thongTinHauQua);
        }
        public bool xoaThongTinHauQua(string maHauQua)
        {
            return dal_HauQua.xoaHauQua( maHauQua);
        }
        public bool suaThongTinHauQua(DTO_HauQua thongTinHauQua, string maHauQua)
        {
            return dal_HauQua.suaHauQua(thongTinHauQua, maHauQua);
        }
    }
}
