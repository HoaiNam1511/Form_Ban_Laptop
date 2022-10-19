using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CongTy
    {
        string tenCongTy, diaChi;
        
        public string TenCongTy { get => tenCongTy; set => tenCongTy = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DTO_CongTy() { }
        public DTO_CongTy(string tenCongTy, string diaChi)
        {
            this.tenCongTy = tenCongTy;
            this.diaChi = diaChi;
        }
    }
}
