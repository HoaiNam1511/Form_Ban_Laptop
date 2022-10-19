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
    public class BUS_CongTy
    {
        DAL_CongTy dalCongTy = new DAL_CongTy();
        
        public DataTable layIdCongTy(string Ten_cong_ty)
        {
            return dalCongTy.layIdCongTy(Ten_cong_ty);
        }
        public DataTable thongTinCongTy()
        {
            return dalCongTy.thongTinCongTy();
        }
        public bool themThongTinCongTy(DTO_CongTy thongTinCongTy)
        {
            return dalCongTy.themThongTinCongTy(thongTinCongTy);
        }

        public bool suaThongTinCongTy(string maCongTy, DTO_CongTy thongTinCongTy)
        {
            return dalCongTy.suaThongTinCongTy(maCongTy, thongTinCongTy);
        }
        public bool xoaThongTinCongTy(string maCongTy)
        {
            return dalCongTy.xoaThongTinCongTy(maCongTy);
        }

    }
}
