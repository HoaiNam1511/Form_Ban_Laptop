using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_San_Pham
    {
        DAL_San_Pham dal_San_Pham = new DAL_San_Pham();
        public DataTable thong_tin_san_pham(string ma_hd)
        {
            return dal_San_Pham.thong_tin_san_pham(ma_hd);
        }

        public DataTable list_san_pham(string ma_hd)
        {
            return dal_San_Pham.list_san_pham(ma_hd);
        }
        public DataTable san_pham_theo_ma(string ma_hoa_don)
        {
            return dal_San_Pham.san_pham_theo_ma(ma_hoa_don);
        }
        public DataTable san_pham_theo_ma_laptop(string ma_laptop)
        {
            return dal_San_Pham.san_pham_theo_ma_laptop(ma_laptop);
        }
    
        public bool them_san_pham(DTO_San_Pham sanpham)
        {
            return dal_San_Pham.them_san_pham(sanpham);
        }
        public bool sua_san_pham(DTO_San_Pham sanpham)
        {
            return dal_San_Pham.sua_san_pham(sanpham);
        }
        public bool xoa_san_pham(string ma)
        {
            return dal_San_Pham.xoa_san_pham(ma);
        }
    }
}
