using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Data;
using System.IO;
namespace Form_Ban_Laptop
{
    public partial class Form_Xem_Thong_Tin_Laptop : Form
    {
        BUS_Thong_Tin_Laptop busThongTin = new BUS_Thong_Tin_Laptop();
        public static string ma_laptop = string.Empty;
        public Form_Xem_Thong_Tin_Laptop()
        {
            InitializeComponent();
        }

        private void Form_Xem_Thong_Tin_Laptop_Load(object sender, EventArgs e)
        {
            DataTable dt = busThongTin.chi_tiet_thong_tin(ma_laptop);
            foreach (DataRow r in dt.Rows)
            {
                lb_ten.Text = r["ten_laptop"].ToString();
                lb_cpu.Text = r["cpu"].ToString();
                lb_card.Text = r["gpu"].ToString();
                lb_bonho.Text = r["bo_nho"].ToString();
                lb_ram.Text = r["ram"].ToString();
                lb_hang.Text = r["ten_hang"].ToString();
                lb_mau.Text = r["ten_mau"].ToString();
                lb_loai.Text = r["ten_loai"].ToString();
                lb_chatlieu.Text = r["chat_lieu"].ToString();
                lb_ma.Text = r["ma_laptop"].ToString();
                lb_gia.Text = r["gia_ban"].ToString();
                string path = Path.Combine(r["file_name"].ToString());
                box_hinhanh.Image = Image.FromFile(path);
                box_hinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
