using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanSu
    {
        string maNhanVien;
        string hoTen, quocTich, noiDangKyThuongTru, chucVu, thongTinKhac;
        int namSinh;
        string maCongTy;
        string CCCD;
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string QuocTich { get => quocTich; set => quocTich = value; }
        public string NoiDangKyThuongTru { get => noiDangKyThuongTru; set => noiDangKyThuongTru = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string ThongTinKhac { get => thongTinKhac; set => thongTinKhac = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string MaCongTy { get => maCongTy; set => maCongTy = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string CCCD1 { get => CCCD; set => CCCD = value; }

        public DTO_NhanSu() { }

        public DTO_NhanSu(string maNhanVien, string hoTen, string quocTich, string noiDangKyThuongTru, string chucVu, string thongTinKhac, int namSinh, string maCongTy, string CCCD)
        {
            this.maNhanVien = maNhanVien;
            this.hoTen = hoTen;
            this.quocTich = quocTich;
            this.noiDangKyThuongTru = noiDangKyThuongTru;
            this.chucVu = chucVu;
            this.thongTinKhac = thongTinKhac;
            this.namSinh = namSinh;
            this.maCongTy = maCongTy;
            this.CCCD = CCCD;
        }
    }
}
