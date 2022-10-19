using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Loai_Laptop
    {
        string ma_loai;
        string ten_loai;

        public string Ma_loai { get => ma_loai; set => ma_loai = value; }
        public string Ten_loai { get => ten_loai; set => ten_loai = value; }

        public DTO_Loai_Laptop() { }

        public DTO_Loai_Laptop(string ma,string ten)
        {
            this.ma_loai = ma;
            this.ten_loai = ten;
        }
    }
}
