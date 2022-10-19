using BUS;
using DTO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class test : Form
    {
        BUS_NhanSu BUS_NS = new BUS_NhanSu();
        BUS_CongTy BUS_CT = new BUS_CongTy();
        public test()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel| *.xls; *.xlsx; *.xlsm; *.xlm";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                textBox1.Text = fileName.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<DTO_NhanSu> userList = new List<DTO_NhanSu>();
            if (textBox1.Text.Trim() != "")
            {
                try
                {
                    // mở file excel
                    var package = new ExcelPackage(new FileInfo(textBox1.Text.ToString()));
                    // lấy ra sheet đầu tiên để thao tác
                    if (package.Workbook.Worksheets.Count > 0)
                    {
                        ExcelWorksheet workSheet = package.Workbook.Worksheets[0];

                        if (workSheet.Dimension != null)
                        {
                            // duyệt tuần tự từ dòng thứ 2 đến dòng cuối cùng của file. lưu ý file excel bắt đầu từ số 1 không phải số 0

                            for (int i = workSheet.Dimension.Start.Row + 1; i <= workSheet.Dimension.End.Row; i++)
                            {
                                try
                                {
                                    // biến j biểu thị cho một column trong file
                                    int j = workSheet.Dimension.Start.Column;
                                    // lấy ra cột họ tên tương ứng giá trị tại vị trí [i, 1]. i lần đầu là 2
                                    // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh

                                    string name = workSheet.Cells[i, j].Text.ToString();

                                    string quoctich = workSheet.Cells[i, j += 1].Text.ToString();
                                    int birthday = 0;
                                    try
                                    {
                                        birthday = Convert.ToInt32(workSheet.Cells[i, j += 1].Text.ToString());
                                    }
                                    catch (Exception)
                                    {
                                    }


                                    string hokhau = workSheet.Cells[i, j += 1].Text.ToString();
                                    string chucvu = workSheet.Cells[i, j += 1].Text.ToString();
                                    string thongtinkhac = workSheet.Cells[i, j += 1].Text.ToString();
                                    string tenCongTy = workSheet.Cells[i, j += 1].Text.ToString();
                                    //lấy ra cột ngày sinh tương ứng giá trị tại vị trí[i, 2]. i lần đầu là 2
                                    // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                                    // tạo UserInfo từ dữ liệu đã lấy được
                                    DataTable dt = new DataTable();
                                    dt = BUS_CT.layIdCongTy(tenCongTy);
                                    string idCongTy = "";

                                    if (dt.Rows.Count > 0)
                                    {
                                        DataRow r = dt.Rows[0];
                                        idCongTy = r["Ma_cong_ty"].ToString();
                                    }

                                    //if (kiemTraNhap(name, quoctich, hokhau, birthday, chucvu, idCongTy, i) == true)
                                    //{
                                    //    DTO_NhanSu user = new DTO_NhanSu(name, quoctich, hokhau, chucvu, thongtinkhac, birthday, idCongTy);
                                    //    // add UserInfo vào danh sách userList
                                    //    userList.Add(user);
                                    //    BUS_NS.themThongTinNhanSu(user);
                                    //    dt.Clear();
                                    //}
                                }
                                catch (Exception exe)
                                {
                                    throw exe;
                                }
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

            dataGridView1.DataSource = userList;
        }

        public bool kiemTraNhap(string name, string quoctich, string hokhau, int birthday, string chucvu, string tenCongTy, int row)
        {

            string thongBao = "\nDữ liệu: ";
            bool kiemTra = false;
            if (name == "")
            {
                thongBao += " - Họ tên";
                kiemTra = true;
            }
            if (quoctich == "")
            {
                thongBao += " - Quốc tịch";
                kiemTra = true;
            }
            if (hokhau == "")
            {
                thongBao += " - Hộ khẩu";
                kiemTra = true;
            }
            if (birthday == 0)
            {
                thongBao += " - Năm sinh";
                kiemTra = true;
            }
            if (chucvu == "")
            {
                thongBao += " - Chức vụ";
                kiemTra = true;
            }
            if (tenCongTy == "")
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


        private void button3_Click(object sender, EventArgs e)
        {
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
                    ws.Cells.Style.Font.Name = "Calibri";
                       
                    
           

                    // Tạo danh sách các column header
                    //string[] arrColumnHeader = {
                    //                        "STT",
                    //                        "Tóm tắt nội dung vụ việc",
                    //                        "Người",
                    //                        "Phương tiện",
                    //                        "Nguyên vật liệu",
                    //                        "Khác",
                    //                        "Tội danh",
                    //                        "Người",
                    //                        "Hành vi vi phạm",
                    //                        "Người",
                    //                        "Khác",
                    //};

                    //// lấy ra số lượng cột cần dùng dựa vào số lượng header
                    //var countColHeader = arrColumnHeader.Count();

                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "Dữ liệu cơ sở về vụ việc liên quan đến ANTT";
                    ws.Cells[1, 1, 1, 11].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, 11].Style.Font.Bold = true;
                    // căn giữa
                    ws.Cells[1, 1, 1, 11].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells[2, 1].Value = "(Từ 16/12/2019 đến ngày …………….)";
                    ws.Cells[2, 1, 2, 11].Merge = true;
                    ws.Cells[2, 1, 2, 11].Style.Font.Bold = true;
                    ws.Cells[2, 1, 2, 11].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                   
                    ws.Cells[3, 1].Value = "Tên doanh nghiệp:";
                    ws.Cells[3, 1, 3, 11].Merge = true;
                    ws.Cells[3, 1, 3, 11].Style.Font.Bold = true;
                    
                    ws.Cells[4, 1].Value = "Địa chỉ trụ sở:";
                    ws.Cells[4, 1, 4, 11].Merge = true;
                    ws.Cells[4, 1, 4, 11].Style.Font.Bold = true;
                    
                    ws.Cells[5, 1].Value = "STT";
                    ws.Cells[5, 1, 8, 1].Merge = true;
                    ws.Cells[5, 1, 8, 1].Style.Font.Bold = true;
                    
                    ws.Cells[5, 2].Value = "Tóm tắt nội dung vụ việc";
                    ws.Cells[5, 2, 8, 2].Merge = true;
                    ws.Cells[5, 2, 8, 2].Style.Font.Bold = true;

                    ws.Cells[5, 3].Value = "Hậu quả thiệt hại";
                    ws.Cells[5, 3, 5, 6].Merge = true;
                    ws.Cells[5, 3, 5, 6].Style.Font.Bold = true;

                    ws.Cells[5, 7].Value = "Kết quả xử lý";
                    ws.Cells[5, 7, 5, 11].Merge = true;
                    ws.Cells[5, 7, 5, 11].Style.Font.Bold = true;

                    ws.Cells[6, 3].Value = "Người";
                    ws.Cells[6, 3, 7, 3].Merge = true;
                    ws.Cells[6, 3, 7, 3].Style.Font.Bold = true;
                    
                    ws.Cells[6, 4].Value = "Phương tiện";
                    ws.Cells[6, 4, 7, 4].Merge = true;
                    ws.Cells[6, 4, 7, 4].Style.Font.Bold = true;
                    
                    ws.Cells[6, 5].Value = "Nguyên vật liệu";
                    ws.Cells[6, 5, 7, 5].Merge = true;
                    ws.Cells[6, 5, 7, 5].Style.Font.Bold = true;
                    
                    ws.Cells[6, 7].Value = "Hình sự";
                    ws.Cells[6, 7, 6, 8].Merge = true;
                    ws.Cells[6, 7, 6, 8].Style.Font.Bold = true;
                    
                    ws.Cells[6, 9].Value = "Hành chính";
                    ws.Cells[6, 9, 6, 10].Merge = true;
                    ws.Cells[6, 9, 6, 10].Style.Font.Bold = true;
                    
                    ws.Cells[6, 11].Value = "Khác";
                    ws.Cells[6, 11, 7, 11].Merge = true;
                    ws.Cells[6, 11, 7, 11].Style.Font.Bold = true;

                    ws.Cells[7, 7].Value = "Tội danh";
                    ws.Cells[7, 7].Style.Font.Bold = true;
                   
                    ws.Cells[7, 8].Value = "Người";
                    ws.Cells[7, 8].Style.Font.Bold = true;
                   
                    ws.Cells[7, 9].Value = "Hành vi vi phạm";
                    ws.Cells[7, 9].Style.Font.Bold = true;
                   
                    ws.Cells[7, 10].Value = "Người";
                    ws.Cells[7, 10].Style.Font.Bold = true;



                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    int stt = 1;
                    for(int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        int colIndex = 1;
                        int rowIndex = 8;

                        //gán giá trị cho từng cell                      
                        ws.Cells[rowIndex, colIndex++].Value = stt;
                        ws.Cells[rowIndex, colIndex++].Value = dataGridView1.Rows[i].Cells[1];
                        ws.Cells[rowIndex, colIndex++].Value = dataGridView1.Rows[i].Cells[7];
                        ws.Cells[rowIndex, colIndex++].Value = dataGridView1.Rows[i].Cells[8];
                        ws.Cells[rowIndex, colIndex++].Value = dataGridView1.Rows[i].Cells[9];
                        ws.Cells[rowIndex, colIndex++].Value = dataGridView1.Rows[i].Cells[10];
                        if(dataGridView1.Rows[i].Cells[14].ToString() == "Hình sự")
                        {
                            ws.Cells[rowIndex, colIndex++].Value = dataGridView1.Rows[i].Cells[11];
                            ws.Cells[rowIndex, colIndex++].Value = dataGridView1.Rows[i].Cells[13];

                        }else if(dataGridView1.Rows[i].Cells[14].ToString() == "Hành chính")
                        {
                            ws.Cells[rowIndex, colIndex++].Value = dataGridView1.Rows[i].Cells[12];
                            ws.Cells[rowIndex, colIndex++].Value = dataGridView1.Rows[i].Cells[13];

                        }
                            ws.Cells[rowIndex, colIndex++].Value = dataGridView1.Rows[i].Cells[15];





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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
        }

        private void qunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_QlSuViec f = new Form_QlSuViec();
            f.Show();
        }

        private void menuThongKeSuViec_Click(object sender, EventArgs e)
        {
            StaticClass.indexThongke = 0;
            Form_ThongKe f = new Form_ThongKe();
            f.Show();
        }

        private void menuThongKeNhanSu_Click(object sender, EventArgs e)
        {
            StaticClass.indexThongke = 1;
            Form_ThongKe f = new Form_ThongKe();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)(dataGridView1.DataSource);

            MessageBox.Show(data.Rows[0][0].ToString());
        }
    }
}
