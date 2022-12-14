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
    public partial class Form_San_Pham : Form
    {

        BUS_Hoa_Don_Ban bus_Hoa_Don_Ban = new BUS_Hoa_Don_Ban();
        BUS_Thong_Tin_Laptop busLaptop = new BUS_Thong_Tin_Laptop();
        BUS_NhanVien busNV = new BUS_NhanVien();
        BUS_San_Pham busSP = new BUS_San_Pham();
        BUS_Kho_Hang bus_Kho = new BUS_Kho_Hang();
        public static string ma_hoa_don = string.Empty;
        
        public Form_San_Pham()
        {
            InitializeComponent();
        }

        private void Form_Hoa_Don_Hang_Load(object sender, EventArgs e)
        {
            DataTable dt_Hoa_Don_1 = bus_Hoa_Don_Ban.thong_tin_hoa_don();
            foreach (DataRow r1 in dt_Hoa_Don_1.Rows)
            {
                cbo_mahoadon.Items.Add(r1["ma_hoa_don"].ToString());
            }
            if (ma_hoa_don.ToString() != "")
            {
                DataTable dt_Hoa_Don = bus_Hoa_Don_Ban.thong_tin_1_hoa_don(ma_hoa_don);
                foreach (DataRow r in dt_Hoa_Don.Rows)
                {
                    txttenkhach.Text = r["ten_khach"].ToString();
                    // Dua vao cbo tai vi tri
                    for (int i = 0; i < cbo_mahoadon.Items.Count; i++)
                    {
                        if (cbo_mahoadon.Items[i].ToString() == r["ma_hoa_don"].ToString())
                        {
                            cbo_mahoadon.SelectedIndex = i;
                            break;
                        }
                    }
                    txtsodt.Text = r["so_dien_thoai"].ToString();
                    txtdiachi.Text = r["dia_chi"].ToString();
                    string ngaysinh = r["ngay_ban"].ToString();
                    txt_ngayban.Text = r["ngay_ban"].ToString().Substring(0, ngaysinh.IndexOf(" "));
                    txt_tennv.Text = r["ma_nv"].ToString();
                    cbomanv.Items.Add(r["ma_nv"].ToString());
                    for (int i = 0; i < cbomanv.Items.Count; i++)
                    {
                        if (cbomanv.Items[i].ToString() == r["ma_nv"].ToString())
                        {
                            cbomanv.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }

            DataTable dt_Laptop = busLaptop.thong_tin_laptop();
            foreach (DataRow r2 in dt_Laptop.Rows)
            {
                cbomalaptop.Items.Add(r2["ma_laptop"].ToString());
            }
            string ma_hd = cbo_mahoadon.SelectedItem.ToString();

            DataTable dt_SanPham = busSP.list_san_pham(ma_hd);
            dgvdanhsach.DataSource = dt_SanPham;
            int tong = 0;
            foreach(DataRow r1 in dt_SanPham.Rows)
            {
                tong += Convert.ToInt32(r1["tong_tien"].ToString()); 
            }
            txt_tongthanhtoan.Text = tong.ToString();
            Hienthi();
            
        }
        public void Hienthi()
        {
            //string ma = cbo_mahoadon.SelectedItem.ToString();
            DataTable dt_SanPham = busSP.list_san_pham(cbo_mahoadon.SelectedItem.ToString());
            dgvdanhsach.DataSource = dt_SanPham;
            dgvdanhsach.Columns["ma_sp"].HeaderText = "Mã";
            dgvdanhsach.Columns["ma_laptop"].HeaderText = "Mã laptop";
            dgvdanhsach.Columns["don_gia"].HeaderText = "Đơn giá";
            dgvdanhsach.Columns["so_luong"].HeaderText = "Số lượng";
            dgvdanhsach.Columns["tong_tien"].HeaderText = "Tổng tiền";
            dgvdanhsach.Columns["ma_hoa_don"].HeaderText = "Mã hoá đơn";
        }

        private void cbomalaptop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma_laptop = cbomalaptop.SelectedItem.ToString();
            DataTable dt = busLaptop.thong_tin_1_laptop(ma_laptop);
            foreach (DataRow r1 in dt.Rows)
            {
                txt_tenlaptop.Text = r1["ten_laptop"].ToString();
                txt_dongia.Text = r1["gia_ban"].ToString();
            }
        }

        private void txt_dongia_TextChanged(object sender, EventArgs e)
        {
            if(txt_dongia.Text != "")
            {
                int gia = Convert.ToInt32(txt_dongia.Text);
                int soluong = Convert.ToInt32(nbl_soluong.Value);
                int tong = gia * soluong;
                txttongtien.Text = tong.ToString();
                string ma_hd = cbo_mahoadon.SelectedItem.ToString();
                // Cap nhat gia
                //int thanhtoan = Convert.ToInt32(txt_tongthanhtoan.Text);
                int thanhtoan = 0;
                thanhtoan = thanhtoan + tong;
                txt_tongthanhtoan.Text = thanhtoan.ToString();
                int t = Convert.ToInt32(txt_tongthanhtoan.Text);
                bus_Hoa_Don_Ban.tong_thanh_toan(ma_hd, t);
            }
        }

        private void nbl_soluong_ValueChanged(object sender, EventArgs e)
        {
            if(nbl_soluong.Value >= 1)
            {
                int gia = Convert.ToInt32(txt_dongia.Text);
                int soluong = Convert.ToInt32(nbl_soluong.Value);
                int tong = gia * soluong;
                txttongtien.Text = tong.ToString();
                // Cap nhat gia
                //int thanhtoan = Convert.ToInt32(txt_tongthanhtoan.Text);
                int thanhtoan = 0;
                thanhtoan = thanhtoan + tong;
                txt_tongthanhtoan.Text = thanhtoan.ToString();
                int t = Convert.ToInt32(txt_tongthanhtoan.Text);
                string ma_hd = cbo_mahoadon.SelectedItem.ToString();
                bus_Hoa_Don_Ban.tong_thanh_toan(ma_hd, t);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(kiem_tra_nhap(true))
            {
                string ma_laptop = cbomalaptop.SelectedItem.ToString();
                int soluong = Convert.ToInt32(nbl_soluong.Value);
                int tong = Convert.ToInt32(txttongtien.Text);
                int dongia = Convert.ToInt32(txt_dongia.Text);
                string ma_hd = cbo_mahoadon.SelectedItem.ToString();
                // Cap nhat gia
                //int thanhtoan = Convert.ToInt32(txt_tongthanhtoan.Text);
                int thanhtoan = 0;
                thanhtoan = thanhtoan + tong;
                txt_tongthanhtoan.Text = thanhtoan.ToString();
                int t = Convert.ToInt32(txt_tongthanhtoan.Text);
                bus_Hoa_Don_Ban.tong_thanh_toan(ma_hd, t);
                DTO_San_Pham sanpham = new DTO_San_Pham(0,ma_laptop, dongia, soluong, tong, ma_hd);
                if (busSP.them_san_pham(sanpham))
                {
                    lb_thongbao_1.Text = "Thêm thành công";
                    Hienthi();
                }
                else
                {
                    lb_thongbao_1.Text = "Thêm thất bại";
                }
                int vitri = dgvdanhsach.CurrentCell.RowIndex;
                if (cbomalaptop.SelectedItem.ToString() != dgvdanhsach.Rows[vitri].Cells[1].Value.ToString())
                {

                }
                // Cap nhat so luong kho
                DataTable dt_Sl_Ton_Kho = bus_Kho.so_luong_ton_kho(ma_laptop);
                int sl_ton_kho = 0;
                int sl_ban = 0;
                foreach (DataRow r in dt_Sl_Ton_Kho.Rows)
                {
                    sl_ton_kho += Convert.ToInt32(r["ton_kho"].ToString());
                    sl_ban += Convert.ToInt32(r["so_luong_ban"].ToString());
                }
                sl_ton_kho = sl_ton_kho - soluong;
                sl_ban += soluong;
                DTO_Kho_Hang cap_nhat = new DTO_Kho_Hang(ma_laptop, "", 0, 0, sl_ban, sl_ton_kho);
                bus_Kho.cap_nhat_sl_them_sp(cap_nhat);
                
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (kiem_tra_nhap(true))
            {
                string ma_laptop = cbomalaptop.SelectedItem.ToString();
                int soluong = Convert.ToInt32(nbl_soluong.Value);
                int tong = Convert.ToInt32(txttongtien.Text);
                int dongia = Convert.ToInt32(txt_dongia.Text);
                int ma = Convert.ToInt32(txtma.Text);
                string ma_hd = cbo_mahoadon.SelectedItem.ToString();
                // Cap nhat gia
                //int thanhtoan = Convert.ToInt32(txt_tongthanhtoan.Text);
                int thanhtoan = 0;
                thanhtoan = thanhtoan + tong;
                txt_tongthanhtoan.Text = thanhtoan.ToString();
                int t = Convert.ToInt32(txt_tongthanhtoan.Text);
                bus_Hoa_Don_Ban.tong_thanh_toan(ma_hd, t);
                DTO_San_Pham sanpham = new DTO_San_Pham(ma,ma_laptop, dongia, soluong, tong, ma_hd);
                if (busSP.sua_san_pham(sanpham))
                {
                    lb_thongbao_1.Text = "Sửa thành công";
                    Hienthi();
                }
                else
                {
                    lb_thongbao_1.Text = "Sửa thất bại";
                }
                
                //Tinh so luong
                DataTable dt_Tong_Sl = busSP.san_pham_theo_ma_laptop(cbomalaptop.SelectedItem.ToString());
                int tong_sl = 0;
                foreach (DataRow r3 in dt_Tong_Sl.Rows)
                {
                    tong_sl += Convert.ToInt32(r3["so_luong"].ToString());
                }
                //Cap nhat so luong kho
                DataTable dt_Sl_Ton_Kho = bus_Kho.so_luong_ton_kho(ma_laptop);
                int sl_ton_kho = 0;
                int sl_ban = 0;
                int sl_nhap = 0;
                foreach (DataRow r in dt_Sl_Ton_Kho.Rows)
                {
                    sl_ton_kho += Convert.ToInt32(r["ton_kho"].ToString());
                    sl_ban += Convert.ToInt32(r["so_luong_ban"].ToString());
                    sl_nhap += Convert.ToInt32(r["so_luong_nhap"].ToString());
                }
                sl_ton_kho = (sl_nhap - tong_sl);
                sl_ban = tong_sl;
                DTO_Kho_Hang cap_nhat = new DTO_Kho_Hang(ma_laptop, "", 0, 0, sl_ban, sl_ton_kho);
                bus_Kho.cap_nhat_sl_them_sp(cap_nhat);
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(txtma.Text != "")
            {
                // Cap nhat gia
                //int tong = Convert.ToInt32(txttongtien.Text);
                //int thanhtoan = Convert.ToInt32(txt_tongthanhtoan.Text);
                //thanhtoan = thanhtoan + tong;
                //txt_tongthanhtoan.Text = thanhtoan.ToString();
                //int t = Convert.ToInt32(txt_tongthanhtoan.Text);
                //string ma_hd = cbo_mahoadon.SelectedItem.ToString();
                //bus_Hoa_Don_Ban.tong_thanh_toan(ma_hd, t);
                if (busSP.xoa_san_pham(txtma.Text))
                {
                    lb_thongbao_1.Text = "Xoá thành công";
                    Hienthi();
                }
                else
                {
                    lb_thongbao_1.Text = "Xoá thất bại";
                }
            }
        }
        public bool kiem_tra_nhap(bool check)
        {
            string thong_bao = "Vui lòng nhập: ";
            bool kiem_tra = false;

            if (txt_tenlaptop.Text.Trim().Length == 0)
            {
                thong_bao += " - Mã laptop ";
                kiem_tra = true;
            }

            if (((int)nbl_soluong.Value) == 0)
            {
                thong_bao += " - Số lượng ";
                kiem_tra = true;
            }
        
            if (kiem_tra == true)
            {
                MessageBox.Show(thong_bao, "Lỗi nhập dữ liệu", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dgvdanhsach.CurrentCell.RowIndex;
            txtma.Text = dgvdanhsach.Rows[vitri].Cells[0].Value.ToString();
            cbomalaptop.SelectedItem = dgvdanhsach.Rows[vitri].Cells[1].Value.ToString();
            txt_dongia.Text = dgvdanhsach.Rows[vitri].Cells[2].Value.ToString();
            nbl_soluong.Value = Convert.ToInt32(dgvdanhsach.Rows[vitri].Cells[3].Value.ToString());
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            if (cbo_mahoadon.SelectedItem.ToString() != "")
            {
                if (dgvdanhsach.Rows.Count > 1)
                {
                    //Cong tong hoa don
                    string ma_hd = cbo_mahoadon.SelectedItem.ToString();
                    DataTable tb_HoaDon = busSP.list_san_pham(cbo_mahoadon.SelectedItem.ToString());
                    int tong = 0;
                    foreach (DataRow r1 in tb_HoaDon.Rows)
                    {
                        tong += Convert.ToInt32(r1["tong_tien"].ToString());
                    }
                    bus_Hoa_Don_Ban.tong_thanh_toan(ma_hd, tong);
                    //In hoa don
                    DataTable dt_SanPham = busSP.san_pham_theo_ma(ma_hd);
                    Hoa_Don_Ban baocao = new Hoa_Don_Ban();
                    baocao.SetDataSource(dt_SanPham);
                    // Hien thi bao cao
                    Hoa_Don_Ban_Form f = new Hoa_Don_Ban_Form();
                    f.crp_HoaDon.ReportSource = baocao;
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vui lòng thêm sản phẩm để in");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã hoá đơn");
            }
        }

        private void cbo_mahoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = cbo_mahoadon.SelectedItem.ToString();
            DataTable dt_Hoa_Don = bus_Hoa_Don_Ban.thong_tin_1_hoa_don(ma);
            foreach (DataRow r in dt_Hoa_Don.Rows)
            {
                txttenkhach.Text = r["ten_khach"].ToString();
                txtsodt.Text = r["so_dien_thoai"].ToString();
                txtdiachi.Text = r["dia_chi"].ToString();
                string ngaysinh = r["ngay_ban"].ToString();
                txt_ngayban.Text = r["ngay_ban"].ToString().Substring(0, ngaysinh.IndexOf(" "));
                txt_tennv.Text = r["ma_nv"].ToString();
            }

            DataTable dt_SanPham = busSP.list_san_pham(ma);
            dgvdanhsach.DataSource = dt_SanPham;
            dgvdanhsach.Columns["ma_sp"].HeaderText = "Mã";
            dgvdanhsach.Columns["ma_laptop"].HeaderText = "Mã laptop";
            dgvdanhsach.Columns["don_gia"].HeaderText = "Đơn giá";
            dgvdanhsach.Columns["so_luong"].HeaderText = "Số lượng";
            dgvdanhsach.Columns["tong_tien"].HeaderText = "Tổng tiền";
            dgvdanhsach.Columns["ma_hoa_don"].HeaderText = "Mã hoá đơn";
        }

        private void btn_resert_Click(object sender, EventArgs e)
        {
            txt_tenlaptop.Text = "";
            txt_dongia.Text = "0";
            nbl_soluong.Value = 1;
            txt_tongthanhtoan.Text = "";
        }

        private void txt_tukhoa_Validated(object sender, EventArgs e)
        {
            DataTable dt = busSP.list_san_pham(cbo_mahoadon.SelectedItem.ToString());
            DataRow[] row = dt.Select("ma_laptop like '%" + txt_tukhoa.Text + "%'");
            if (row.Length > 0)
            {
                DataTable dt1 = row.CopyToDataTable();
                dgvdanhsach.DataSource = dt1;
            }
            else
            {

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Form_Hoa_Don_Ban f = new Form_Hoa_Don_Ban();
            f.Show();
            this.Close();
        }
    }
}
