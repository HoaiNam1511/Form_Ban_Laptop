using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_San_Pham
    {
        int ma_sp;
        string ma_laptop;
        int don_gia;
        int so_luong;
        int tong_tien;
        string ma_hoa_don;

        public int Ma_sp { get => ma_sp; set => ma_sp = value; }
        public string Ma_laptop { get => ma_laptop; set => ma_laptop = value; }
        public int Don_gia { get => don_gia; set => don_gia = value; }
        public int So_luong { get => so_luong; set => so_luong = value; }
        public int Tong_tien { get => tong_tien; set => tong_tien = value; }
        public string Ma_hoa_don { get => ma_hoa_don; set => ma_hoa_don = value; }
      

        public DTO_San_Pham() { }
        public DTO_San_Pham(int masp,string ma, int gia, int soluong, int tong, string ma_hd)
        {
            this.ma_sp = masp;
            this.ma_laptop = ma;
            this.don_gia = gia;
            this.so_luong = soluong;
            this.tong_tien = tong;
            this.ma_hoa_don = ma_hd;
        }
    }
}
