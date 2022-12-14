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
using DTO;
using System.Data;
namespace Form_Ban_Laptop
{
    public partial class Form_Dang_Nhap : Form
    {
        BUS_Dang_Nhap bus_Dang_Nhap = new BUS_Dang_Nhap();
        public Form_Dang_Nhap()
        {
            InitializeComponent();
        }

        private void Form_Dang_Nhap_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (kiem_tra_nhap(true))
            {
                DTO_Dang_Nhap thong_tin_tk = new DTO_Dang_Nhap(txt_taikhoan.Text, txt_matkhau.Text);
                DataTable dt_taikhoan = bus_Dang_Nhap.tai_khoan(thong_tin_tk);
                if(dt_taikhoan.Rows.Count > 0)
                {
                    string ten = dt_taikhoan.Rows[0]["tai_khoan"].ToString();
                    Form_Master f = new Form_Master(ten);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    lb_thongbao.Text = "Không chính xác";
                }  
            }
            
        }
        public bool kiem_tra_nhap(bool kiemtra)
        {
            string thong_bao = "";
            bool check = false;
            if(txt_taikhoan.Text.Trim().Length == 0)
            {
                thong_bao += "tên tài khoản ";
                check = true;
            }
            if (txt_matkhau.Text.Trim().Length == 0)
            {
                thong_bao += " mật khẩu";
                check = true;
            }
            if (check == true)
            {
                lb_thongbao.Text = thong_bao;
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
