using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HauQua
    {
        string nguoi, phuongTien, nguyenVatLieu, khac;
        public DTO_HauQua(string nguoi, string phuongTien, string nguyenVatLieu, string khac)
        {
            this.nguoi = nguoi;
            this.phuongTien = phuongTien;
            this.nguyenVatLieu = nguyenVatLieu;
            this.khac = khac;
        }
        public DTO_HauQua() { }
        public string Nguoi { get => nguoi; set => nguoi = value; }
        public string PhuongTien { get => phuongTien; set => phuongTien = value; }
        public string NguyenVatLieu { get => nguyenVatLieu; set => nguyenVatLieu = value; }
        public string Khac { get => khac; set => khac = value; }
    }
}
