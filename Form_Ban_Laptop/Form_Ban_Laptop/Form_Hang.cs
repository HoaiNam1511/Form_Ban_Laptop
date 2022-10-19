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
    public partial class Form_Hang : Form
    {
        BUS_Hang busHang = new BUS_Hang();
        public Form_Hang()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            if (kiem_tra_nhap(true))
            {
                DTO_Hang hang = new DTO_Hang(txtmahang.Text, txttenhang.Text);
                if (busHang.them_Hang(hang))
                {
                    lb_thongbao.Text = "Thêm thành công";
                    dgvdanhsach.DataSource = busHang.thong_tin_HANG();
                }
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (kiem_tra_nhap(true))
            {
                DTO_Hang hang = new DTO_Hang(txtmahang.Text, txttenhang.Text);
                if (busHang.sua_Hang(hang))
                {
                    lb_thongbao.Text = "Sửa thành công";
                    dgvdanhsach.DataSource = busHang.thong_tin_HANG();
                }
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(txtmahang.Text != "")
            {
                string ma = txtmahang.Text;
                if (busHang.xoa_Hang(ma))
                {
                    lb_thongbao.Text = "Xoá thành công";
                    dgvdanhsach.DataSource = busHang.thong_tin_HANG();
                }
            }
        }
        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dgvdanhsach.CurrentCell.RowIndex;
            txtmahang.Text = dgvdanhsach.Rows[vitri].Cells[0].Value.ToString();
            txttenhang.Text = dgvdanhsach.Rows[vitri].Cells[1].Value.ToString();
        }
        private bool kiem_tra_nhap(bool check)
        {
            string thong_bao = "Lỗi nhập dữ liệu: ";
            bool kiem_tra = false;
  
            if (txtmahang.Text.Trim().Length == 0)
            {
                thong_bao += " - Thiếu mã hãng";
                kiem_tra = true;
            }
            if (txttenhang.Text.Trim().Length == 0)
            {
                thong_bao += " - Thiếu tên hãng ";
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

        private void hienthidssv()
        {
            dgvdanhsach.DataSource = busHang.thong_tin_HANG();
            dgvdanhsach.Columns["ma_hang"].HeaderText = "Mã hãng";
            dgvdanhsach.Columns["ten_hang"].HeaderText = "Tên hãng";
        }

        private void Form_Hang_Load(object sender, EventArgs e)
        {
            hienthidssv();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
