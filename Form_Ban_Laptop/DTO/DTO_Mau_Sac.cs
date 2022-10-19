using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Mau_Sac
    {
        string ma_mau;
        string ten_mau;
        public string Ma_mau { get => ma_mau; set => ma_mau = value; }
        public string Ten_mau { get => ten_mau; set => ten_mau = value; }

        public DTO_Mau_Sac() { }

        public DTO_Mau_Sac(string ma,string ten)
        {
            this.ma_mau = ma;
            this.ten_mau = ten;
        }
    }
}
