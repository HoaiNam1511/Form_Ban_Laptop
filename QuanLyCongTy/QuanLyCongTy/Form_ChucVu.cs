using System;
using System.Collections.Generic;
using BUS;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class Form_ChucVu : Form
    {
        BUS_ChucVu bus_ChucVu = new BUS_ChucVu();
        BUS_NhomChucVu bus_NhomChucVu = new BUS_NhomChucVu();
        BUS_NhanSu bus_NhanSu = new BUS_NhanSu();
     
        public Form_ChucVu()
        {
            InitializeComponent();
            this.Text = "11111";
        }

        private void Form_ChucVu_Load(object sender, EventArgs e)
        {
            DataTable thongTinNhomChucVu = bus_NhomChucVu.thongTinNhomChucVu();
            cboNhomChucVu.ValueMember = "Ma_nhom_chuc_vu";
            cboNhomChucVu.DisplayMember = "Ten_nhom_chuc_vu";
            cboNhomChucVu.DataSource = thongTinNhomChucVu;
            hienThi();
            //dtNhanSu = bus_NhanSu.thongTinNhanSu();
        }
        public void hienThi()
        {
            DataTable dtChucVu = bus_ChucVu.thongTinChucVu();
            dgvChucVu.DataSource = dtChucVu;
            dgvChucVu.Columns["Ma_chuc_vu"].HeaderText = "Mã chức vụ";
            dgvChucVu.Columns["Ten_chuc_vu"].HeaderText = "Tên chức vụ";
            dgvChucVu.Columns["id_chuc_vu"].Visible = false;
        }
        public bool kiemTraNhap(bool check)
        {
            string thongBao = "Vui lòng nhập: ";
            bool kiemTra = false;
            if (txtTenChucVu.Text.Trim().Length == 0)
            {
                thongBao += " - Tên chức vụ";
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
        
        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChucVu.Rows.Count > 0)
            {
                int vitri = dgvChucVu.CurrentCell.RowIndex;
                lbMaChucVu.Text = dgvChucVu.Rows[vitri].Cells[1].Value.ToString();
                txtTenChucVu.Text = dgvChucVu.Rows[vitri].Cells[2].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (StaticClass.kiemTraQuyen())
            {
                if (kiemTraNhap(true))
                {
                    string maNhomChucVu = cboNhomChucVu.SelectedValue.ToString();
                    DTO_ChucVu thongTinChucVu = new DTO_ChucVu(txtTenChucVu.Text, maNhomChucVu);
                    if (bus_ChucVu.themThongTinChucVu(thongTinChucVu))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                        clear();
                        hienThi();
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

            }
            else
                MessageBox.Show("Chức năng này chỉ có Admin được thực hiện");
            if (lbMaChucVu.Text != ". . .")
            {
                if (kiemTraNhap(true))
                {
                    int viTri = dgvChucVu.CurrentCell.RowIndex;
                    if (dgvChucVu.Rows[viTri].Cells[2].Value.ToString() != "Khác")
                    {
                        string maChucVu = lbMaChucVu.Text;
                        string maNhomChucVu = cboNhomChucVu.SelectedValue.ToString();
                        DTO_ChucVu thongTinChucVu = new DTO_ChucVu(txtTenChucVu.Text, maNhomChucVu);
                        if (bus_ChucVu.suaThongTinChucVu(maChucVu, thongTinChucVu))
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                            clear();
                            hienThi();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa nhóm chức vụ này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                 
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức vụ cần sửa", "Lỗi", MessageBoxButtons.OK);
            }
        }
        private void xoaChucVu()
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xoá ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                int vitri = dgvChucVu.CurrentCell.RowIndex;
                string maCongTy = dgvChucVu.Rows[vitri].Cells[1].Value.ToString();
                if (bus_ChucVu.xoaThongTinChucVu(maCongTy))
                    clear();
                hienThi();
            }
        }
        private void kiemTraXoa()
        {
            DataTable dtNhanSu;
            dtNhanSu = bus_NhanSu.thongTinNhanSu();
            int kt = 0;
            foreach (DataRow dtRow in dtNhanSu.Rows)
            {
                if (dtRow["Ten_chuc_vu"].ToString() == txtTenChucVu.Text)
                {
                    kt++;
                }
            }
            if (kt == 0)
            {
                xoaChucVu();
            }
            else
            {
                MessageBox.Show("Không thể xoá, đang có nhân viên sử dụng chức vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable dtNhanSu;
            dtNhanSu = bus_NhanSu.thongTinNhanSu();
            int viTri = dgvChucVu.CurrentCell.RowIndex;
            if (StaticClass.kiemTraQuyen())
            {
                if (dgvChucVu.Rows.Count > 0)
                {
                    if (lbMaChucVu.Text != ". . .")
                    {
                        if (dgvChucVu.Rows[viTri].Cells[2].Value.ToString() != "Khác")
                        {
                            if (dtNhanSu.Rows.Count > 0)
                            {
                                kiemTraXoa();
                            }
                            else
                            {
                                xoaChucVu();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thể xoá nhóm chức vụ này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn chức vụ cần xóa", "Lỗi", MessageBoxButtons.OK);
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

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            lbMaChucVu.Text = ". . .";
            if(cboNhomChucVu.Items.Count>0)
            {
                cboNhomChucVu.SelectedIndex = 0;
            }
            txtTenChucVu.Text = "";
            
        }

    }
}
