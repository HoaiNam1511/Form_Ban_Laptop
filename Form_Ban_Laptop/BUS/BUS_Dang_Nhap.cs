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
   
    public class BUS_Dang_Nhap
    {
        DAL_Dang_Nhap dal_Dang_Nhap = new DAL_Dang_Nhap();
        public DataTable tai_khoan(DTO_Dang_Nhap tai_khoan)
        {
            return dal_Dang_Nhap.thong_tin_tai_khoan(tai_khoan);
        }
    }
}
