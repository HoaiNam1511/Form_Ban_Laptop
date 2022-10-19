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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        public void loadForm(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Dock = DockStyle.Fill;
            this.Size = new Size(panelMain.Size.Width+25, panelMain.Size.Height + 50);
            f.Show();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            phanQuyen();
            switch (StaticClass.indexHomeLoadForm)
            {
                case 0:
                    {
                        this.Text = "Quản lý sự việc";
                        Form_QlSuViec f = new Form_QlSuViec();
                        panelMain.Size = f.Size;
                        loadForm(f);
                        break;
                    }
                case 1:
                    {
                        this.Text = "Quản lý nhân sự";
                        Form_NhanSu f = new Form_NhanSu();
                        panelMain.Size = f.Size;
                        loadForm(f);
                        break;
                    }
                case 2:
                    {
                        this.Text = "Quản lý công ty";
                        Form_CongTy f = new Form_CongTy();
                        panelMain.Size = f.Size;
                        loadForm(f);
                        break;
                    }
                case 3:
                    {
                        this.Text = "Quản lý chức vụ";
                        Form_ChucVu f = new Form_ChucVu();
                        panelMain.Size = f.Size;
                        loadForm(f);
                        break;
                    }
                case 4:
                    {
                        this.Text = "Quản lý tài khoản";
                        Form_QLTaiKhoan f = new Form_QLTaiKhoan();
                        panelMain.Size = f.Size;
                        loadForm(f);
                        break;
                    } 
                case 5:
                    {
                        this.Text = "Thống kê";
                        Form_ThongKe f = new Form_ThongKe();
                        panelMain.Size = f.Size;
                        loadForm(f);
                        break;
                    }
                case 6:
                    {
                        this.Text = "Thông tin cá nhân";
                        Form_ThongTinTaiKhoan f = new Form_ThongTinTaiKhoan();
                        panelMain.Size = f.Size;
                        loadForm(f);
                        break;
                    }
            }
       
        }

        private void phanQuyen()
        {
            if (StaticClass.kiemTraQuyen())
            {
                menuQlSuViec.Enabled = true;
                menuQlCongTy.Enabled = true;
                menuQlTaiKhoan.Enabled = true;
                menuQuanLyNhanSu.Enabled = true;
                menuQlSuViec.Enabled = true;
                menuQlChucVu.Enabled = true;
            }
            else
            {
                menuQlSuViec.Enabled = false;
                menuQlCongTy.Enabled = false;
                menuQlTaiKhoan.Enabled = false;
                menuQuanLyNhanSu.Enabled = false;
                menuQlSuViec.Enabled = false;
                menuQlChucVu.Enabled = false;

            }
        }


        private void mennuQlSuViec_Click(object sender, EventArgs e)
        {
            
        }

        

        private void menuThongKeSuViec_Click(object sender, EventArgs e)
        {
            StaticClass.indexThongke = 0;
            
            Form_ThongKe f = new Form_ThongKe();
            this.Text = "Thống kê";
            panelMain.Size = f.Size;
            loadForm(f);
        }

        private void menuThongKeNhanSu_Click(object sender, EventArgs e)
        {
            this.Text = "Thống kê";

            StaticClass.indexThongke = 1;
            Form_ThongKe f = new Form_ThongKe();
            panelMain.Size = f.Size;
            loadForm(f);
        }

        private void menuHome_Click(object sender, EventArgs e)
        {
            this.Text = "Home";
            Home f = new Home();
            f.Show();
            this.Close();
        }

        private void menuQuanLyNhanSu_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý nhân sự";
            Form_NhanSu f = new Form_NhanSu();
            panelMain.Size = f.Size;
            
            loadForm(f);
        }

        private void menuQlCongTy_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý công ty";
            Form_CongTy f = new Form_CongTy();
            panelMain.Size = f.Size;
            loadForm(f);
        }

        private void menuQlTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý tài khoản";
            Form_QLTaiKhoan f = new Form_QLTaiKhoan();
            panelMain.Size = f.Size;
            loadForm(f);
        }

        private void menuQlSuViec_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý sự việc";
            Form_QlSuViec f = new Form_QlSuViec();
            panelMain.Size = f.Size;
            loadForm(f);
        }

        

        private void menuQlChucVu_Click(object sender, EventArgs e)
        {
            this.Text = "Quản lý chức vụ";
            Form_ChucVu f = new Form_ChucVu();
            panelMain.Size = f.Size;
            loadForm(f);
        }

        private void menuCaNhan_Click(object sender, EventArgs e)
        {
            this.Text = "Tài khoản cá nhân";
            Form_ThongTinTaiKhoan f = new Form_ThongTinTaiKhoan();
            panelMain.Size = f.Size;
            loadForm(f);
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            Form_Login f = new Form_Login();
            f.Show();
            this.Hide();
        }
    }
}
