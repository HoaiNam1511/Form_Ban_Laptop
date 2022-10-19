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
    public class BUS_Mau_Sac
    {
        DAL_Mau_Sac dal_Mau_Sac = new DAL_Mau_Sac();
        public DataTable thong_tin_mau_sac()
        {
            return dal_Mau_Sac.lay_thong_tin_Mau();
        }
        public bool them_mau_sac(DTO_Mau_Sac mau)
        {
            return dal_Mau_Sac.them_mau_sac(mau);
        }
        public bool sua_mau_sac(DTO_Mau_Sac mau)
        {
            return dal_Mau_Sac.sua_mau_sac(mau);
        }
        public bool xoa_mau_sac(string ma)
        {
            return dal_Mau_Sac.xoa_mau_sac(ma);
        }
    }
}
