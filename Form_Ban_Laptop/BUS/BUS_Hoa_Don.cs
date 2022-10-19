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
    public class BUS_Hoa_Don
    {
        DAL_Hoa_Don dal_Hoa_Don = new DAL_Hoa_Don();
        public DataTable thong_tin_hoa_don()
        {
            return dal_Hoa_Don.lay_thong_tin_hoa_don();
        }
        public bool them_thong_tin(DTO_Hoa_Don hoa_don)
        {
            return dal_Hoa_Don.them_hoa_don(hoa_don);
        }
        public bool xoa_hoa_don(string ma)
        {
            return dal_Hoa_Don.xoa_hoa_don(ma);
        }
        public bool sua_hoa_don(DTO_Hoa_Don hoa_don)
        {
            return dal_Hoa_Don.sua_hoa_don(hoa_don);
        }
    }
}
