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
    
    public class BUS_Hoa_Don_Ban
    {
        DAL_Hoa_Don_Ban dal_Hoa_Don_Ban = new DAL_Hoa_Don_Ban();
        public DataTable thong_tin_hoa_don()
        {
            return dal_Hoa_Don_Ban.thong_tin_hoa_don();
        }
        public DataTable thong_tin_1_hoa_don(string ma)
        {
            return dal_Hoa_Don_Ban.thong_tin_1_hoa_don(ma);
        }
        public bool them_hoa_don(DTO_Hoa_Don_Ban hoa_don)
        {
            return dal_Hoa_Don_Ban.them_hoa_don(hoa_don);
        }

        public bool sua_hoa_don(DTO_Hoa_Don_Ban hoa_don)
        {
            return dal_Hoa_Don_Ban.sua_hoa_don(hoa_don);
        }
        public bool tong_thanh_toan(string ma,int tong)
        {
            return dal_Hoa_Don_Ban.sua_tong_thanh_toan(ma,tong);
        }
        public bool xoa_hoa_don(string ma)
        {
            return dal_Hoa_Don_Ban.xoa_hoa_don(ma);
        }
    }
}
