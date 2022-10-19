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

    public class BUS_ThongKe
    {
        DAL_ThongKe dalThongKe = new DAL_ThongKe();
        public DataTable timKiemAllSuviec(string tuKhoa)
        {
            return dalThongKe.timKiemAllSuviec(tuKhoa);
        }

        public DataTable timKiemAllNhanSu(string tuKhoa)
        {
            return dalThongKe.timKiemAllNhanSu(tuKhoa);
        }
    }
}
