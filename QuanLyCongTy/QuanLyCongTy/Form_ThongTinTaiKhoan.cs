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

namespace QuanLyCongTy
{
    public partial class Form_ThongTinTaiKhoan : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        public Form_ThongTinTaiKhoan()
        {
            InitializeComponent();
            hienThi();
        }
        private void hienThi()
        {
            DataTable dtTaiKhoan = new DataTable();
            dtTaiKhoan = busTaiKhoan.chiTietTaiKhoan(StaticClass.maTaiKhoan.ToString());
            txt_user.Text = dtTaiKhoan.Rows[0]["Ten_tai_khoan"].ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = busTaiKhoan.chiTietTaiKhoan(StaticClass.maTaiKhoan);
            DataRow r = dt.Rows[0];
            if (txt_passmoi.Text != "" && txt_passmoi1.Text != "" && txt_passcu.Text!="")
                if (txt_passcu.Text == r["Mat_khau"].ToString() && txt_passmoi.Text == txt_passmoi1.Text)
                {
                    DTO_TaiKhoan tk = new DTO_TaiKhoan(r["Ten_tai_khoan"].ToString(), txt_passmoi.Text.ToString(), StaticClass.maQuyen);
                    
                    if(busTaiKhoan.suaTaiKhoan(tk, StaticClass.maTaiKhoan))
                        MessageBox.Show("Sửa thành công");
                    else
                        MessageBox.Show("Sửa không thành công");
                }
                else
                    MessageBox.Show("Sửa không thành công! Hãy nhập đủ thông tin");
            else
                MessageBox.Show("Sửa không thành công! Hãy nhập đủ thông tin");

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            f.Show();
            this.Close();


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Home f = new Home();
            f.Show();
            Application.OpenForms["Form_Main"].Close();
        }
    }
}
