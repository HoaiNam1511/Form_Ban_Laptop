using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChucVu
    {
        string tenChucVu;
        string maNhomChucVu;
        public DTO_ChucVu(string tenChucVu,string maNhomChucVu)
        {
            this.tenChucVu = tenChucVu;
            this.maNhomChucVu = maNhomChucVu;
        }
        public DTO_ChucVu() { }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
        public string MaNhomChucVu { get => maNhomChucVu; set => maNhomChucVu = value; }
    }
}
