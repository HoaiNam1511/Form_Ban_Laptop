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
    public partial class Form1 : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (kiem_tra_nhap(true))
            {
                    bool gioitinh;
                    if (rdonam.Checked)
                    {
                        gioitinh = true;
                    }
                    else
                    {
                        gioitinh = false;
                    }
                    DTO_NhanVien nv = new DTO_NhanVien(txtmanv.Text, txttennv.Text, txtdiachi.Text, gioitinh, txtsodt.Text, txtngaysinh.Text);
                    if (busNV.them_nhan_vien(nv))
                    {
                        lb_thongbao_1.Text = "Thêm thành công";
                        dgvdanhsach.DataSource = busNV.lay_thong_tin_nv();
                    }
                    else
                    {
                        lb_thongbao_1.Text = "Thêm thất bại";
                    }
            }

        }

        private void txtsodt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void hienthidssv()
        {
            dgvdanhsach.DataSource = busNV.lay_thong_tin_nv();
            dgvdanhsach.Columns["ma_nv"].HeaderText = "Mã NV";
            dgvdanhsach.Columns["ten_nv"].HeaderText = "Họ và tên";
            dgvdanhsach.Columns["gioi_tinh"].HeaderText = "Giới tính";
            dgvdanhsach.Columns["ngay_sinh"].HeaderText = "Ngày sinh";
            dgvdanhsach.Columns["so_dt"].HeaderText = "Số điện thoại";
            dgvdanhsach.Columns["dia_chi"].HeaderText = "Địa chỉ";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hienthidssv();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (kiem_tra_nhap(true))
            {
                    bool gioitinh;
                    if (rdonam.Checked)
                    {
                        gioitinh = true;
                    }
                    else
                    {
                        gioitinh = false;
                    }
                    DTO_NhanVien nv = new DTO_NhanVien(txtmanv.Text, txttennv.Text, txtdiachi.Text, gioitinh, txtsodt.Text, txtngaysinh.Text);
                    if (busNV.sua(nv))
                    {
                        lb_thongbao_1.Text = "Sửa thành công";
                        dgvdanhsach.DataSource = busNV.lay_thong_tin_nv();
                    }
                    else
                    {
                        lb_thongbao_1.Text = "Sửa thất bại";
                    }
                
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text != "")
            {
                if(MessageBox.Show("Bạn có chắc chắn xoá ?", "Cảnh báo",MessageBoxButtons.YesNo).ToString() == "Yes")
                {
                    string ma = txtmanv.Text;
                    if (busNV.xoa(ma))
                    {
                        lb_thongbao_1.Text = "Thêm thành công";
                        dgvdanhsach.DataSource = busNV.lay_thong_tin_nv();
                    }
                    else
                    {
                        lb_thongbao_1.Text = "Xoá thất bại";
                    }
                }
            }
        }

        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dgvdanhsach.CurrentCell.RowIndex;
            txtmanv.Text = dgvdanhsach.Rows[vitri].Cells[0].Value.ToString();
            txttennv.Text = dgvdanhsach.Rows[vitri].Cells[1].Value.ToString();
            txtdiachi.Text = dgvdanhsach.Rows[vitri].Cells[2].Value.ToString();
            if (dgvdanhsach.Rows[vitri].Cells[3].Value.ToString() == "True")
            {
                rdonam.Checked = true;
                rdonu.Checked = false;
            }
            else
            {
                rdonam.Checked = false;
                rdonu.Checked = true;
            }
            txtsodt.Text = dgvdanhsach.Rows[vitri].Cells[4].Value.ToString();
            txtngaysinh.Text = Convert.ToDateTime(dgvdanhsach.Rows[vitri].Cells[5].Value.ToString()).ToString("MM/dd/yyyy");
        }
        private bool kiem_tra_nhap(bool check)
        {
            dgvdanhsach.DataSource = busNV.lay_thong_tin_nv();
            DataTable dt = busNV.lay_thong_tin_nv();
            string thong_bao = "Lỗi nhập dữ liệu: ";
            bool kiem_tra = false;
            if (txtmanv.Text.Trim().Length == 0)
            {
                thong_bao += " - Thiếu mã nhân viên";
                kiem_tra = true;
            }
            //else
            //{
            //    if (check)
            //    {
            //        int dem = 0;
            //        for(int i = 0;i < dt.Rows.Count; i++)
            //        {
            //            if(txtmanv.Text == dgvdanhsach.Rows[i].Cells[0].Value.ToString())
            //            {
            //                thong_bao += " - Trùng mã nhân viên";
            //                kiem_tra = true;
            //                break;
            //            }
            //        }
                    
            //    }
            //}
            if (txttennv.Text.Trim().Length == 0)
            {
                thong_bao += " - Thiếu họ tên, ";
                kiem_tra = true;
            }
            if (txtsodt.Text.Trim().Length == 0)
            {
                thong_bao += " - Thiếu số điện thoại ";
                kiem_tra = true;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                thong_bao += " - Thiếu địa chỉ ";
                kiem_tra = true;
            }
            if (txtngaysinh.Text.Trim().Length != 0)
            {
                try
                {
                    DateTime date = Convert.ToDateTime(txtngaysinh.Text);
                }
                catch
                {
                    thong_bao += "Nhập lỗi ngày sinh (tháng/ngày/năm)";
                    kiem_tra = true;
                }
            }
            else
            {
                thong_bao += " - Thiếu ngày sinh ";
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
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            txtsodt.Text = "";
            txtdiachi.Text = "";
            txtngaysinh.Text = "";
            rdonam.Checked = true;
        }

        private void txt_tukhoa_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = busNV.lay_thong_tin_nv();
            DataRow[] row = dt.Select("ten_nv like '%" + txt_tukhoa.Text + "%'");
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
