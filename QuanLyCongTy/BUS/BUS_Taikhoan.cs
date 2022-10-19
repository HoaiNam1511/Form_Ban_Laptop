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
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan DAL_TK = new DAL_TaiKhoan();

        public DataTable layThongTinQuyen()
        {
            return DAL_TK.layThongTinQuyen();
        }


        public DataTable layThongTinTaiKhoan()
        {
            return DAL_TK.layThongTinTaiKhoan();
        }

        public DataTable chiTietTaiKhoan(string maTaiKhoan)
        {
            return DAL_TK.chiTietTaiKhoan(maTaiKhoan);
        }

        public bool themTaiKhoan(DTO_TaiKhoan tk)
        {
            return DAL_TK.themTaiKhoan(tk);
        }

        public bool xoaTaiKhoan(string maTaiKhoan)
        {
            return DAL_TK.xoaTaiKhoan(maTaiKhoan);
        }

        public bool suaTaiKhoan(DTO_TaiKhoan tk, string maTaiKhoan)
        {
            return DAL_TK.suaTaiKhoan(tk, maTaiKhoan);
        }

    }
}
