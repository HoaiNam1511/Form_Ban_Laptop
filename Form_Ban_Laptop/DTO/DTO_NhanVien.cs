using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        string manv;
        string tennv;
        string diachi;
        bool gioitinh;
        string sodt;
        string ngaysinh;

        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public bool Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sodt { get => sodt; set => sodt = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        
        public DTO_NhanVien() { }
        public DTO_NhanVien(string ma,string ten, string dc,bool gt, string sdt, string ngay) {
            this.manv = ma;
            this.tennv = ten;
            this.diachi = dc;
            this.gioitinh = gt;
            this.sodt = sdt;
            this.ngaysinh = ngay;
        }
    }
}
