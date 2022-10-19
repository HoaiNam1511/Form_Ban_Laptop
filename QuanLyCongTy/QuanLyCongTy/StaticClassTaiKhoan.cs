using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public static class StaticClassTaiKhoan
    {
        public static string maQuyen;

        public static bool kiemTraQuyen()
        {
            if (maQuyen == "QU1")
                return true;
            else
                return false;
        }
    }
}
