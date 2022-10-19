using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class Form_CongTy : Form
    {
        BUS_CongTy bus_CongTy = new BUS_CongTy();
        BUS_NhanSu bus_NhanSu = new BUS_NhanSu();
        BUS_SuViec busSuViec = new BUS_SuViec();
        public Form_CongTy()
        {
            InitializeComponent();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
            txtTenCongTy.Text = "";
            txtTimKiem.Text = "";
            lbMaCongTy.Text = ". . .";
        }

    

        public void hienThi()
        {
            DataTable dtCongTy = bus_CongTy.thongTinCongTy();
            dgvCongTy.DataSource = dtCongTy;
            dgvCongTy.Columns["Ma_cong_ty"].HeaderText = "Mã công ty";
            dgvCongTy.Columns["Ten_cong_ty"].HeaderText = "Tên công ty";
            dgvCongTy.Columns["Dia_chi_cong_ty"].HeaderText = "Địa chỉ";
            dgvCongTy.Columns["id_cong_ty"].Visible = false;
        }
        private void Form_CongTy_Load(object sender, EventArgs e)
        {
            hienThi();
        }
        public bool kiemTraNhap(bool check)
        {
            string thongBao = "Vui lòng nhập: ";
            bool kiemTra = false;
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                thongBao += " - Địa chỉ";
                kiemTra = true;
            }
            if (txtTenCongTy.Text.Trim().Length == 0)
            {
                thongBao += " - Tên công ty";
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

        private void dgvCongTy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCongTy.Rows.Count > 0)
            {
                int vitri = dgvCongTy.CurrentCell.RowIndex;
                lbMaCongTy.Text = dgvCongTy.Rows[vitri].Cells[1].Value.ToString();
                txtTenCongTy.Text = dgvCongTy.Rows[vitri].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvCongTy.Rows[vitri].Cells[3].Value.ToString();
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            BindingSource bsCongTy = new BindingSource();
            bsCongTy.DataSource = dgvCongTy.DataSource;
            bsCongTy.Filter = "Ten_cong_ty" + " like '%" + txtTimKiem.Text + "%'";
            dgvCongTy.DataSource = bsCongTy;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (StaticClass.kiemTraQuyen())
            {

                if (kiemTraNhap(true))
                {
                    DTO_CongTy thongTinCongTy = new DTO_CongTy(txtTenCongTy.Text, txtDiaChi.Text);
                    if (bus_CongTy.themThongTinCongTy(thongTinCongTy))
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
            if (lbMaCongTy.Text != ". . .")
            {
                if (kiemTraNhap(true))
                {
                    string maCongTy = lbMaCongTy.Text;
                    DTO_CongTy thongTinSua = new DTO_CongTy(txtTenCongTy.Text, txtDiaChi.Text);
                    if (bus_CongTy.suaThongTinCongTy(maCongTy, thongTinSua))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        clear();
                        hienThi();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn công ty cần sửa", "Lỗi", MessageBoxButtons.OK);
            }
        }
        private void xoaCongTy()
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xoá ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                int vitri = dgvCongTy.CurrentCell.RowIndex;
                string maCongTy = dgvCongTy.Rows[vitri].Cells[1].Value.ToString();
                if (bus_CongTy.xoaThongTinCongTy(maCongTy))
                    clear();
                hienThi();
            }
        }
        private void kiemTraXoa()
        {
            DataTable dtNhanSu = bus_NhanSu.thongTinNhanSu();
            DataTable dtSuViec = busSuViec.thongTinSuViec();

            int kt = 0;
            foreach (DataRow dtRow in dtNhanSu.Rows)
            {
                if (dtRow["Ten_cong_ty"].ToString() == txtTenCongTy.Text)
                {
                    kt++;
                }
            }

            foreach (DataRow dtRowSv in dtSuViec.Rows)
            {
                if (dtRowSv["Ten_cong_ty"].ToString() == txtTenCongTy.Text)
                {
                    kt++;
                }
            }

            if (kt == 0)
            {
                xoaCongTy();
            }
            else
            {
                MessageBox.Show("Không thể xoá, đang có nhân viên sử dụng công ty", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable dtNhanSu = bus_NhanSu.thongTinNhanSu();
            if (StaticClass.kiemTraQuyen())
            {
                if (dgvCongTy.Rows.Count > 0)
                {
                    if (lbMaCongTy.Text != ". . .")
                    {
                        if (dtNhanSu.Rows.Count > 0)
                        {
                            kiemTraXoa();
                        }
                        else
                        {
                            xoaCongTy();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn công ty cần xóa", "Lỗi", MessageBoxButtons.OK);
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
            lbMaCongTy.Text = ". . .";
            txtTenCongTy.Text = "";
            txtDiaChi.Text = "";
            txtTimKiem.Text = "";
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
             StaticClass.indexHomeLoadForm = 3;
            Form_Main f = new Form_Main();
            f.Show();
            Application.OpenForms["Form_Main"].Close();

        }

        private void btnQlNhanSu_Click(object sender, EventArgs e)
        {
            StaticClass.indexHomeLoadForm = 1;
            Form_Main f = new Form_Main();
            f.Show();
            Application.OpenForms["Form_Main"].Close();

        }
    }
}
