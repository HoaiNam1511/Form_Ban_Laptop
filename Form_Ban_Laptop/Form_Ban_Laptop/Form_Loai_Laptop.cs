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
    public partial class Form_Loai_Laptop : Form
    {
        BUS_Loai_Laptop busLoai = new BUS_Loai_Laptop();
        public Form_Loai_Laptop()
        {
            InitializeComponent();
        }
        private void Form_Thong_Tin_Laptop_Load(object sender, EventArgs e)
        {
            Hienthi();

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (kiem_tra_nhap(true))
            {
                DTO_Loai_Laptop loai = new DTO_Loai_Laptop(txtmaloai.Text, txttenloai.Text);
                if (busLoai.them_Loai(loai))
                {
                    lb_thongbao_1.Text = "Them thanh cong";
                    dgvdanhsach.DataSource = busLoai.thong_tin_LOAI();
                }
            }
        }



        private void btnsua_Click(object sender, EventArgs e)
        {
            if (kiem_tra_nhap(true))
            {
                DTO_Loai_Laptop loai = new DTO_Loai_Laptop(txtmaloai.Text, txttenloai.Text);
                if (busLoai.sua_Loai(loai))
                {
                    lb_thongbao_1.Text = "Sửa thành công";
                    dgvdanhsach.DataSource = busLoai.thong_tin_LOAI();
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmaloai.Text != "")
            {
                string ma = txtmaloai.Text;
                if (busLoai.xoa_Loai(ma))
                {
                    lb_thongbao_1.Text = "Xoá thành công";
                    dgvdanhsach.DataSource = busLoai.thong_tin_LOAI();
                }
            }
        }



        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Hienthi()
        {
            dgvdanhsach.DataSource = busLoai.thong_tin_LOAI();
            dgvdanhsach.Columns["ma_loai"].HeaderText = "Mã loại";
            dgvdanhsach.Columns["ten_loai"].HeaderText = "Tên loại";
        }
        private bool kiem_tra_nhap(bool check)
        {
            string thong_bao = "Lỗi nhập dữ liệu: ";
            bool kiem_tra = false;

            if (txtmaloai.Text.Trim().Length == 0)
            {
                thong_bao += " - Thiếu mã hãng";
                kiem_tra = true;
            }
            if (txttenloai.Text.Trim().Length == 0)
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

        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dgvdanhsach.CurrentCell.RowIndex;
            txtmaloai.Text = dgvdanhsach.Rows[vitri].Cells[0].Value.ToString();
            txttenloai.Text = dgvdanhsach.Rows[vitri].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtmaloai.Text = "";
            txttenloai.Text = "";
        }

        private void txt_tukhoa_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = busLoai.thong_tin_LOAI();
            DataRow[] row = dt.Select("ten_loai like '%" + txt_tukhoa.Text + "%'");
            if (row.Length > 0)
            {
                DataTable dt1 = row.CopyToDataTable();
                dgvdanhsach.DataSource = dt1;
            }
            else
            {

            }
        }
    }
}
