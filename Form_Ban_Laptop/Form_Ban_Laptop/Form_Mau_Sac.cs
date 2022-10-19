using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Form_Ban_Laptop
{
    public partial class Form_Mau_Sac : Form
    {
        BUS_Mau_Sac busMau = new BUS_Mau_Sac();
        public Form_Mau_Sac()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (kiem_tra_nhap(true))
            {
                DTO_Mau_Sac mau = new DTO_Mau_Sac(txtmamau.Text, txttenmau.Text);
                if (busMau.them_mau_sac(mau))
                {
                    lb_thongbao.Text = "Thêm thành công";
                    dgvdanhsach.DataSource = busMau.thong_tin_mau_sac();
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (kiem_tra_nhap(true))
            {
                DTO_Mau_Sac mau = new DTO_Mau_Sac(txtmamau.Text, txttenmau.Text);
                if (busMau.sua_mau_sac(mau))
                {
                    lb_thongbao.Text = "Sửa thành công";
                    dgvdanhsach.DataSource = busMau.thong_tin_mau_sac();
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmamau.Text != "")
            {
                string ma = txtmamau.Text;
                if (busMau.xoa_mau_sac(ma))
                {
                    lb_thongbao.Text = "Xoá thành công";
                    dgvdanhsach.DataSource = busMau.thong_tin_mau_sac();
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool kiem_tra_nhap(bool check)
        {
            string thong_bao = "Lỗi nhập dữ liệu: ";
            bool kiem_tra = false;

            if (txtmamau.Text.Trim().Length == 0)
            {
                thong_bao += " - Thiếu mã màu";
                kiem_tra = true;
            }
            if (txttenmau.Text.Trim().Length == 0)
            {
                thong_bao += " - Thiếu tên màu ";
                kiem_tra = true;
            }



            if (kiem_tra)
            {
                MessageBox.Show(thong_bao, "Lỗi nhập dữ liệu", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Hienthidssv()
        {
            dgvdanhsach.DataSource = busMau.thong_tin_mau_sac();
            dgvdanhsach.Columns["ma_mau"].HeaderText = "Mã màu";
            dgvdanhsach.Columns["ten_mau"].HeaderText = "Tên màu";
        }

        private void dgvdanhsach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dgvdanhsach.CurrentCell.RowIndex;
            txtmamau.Text = dgvdanhsach.Rows[vitri].Cells[0].Value.ToString();
            txttenmau.Text = dgvdanhsach.Rows[vitri].Cells[1].Value.ToString();
        }

        private void Form_Mau_Sac_Load(object sender, EventArgs e)
        {
            Hienthidssv();
        }
    }
}
