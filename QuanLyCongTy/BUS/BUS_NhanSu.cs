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
    public class BUS_NhanSu
    {
        DAL_NhanSu dal_NhanSu = new DAL_NhanSu();
        public bool themThongTinNhanSu(DTO_NhanSu thongTinNhanSu)
        {
            return dal_NhanSu.themThongTinNhanSu(thongTinNhanSu);
        }
        public DataTable thongTinNhanSu()
        {
            return dal_NhanSu.thongTinNhanSu();
        }
        public bool suaThongTinNhanSu(DTO_NhanSu nhanSu)
        {
            return dal_NhanSu.suaThongTinNhanSu( nhanSu);
        }

        public bool xoaThongTinNhanSu(string maNhanSu)
        {
            return dal_NhanSu.xoaThongTinNhanSu(maNhanSu);
        }
        public DataTable thongTinNhanVienExport(string maCongTy)
        {
            return dal_NhanSu.thongTinNhanVienExport(maCongTy);
        }

    }
}
