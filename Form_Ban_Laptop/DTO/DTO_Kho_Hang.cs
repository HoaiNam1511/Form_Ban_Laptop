using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Kho_Hang
    {
        string ma_laptop;
        string ten_laptop;
        int gia_ban;
        int so_luong_nhap;
        int so_luong_ban;
        int so_luong_ton;

        public string Ma_laptop { get => ma_laptop; set => ma_laptop = value; }
        public string Ten_laptop { get => ten_laptop; set => ten_laptop = value; }
        public int Gia_ban { get => gia_ban; set => gia_ban = value; }
        public int So_luong_nhap { get => so_luong_nhap; set => so_luong_nhap = value; }
        public int So_luong_ban { get => so_luong_ban; set => so_luong_ban = value; }
        public int So_luong_ton { get => so_luong_ton; set => so_luong_ton = value; }

        public DTO_Kho_Hang() { }

        public DTO_Kho_Hang(string ma_laptop, string ten_laptop, int gia_ban, int so_luong_nhap, int so_luong_ban, int so_luong_ton)
        {
            this.ma_laptop = ma_laptop;
            this.ten_laptop = ten_laptop;
            this.gia_ban = gia_ban;
            this.so_luong_nhap = so_luong_nhap;
            this.so_luong_ban = so_luong_ban;
            this.so_luong_ton = so_luong_ton;
        }
    }
}
