using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLyCongTy
{
    public partial class Form_SuViec_Sua : Form
    {
        string maSuViec;
        BUS_HauQua bus_HauQua = new BUS_HauQua();
        BUS_KetQua bus_KetQua = new BUS_KetQua();
        BUS_SuViec bus_SuViec = new BUS_SuViec();
        BUS_CongTy bus_CongTy = new BUS_CongTy();
        private Form_QlSuViec formQl;
        public Form_SuViec_Sua(string msv, Form_QlSuViec formQlParam)
        {
            InitializeComponent();
            maSuViec = msv;
            formQl = formQlParam;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            DataTable dtMotSuViec = bus_SuViec.thongTinMotSuViec(maSuViec);
            if (kiemTraNhap())
            {
                string maHauQua = dtMotSuViec.Rows[0]["Ma_hau_qua"].ToString();
                string maKetQua = dtMotSuViec.Rows[0]["Ma_ket_qua"].ToString();
                DTO_HauQua hauQua = new DTO_HauQua(txtHqNguoi.Text, txtHqPhuongTien.Text, txtHqVatLieu.Text, txtHqKhac.Text);
                bus_HauQua.suaThongTinHauQua(hauQua, maHauQua);

                if (cboLoai.Text == "Hình sự")
                {
                    DTO_KetQua ketQua = new DTO_KetQua(txtKqNguoi.Text, "", txtKqToiDanhHanhVi.Text, "", "", cboLoai.Text);
                    bus_KetQua.suaThongTinKetQua(ketQua, maKetQua);
                }
                else if (cboLoai.Text == "Hành chính")
                {
                    DTO_KetQua ketQua = new DTO_KetQua("", txtKqNguoi.Text, "", txtKqToiDanhHanhVi.Text, "", cboLoai.Text);
                    bus_KetQua.suaThongTinKetQua(ketQua, maKetQua);
                }
                else
                {
                    DTO_KetQua ketQua = new DTO_KetQua("", "", "", "", txtKqToiDanhHanhVi.Text, cboLoai.Text);
                    bus_KetQua.suaThongTinKetQua(ketQua, maKetQua);
                }
                DateTime thoiGianBD = Convert.ToDateTime(dtpThoiGianBD.Value.ToString("dd-MM-yyyy"));
                DateTime thoiGianKT = Convert.ToDateTime(dtpThoiGianKT.Value.ToString("dd-MM-yyyy"));
                string maCongTy = cboCongTy.SelectedValue.ToString();
                DTO_SuViec suViec = new DTO_SuViec(txtTomTat.Text, thoiGianBD, thoiGianKT, maCongTy);
                if(bus_SuViec.suaThongSuViec(suViec, maSuViec))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn Tài khoản muốn sửa");
            }
            formQl.hienThi();
            clear();

        }
        private bool kiemTraNhap()
        {
            string thong_bao = "Vui lòng nhập: ";
            bool kiem_tra = false;
            if (cboCongTy.SelectedIndex<0)
            {
                kiem_tra = true;
            }
            if (txtHqNguoi.Text.Trim().Length == 0)
            {
                kiem_tra = true;
            }
            if (txtHqPhuongTien.Text.Trim().Length == 0)
            {
                kiem_tra = true;
            }
            if (txtHqVatLieu.Text.Trim().Length == 0)
            {
                kiem_tra = true;
            }
            if (txtKqNguoi.Text.Trim().Length == 0)
            {
                kiem_tra = true;
            }
            if (txtKqToiDanhHanhVi.Text.Trim().Length == 0)
            {
                kiem_tra = true;
            }
            if (txtTomTat.Text.Trim().Length == 0)
            {
                kiem_tra = true;
            }
            if (kiem_tra == true)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Form_SuViec_Sua_Load(object sender, EventArgs e)
        {
            lbMaVuViec.Text = maSuViec;
            DataTable dtCongTy = bus_CongTy.thongTinCongTy();
            cboCongTy.ValueMember = "Ma_cong_ty";
            cboCongTy.DisplayMember = "Ten_cong_ty";
            cboCongTy.DataSource = dtCongTy;

            cboLoai.Items.Add("Hình sự");
            cboLoai.Items.Add("Hành chính");
            cboLoai.Items.Add("Khác");

            DataTable dtMotSuViec = bus_SuViec.thongTinMotSuViec(maSuViec);
            foreach (DataRow dtSuViec in dtMotSuViec.Rows)
            {
                txtTomTat.Text = dtSuViec["Tom_tat_su_viec"].ToString();

                CultureInfo culutreInfo = new CultureInfo("vi-VN");
                culutreInfo.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
                Thread.CurrentThread.CurrentCulture = culutreInfo;
                dtpThoiGianBD.Value = Convert.ToDateTime(dtSuViec["Thoi_gian_bd"].ToString());
                dtpThoiGianKT.Value = Convert.ToDateTime(dtSuViec["Thoi_gian_kt"].ToString());

                cboCongTy.SelectedValue = dtSuViec["Ma_cong_ty"].ToString();
                txtHqNguoi.Text = dtSuViec["Hau_qua_nguoi"].ToString();
                txtHqVatLieu.Text = dtSuViec["Nguyen_vat_lieu"].ToString();
                txtHqPhuongTien.Text = dtSuViec["Phuong_tien"].ToString();
                txtHqKhac.Text = dtSuViec["Hau_qua_khac"].ToString();
                cboLoai.SelectedItem = dtSuViec["Nhom"].ToString();
                if (dtSuViec["Toi_danh"].ToString().Trim().Length > 0)
                {
                    txtKqToiDanhHanhVi.Text = dtSuViec["Toi_danh"].ToString().Trim();
                    txtKqNguoi.Text = Text = dtSuViec["Toi_danh_nguoi"].ToString().Trim();
                }
                else if (dtSuViec["Hanh_vi"].ToString().Trim().Length > 0)
                {
                    txtKqToiDanhHanhVi.Text = dtSuViec["Hanh_vi"].ToString().Trim();
                    txtKqNguoi.Text = Text = dtSuViec["Hanh_chinh_nguoi"].ToString().Trim();
                }
                else
                {
                    txtKqToiDanhHanhVi.Text = Text = dtSuViec["Ket_qua_khac"].ToString().Trim();
                    txtKqNguoi.Visible = false;
                    lbNguoiKetQua.Visible = false;
                }

            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            lbMaVuViec.Text = ". . .";
            txtHqKhac.Text = "";
            txtHqNguoi.Text = "";
            txtHqPhuongTien.Text = "";
            txtHqVatLieu.Text = "";
            txtKqNguoi.Text = "";
            txtKqToiDanhHanhVi.Text = "";
            txtTomTat.Text = "";
            if (cboCongTy.Items.Count > 0)
                cboCongTy.SelectedIndex = 0;
            if (cboLoai.Items.Count > 0)
                cboLoai.SelectedIndex = 0;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLoai.Text == "Khác")
            {
                txtKqNguoi.Visible = false;
                lbNguoiKetQua.Visible = false;
            }
            else
            {
                txtKqNguoi.Visible = true;
                lbNguoiKetQua.Visible = true;
            }
        }
    }
}
