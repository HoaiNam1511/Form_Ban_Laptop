using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyCongTy
{
    public partial class Form_QlSuViec : Form
    {
        BUS_HauQua bus_HauQua = new BUS_HauQua();
        BUS_KetQua bus_KetQua = new BUS_KetQua();
        BUS_SuViec bus_SuViec = new BUS_SuViec();
        BUS_CongTy bus_CongTy = new BUS_CongTy();
        BUS_ThongKe busThongKe = new BUS_ThongKe();
        public Form_QlSuViec()
        {
            InitializeComponent();
            

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (StaticClass.kiemTraQuyen())
            {
                Form_SuViec_Them f = new Form_SuViec_Them(this);
                f.ShowDialog();
            }
            else
                MessageBox.Show("Chức năng này chỉ có Admin được thực hiện");
            
        }
        public void hienThi()
        {
            DataTable dtThongTinSv = bus_SuViec.thongTinSuViec();
            dgvSuViec.DataSource = dtThongTinSv;
            dgvSuViec.Columns["Ma_su_viec"].HeaderText = "Mã sự việc";
            dgvSuViec.Columns["Tom_tat_su_viec"].HeaderText = "Tóm tắt sự việc";
            dgvSuViec.Columns["Ma_hau_qua"].Visible = false;
            dgvSuViec.Columns["Ma_ket_qua"].Visible = false;
            dgvSuViec.Columns["Thoi_gian_bd"].HeaderText = "Thời gian bắt đầu";
            dgvSuViec.Columns["Thoi_gian_kt"].HeaderText = "Thời gian kết thúc";
            ////////
            ///
            dgvSuViec.Columns["Hau_qua_nguoi"].HeaderText = "Người nhóm hậu quả";
            dgvSuViec.Columns["Phuong_tien"].Visible = false;
            dgvSuViec.Columns["Nguyen_vat_lieu"].Visible = false;
            dgvSuViec.Columns["Hau_qua_khac"].Visible = false;

            dgvSuViec.Columns["Toi_danh_nguoi"].HeaderText = "Người nhóm hình sự";
            dgvSuViec.Columns["Hanh_chinh_nguoi"].HeaderText = "Người nhóm hành chính";
            dgvSuViec.Columns["Toi_danh"].Visible = false;
            dgvSuViec.Columns["Hanh_vi"].Visible = false;
            dgvSuViec.Columns["Ket_qua_khac"].Visible = false;

            //dgvSuViec.Columns["id_hau_qua"].Visible = false;
            //dgvSuViec.Columns["Ma_hau_qua1"].Visible = false;
            //dgvSuViec.Columns["Ma_su_viec1"].Visible = false;
            //dgvSuViec.Columns["id_ket_qua"].Visible = false;
            //dgvSuViec.Columns["Ma_ket_qua1"].Visible = false;
            //dgvSuViec.Columns["Ma_su_viec2"].Visible = false;

            dgvSuViec.Columns["Ma_cong_ty"].Visible = false;
            // dgvSuViec.Columns["Ma_cong_ty1"].Visible = false;
            //dgvSuViec.Columns["id_cong_ty"].Visible = false;
            dgvSuViec.Columns["Ten_cong_ty"].Visible = false;
            // dgvSuViec.Columns["Dia_chi_cong_ty"].Visible = false;
            // dgvSuViec.Columns["Ma_su_viec2"].Visible = false;

            dgvSuViec.Columns["Nhom"].HeaderText = "Nhóm";

        }
        private void Form_QlSuViec_Load(object sender, EventArgs e)
        {
            hienThi();
        }

        private void dgvSuViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSuViec.Rows.Count > 0)
            {
                int vitri = dgvSuViec.CurrentCell.RowIndex;
                lbThongTinSuViec.Text = "Thông tin sự việc: " + dgvSuViec.Rows[vitri].Cells[1].Value.ToString();
                string ngay = dgvSuViec.Rows[vitri].Cells[2].Value.ToString();
                if (dgvSuViec.Rows[vitri].Cells[2].Value.ToString().Length > 0)
                {
                    lbThoiGianBD.Text = "Thời gian từ: " + dgvSuViec.Rows[vitri].Cells[2].Value.ToString().Substring(0, ngay.IndexOf(" "));
                }
                if (dgvSuViec.Rows[vitri].Cells[3].Value.ToString().Length > 0)
                {
                    lbThoiGianKT.Text = "Thời gian đến: " + dgvSuViec.Rows[vitri].Cells[3].Value.ToString().Substring(0, ngay.IndexOf(" "));
                }

                lbHqNguoi.Text = "Người: " + dgvSuViec.Rows[vitri].Cells[7].Value.ToString();
                lbHqPhuongTien.Text = "Phương tiện: " + dgvSuViec.Rows[vitri].Cells[8].Value.ToString();
                lbHqNguyenVatLieu.Text = "Vật liệu: " + dgvSuViec.Rows[vitri].Cells[9].Value.ToString();
                lbHqKhac.Text = "Khác " + dgvSuViec.Rows[vitri].Cells[10].Value.ToString();
                if (dgvSuViec.Rows[vitri].Cells[12].Value.ToString().Trim().Length > 0)
                {
                    lbKqNguoi.Text = "Người: " + dgvSuViec.Rows[vitri].Cells[12].Value.ToString();
                }
                if (dgvSuViec.Rows[vitri].Cells[14].Value.ToString().Trim().Length > 0)
                {
                    lbKqNguoi.Text = "Người: " + dgvSuViec.Rows[vitri].Cells[14].Value.ToString();
                }
                if (dgvSuViec.Rows[vitri].Cells[11].Value.ToString().Trim().Length > 0)
                {
                    lbKqTDanhHVi.Text = "Tội danh: " + dgvSuViec.Rows[vitri].Cells[11].Value.ToString();
                }
                else if (dgvSuViec.Rows[vitri].Cells[13].Value.ToString().Trim().Length > 0)
                {
                    lbKqTDanhHVi.Text = "Hành vi: " + dgvSuViec.Rows[vitri].Cells[13].Value.ToString();
                }
                else
                {
                    lbKqTDanhHVi.Text = "Khác: " + dgvSuViec.Rows[vitri].Cells[16].Value.ToString();
                }

                lbKqNhom.Text = "Nhóm: " + dgvSuViec.Rows[vitri].Cells[15].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (StaticClass.kiemTraQuyen())
            {
                if (lbThongTinSuViec.Text != "Thông tin sự việc:")
                {
                    int vitri = dgvSuViec.CurrentCell.RowIndex;
                    string maSuViec = dgvSuViec.Rows[vitri].Cells[0].Value.ToString();
                    Form_SuViec_Sua fSua = new Form_SuViec_Sua(maSuViec, this);
                    fSua.ShowDialog();

                }
                else
                    MessageBox.Show("Hãy chọn sự việc muốn sửa");
            }
            else
                MessageBox.Show("Chức năng này chỉ có Admin được thực hiện");

            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (StaticClass.kiemTraQuyen())
            {

                if (dgvSuViec.Rows.Count > 0)
                {
                    if (lbThongTinSuViec.Text != "Thông tin sự việc:")
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xoá ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            int vitri = dgvSuViec.CurrentCell.RowIndex;
                            bus_SuViec.xoaThongTinSuViec(dgvSuViec.Rows[vitri].Cells[0].Value.ToString());
                            bus_HauQua.xoaThongTinHauQua(dgvSuViec.Rows[vitri].Cells[4].Value.ToString());
                            bus_KetQua.xoaThongTinKetQua(dgvSuViec.Rows[vitri].Cells[5].Value.ToString());
                            hienThi();
                        }
                    }
                    else
                        MessageBox.Show("Hãy chọn sự việc muốn xóa");
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cần xoá");
                }
               
            }
            else
                MessageBox.Show("Chức năng này chỉ có Admin được thực hiện");

           
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dtSuViec = new DataTable();
            dtSuViec = busThongKe.timKiemAllSuviec(txtTimKiem.Text.ToString());
            dgvSuViec.DataSource = dtSuViec;
        }
    }
}
