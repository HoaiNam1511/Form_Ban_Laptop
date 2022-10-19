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
    public class BUS_Loai_Laptop
    {
        DAL_Loai_Laptop dal_Loai_Laptop = new DAL_Loai_Laptop();
        public DataTable thong_tin_LOAI()
        {
            return dal_Loai_Laptop.lay_thong_tin_Loai();
        }
        public bool them_Loai(DTO_Loai_Laptop loai)
        {
            return dal_Loai_Laptop.them_loai(loai);
        }
        public bool sua_Loai(DTO_Loai_Laptop loai)
        {
            return dal_Loai_Laptop.sua_loai(loai);
        }
        public bool xoa_Loai(string ma)
        {
            return dal_Loai_Laptop.xoa_loai(ma);
        }
    }
}
