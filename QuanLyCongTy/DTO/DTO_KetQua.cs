using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KetQua
    {
        string toiDanh, hanhVi, khac, nhom;
        string toiDanhNguoi, hanhChinhNguoi;
        public DTO_KetQua(string toiDanhNguoi, string hanhChinhNguoi, string toiDanh, string hanhVi, string khac, string nhom)
        {
            this.toiDanhNguoi = toiDanhNguoi;
            this.hanhChinhNguoi = hanhChinhNguoi;
            this.toiDanh = toiDanh;
            this.hanhVi = hanhVi;
            this.khac = khac;
            this.nhom = nhom;
        }
        public DTO_KetQua() { }
        public string ToiDanh { get => toiDanh; set => toiDanh = value; }
        public string HanhVi { get => hanhVi; set => hanhVi = value; }
        public string Khac { get => khac; set => khac = value; }
        public string Nhom { get => nhom; set => nhom = value; }
        public string ToiDanhNguoi { get => toiDanhNguoi; set => toiDanhNguoi = value; }
        public string HanhChinhNguoi { get => hanhChinhNguoi; set => hanhChinhNguoi = value; }
    }
}

