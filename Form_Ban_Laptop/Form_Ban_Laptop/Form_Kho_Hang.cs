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
using System.Data;
namespace Form_Ban_Laptop
{
    public partial class Form_Kho_Hang : Form
    {
        BUS_Thong_Tin_Laptop bus_Laptop = new BUS_Thong_Tin_Laptop();
        BUS_San_Pham bus_SP = new BUS_San_Pham();
        BUS_Kho_Hang bus_KHO = new BUS_Kho_Hang();
        public Form_Kho_Hang()
        {
            InitializeComponent();
        }

        private void Form_Kho_Hang_Load(object sender, EventArgs e)
        {
            DataTable dt_laptop = bus_Laptop.thong_tin_laptop();

            foreach (DataRow r in dt_laptop.Rows)
            {
                cbo_malaptop.Items.Add(r["ma_laptop"]);
            }
            Hienthi();
        }

        private void cbo_malaptop_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt_laptop = bus_Laptop.thong_tin_laptop();
            foreach (DataRow r in dt_laptop.Rows)
            {
                if (cbo_malaptop.SelectedItem.ToString() == r["ma_laptop"].ToString())
                {
                    txt_giaban.Text = r["gia_ban"].ToString();
                    txt_tenlaptop.Text = r["ten_laptop"].ToString();
                }
            }
           
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(kiem_tra_nhap(true))
            {
                int sl_nhap_kho = Convert.ToInt32(txt_soluong.Text);
                int sl_ban = Convert.ToInt32(txt_daban.Text);
                int sl_ton_kho = Convert.ToInt32(txt_tonkho.Text);
                int gia = Convert.ToInt32(txt_giaban.Text);

                DTO_Kho_Hang nhap_hang = new DTO_Kho_Hang(cbo_malaptop.SelectedItem.ToString(), txt_tenlaptop.Text, gia, sl_nhap_kho, sl_ban, sl_ton_kho);
                if (bus_KHO.them_vao_kho(nhap_hang))
                {
                    lb_thongbao.Text = "Thêm thành công";
                    Hienthi();
                }
                else
                {
                    lb_thongbao.Text = "Thêm thất bại";
                }
            }

        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (kiem_tra_nhap(true))
            {
                int sl_nhap_kho = Convert.ToInt32(txt_soluong.Text);
                int sl_ban = Convert.ToInt32(txt_daban.Text);
                int sl_ton_kho = Convert.ToInt32(txt_tonkho.Text);
                int gia = Convert.ToInt32(txt_giaban.Text);
                
                DTO_Kho_Hang nhap_hang = new DTO_Kho_Hang(cbo_malaptop.SelectedItem.ToString(), txt_tenlaptop.Text, gia, sl_nhap_kho, sl_ban, sl_ton_kho);
                if (bus_KHO.sua_kho(nhap_hang))
                {
                    lb_thongbao.Text = "Sửa thành công";
                    Hienthi();
                }
                else
                {
                    lb_thongbao.Text = "Sửa thất bại";
                }
            }

        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(txt_tenlaptop.Text.Trim().Length > 0)
            {
                if (bus_KHO.xoa_kho(cbo_malaptop.SelectedItem.ToString()))
                {
                    lb_thongbao.Text = "Xoá thành công";
                    Hienthi();
                }
                else
                {
                    lb_thongbao.Text = "Xoá thất bại";
                }
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            DataTable dt_kho = bus_KHO.thong_tin_kho();
            Kho_Hang_RPT kho_rpt = new Kho_Hang_RPT();
            kho_rpt.SetDataSource(dt_kho);

            In_Kho_Hang_Form f = new In_Kho_Hang_Form();
            f.crp_Khohang.ReportSource = kho_rpt;
            f.ShowDialog();

        }
        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            if(txt_soluong.Text != "")
            {
                int sl_nhap_kho = Convert.ToInt32(txt_soluong.Text);
                int sl_ban = 0;
                int sl_ton_kho = 0;
                int gia = Convert.ToInt32(txt_giaban.Text);
                DataTable dt_sanpham = bus_SP.san_pham_theo_ma_laptop(cbo_malaptop.SelectedItem.ToString());
                foreach (DataRow r in dt_sanpham.Rows)
                {
                    if (cbo_malaptop.SelectedItem.ToString() == r["ma_laptop"].ToString())
                    {
                        sl_ban += Convert.ToInt32(r["so_luong"].ToString());
                    }
                }
                if(sl_nhap_kho > sl_ban)
                {
                    sl_ton_kho = sl_nhap_kho - sl_ban;
                    txt_tonkho.Text = sl_ton_kho.ToString();
                    txt_daban.Text = sl_ban.ToString();
                }
                else
                {
                    lb_thongbao.Text = "Nhập số lượng trên: " + sl_ban;
                }
            }
        }
        public void Hienthi()
        {
            dgvdanhsach.DataSource = bus_KHO.thong_tin_kho();
            dgvdanhsach.Columns["ma_laptop"].HeaderText = "Mã laptop";
            dgvdanhsach.Columns["ten_laptop"].HeaderText = "Tên lapotop";
            dgvdanhsach.Columns["gia_ban"].HeaderText = "Giá bán";
            dgvdanhsach.Columns["so_luong_nhap"].HeaderText = "Số lượng nhập";
            dgvdanhsach.Columns["so_luong_ban"].HeaderText = "Đã bán";
            dgvdanhsach.Columns["ton_kho"].HeaderText = "Tồn kho";

        }
        public bool kiem_tra_nhap(bool check)
        {
            string thong_bao = "Vui lòng nhập: ";
            bool kiem_tra = false;

            if (txt_giaban.Text.Trim().Length == 0)
            {
                thong_bao += " - Mã laptop ";
                kiem_tra = true;
            }

            if (txt_soluong.Text.Trim().Length == 0)
            {
                thong_bao += " -Số lượng ";
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
            cbo_malaptop.SelectedItem = dgvdanhsach.Rows[vitri].Cells[0].Value.ToString();
            txt_tenlaptop.Text = dgvdanhsach.Rows[vitri].Cells[1].Value.ToString();
            txt_giaban.Text = dgvdanhsach.Rows[vitri].Cells[2].Value.ToString();
            txt_soluong.Text = dgvdanhsach.Rows[vitri].Cells[3].Value.ToString();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            cbo_malaptop.SelectedItem = "";
            txt_tenlaptop.Text = "";
            txt_giaban.Text = "";
            txt_soluong.Text = "";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_tukhoa_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = bus_KHO.thong_tin_kho();
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

       
    }
}
