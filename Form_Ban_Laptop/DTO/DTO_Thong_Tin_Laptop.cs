using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DTO
{
    public class DTO_Thong_Tin_Laptop
    {
        string ma_laptop;
        string ten_laptop;
        int gia_ban;
        string chat_lieu;
        string ram;
        string cpu;
        string card;
        string bo_nho;
        string ma_loai;
        string ma_mau;
        string ma_hang;
        string ten_file;

        public string Ma_laptop { get => ma_laptop; set => ma_laptop = value; }
        public string Ten_laptop { get => ten_laptop; set => ten_laptop = value; }
        public int Gia_ban { get => gia_ban; set => gia_ban = value; }
        public string Chat_lieu { get => chat_lieu; set => chat_lieu = value; }
        public string Ram { get => ram; set => ram = value; }
        public string Cpu { get => cpu; set => cpu = value; }
        public string Card { get => card; set => card = value; }
        public string Bo_nho { get => bo_nho; set => bo_nho = value; }
        public string Ma_loai { get => ma_loai; set => ma_loai = value; }
        public string Ma_mau { get => ma_mau; set => ma_mau = value; }
        public string Ma_hang { get => ma_hang; set => ma_hang = value; }
        public string Ten_file { get => ten_file; set => ten_file = value; }

        public DTO_Thong_Tin_Laptop() { }

        public DTO_Thong_Tin_Laptop(string ma_laptop, string ten_laptop,int gia,string chat_lieu, string ram,string cpu,string card,string bo_nho, string ma_loai, string ma_mau, string ma_hang,string ten_file)
        {
            this.ma_laptop = ma_laptop;
            this.ten_laptop = ten_laptop;
            this.gia_ban = gia;
            this.chat_lieu = chat_lieu;
            this.ram = ram;
            this.cpu = cpu;
            this.card = card;
            this.bo_nho = bo_nho;
            this.ma_loai = ma_loai;
            this.ma_mau = ma_mau;
            this.ma_hang = ma_hang;
            this.ten_file = ten_file;
        }

    }
}
