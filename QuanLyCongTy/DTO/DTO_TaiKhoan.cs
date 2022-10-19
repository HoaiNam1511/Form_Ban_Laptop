using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        string taiKhoan, matKhau, maQuyen;

        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        public string MaQuyen
        {
            get { return maQuyen; }
            set { maQuyen = value; }
        }
        public DTO_TaiKhoan(){ }
        public DTO_TaiKhoan(string taiKhoan, string matKhau, string maQuyen) {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.maQuyen = maQuyen;
        }
    }
}
