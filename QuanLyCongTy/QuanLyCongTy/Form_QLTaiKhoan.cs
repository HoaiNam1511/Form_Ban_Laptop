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

namespace QuanLyCongTy
{
    public partial class Form_QLTaiKhoan : Form
    {
        BUS_TaiKhoan bus_TaiKhoan = new BUS_TaiKhoan();
        public Form_QLTaiKhoan()
        {
            InitializeComponent();
            hienThiDanhSach();
            hienThiPhanQuyen();
        }

        public bool kiemTraNhap()
        {


            string thongBao = "Vui lòng nhập: ";
            bool kiemTra = false;
            if (txtTaiKhoan.Text.Trim().Length == 0)
            {
                thongBao += " - Tài khoản";
                kiemTra = true;
            }
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                thongBao += " - Mật khẩu";
                kiemTra = true;
            }
            if (cbbPhanQuyen.SelectedIndex < 0)
            {
                thongBao += " - Phân quyền";
                kiemTra = true;
            }

            if (kiemTra == true)
            {
                MessageBox.Show(thongBao, "Lỗi nhập dữ liệu", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void hienThiPhanQuyen()
        {
            cbbPhanQuyen.Items.Clear();
            DataTable dt = bus_TaiKhoan.layThongTinQuyen();
            cbbPhanQuyen.ValueMember = "Ma_quyen";
            cbbPhanQuyen.DisplayMember = "Ten_quyen";
            cbbPhanQuyen.DataSource = dt;
        }

        private void hienThiDanhSach()
        {
            dgvThongTinTaiKhoan.DataSource = bus_TaiKhoan.layThongTinTaiKhoan();
            dgvThongTinTaiKhoan.Columns["Ma_tai_khoan"].HeaderText = "Mã tài khoản";
            dgvThongTinTaiKhoan.Columns["Ten_tai_khoan"].HeaderText = "Tài khoản";
            dgvThongTinTaiKhoan.Columns["Mat_khau"].HeaderText = "Mật khẩu";
            //dgvThongTinTaiKhoan.Columns["Mat_khau"].Visible = false;
            dgvThongTinTaiKhoan.Columns["Ten_quyen"].HeaderText = "Quyền";
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if(StaticClass.kiemTraQuyen())
            {
                if (kiemTraNhap())
                {
                    string matKhau = txtMatKhau.Text.ToString();
                    string taiKhoan = txtTaiKhoan.Text.ToString();
                    string maQuyen = cbbPhanQuyen.SelectedValue.ToString();
                    DTO_TaiKhoan tk = new DTO_TaiKhoan(taiKhoan, matKhau, maQuyen);
                    if (bus_TaiKhoan.themTaiKhoan(tk))
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvThongTinTaiKhoan.DataSource = bus_TaiKhoan.layThongTinTaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }
            }
            else 
                MessageBox.Show("Chức năng này chỉ có Admin được thực hiện");            
           
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (StaticClass.kiemTraQuyen())
            {
                if (lbMaTaiKhoan.Text.ToString() != ". . .")
                {
                    string matKhau = txtMatKhau.Text.ToString();
                    string taiKhoan = txtTaiKhoan.Text.ToString();

                    string maQuyen = cbbPhanQuyen.SelectedValue.ToString();
                    string maTaiKhoan = lbMaTaiKhoan.Text.ToString();
                    if (kiemTraNhap() == true)
                    {
                        DTO_TaiKhoan tk = new DTO_TaiKhoan(taiKhoan, matKhau, maQuyen);
                        if (bus_TaiKhoan.suaTaiKhoan(tk, maTaiKhoan))
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                            hienThiDanhSach();
                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Hãy chọn Tài khoản muốn sửa");
                }
            }
            else
                MessageBox.Show("Chức năng này chỉ có Admin được thực hiện");
            
            clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (StaticClass.kiemTraQuyen())
            {
                if (dgvThongTinTaiKhoan.Rows.Count > 0)
                {
                    if (lbMaTaiKhoan.Text.ToString() != ". . .")
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xoá ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            string maTaiKhoan = lbMaTaiKhoan.Text.ToString();
                            if (bus_TaiKhoan.xoaTaiKhoan(maTaiKhoan))
                            {
                                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK);
                                hienThiDanhSach();
                            }
                            else
                            {
                                MessageBox.Show("Xoá không thành công", "Thông báo", MessageBoxButtons.OK);
                            }
                        }

                    }

                    else
                    {
                        MessageBox.Show("Hãy chọn Tài khoản muốn xóa");
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cần xoá");
                }

                
            }
            else
                MessageBox.Show("Chức năng này chỉ có Admin được thực hiện");

            
            
        }

        private void dgvThongTinTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThongTinTaiKhoan.Rows.Count > 0)
            {
                int vitri = dgvThongTinTaiKhoan.CurrentCell.RowIndex;
                lbMaTaiKhoan.Text = dgvThongTinTaiKhoan.Rows[vitri].Cells[1].Value.ToString();
                txtTaiKhoan.Text = dgvThongTinTaiKhoan.Rows[vitri].Cells[2].Value.ToString();
                txtMatKhau.Text = dgvThongTinTaiKhoan.Rows[vitri].Cells[3].Value.ToString();
                for (int i = 0; i < cbbPhanQuyen.Items.Count; i++)
                {

                    if (cbbPhanQuyen.GetItemText(cbbPhanQuyen.Items[i]) == dgvThongTinTaiKhoan.Rows[vitri].Cells[5].Value.ToString())
                    {
                        cbbPhanQuyen.SelectedItem = cbbPhanQuyen.Items[i];
                    }
                }
            }
            

        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            lbMaTaiKhoan.Text = ". . .";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            if (cbbPhanQuyen.Items.Count > 0)
                cbbPhanQuyen.SelectedItem = cbbPhanQuyen.Items[0];
        }

        private void Form_QLTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
