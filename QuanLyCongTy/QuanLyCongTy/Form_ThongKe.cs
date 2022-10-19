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
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace QuanLyCongTy
{
    public partial class Form_ThongKe : Form
    {
        BUS_NhanSu busNhanSu = new BUS_NhanSu();
        BUS_CongTy bus_CongTy = new BUS_CongTy();
        BUS_ThongKe busThongKe = new BUS_ThongKe();
        BUS_SuViec busSuViec = new BUS_SuViec();
        BUS_NhomChucVu bus_NhomChucVu = new BUS_NhomChucVu();
        BUS_ChucVu bus_ChucVu = new BUS_ChucVu();
        public Form_ThongKe()
        {
            InitializeComponent();
        }
        public void hienThi()
        {
            List<String> listNoiDung = new List<string>();
            listNoiDung.Add("Sự việc");
            listNoiDung.Add("Nhân sự");
            cboNoiDungThongKe.DataSource = listNoiDung;
            cboNoiDungThongKe.SelectedIndex = StaticClass.indexThongke;
            hienThiThongKeSuViec();
            chonNoiDungThongKe();
        }

        private void hienThiThongKeSuViec()
        {
            BUS_SuViec busSuViec = new BUS_SuViec();
            DataTable dtSuViec = new DataTable();
            dtSuViec = busSuViec.thongTinSuViec();
            dgvThongKe.DataSource = dtSuViec;
           
            dgvThongKe.Columns["Ma_su_viec"].HeaderText = "Mã sự việc";
            dgvThongKe.Columns["Tom_tat_su_viec"].HeaderText = "Tóm tắt sự việc";
            dgvThongKe.Columns["Tom_tat_su_viec"].MinimumWidth = 300;

            dgvThongKe.Columns["Ma_hau_qua"].Visible = false;
            dgvThongKe.Columns["Ma_ket_qua"].Visible = false;
            dgvThongKe.Columns["Thoi_gian_bd"].HeaderText = "Thời gian bắt đầu";
            dgvThongKe.Columns["Thoi_gian_kt"].HeaderText = "Thời gian kết thúc";

            dgvThongKe.Columns["Hau_qua_nguoi"].HeaderText = "Người nhóm hậu quả";
            //dgvThongKe.Columns["Phuong_tien"].Visible = false;
            //dgvThongKe.Columns["Nguyen_vat_lieu"].Visible = false;
            //dgvThongKe.Columns["Hau_qua_khac"].Visible = false;
            dgvThongKe.Columns["Phuong_tien"].HeaderText = "Phương tiện";
            dgvThongKe.Columns["Nguyen_vat_lieu"].HeaderText = "Nguyên vật liệu";
            dgvThongKe.Columns["Hau_qua_khac"].HeaderText = "Hậu quả khác";

            dgvThongKe.Columns["Toi_danh_nguoi"].HeaderText = "Người nhóm hình sự";
            dgvThongKe.Columns["Hanh_chinh_nguoi"].HeaderText = "Người nhóm hành chính";
            //dgvThongKe.Columns["Toi_danh"].Visible = false;
            //dgvThongKe.Columns["Hanh_vi"].Visible = false;
            //dgvThongKe.Columns["Ket_qua_khac"].Visible = false;
            dgvThongKe.Columns["Toi_danh"].HeaderText = "Tội danh";
            dgvThongKe.Columns["Hanh_vi"].HeaderText = "Hành vi";
            dgvThongKe.Columns["Ket_qua_khac"].HeaderText = "Kết quả khác";


            dgvThongKe.Columns["Ma_cong_ty"].Visible = false;

            //dgvThongKe.Columns["Ten_cong_ty"].Visible = false;
            dgvThongKe.Columns["Ten_cong_ty"].HeaderText = "Tên công ty";
            dgvThongKe.Columns["Dia_chi_cong_ty"].HeaderText = "Địa chỉ công ty";


            dgvThongKe.Columns["Nhom"].HeaderText = "Nhóm";

            thongKeSVTK();

        }
        private void hienThiThongKeNhanSu()
        {
            BUS_NhanSu busNhanSu = new BUS_NhanSu();
            DataTable dtNhanSu = new DataTable();
            dtNhanSu = busNhanSu.thongTinNhanSu();
            dgvThongKe.DataSource = dtNhanSu;
            dgvThongKe.Columns["Ho_ten"].HeaderText = "Họ tên";
            dgvThongKe.Columns["Quoc_tich"].HeaderText = "Quốc tịch";
            dgvThongKe.Columns["Nam_sinh"].HeaderText = "Năm sinh";
            dgvThongKe.Columns["Ho_khau"].HeaderText = "Hộ khẩu";
            dgvThongKe.Columns["Ten_chuc_vu"].HeaderText = "Chức vụ";
            dgvThongKe.Columns["Thong_tin_khac"].HeaderText = "Thông tin khác";
            dgvThongKe.Columns["Ma_nhan_vien"].HeaderText = "Mã nhân viên";
            dgvThongKe.Columns["CCCD"].HeaderText = "CCCD";
            thongKeNSTK();
        }


        private void cboNoiDungThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            chonNoiDungThongKe();
        }

        private void chonNoiDungThongKe()
        {
            if (cboNoiDungThongKe.SelectedIndex == 0)
            {
                hienThiThongKeSuViec();
                if (cboCongTy.Items.Count > 0)
                {
                    cboCongTy.SelectedIndex = 0;
                    thongKeSVTK();
                }
                    
                dtpThoiGianBD.Enabled = true;
                dtpThoiGianKT.Enabled = true;
                dtpThoiGianBDTK.Enabled = true;
                dtpThoiGianKTTK.Enabled = true;
                cboNamSinh.Enabled = false;
                cboNhomChucVu.Enabled = false;
                cboChucVu.Enabled = false;


            }
            if (cboNoiDungThongKe.SelectedIndex == 1)
            {
                hienThiThongKeNhanSu();

                if (cboCongTy.Items.Count > 0)
                {
                    cboCongTy.SelectedIndex = 0;
                    thongKeNSTK();
                }
                
                dtpThoiGianBD.Enabled = false;
                dtpThoiGianKT.Enabled = false;
                dtpThoiGianBDTK.Enabled = false;
                dtpThoiGianKTTK.Enabled = false;
                cboNamSinh.Enabled = true;
                cboNhomChucVu.Enabled = true;
                cboChucVu.Enabled = true;

            }
        }


        private void thongKeSVTK()
        {
            DateTime ngaybd = dtpThoiGianBDTK.Value;
            DateTime ngaykt = dtpThoiGianKTTK.Value;

            if (ngaykt >= ngaybd)
            {
                if (cboCongTy.Items.Count > 0)
                {
                    dgvThongKe.DataSource = busSuViec.thongTinSuViec();
                    BindingSource bsSuViec = new BindingSource();
                    bsSuViec.DataSource = dgvThongKe.DataSource;
                    bsSuViec.Filter = string.Format("Thoi_gian_bd >= #{0:yyyy/MM/dd}# AND Thoi_gian_kt <= #{1:yyyy/MM/dd}# OR Ma_cong_ty like '%" + cboCongTyTK.SelectedValue.ToString() + "%' ", dtpThoiGianBDTK.Value, dtpThoiGianKTTK.Value);
                    dgvThongKe.DataSource = bsSuViec;
                }
            }
            else
            {
                dtpThoiGianBDTK.Value = dtpThoiGianKTTK.Value;
                MessageBox.Show("Vui lòng chọn ngày bắt đầu nhỏ hơn ngày kết thúc");
            }
                
           
        }

        private void thongKeSV()
        {
            DateTime ngaybd = dtpThoiGianBD.Value;
            DateTime ngaykt = dtpThoiGianKT.Value;

            if (ngaykt >= ngaybd)
            {
                if (cboCongTy.Items.Count > 0)
                {
                    dgvThongKe.DataSource = busSuViec.thongTinSuViec();
                    BindingSource bsSuViec = new BindingSource();
                    bsSuViec.DataSource = dgvThongKe.DataSource;
                    bsSuViec.Filter = string.Format("Thoi_gian_bd >= #{0:yyyy/MM/dd}# AND Thoi_gian_kt <= #{1:yyyy/MM/dd}# AND Ma_cong_ty like '%" + cboCongTy.SelectedValue.ToString() + "%' ", dtpThoiGianBD.Value, dtpThoiGianKT.Value);
                    dgvThongKe.DataSource = bsSuViec;
                }
              
            }
            else
            {
                dtpThoiGianBD.Value = dtpThoiGianKT.Value;
                MessageBox.Show("Vui lòng chọn ngày bắt đầu nhỏ hơn ngày kết thúc");
            }


        }



        private void thongKeNSTK()
        {
            if (cboCongTy.Items.Count > 0)
            {
                dgvThongKe.DataSource = busNhanSu.thongTinNhanSu();
                BindingSource bsNhanSu = new BindingSource();
                bsNhanSu.DataSource = dgvThongKe.DataSource;
                bsNhanSu.Filter = "Ma_cong_ty" + " like '%" + cboCongTyTK.SelectedValue.ToString() + "%'";
                dgvThongKe.DataSource = bsNhanSu;
            }             
        }

        private void thongKeNS()
        {
            if (cboCongTy.Items.Count > 0)
            {
                dgvThongKe.DataSource = busNhanSu.thongTinNhanSu();
                BindingSource bsNhanSu = new BindingSource();
                bsNhanSu.DataSource = dgvThongKe.DataSource;
                bsNhanSu.Filter = "Ma_cong_ty" + " like '%" + cboCongTy.SelectedValue.ToString() + "%'";
                dgvThongKe.DataSource = bsNhanSu;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(cboNoiDungThongKe.SelectedIndex == 0)
            {
                DataTable dtSuViec = new DataTable();
                dtSuViec = busThongKe.timKiemAllSuviec(txtTimKiem.Text.ToString());
                dgvThongKe.DataSource = dtSuViec;
            }
            if(cboNoiDungThongKe.SelectedIndex == 1)
            {
                DataTable dtNhanSu = new DataTable();
                dtNhanSu = busThongKe.timKiemAllNhanSu(txtTimKiem.Text.ToString());
                dgvThongKe.DataSource = dtNhanSu;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string maCongTy = cboCongTy.SelectedValue.ToString();
            DataTable dtNhanSuExport = busNhanSu.thongTinNhanVienExport(maCongTy);
            if(dtNhanSuExport.Rows.Count > 0)
            {
                RPT_NhanSu rptNhanSu = new RPT_NhanSu();
                rptNhanSu.SetDataSource(dtNhanSuExport);
                Form_RPT_NhanSu formExport = new Form_RPT_NhanSu();
                formExport.crpFormNhanSu.ReportSource = rptNhanSu;
                formExport.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu của công ty này","Lỗi dữ liệu");
            }
        }

        private void Form_ThongKe_Load(object sender, EventArgs e)
        {
            DataTable thongTinCongTy = bus_CongTy.thongTinCongTy();
            cboCongTy.ValueMember = "Ma_cong_ty";
            cboCongTy.DisplayMember = "Ten_cong_ty";
            cboCongTy.DataSource = thongTinCongTy;

            DataTable thongTinCongTyTK = bus_CongTy.thongTinCongTy();
            cboCongTyTK.ValueMember = "Ma_cong_ty";
            cboCongTyTK.DisplayMember = "Ten_cong_ty";
            cboCongTyTK.DataSource = thongTinCongTyTK;

            cboNhomChucVu.Items.Clear();
            DataTable thongTinNhomChucVu = bus_NhomChucVu.thongTinNhomChucVu();
            cboNhomChucVu.ValueMember = "Ma_nhom_chuc_vu";
            cboNhomChucVu.DisplayMember = "Ten_nhom_chuc_vu";
            cboNhomChucVu.DataSource = thongTinNhomChucVu;

            DataTable tbThongTinChucVu = bus_ChucVu.thongTinChucVu();
            cboChucVu.ValueMember = "Ma_chuc_vu";
            cboChucVu.DisplayMember = "Ten_chuc_vu";
            cboChucVu.DataSource = tbThongTinChucVu;

            for (int i = 2022; i >= 1950; i--)
            {
                cboNamSinh.Items.Add(i);
            }
            cboNamSinh.SelectedIndex = 0;

            hienThi();

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (cboNoiDungThongKe.SelectedIndex == 0)
                if (dgvThongKe.Rows.Count > 0)
                    exportSuViec();
                else
                    MessageBox.Show("Không có dữ liệu");

            if (cboNoiDungThongKe.SelectedIndex == 1)
                if (dgvThongKe.Rows.Count > 0)
                    exportNhanSu();
                else
                    MessageBox.Show("Không có dữ liệu");
        }
        private void exportNhanSu()
        {
            thongKeNS();
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
   

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog().ToString() == "OK")
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    // đặt tên người tạo file
                    p.Workbook.Properties.Author = "";

                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = "";

                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("Sheet 1");

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[0];

                    // đặt tên cho sheet
                    ws.Name = "Sheet 1";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 14;
                    // font family mặc định cho cả sheet



                    ws.Cells[1, 1].Value = "Thu thập dữ liệu cơ sở về nhân sự doanh nghiệp";
                    ws.Cells[1, 1, 1, 7].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, 7].Style.Font.Bold = true;
                    // căn giữa
                    ws.Cells[1, 1, 7, 7].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws.Cells[1, 1, 7, 7].Style.VerticalAlignment = ExcelVerticalAlignment.Center;



                    ws.Cells[2, 1].Value = "STT";
                    ws.Cells[2, 1].Style.Font.Bold = true;
                    

                    ws.Cells[2, 2].Value = "HỌ TÊN";
                    ws.Cells[2, 2].Style.Font.Bold = true;

                    ws.Cells[2, 3].Value = "QUỐC TỊCH";
                    ws.Cells[2, 3].Style.Font.Bold = true;

                    ws.Cells[2, 4].Value = "NĂM SINH";
                    ws.Cells[2, 4].Style.Font.Bold = true;

                    ws.Cells[2, 5].Value = "NƠI ĐKHKTT";
                    ws.Cells[2, 5].Style.Font.Bold = true;


                    ws.Cells[2, 6].Value = "CHỨC VỤ";
                    ws.Cells[2, 6].Style.Font.Bold = true;


                    ws.Cells[2, 7].Value = "THÔNG TIN KHÁC CẦN QUAN TÂM";
                    ws.Cells[2, 7].Style.Font.Bold = true;

                    ws.Cells[ws.Dimension.Address].AutoFitColumns();



                    int rowIndex = 3;
                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    int stt = 1;
                    for (int i = 0; i < dgvThongKe.Rows.Count; i++)
                    {
                        int colIndex = 1;



                        ////gán giá trị cho từng cell                      
                        ws.Cells[rowIndex, colIndex++].Value = stt;
                        ws.Cells[rowIndex, colIndex++].Value = dgvThongKe.Rows[i].Cells[2].Value.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dgvThongKe.Rows[i].Cells[3].Value.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dgvThongKe.Rows[i].Cells[4].Value.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dgvThongKe.Rows[i].Cells[5].Value.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dgvThongKe.Rows[i].Cells[10].Value.ToString();
                        

                        ws.Cells[rowIndex, colIndex++].Value = dgvThongKe.Rows[i].Cells[7].Value.ToString();
                        stt++;
                        rowIndex++;




                        //// lưu ý phải .ToShortDateString để dữ liệu khi in ra Excel là ngày như ta vẫn thấy.Nếu không sẽ ra tổng số :v
                        //ws.Cells[rowIndex, colIndex++].Value = item.Birthday.ToShortDateString();

                    }

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất excel thành công!");
            }
            catch (Exception EE)
            {
                MessageBox.Show("Có lỗi khi lưu file!" + EE);
            }
        }

        private void exportSuViec()
        {
            thongKeSV();



            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog().ToString() == "OK")
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    // đặt tên người tạo file

                    // đặt tiêu đề cho file

                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("Sheet 1");

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[0];

                    // đặt tên cho sheet
                    ws.Name = "Sheet 1";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 14;
                    // font family mặc định cho cả sheet
                    //ws.Cells.Style.Font.Name = "Times New Roman";
                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "Dữ liệu cơ sở về vụ việc liên quan đến ANTT";
                    ws.Cells[1, 1, 1, 11].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, 11].Style.Font.Bold = true;
                    // căn giữa
                    ws.Cells[1, 1, 7, 11].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws.Cells[1, 1, 7, 11].Style.VerticalAlignment = ExcelVerticalAlignment.Center;


                    CultureInfo culutreInfo = new CultureInfo("vi-VN"); 
                    culutreInfo.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
                    Thread.CurrentThread.CurrentCulture = culutreInfo;
                    string ngaybd = dtpThoiGianBD.Value.ToString("dd/MM/yyyy").Substring(0, dtpThoiGianBD.Value.ToString().IndexOf(" "));
                    string ngaykt = dtpThoiGianKT.Value.ToString("dd/MM/yyyy").Substring(0, dtpThoiGianKT.Value.ToString().IndexOf(" "));
                    ws.Cells[2, 1].Value = "(Từ " + ngaybd + " đến " + ngaykt + ")";
                    ws.Cells[2, 1, 2, 11].Merge = true;
                    ws.Cells[2, 1, 2, 11].Style.Font.Italic = true;
                    culutreInfo.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy";


                    ws.Cells[3, 1].Value = "Tên doanh nghiệp: " + cboCongTy.Text.ToString();
                    ws.Cells[3, 1, 3, 11].Merge = true;
                    ws.Cells[3, 1, 3, 11].Style.Font.Bold = true;
                    ws.Cells[3, 1, 3, 11].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                    if(dgvThongKe.Rows.Count > 0)
                    ws.Cells[4, 1].Value = "Địa chỉ trụ sở: "+ dgvThongKe.Rows[0].Cells[17].Value.ToString();
                    ws.Cells[4, 1, 4, 11].Merge = true;
                    ws.Cells[4, 1, 4, 11].Style.Font.Bold = true;
                    ws.Cells[4, 1, 4, 11].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                    ws.Cells[5, 1].Value = "STT";
                    ws.Cells[5, 1, 7, 1].Merge = true;
                    ws.Cells[5, 1, 7, 1].Style.Font.Bold = true;
                    // ws.Cells[5, 1, 7, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells[5, 2].Value = "Tóm tắt nội dung vụ việc";
                    ws.Cells[5, 2, 7, 2].Merge = true;
                    ws.Cells[5, 2, 7, 2].Style.Font.Bold = true;

                    // ws.Cells[5, 2, 7, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells[5, 3].Value = "Hậu quả thiệt hại";
                    ws.Cells[5, 3, 5, 6].Merge = true;
                    ws.Cells[5, 3, 5, 6].Style.Font.Bold = true;
                    // ws.Cells[5, 3, 5, 6].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells[5, 7].Value = "Kết quả xử lý";
                    ws.Cells[5, 7, 5, 11].Merge = true;
                    ws.Cells[5, 7, 5, 11].Style.Font.Bold = true;
                    //ws.Cells[5, 7, 5, 11].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;


                    ws.Cells[6, 3].Value = "Người";
                    ws.Cells[6, 3, 7, 3].Merge = true;
                    ws.Cells[6, 3, 7, 3].Style.Font.Bold = true;
                    // ws.Cells[6, 3, 7, 3].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;


                    ws.Cells[6, 4].Value = "Phương tiện";
                    ws.Cells[6, 4, 7, 4].Merge = true;
                    ws.Cells[6, 4, 7, 4].Style.Font.Bold = true;
                    // ws.Cells[6, 4, 7, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;


                    ws.Cells[6, 5].Value = "Nguyên vật liệu";
                    ws.Cells[6, 5, 7, 5].Merge = true;
                    ws.Cells[6, 5, 7, 5].Style.Font.Bold = true;
                    // ws.Cells[6, 5, 7, 5].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;


                    ws.Cells[6, 6].Value = "Khác";
                    ws.Cells[6, 6, 7, 6].Merge = true;
                    ws.Cells[6, 6, 7, 6].Style.Font.Bold = true;
                    // ws.Cells[6, 6, 7, 6].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;


                    ws.Cells[6, 7].Value = "Hình sự";
                    ws.Cells[6, 7, 6, 8].Merge = true;
                    ws.Cells[6, 7, 6, 8].Style.Font.Bold = true;
                    // ws.Cells[6, 7, 6, 8].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;


                    ws.Cells[6, 9].Value = "Hành chính";
                    ws.Cells[6, 9, 6, 10].Merge = true;
                    ws.Cells[6, 9, 6, 10].Style.Font.Bold = true;
                    //ws.Cells[6, 9, 6, 10].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;


                    ws.Cells[6, 11].Value = "Khác";
                    ws.Cells[6, 11, 7, 11].Merge = true;
                    ws.Cells[6, 11, 7, 11].Style.Font.Bold = true;
                    //ws.Cells[6, 11, 7, 11].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;


                    ws.Cells[7, 7].Value = "Tội danh";
                    ws.Cells[7, 7].Style.Font.Bold = true;
                    //       ws.Cells[7, 7].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;


                    ws.Cells[7, 8].Value = "Người";
                    ws.Cells[7, 8].Style.Font.Bold = true;
                    //       ws.Cells[7, 8].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;


                    ws.Cells[7, 9].Value = "Hành vi vi phạm";
                    ws.Cells[7, 9].Style.Font.Bold = true;
                    //       ws.Cells[7, 9].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;


                    ws.Cells[7, 10].Value = "Người";
                    ws.Cells[7, 10].Style.Font.Bold = true;
                    //      ws.Cells[7, 10].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws.Cells[ws.Dimension.Address].AutoFitColumns();




                    int rowIndex = 8;
                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    int stt = 1;
                    for (int i = 0; i < dgvThongKe.Rows.Count; i++)
                    {
                        int colIndex = 1;



                        ////gán giá trị cho từng cell                      
                        ws.Cells[rowIndex, colIndex++].Value = stt;
                        ws.Cells[rowIndex, colIndex++].Value = dgvThongKe.Rows[i].Cells[1].Value.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dgvThongKe.Rows[i].Cells[7].Value.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dgvThongKe.Rows[i].Cells[8].Value.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dgvThongKe.Rows[i].Cells[9].Value.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dgvThongKe.Rows[i].Cells[10].Value.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dgvThongKe.Rows[i].Cells[11].Value.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dgvThongKe.Rows[i].Cells[12].Value.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dgvThongKe.Rows[i].Cells[13].Value.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dgvThongKe.Rows[i].Cells[14].Value.ToString();
                       

                        ws.Cells[rowIndex, colIndex++].Value = dgvThongKe.Rows[i].Cells[16].Value.ToString();
                        stt++;
                        rowIndex++;




                        //// lưu ý phải .ToShortDateString để dữ liệu khi in ra Excel là ngày như ta vẫn thấy.Nếu không sẽ ra tổng số :v
                        //ws.Cells[rowIndex, colIndex++].Value = item.Birthday.ToShortDateString();

                    }

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất excel thành công!");
            }
            catch (Exception EE)
            {
                MessageBox.Show("Có lỗi khi lưu file!" + EE);
            }
        }


        private void dtpThoiGianBDTK_ValueChanged(object sender, EventArgs e)
        {
            thongKeSVTK();
        }

        private void dtpThoiGianKTTK_ValueChanged(object sender, EventArgs e)
        {
            thongKeSVTK();
        }

        private void cboCongTyTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNoiDungThongKe.SelectedIndex == 0)
            {
                thongKeSVTK();
            }
            if (cboNoiDungThongKe.SelectedIndex == 1)
            {
                thongKeNSTK();
               
            }
        }

        private void btnXemTruoc_Click(object sender, EventArgs e)
        {
            if (cboNoiDungThongKe.SelectedIndex == 0)
                thongKeSV();

            if (cboNoiDungThongKe.SelectedIndex == 1)
                thongKeNS();
        }

        private void cboNhomChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtNhanSu = busNhanSu.thongTinNhanSu();
            if (dtNhanSu.Rows.Count > 0)
            {
                dgvThongKe.DataSource = busNhanSu.thongTinNhanSu();
                BindingSource bsNhanSu = new BindingSource();
                bsNhanSu.DataSource = dgvThongKe.DataSource;
                bsNhanSu.Filter = "Ten_nhom_chuc_vu" + " like '%" + cboNhomChucVu.Text.ToString() + "%'";
                dgvThongKe.DataSource = bsNhanSu;

            }
        }

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtNhanSu = busNhanSu.thongTinNhanSu();
            if (dtNhanSu.Rows.Count > 0)
            {
                dgvThongKe.DataSource = busNhanSu.thongTinNhanSu();
                BindingSource bsNhanSu = new BindingSource();
                bsNhanSu.DataSource = dgvThongKe.DataSource;
                bsNhanSu.Filter = "Ten_chuc_vu" + " like '%" + cboChucVu.Text.ToString() + "%'";
                dgvThongKe.DataSource = bsNhanSu;
               
            }
        }

        private void cboNamSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtNhanSu = busNhanSu.thongTinNhanSu();
            if (dtNhanSu.Rows.Count > 0)
            {
                dgvThongKe.DataSource = busNhanSu.thongTinNhanSu();
                BindingSource bsNhanSu = new BindingSource();
                bsNhanSu.DataSource = dgvThongKe.DataSource;
                bsNhanSu.Filter = "convert(Nam_sinh,'System.String')" + " like '%" + cboNamSinh.SelectedItem.ToString() + "%'";
                dgvThongKe.DataSource = bsNhanSu;

            }
        }
    }
}
