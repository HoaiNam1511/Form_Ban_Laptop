using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Hoa_Don_Ban
    {
        string ma_hoa_don;
        string ten_khach;
        string dia_chi;
        int so_dt;
        string ngay_ban;
        string ma_nv;
        public string Ma_hoa_don { get => ma_hoa_don; set => ma_hoa_don = value; }
        public string Ten_khach { get => ten_khach; set => ten_khach = value; }
        public string Dia_chi { get => dia_chi; set => dia_chi = value; }
        public int So_dt { get => so_dt; set => so_dt = value; }
        public string Ngay_ban { get => ngay_ban; set => ngay_ban = value; }
        public string Ma_nv { get => ma_nv; set => ma_nv = value; }

        public DTO_Hoa_Don_Ban() { }

        public DTO_Hoa_Don_Ban(string ma, string ten, string diachi, int so_dt,string ngay,string manv)
        {
            this.ma_hoa_don = ma;
            this.ten_khach = ten;
            this.dia_chi = diachi;
            this.ngay_ban = ngay;
            this.ma_nv = manv;
            this.so_dt = so_dt;
        }
    }
}
