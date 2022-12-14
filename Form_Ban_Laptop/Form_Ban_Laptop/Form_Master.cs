using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Ban_Laptop
{
    public partial class Form_Master : Form
    {
        public Form_Master(string ten_tai_khoan)
        {
            InitializeComponent();
            txt_tentk.Text = ten_tai_khoan;
        }

        private void Form_Master_Load(object sender, EventArgs e)
        {

        }
        public void loadForm(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btn_thongtin_laptop_Click(object sender, EventArgs e)
        {
            loadForm(new Form_Thong_Tin_Laptop());
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            loadForm(new Form_Hoa_Don_Ban());
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            loadForm(new Form1());
        }

        private void btn_hang_Click(object sender, EventArgs e)
        {
            loadForm(new Form_Hang());
        }

        private void btn_mausac_Click(object sender, EventArgs e)
        {
            loadForm(new Form_Mau_Sac());
        }

        private void btn_loai_Click(object sender, EventArgs e)
        {
            loadForm(new Form_Loai_Laptop());
        }

        private void btn_kho_Click(object sender, EventArgs e)
        {
            loadForm(new Form_Kho_Hang());
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            Form_Dang_Nhap f = new Form_Dang_Nhap();
            f.Show();
            this.Hide();
        }
    }
}
