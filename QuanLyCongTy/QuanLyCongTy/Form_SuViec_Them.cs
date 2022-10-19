using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using OfficeOpenXml;

namespace QuanLyCongTy
{
    public partial class Form_SuViec_Them : Form
    {
        BUS_HauQua bus_HauQua = new BUS_HauQua();
        BUS_KetQua bus_KetQua = new BUS_KetQua();
        BUS_SuViec bus_SuViec = new BUS_SuViec();
        BUS_CongTy bus_CongTy = new BUS_CongTy();

        private  Form_QlSuViec formQl;
        public Form_SuViec_Them(Form_QlSuViec formQlParam)
        {
            InitializeComponent();
            formQl = formQlParam;
        }

        private void Form_SuViec_Them_Load(object sender, EventArgs e)
        {
            DataTable dtCongTy = bus_CongTy.thongTinCongTy();
            cboCongTy.ValueMember = "Ma_cong_ty";
            cboCongTy.DisplayMember = "Ten_cong_ty";
            cboCongTy.DataSource = dtCongTy;
            cboLoai.Items.Add("Hình sự");
            cboLoai.Items.Add("Hành chính");
            cboLoai.Items.Add("Khác");
            cboLoai.SelectedIndex = 0;
        }

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLoai.SelectedIndex == 1)
            {
                lbLoai.Text = "Hành vi vi phạm";
            }
            else if(cboLoai.SelectedIndex == 0)
            {
                lbLoai.Text = "Tội danh";
            }
            else
            {
                lbLoai.Text = "Khác";
            }
        }


        private void clear()
        {
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
            txtLinkFile.Text = "";
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemTraNhap())
            {
                DTO_HauQua hauQua = new DTO_HauQua(txtHqNguoi.Text, txtHqPhuongTien.Text, txtHqVatLieu.Text, txtHqKhac.Text);
                bus_HauQua.themThongTinHauQua(hauQua);
                if (cboLoai.Text == "Hình sự")
                {
                    DTO_KetQua ketQua = new DTO_KetQua(txtKqNguoi.Text, "", txtKqToiDanhHanhVi.Text, "", "", cboLoai.Text);
                    if (bus_KetQua.themThongTinKetQua(ketQua))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else if (cboLoai.Text == "Hành chính")
                {
                    DTO_KetQua ketQua = new DTO_KetQua("", txtKqNguoi.Text, "", txtKqToiDanhHanhVi.Text, "", cboLoai.Text);
                    if (bus_KetQua.themThongTinKetQua(ketQua))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK );
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    DTO_KetQua ketQua = new DTO_KetQua("", txtKqNguoi.Text, "", "", txtKqToiDanhHanhVi.Text, cboLoai.Text);
                    if (bus_KetQua.themThongTinKetQua(ketQua))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }

                CultureInfo culutreInfo = new CultureInfo("vi-VN");
                culutreInfo.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
                Thread.CurrentThread.CurrentCulture = culutreInfo;
                DateTime thoiGianBD = Convert.ToDateTime(dtpThoiGianBD.Value.ToString("dd-MM-yyyy"));
                DateTime thoiGianKT = Convert.ToDateTime(dtpThoiGianKT.Value.ToString("dd-MM-yyyy"));
                string maCongTy = cboCongTy.SelectedValue.ToString();
                DTO_SuViec suViec = new DTO_SuViec(txtTomTat.Text, thoiGianBD, thoiGianKT, maCongTy);
                DataTable dtHauQua = bus_HauQua.thongTinHauQua();
                DataTable dtKetQua = bus_KetQua.thongTinKetQua();
                string maHauQua = dtHauQua.Rows[0]["Ma_hau_qua"].ToString();
                string maKetQua = dtKetQua.Rows[0]["Ma_ket_qua"].ToString();
                bus_SuViec.themThongTinSuViec(suViec, maHauQua, maKetQua);
                clear();
            }

            formQl.hienThi();

        }
        private bool kiemTraNhap()
        {
            string thong_bao = "Vui lòng nhập: ";
            bool kiem_tra = false;
            if (cboCongTy.SelectedIndex < 0)
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
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Lỗi nhập dữ liệu", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
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
                List<DTO_SuViec> listSuViec = new List<DTO_SuViec>();
                List<DTO_HauQua> listHauQua = new List<DTO_HauQua>();
                List<DTO_KetQua> listKetQua = new List<DTO_KetQua>();
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
                                int count = 0;
                                for (int i = workSheet.Dimension.Start.Row+3; i <= workSheet.Dimension.End.Row; i++)
                                {
                                    try
                                    {
                                        // biến j biểu thị cho một column trong file
                                        int j = workSheet.Dimension.Start.Column+1;
                                        // lấy ra cột họ tên tương ứng giá trị tại vị trí [i, 1]. i lần đầu là 2
                                        // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh

                                        string tomTat = workSheet.Cells[i, j].Text.ToString().Trim();


                                        DateTime batDau = Convert.ToDateTime("12/31/9999");
                                        DateTime ketThuc = Convert.ToDateTime("12/31/9999");
                                        CultureInfo culutreInfo = new CultureInfo("vi-VN");
                                        Thread.CurrentThread.CurrentCulture = culutreInfo;
                                        culutreInfo.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
                                        try
                                        {
                                            batDau = Convert.ToDateTime(workSheet.Cells[i, j += 1].Text.ToString());


                                        }
                                        catch (Exception)
                                        {
                                            MessageBox.Show("Loi datetime" + batDau.ToString());
                                        }
                                        try
                                        {
                                            
                                            ketThuc = Convert.ToDateTime(workSheet.Cells[i, j += 1].Text.ToString());

                                        }
                                        catch (Exception)
                                        {

                                            MessageBox.Show("Loi datetime" + ketThuc.ToString());

                                        }
                                        culutreInfo.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy";

                                        string hauQuaNguoi = workSheet.Cells[i, j += 1].Text.ToString().Trim();
                                        string hauQuaPhuongTien = workSheet.Cells[i, j += 1].Text.ToString().Trim();
                                        string hauQuaNguyenVatLieu = workSheet.Cells[i, j += 1].Text.ToString().Trim();
                                        string hauQuaKhac = workSheet.Cells[i, j += 1].Text.ToString().Trim();



                                        string toiDanhHinhSu = workSheet.Cells[i, j += 1].Text.ToString().Trim();
                                        string nguoiHinhsu = workSheet.Cells[i, j += 1].Text.ToString().Trim();
                                        string hanhViHanhChinh = workSheet.Cells[i, j += 1].Text.ToString().Trim();

                                        string nguoiHanhChinh = workSheet.Cells[i, j += 1].Text.ToString().Trim();

                                        string khac = workSheet.Cells[i, j += 1].Text.ToString().Trim();

                                        string tenCongTy = workSheet.Cells[i, j += 1].Text.ToString().Trim();
                                        string nguoi, nhom;
                                        if (nguoiHinhsu != null)
                                        {
                                            nhom = "Hình sự";
                                            nguoi = nguoiHinhsu;
                                        }

                                        else
                                        {
                                            nhom = "Hành chính";
                                            nguoi = nguoiHanhChinh;
                                        }



                                        // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh

                                        DataTable dtCongTy = new DataTable();

                                        dtCongTy = bus_CongTy.layIdCongTy(tenCongTy);
                                        string maCongTy = "";
                                        if (dtCongTy.Rows.Count > 0)
                                        {
                                            DataRow r = dtCongTy.Rows[0];
                                            maCongTy = r["Ma_cong_ty"].ToString();
                                        }

                                        if (kiemTraNhapExcel(tomTat, batDau, ketThuc, hauQuaNguoi, hauQuaPhuongTien,
                                            hauQuaNguyenVatLieu, hauQuaKhac, toiDanhHinhSu, nguoiHinhsu, hanhViHanhChinh,
                                            nguoiHanhChinh, khac, i, maCongTy))
                                        {


                                            DTO_SuViec suViec = new DTO_SuViec(tomTat, batDau, ketThuc, maCongTy);
                                            DTO_HauQua hauQua = new DTO_HauQua(hauQuaNguoi, hauQuaPhuongTien, hauQuaNguyenVatLieu, hauQuaKhac);
                                            DTO_KetQua ketQua = new DTO_KetQua(nguoiHinhsu, nguoiHanhChinh, toiDanhHinhSu, hanhViHanhChinh, khac, nhom);
                                            // add nhanSuinfo vào danh sách listNhanSu
                                            listSuViec.Add(suViec);
                                            listHauQua.Add(hauQua);
                                            listKetQua.Add(ketQua);


                                            bus_HauQua.themThongTinHauQua(hauQua);
                                            bus_KetQua.themThongTinKetQua(ketQua);
                                            DataTable dtHauQua = bus_HauQua.thongTinHauQua();
                                            DataTable dtKetQua = bus_KetQua.thongTinKetQua();
                                            string maHauQua = dtHauQua.Rows[0]["Ma_hau_qua"].ToString();
                                            string maKetQua = dtKetQua.Rows[0]["Ma_ket_qua"].ToString();

                                            if (bus_SuViec.themThongTinSuViec(suViec, maHauQua, maKetQua))
                                            {
                                                count++;
                                                clear();
                                            }

                                            dtCongTy.Clear();
                                        }


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


            formQl.hienThi();
        }




        public bool kiemTraNhapExcel(string tomTat, DateTime batDau, DateTime ketThuc, string hauQuaNguoi,
            string hauQuaPhuongTien, string hauQuaNguyenVatLieu, string hauQuaKhac, string toiDanhHinhSu,
            string nguoiHinhsu, string hanhViHanhChinh, string nguoiHanhChinh, string ketQuaKhac, int row, string maCongTy)
        {


            string thongBao = "\nDữ liệu: ";
            bool kiemTra = false;
            if (tomTat == null)
            {
                thongBao += "\n- Tóm tắt ";
                kiemTra = true;
            }

            if (batDau == Convert.ToDateTime("12/31/9999"))
            {
                thongBao += "\n- Thời gian bắt đầu";
                kiemTra = true;
            }
            if (ketThuc == Convert.ToDateTime("12/31/9999"))
            {
                thongBao += " \n- Thời gian kết thúc";
                kiemTra = true;
            }
            if (hauQuaNguoi == null)
            {
                thongBao += " \n- Người ở phần hậu quả";
                kiemTra = true;
            }
            if (hauQuaPhuongTien == null)
            {
                thongBao += " \n- Phương tiện ở phần hậu quả";
                kiemTra = true;
            }
            if (hauQuaNguyenVatLieu == null)
            {
                thongBao += " \n- Nguyên vật liệu ở phần kết quả";
                kiemTra = true;
            }
            if (hauQuaKhac == null)
            {
                thongBao += " \n- Khác ở phần kết quả";
                kiemTra = true;
            }
            if (toiDanhHinhSu == null)
            {
                thongBao += " \n- Tội danh ở phần kết quả xử lý hình sự";
                kiemTra = true;
            }
            if (nguoiHinhsu == null)
            {
                thongBao += " \n- Người ở phần kết quả xử lý hình sự";
                kiemTra = true;
            }
            if (hanhViHanhChinh == null)
            {
                thongBao += " \n- Hành vi vi phạm ở phần kết quả xử lý hành chính";
                kiemTra = true;
            }
            if (nguoiHanhChinh == null)
            {
                thongBao += " \n- Người ở phần kết quả xử lý hành chính";
                kiemTra = true;
            }
            if (ketQuaKhac == null)
            {
                thongBao += " \n- Khác ở phần kết quả xử lý hành chính";
                kiemTra = true;
            }
            if (maCongTy == "")
            {
                thongBao += " \n- Công ty";
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
    }
}
