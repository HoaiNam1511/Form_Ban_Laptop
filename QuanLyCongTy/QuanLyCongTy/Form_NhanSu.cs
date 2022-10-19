using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using OfficeOpenXml;

namespace QuanLyCongTy
{
    public partial class Form_NhanSu : Form
    {
        BUS_NhanSu bus_NhanSu = new BUS_NhanSu();
        BUS_CongTy bus_CongTy = new BUS_CongTy();
        BUS_ChucVu bus_ChucVu = new BUS_ChucVu();
        BUS_NhomChucVu bus_NhomChucVu = new BUS_NhomChucVu();
        BUS_ThongKe busThongKe = new BUS_ThongKe();
        public Form_NhanSu()
        {
            InitializeComponent();
            txtKhac.Enabled = false;
        }

        private void Form_NhanSu_Load(object sender, EventArgs e)
        {
            cboCongTy.Items.Clear();
            DataTable thongTinCongTy = bus_CongTy.thongTinCongTy();
            cboCongTy.ValueMember = "Ma_cong_ty";
            cboCongTy.DisplayMember = "Ten_cong_ty";
            cboCongTy.DataSource = thongTinCongTy;
            for (int i = 2022; i >= 1950; i--)
            {
                cboNamSinh.Items.Add(i);
            }
            cboNamSinh.SelectedIndex = 0;

            cboNhomChucVu.Items.Clear();
            DataTable thongTinNhomChucVu = bus_NhomChucVu.thongTinNhomChucVu();
            cboNhomChucVu.ValueMember = "Ma_nhom_chuc_vu";
            cboNhomChucVu.DisplayMember = "Ten_nhom_chuc_vu";
            cboNhomChucVu.DataSource = thongTinNhomChucVu;
            cboQuocTich.Items.Add("Việt Nam");
            cboQuocTich.Items.Add("Khác");
            cboQuocTich.SelectedIndex = 0;
            hienThi();
        }

        public void hienThi()
        {
            DataTable dtNhanSu = bus_NhanSu.thongTinNhanSu();
            dgvThongTinNhanSu.DataSource = dtNhanSu;
            dgvThongTinNhanSu.Columns["Ma_nhan_vien"].HeaderText = "Mã nhân viên";
            dgvThongTinNhanSu.Columns["Ho_ten"].HeaderText = "Họ tên";
            dgvThongTinNhanSu.Columns["Quoc_tich"].HeaderText = "Quốc tịch";
            dgvThongTinNhanSu.Columns["Nam_sinh"].HeaderText = "Năm sinh";
            dgvThongTinNhanSu.Columns["Ho_khau"].HeaderText = "Hộ khẩu";
            dgvThongTinNhanSu.Columns["Ten_chuc_vu"].HeaderText = "Chức vụ";
            //dgvThongTinNhanSu.Columns["Ma_chuc_vu"].HeaderText = "Chức vụ";
            dgvThongTinNhanSu.Columns["Thong_tin_khac"].HeaderText = "Thông tin khác";
            dgvThongTinNhanSu.Columns["Ma_nhan_vien"].HeaderText = "Mã nhân viên";
            dgvThongTinNhanSu.Columns["CCCD"].HeaderText = "CCCD";
            dgvThongTinNhanSu.Columns["Ma_chuc_vu"].Visible = false;
            dgvThongTinNhanSu.Columns["Ma_cong_ty"].Visible = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (StaticClass.kiemTraQuyen())
            {
                if (kiemTraNhap(true))
                {
                    DataTable dtNhanSu = bus_NhanSu.thongTinNhanSu();
                    string maCongTy = cboCongTy.SelectedValue.ToString();
                    string chucVu;
                    if (cboChucVu.Text != "Khác")
                    {
                        chucVu = cboChucVu.SelectedValue.ToString();
                    }
                    else
                    {
                        string tenChucVu = txtKhac.Text;
                        string maNhomChucVu = cboNhomChucVu.SelectedValue.ToString();
                        DTO_ChucVu dtoChucVu = new DTO_ChucVu(tenChucVu, maNhomChucVu);
                        bus_ChucVu.themThongTinChucVu(dtoChucVu);
                        DataTable dtChucVu = bus_ChucVu.thongTinMotChucVuDESC();
                        chucVu = dtChucVu.Rows[0]["Ma_chuc_vu"].ToString();
                        //Cap nhat lai combobox
                        DataTable thongTinNhomChucVu = bus_NhomChucVu.thongTinNhomChucVu();
                        cboNhomChucVu.ValueMember = "Ma_nhom_chuc_vu";
                        cboNhomChucVu.DisplayMember = "Ten_nhom_chuc_vu";
                        cboNhomChucVu.DataSource = thongTinNhomChucVu;
                    }
                    string quocTich = cboQuocTich.Text;
                    int namSinh = Convert.ToInt32(cboNamSinh.SelectedItem.ToString());
                    DTO_NhanSu nhanSu = new DTO_NhanSu(txtMaNhanVien.Text,txtHoTen.Text, quocTich, txtHoKhau.Text, chucVu, txtThongTinKhac.Text, namSinh, maCongTy,txtCCCD.Text);

                    if(dtNhanSu.Rows.Count == 0)
                    {
                        if (bus_NhanSu.themThongTinNhanSu(nhanSu))
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                            hienThi();
                        }
                    }
                    else
                    {
                        foreach (DataRow row in dtNhanSu.Rows)
                        {
                            if (txtMaNhanVien.Text == row["Ma_nhan_vien"].ToString())
                            {
                                MessageBox.Show("Mã nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                break;
                            }
                            else
                            {
                                if (bus_NhanSu.themThongTinNhanSu(nhanSu))
                                {
                                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                                    hienThi();
                                }
                            }

                        }
                    }
                }
            }
            else
                MessageBox.Show("Chức năng này chỉ có Admin được thực hiện");
                clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (StaticClass.kiemTraQuyen())
            {
                if (txtMaNhanVien.Text.Trim() != "")
                {
                    if (kiemTraNhap(true))
                    {
                        string maCongTy = cboCongTy.SelectedValue.ToString();
                        string chucVu;
                        if (cboChucVu.Text != "Khác")
                        {
                            chucVu = cboChucVu.SelectedValue.ToString();
                        }
                        else
                        {
                            string tenChucVu = txtKhac.Text;
                            string maNhomChucVu = cboNhomChucVu.SelectedValue.ToString();
                            DTO_ChucVu dtoChucVu = new DTO_ChucVu(tenChucVu, maNhomChucVu);
                            bus_ChucVu.themThongTinChucVu(dtoChucVu);
                            DataTable dtChucVu = bus_ChucVu.thongTinMotChucVuDESC();
                            chucVu = dtChucVu.Rows[0]["Ma_chuc_vu"].ToString();
                            //Cap nhat lai combobox
                            DataTable thongTinNhomChucVu = bus_NhomChucVu.thongTinNhomChucVu();
                            cboNhomChucVu.ValueMember = "Ma_nhom_chuc_vu";
                            cboNhomChucVu.DisplayMember = "Ten_nhom_chuc_vu";
                            cboNhomChucVu.DataSource = thongTinNhomChucVu;

                        }
                        string quocTich = cboQuocTich.Text;
                        int namSinh = Convert.ToInt32(cboNamSinh.SelectedItem.ToString());
                        DTO_NhanSu nhanSu = new DTO_NhanSu(txtMaNhanVien.Text, txtHoTen.Text, quocTich, txtHoKhau.Text, chucVu, txtThongTinKhac.Text, namSinh, maCongTy,txtCCCD.Text);
                        MessageBox.Show(txtMaNhanVien.Text);
                        if(bus_NhanSu.suaThongTinNhanSu( nhanSu))
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                            hienThi();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Chọn vị trí cần sửa", "Lỗi", MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Chức năng này chỉ có Admin được thực hiện");

            clear();
        }

        private void dgvThongTinNhanSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKhac.Enabled = false;
            txtKhac.Text = "";
            int vitri = dgvThongTinNhanSu.CurrentCell.RowIndex;
            txtMaNhanVien.Text = dgvThongTinNhanSu.Rows[vitri].Cells[0].Value.ToString();
            txtHoTen.Text = dgvThongTinNhanSu.Rows[vitri].Cells[1].Value.ToString();
            cboQuocTich.Text = dgvThongTinNhanSu.Rows[vitri].Cells[2].Value.ToString();
            cboNamSinh.SelectedItem = Convert.ToInt32(dgvThongTinNhanSu.Rows[vitri].Cells[3].Value.ToString());
            txtHoKhau.Text = dgvThongTinNhanSu.Rows[vitri].Cells[4].Value.ToString();
            txtThongTinKhac.Text = dgvThongTinNhanSu.Rows[vitri].Cells[6].Value.ToString();
            txtCCCD.Text = dgvThongTinNhanSu.Rows[vitri].Cells[8].Value.ToString();
            cboCongTy.Text = dgvThongTinNhanSu.Rows[vitri].Cells[9].Value.ToString();
            cboChucVu.Text = dgvThongTinNhanSu.Rows[vitri].Cells[10].Value.ToString();
            cboNhomChucVu.Text = dgvThongTinNhanSu.Rows[vitri].Cells[11].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (StaticClass.kiemTraQuyen())
            {
                if (dgvThongTinNhanSu.Rows.Count > 0) {
                    if (txtMaNhanVien.Text.ToString() != "")
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xoá ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            int vitri = dgvThongTinNhanSu.CurrentCell.RowIndex;
                            string maNhanSu = dgvThongTinNhanSu.Rows[vitri].Cells[0].Value.ToString();
                            bus_NhanSu.xoaThongTinNhanSu(maNhanSu);
                            hienThi();
                            clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn tài khoản muốn xóa");
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
        public bool kiemTraNhap(bool check)
        {
            string thongBao = "Vui lòng nhập: ";
            bool kiemTra = false;
            if(cboChucVu.SelectedItem.ToString().Trim().Length == 0)
            {
                thongBao += " - Chức vụ";
                kiemTra = true;
            }
            if (txtHoKhau.Text.Trim().Length == 0)
            {
                thongBao += " - Hộ khẩu";
                kiemTra = true;
            }
            if (txtHoTen.Text.Trim().Length == 0)
            {
                thongBao += " - Họ tên";
                kiemTra = true;
            }
            if (cboNamSinh.SelectedItem.ToString().Trim().Length == 0)
            {
                thongBao += " - Năm sinh";
                kiemTra = true;
            }
            if (cboQuocTich.Text.Trim().Length == 0)
            {
                thongBao += " - Quốc tịch";
                kiemTra = true;
            }
            if (cboCongTy.SelectedIndex < 0)
            {
                thongBao += " - Công ty";
                kiemTra = true;
            }
            if (txtMaNhanVien.Text.Trim().Length  == 0)
            {
                thongBao += " - Mã nhân viên";
                kiemTra = true;
            }
            if (txtCCCD.Text.Trim().Length == 0)
            {
                thongBao += " - CCCD";
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

        private void clear()
        {
            txtHoKhau.Text = "";
            txtHoTen.Text = "";
            cboQuocTich.SelectedIndex = 0;
            txtThongTinKhac.Text = "";
            txtMaNhanVien.Text = "";
            if(cboCongTy.Items.Count>0) 
            cboCongTy.SelectedIndex = 0;
            txtLinkFile.Text = "";
            txtCCCD.Text = "";
            txtMaNhanVien.Text = "";
        }
        private void btnDatLai_Click(object sender, EventArgs e)
        {
            clear();
            hienThi();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dtNhanSu = new DataTable();
            dtNhanSu = busThongKe.timKiemAllNhanSu(txtTimKiem.Text.ToString());
            dgvThongTinNhanSu.DataSource = dtNhanSu;
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            if (StaticClass.kiemTraQuyen())
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Excel| *.xls; *.xlsx; *.xlsm; *.xlm";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string fileName;
                    fileName = dlg.FileName;
                    txtLinkFile.Text = fileName.ToString();
                }
            }
            else
                MessageBox.Show("Chức năng này chỉ có Admin được thực hiện");
        }

        private void btnTaiLen_Click(object sender, EventArgs e)
        {
            if (StaticClass.kiemTraQuyen())
            {
                List<DTO_NhanSu> listNhanSu = new List<DTO_NhanSu>();
                if (txtLinkFile.Text.Trim() != "")
                {
                    try
                    {
                        // mở file excel
                        var package = new ExcelPackage(new FileInfo(txtLinkFile.Text.ToString()));
                        // lấy ra sheet đầu tiên để thao tác
                        if (package.Workbook.Worksheets.Count > 0)
                        {
                            ExcelWorksheet workSheet = package.Workbook.Worksheets[0];

                            if (workSheet.Dimension != null)
                            {
                                // duyệt tuần tự từ dòng thứ 2 đến dòng cuối cùng của file. lưu ý file excel bắt đầu từ số 1 không phải số 0
                                int count=0;
                                for (int i = workSheet.Dimension.Start.Row + 1; i <= workSheet.Dimension.End.Row; i++)
                                {
                                    try
                                    {
                                        // biến j biểu thị cho một column trong file
                                        int j = workSheet.Dimension.Start.Column + 1;
                                        // lấy ra cột họ tên tương ứng giá trị tại vị trí [i, 1]. i lần đầu là 2
                                        // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh

                                        string hoTen = workSheet.Cells[i, j].Text.ToString().Trim();

                                        string quocTich = workSheet.Cells[i, j += 1].Text.ToString().Trim();
                                        if (quocTich != "Việt Nam" && quocTich != "Khác")
                                            quocTich = "";
                                        int namSinh = -1;
                                        try
                                        {
                                            namSinh = Convert.ToInt32(workSheet.Cells[i, j += 1].Text.ToString().Trim());
                                        }
                                        catch (Exception)
                                        {

                                        }

                                        string hoKhau = workSheet.Cells[i, j += 1].Text.ToString().Trim();

                                        string tenChucVu = workSheet.Cells[i, j += 1].Text.ToString().Trim();
                                        DataTable dtChucVu = new DataTable();
                                        dtChucVu = bus_ChucVu.layIdChucVu(tenChucVu);
                                        string maChucVu = "";
                                        if (dtChucVu.Rows.Count > 0)
                                        {
                                            DataRow r = dtChucVu.Rows[0];
                                            maChucVu = r["Ma_chuc_vu"].ToString();
                                        }

                                        string thongtinKhac = workSheet.Cells[i, j += 1].Text.ToString().Trim();
                                        string tenCongTy = workSheet.Cells[i, j += 1].Text.ToString().Trim();
                                        //lấy ra cột ngày sinh tương ứng giá trị tại vị trí[i, 2]. i lần đầu là 2
                                        // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                                        // tạo UserInfo từ dữ liệu đã lấy được
                                        DataTable dtCongty = new DataTable();
                                        dtCongty = bus_CongTy.layIdCongTy(tenCongTy);
                                        string maCongTy = "";
                                        if (dtCongty.Rows.Count > 0)
                                        {
                                            DataRow r = dtCongty.Rows[0];
                                            maCongTy = r["Ma_cong_ty"].ToString();
                                        }
                                        //if (kiemTraNhapExcel(hoTen, quocTich, hoKhau, namSinh, maChucVu, maCongTy, i) == true)
                                        //{
                                        //    DTO_NhanSu nhanSu = new DTO_NhanSu(hoTen, quocTich, hoKhau, maChucVu, thongtinKhac, namSinh, maCongTy);
                                        //    // add nhanSuinfo vào danh sách listNhanSu
                                        //    listNhanSu.Add(nhanSu);
                                        //    if (bus_NhanSu.themThongTinNhanSu(nhanSu))
                                        //    {
                                        //        count++;
                                        //        clear();
                                        //    }
                                        //    dtCongty.Clear();
                                        //}
                                    }
                                    catch (Exception exe)
                                    {
                                        throw exe;
                                    }
                                }
                                if (count > 0)
                                {
                                    MessageBox.Show("Nhập " + count + " dòng dữ liệu thành công");
                                }
                            }
                            else
                            {
                                MessageBox.Show("File trống");
                            }

                        }
                        else
                            MessageBox.Show("File không hợp lệ");

                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("Error!" + ee);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn file");
                }
            }
            else
                MessageBox.Show("Chức năng này chỉ có Admin được thực hiện");
            

            hienThi();
        }
        public bool kiemTraNhapExcel(string hoTen, string quocTich, string hoKhau, int namSinh, string chucVu, string maCongTy, int row)
        {

            string thongBao = "\nDữ liệu: ";
            bool kiemTra = false;
            if (hoTen == null)
            {
                thongBao += " - Họ tên";
                kiemTra = true;
            }
            if (quocTich == null)
            {
                thongBao += " - Quốc tịch";
                kiemTra = true;
            }
            if (hoKhau == null)
            {
                thongBao += " - Hộ khẩu";
                kiemTra = true;
            }
            if (namSinh == -1)
            {
                thongBao += " - Năm sinh";
                kiemTra = true;
            }
            if (chucVu == "")
            {
                thongBao += " - Chức vụ";
                kiemTra = true;
            }
            if (maCongTy == "")
            {
                thongBao += " - Công ty";
                kiemTra = true;
            }

            if (kiemTra == true)
            {
                MessageBox.Show("Lỗi nhập dữ liệu tại dòng " + row + thongBao);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboChucVu.Text.ToString() == "Khác")
            {
                txtKhac.Enabled = true;
            }
            else
            {
                txtKhac.Enabled = false;
                txtKhac.Text = "";
            }
        }

        private void cboNhomChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNhomChucVu = cboNhomChucVu.SelectedValue.ToString();
            DataTable tbThongTinChucVu = bus_ChucVu.thongTinChucVuNhom(maNhomChucVu);
            cboChucVu.ValueMember = "Ma_chuc_vu";
            cboChucVu.DisplayMember = "Ten_chuc_vu";
            cboChucVu.DataSource = tbThongTinChucVu;
        }
    }
}
