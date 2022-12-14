using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Dang_Nhap
    {
        string ten_tai_khoan;
        string mat_khau;

        public string Ten_tai_khoan { get => ten_tai_khoan; set => ten_tai_khoan = value; }
        public string Mat_khau { get => mat_khau; set => mat_khau = value; }

        public DTO_Dang_Nhap(){}
        public DTO_Dang_Nhap(string ten,string matkhau) {
            this.ten_tai_khoan = ten;
            this.mat_khau = matkhau;
        }
    }
}
