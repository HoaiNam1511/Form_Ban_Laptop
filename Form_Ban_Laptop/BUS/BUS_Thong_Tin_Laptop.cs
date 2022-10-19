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
    public class BUS_Thong_Tin_Laptop
    {
        DAL_Thong_Tin_Laptop dal_Thong_Tin_Laptop = new DAL_Thong_Tin_Laptop();
        public DataTable thong_tin_laptop()
        {
            return dal_Thong_Tin_Laptop.lay_thong_tin_laptop();
        }
        public DataTable chi_tiet_thong_tin(string ma)
        {
            return dal_Thong_Tin_Laptop.chi_tiet_thong_tin(ma);
        }

        public DataTable thong_tin_1_laptop(string ma)
        {
            return dal_Thong_Tin_Laptop.thong_tin_1_laptop(ma);
        }
        public bool them_thong_tin_laptop(DTO_Thong_Tin_Laptop thong_tin)
        {
            return dal_Thong_Tin_Laptop.them_thong_tin_Laptop(thong_tin);
        }
        public bool sua_thong_tin_laptop(DTO_Thong_Tin_Laptop thong_tin)
        {
            return dal_Thong_Tin_Laptop.sua_thong_tin_Laptop(thong_tin);
        }
        public bool xoa_thong_tin_laptop(string ma)
        {
            return dal_Thong_Tin_Laptop.xoa_thong_tin_Laptop(ma);
        }
    }
    
}
