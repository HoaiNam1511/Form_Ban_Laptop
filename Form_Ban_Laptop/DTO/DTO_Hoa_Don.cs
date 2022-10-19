using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Hoa_Don
    {
        string ma_hoa_don;
        string ten_khach;
        string dia_chi;
        int so_dt;
        string ngay_ban;
        int bao_hanh;
        int so_luong;
        int don_gia;
        int tong_tien;
        string ma_laptop;
        string ma_nv;

        public string Ma_hoa_don { get => ma_hoa_don; set => ma_hoa_don = value; }
        public string Ten_khach { get => ten_khach; set => ten_khach = value; }
        public string Dia_chi { get => dia_chi; set => dia_chi = value; }
        public int So_dt { get => so_dt; set => so_dt = value; }
        public string Ngay_ban { get => ngay_ban; set => ngay_ban = value; }
        public int Bao_hanh { get => bao_hanh; set => bao_hanh = value; }
        public int So_luong { get => so_luong; set => so_luong = value; }
        public int Don_gia { get => don_gia; set => don_gia = value; }
        public int Tong_tien { get => tong_tien; set => tong_tien = value; }
        public string Ma_laptop { get => ma_laptop; set => ma_laptop = value; }
        public string Ma_nv { get => ma_nv; set => ma_nv = value; }

        public DTO_Hoa_Don() { }

        public DTO_Hoa_Don(string ma,string ten, string dc,int sdt, string ngay, int baohanh, int sl, int don_gia, int tong,string ma_laptop,string ma_nv)
        {
            this.ma_hoa_don = ma;
            this.ten_khach = ten;
            this.dia_chi = dc;
            this.so_dt = sdt;
            this.ngay_ban = ngay;
            this.bao_hanh = baohanh;
            this.so_luong = sl;
            this.don_gia = don_gia;
            this.tong_tien = tong;
            this.ma_laptop = ma_laptop;
            this.ma_nv = ma_nv;
        }
    }
}
