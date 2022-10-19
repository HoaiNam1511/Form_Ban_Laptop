using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public static class StaticClass
    {
        public static string maQuyen;
        public static string maTaiKhoan;
        public static int indexThongke=0;
        public static int indexHomeLoadForm;


        public static bool kiemTraQuyen()
        {
            if (maQuyen == "Admin")
                return true;
            else
                return false;
        }
    }
}
