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
    public class BUS_KetQua
    {
        DAL_KetQua dal_KetQua = new DAL_KetQua();
        public DataTable thongTinKetQua()
        {
            return dal_KetQua.thongTinKetQua();
        }
        public bool themThongTinKetQua(DTO_KetQua thongTinKetQua)
        {
            return dal_KetQua.themKetQua(thongTinKetQua);
        }
        public bool suaThongTinKetQua(DTO_KetQua thongTinKetQua,string maKetQua)
        {
            return dal_KetQua.suaKetQua(thongTinKetQua, maKetQua);
        }
        public bool xoaThongTinKetQua(string maKetQua)
        {
            return dal_KetQua.xoaKetQua(maKetQua);
        }
    }
}
