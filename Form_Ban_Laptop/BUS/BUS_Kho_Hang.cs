using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;
using System.Data;
namespace BUS
{
    public class BUS_Kho_Hang
    {
        DAL_Kho_Hang dal_Kho_Hang = new DAL_Kho_Hang();
        public bool them_vao_kho(DTO_Kho_Hang hang)
        {
            return dal_Kho_Hang.them_kho_hang(hang);
        }
        public bool sua_kho(DTO_Kho_Hang hang)
        {
            return dal_Kho_Hang.sua_kho_hang(hang);
        }
        public bool cap_nhat_sl_ban(DTO_Kho_Hang hang)
        {
            return dal_Kho_Hang.cap_nhat_sl_ban(hang);
        }
  
        public bool xoa_kho(string ma)
        {
            return dal_Kho_Hang.xoa_kho_hang(ma);
        }
        public DataTable so_luong_ton_kho(string ma_laptop)
        {
            return dal_Kho_Hang.so_luong_ton_kho(ma_laptop);
        }
        public DataTable thong_tin_kho()
        {
            return dal_Kho_Hang.thong_tin_kho();
        }
        public bool cap_nhat_sl_them_sp(DTO_Kho_Hang so_luong)
        {
            return dal_Kho_Hang.cap_nhat_sl_them_sp(so_luong);
        }
        
        // Cap nhan so luong phan san pham

    }
}
