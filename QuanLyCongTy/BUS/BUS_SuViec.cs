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
    public class BUS_SuViec
    {
        DAL_SuViec dal_SuViec = new DAL_SuViec();
        public DataTable thongTinSuViec()
        {
            return dal_SuViec.thongTinSuViec();
        }
        public DataTable thongTinMotSuViec(string maSuViec)
        {
            return dal_SuViec.thongTinMotSuViec(maSuViec);
        }

        public bool themThongTinSuViec(DTO_SuViec thongTinSuViec,string maHauQua,string maKetQua)
        {
            return dal_SuViec.themThongTinSuViec(thongTinSuViec, maHauQua,maKetQua);
        }
        public bool suaThongSuViec(DTO_SuViec thongTinSuViec, string maSuViec)
        {
            return dal_SuViec.suaThongSuViec(thongTinSuViec, maSuViec);
        }
        public bool xoaThongTinSuViec(string maSuViec)
        {
            return dal_SuViec.xoaThongTinSuViec( maSuViec);
        }
    }
}
