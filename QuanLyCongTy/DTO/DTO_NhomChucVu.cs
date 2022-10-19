using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhomChucVu
    {
        string tenNhomChucVu;

        public DTO_NhomChucVu(string tenNhomChucVu)
        {
            this.tenNhomChucVu = tenNhomChucVu;
        }
        public DTO_NhomChucVu()
        {

        }

        public string TenNhomChucVu { get => tenNhomChucVu; set => tenNhomChucVu = value; }
    }
}
