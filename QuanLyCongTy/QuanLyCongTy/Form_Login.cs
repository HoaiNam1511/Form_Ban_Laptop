using BUS;
using System;
using System.Data;
using System.Windows.Forms;
using DTO;
using System.Drawing;

namespace QuanLyCongTy
{
    public partial class Form_Login : Form
    {
        DTO_TaiKhoan tk = new DTO_TaiKhoan();
        BUS_TaiKhoan BUS_TK = new BUS_TaiKhoan();
        public Form_Login()
        {
            InitializeComponent();
            //txt_taikhoan.Text = "Admin";
            this.MaximizeBox = false;
            //txt_matkhau.Text = "123456";
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (txt_taikhoan.Text.ToString() != "" && txt_matkhau.Text.ToString() != "")
            {
                string taiKhoan = txt_taikhoan.Text.ToString();
                string matKhau = txt_matkhau.Text.ToString();
                DataTable dt = new DataTable();
                dt = BUS_TK.layThongTinTaiKhoan();
                bool kt = false;
                foreach (DataRow row in dt.Rows)
                {
                    if (taiKhoan == row["Ten_tai_khoan"].ToString().Trim() && matKhau == row["Mat_khau"].ToString().Trim())
                    {
                        kt = true;
                        StaticClass.maQuyen = row["Ma_quyen"].ToString().Trim();
                        StaticClass.maTaiKhoan = row["Ma_tai_khoan"].ToString().Trim();
                        break;
                    }
                }
                if (kt == true)
                {
                   
                    Home f = new Home();
                    f.Show();
                    this.Hide();
                }
                else
                    lb_thongbao.Text = "Tài khoản và mật khẩu không hợp lệ";
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin tài khoản và mật khẩu");
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_taikhoan_Enter(object sender, EventArgs e)
        {
            if(txt_taikhoan.Text == "Tài khoản") {
                txt_taikhoan.Text = "";
                txt_taikhoan.ForeColor = Color.Black;

            }
        }

        private void txt_taikhoan_Leave(object sender, EventArgs e)
        {
            if (txt_taikhoan.Text == "")
            {
                txt_taikhoan.Text = "Tài khoản";
                txt_taikhoan.ForeColor = Color.Gray;
               

            }
        }

        private void txt_matkhau_Leave(object sender, EventArgs e)
        {
            if (txt_matkhau.Text == "")
            {
                
                txt_matkhau.Text = "Mật khẩu";
                txt_matkhau.ForeColor = Color.Gray;
                txt_matkhau.PasswordChar = '\0';


            }
        }

        private void txt_matkhau_Enter(object sender, EventArgs e)
        {
            if (txt_matkhau.Text == "Mật khẩu")
            {
                txt_matkhau.Text = "";
                txt_matkhau.ForeColor = Color.Black;
                txt_matkhau.PasswordChar = '*';

            }
        }
    }
}
