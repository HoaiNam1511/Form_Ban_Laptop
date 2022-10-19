using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Hang
    {
        string ma_hang;
        string ten_hang;

        public string Ma_hang { get => ma_hang; set => ma_hang = value; }
        public string Ten_hang { get => ten_hang; set => ten_hang = value; }
        
        public DTO_Hang() { }

        public DTO_Hang(string ma,string ten)
        {
            this.ma_hang = ma;
            this.ten_hang = ten;
        }
    }
}
