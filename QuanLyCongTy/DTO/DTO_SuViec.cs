using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SuViec
    {
        string tomTatSuViec;
        DateTime thoiGianDB;
        DateTime thoiGianKT;
        string maCongTy;

        public DTO_SuViec(string tomTatSuViec, DateTime thoiGianDB, DateTime thoiGianKT, string maCongTy)
        {
            this.tomTatSuViec = tomTatSuViec;
            this.thoiGianDB = thoiGianDB;
            this.thoiGianKT = thoiGianKT;
            this.maCongTy = maCongTy;
        }
        public DTO_SuViec() { }

        public string TomTatSuViec { get => tomTatSuViec; set => tomTatSuViec = value; }
        public DateTime ThoiGianBD { get => thoiGianDB; set => thoiGianDB = value; }
        public DateTime ThoiGianKT { get => thoiGianKT; set => thoiGianKT = value; }
        public string MaCongTy { get => maCongTy; set => maCongTy = value; }
    }
}
