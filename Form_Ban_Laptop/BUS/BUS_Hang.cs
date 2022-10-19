using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
    
    public class BUS_Hang
    {
        DAL_Hang dal_Hang = new DAL_Hang();
        public DataTable thong_tin_HANG()
        {
            return dal_Hang.lay_thong_tin_HANG();
        }
        public bool them_Hang(DTO_Hang hang)
        {
            return dal_Hang.them_hang(hang);
        }
        public bool sua_Hang(DTO_Hang hang)
        {
            return dal_Hang.sua_hang(hang);
        }
        public bool xoa_Hang(string ma)
        {
            return dal_Hang.xoa_hang(ma);
        }
    }
}
