using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;
namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dal_NhanVien = new DAL_NhanVien();
        public bool them_nhan_vien(DTO_NhanVien nv)
        {
            return dal_NhanVien.them_thong_tin_nv(nv);
        }
        public bool sua(DTO_NhanVien nv)
        {
            return dal_NhanVien.sua_nhan_vien(nv);
        }
        public bool xoa(string ma)
        {
            return dal_NhanVien.xoa_nhan_vien(ma);
        }
        public DataTable lay_thong_tin_nv()
        {
            return dal_NhanVien.lay_thong_tin_NV();
        }
        public DataTable thong_tin_1_nv(string ma)
        {
            return dal_NhanVien.thong_tin_1_nv(ma);
        }
    }
}
