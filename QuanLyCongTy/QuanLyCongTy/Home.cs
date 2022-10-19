using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            btnQlCongTy.BackColor = Color.FromArgb(100, 255, 255, 200);
            btnQlSuViec.BackColor = Color.FromArgb(100, 255, 255, 200);
            //btnQlNhanSu.BackColor = Color.FromArgb(100, 255, 255, 200);
            //btnChucVu.BackColor = Color.FromArgb(100, 255, 255, 200);
            btnQlTaiKhoan.BackColor = Color.FromArgb(100, 255, 255, 200);
            btnThongKe.BackColor = Color.FromArgb(100, 255, 255, 200);
            this.MaximizeBox = false;
        }


        private void btnQlNhanSu_Click(object sender, EventArgs e)
        {
            StaticClass.indexHomeLoadForm = 1;
            Form_Main f = new Form_Main();
            f.Show();
            this.Close();

        }

        private void btnQlCongTy_Click(object sender, EventArgs e)
        {
            StaticClass.indexHomeLoadForm = 2;
            Form_Main f = new Form_Main();
            f.Show();
            this.Close();

        }

        private void btnQlSuViec_Click(object sender, EventArgs e)
        {
            StaticClass.indexHomeLoadForm = 0;
            Form_Main f = new Form_Main();
            f.Show();
            this.Close();
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            StaticClass.indexHomeLoadForm = 3;
            Form_Main f = new Form_Main();
            f.Show();
            this.Close();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            test f = new test();
            f.Show();
            this.Close();

        }


        private void btnQlTaiKhoan_Click(object sender, EventArgs e)
        {
            StaticClass.indexHomeLoadForm = 4;
            Form_Main f = new Form_Main();
            f.Show();
            this.Close();

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            StaticClass.indexHomeLoadForm = 5;
            Form_Main f = new Form_Main();
            f.Show();
            this.Close();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (StaticClass.kiemTraQuyen())
            {
                btnQlSuViec.Enabled = true;
                btnQlCongTy.Enabled = true;
                //btnQlNhanSu.Enabled = true;
                //btnChucVu.Enabled = true;
                btnQlTaiKhoan.Enabled = true;
            }
            else
            {
                btnQlSuViec.Enabled = false;
                btnQlCongTy.Enabled = false;
                //btnQlNhanSu.Enabled = false;
                //btnChucVu.Enabled = false;
                btnQlTaiKhoan.Enabled = false;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Form_Login f = new Form_Login();
            f.Show();
            this.Close();
        }

        private void btnTTCN_Click(object sender, EventArgs e)
        {
            StaticClass.indexHomeLoadForm = 6;
            Form_Main f = new Form_Main();
            f.Show();
            this.Close();
        }
    }
}
