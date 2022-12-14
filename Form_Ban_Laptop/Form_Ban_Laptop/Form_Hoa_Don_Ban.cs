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
using System.Data;
namespace Form_Ban_Laptop
{
    public partial class Form_Hoa_Don_Ban : Form
    {
        BUS_Hoa_Don_Ban bus_Hoa_Don_Ban = new BUS_Hoa_Don_Ban();
        BUS_Thong_Tin_Laptop busLaptop = new BUS_Thong_Tin_Laptop();
        BUS_NhanVien busNV = new BUS_NhanVien();
        public Form_Hoa_Don_Ban()
        {
            InitializeComponent();
            btn_chon.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (kiem_tra_nhap(true))
            {
                string ngayban = dtpngayban.Value.ToString("MM-dd-yyyy");
                string ma_nv = cbomanv.SelectedItem.ToString();
                int sodt = Convert.ToInt32(txtsodt.Text);
                DTO_Hoa_Don_Ban hd = new DTO_Hoa_Don_Ban(txt_mahoadon.Text, txttenkhach.Text, txtdiachi.Text,sodt, ngayban, ma_nv);
                if (bus_Hoa_Don_Ban.them_hoa_don(hd))
                {
                    lb_thongbao_1.Text = "thêm thành công";
                    // Xoa combobox truoc khi them du lieu moi vao
                    cbo_mahoadon.Items.Clear();
                    cbo_mahoadon.ResetText();
                    // Dua du lieu vao combobox
                    DataTable dt_mahoadon = bus_Hoa_Don_Ban.thong_tin_hoa_don();
                    foreach (DataRow r2 in dt_mahoadon.Rows)
                    {
                        cbo_mahoadon.Items.Add(r2["ma_hoa_don"]);
                    }
                    Hienthi();
                }
                else
                {
                    lb_thongbao_1.Text = "thêm thất bại";
                }
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (kiem_tra_nhap(true))
            {
                string ngayban = dtpngayban.Value.ToString("MM-dd-yyyy");
                string ma_nv = cbomanv.SelectedItem.ToString();
                int sodt = Convert.ToInt32(txtsodt.Text);
                DTO_Hoa_Don_Ban hd = new DTO_Hoa_Don_Ban(txt_mahoadon.Text,txttenkhach.Text,txtdiachi.Text,sodt,ngayban,ma_nv);
                if (bus_Hoa_Don_Ban.sua_hoa_don(hd))
                {
                    lb_thongbao_1.Text = "sửa thành công";
                    Hienthi();
                }
                else
                {
                    lb_thongbao_1.Text = "sửa thất bại";
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txt_mahoadon.Text != "")
            {
                string ma = txt_mahoadon.Text;
                if (bus_Hoa_Don_Ban.xoa_hoa_don(ma))
                {
                    lb_thongbao_1.Text = "xoá thành công";
                    // Xoa combobox truoc khi them du lieu moi vao
                    cbo_mahoadon.Items.Clear();
                    cbo_mahoadon.ResetText();
                    // Dua du lieu vao combobox
                    DataTable dt_mahoadon = bus_Hoa_Don_Ban.thong_tin_hoa_don();
                    foreach (DataRow r2 in dt_mahoadon.Rows)
                    {
                        cbo_mahoadon.Items.Add(r2["ma_hoa_don"]);
                    }
                    Hienthi();
                }
            }
            else
            {
                lb_thongbao_1.Text = "vui lòng chọn hoá đơn cần xoá";
            }
        }

        private void Form_Hoa_Don_Ban_Load(object sender, EventArgs e)
        {
            DataTable dt = bus_Hoa_Don_Ban.thong_tin_hoa_don();
            dgv_hoa_don.DataSource = dt;

            DataTable dt_NhanVien = busNV.lay_thong_tin_nv();
            foreach (DataRow r1 in dt_NhanVien.Rows)
            {
                cbomanv.Items.Add(r1["ma_nv"]);
            }
            DataTable dt_mahoadon = bus_Hoa_Don_Ban.thong_tin_hoa_don();

            foreach (DataRow r2 in dt_mahoadon.Rows)
            {
                cbo_mahoadon.Items.Add(r2["ma_hoa_don"]);
            }
            dt_mahoadon.Clear();
            Hienthi();
        }
        public void Hienthi()
        {
            DataTable dt1 = bus_Hoa_Don_Ban.thong_tin_hoa_don();
            dgv_hoa_don.DataSource = dt1;
            dgv_hoa_don.Columns["ma_hoa_don"].HeaderText = "Mã hoá đơn";
            dgv_hoa_don.Columns["ten_khach"].HeaderText = "Tên khách hàng";
            dgv_hoa_don.Columns["so_dien_thoai"].HeaderText = "Số diện thoại";
            dgv_hoa_don.Columns["dia_chi"].HeaderText = "Địa chỉ";
            dgv_hoa_don.Columns["ngay_ban"].HeaderText = "Ngày bán";
            dgv_hoa_don.Columns["ma_nv"].HeaderText = "Mã nhân viên";
            dgv_hoa_don.Columns["ten_nv"].Visible = false;
        }

        private void dgv_hoa_don_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dgv_hoa_don.CurrentCell.RowIndex;
            txt_mahoadon.Text = dgv_hoa_don.Rows[vitri].Cells[0].Value.ToString();
            txttenkhach.Text = dgv_hoa_don.Rows[vitri].Cells[1].Value.ToString();
            txtsodt.Text = dgv_hoa_don.Rows[vitri].Cells[2].Value.ToString();
            txtdiachi.Text = dgv_hoa_don.Rows[vitri].Cells[3].Value.ToString();
            dtpngayban.Value = Convert.ToDateTime(dgv_hoa_don.Rows[vitri].Cells[4].Value.ToString());
            cbomanv.SelectedItem = dgv_hoa_don.Rows[vitri].Cells[6].Value.ToString();
        }

        private void cbomanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma_nv = cbomanv.SelectedItem.ToString();
            DataTable dt = busNV.thong_tin_1_nv(ma_nv);
            foreach (DataRow r1 in dt.Rows)
            {
                txt_tennv.Text = r1["ten_nv"].ToString();
            }
        }
        private bool kiem_tra_nhap(bool check)
        {
            string thong_bao = "Vui lòng nhập: ";
            bool kiem_tra = false;

            if (txt_mahoadon.Text.Trim().Length == 0)
            {
                thong_bao += " - Mã hoá đơn";
                kiem_tra = true;
            }
            if (txttenkhach.Text.Trim().Length == 0)
            {
                thong_bao += " - Tên khách ";
                kiem_tra = true;
            }

            if (txtdiachi.Text.Trim().Length == 0)
            {
                thong_bao += " - Địa chỉ ";
                kiem_tra = true;
            }

            if (txtsodt.Text.Trim().Length == 0)
            {
                thong_bao += " - Số điện thoại ";
                kiem_tra = true;
            }
            if (txt_tennv.Text.Trim().Length == 0)
            {
                thong_bao += " - Mã nhân viên ";
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



        private void btn_resert_Click(object sender, EventArgs e)
        {
            txtdiachi.Text = "";
            txtsodt.Text = "";
            txttenkhach.Text = "";
            txt_mahoadon.Text = "";
            txt_tennv.Text = "";
        }



        private void txtsodt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            if (cbo_mahoadon.SelectedItem.ToString() != null)
            {
                Form_San_Pham form_hang = new Form_San_Pham();
                Form_San_Pham.ma_hoa_don = cbo_mahoadon.SelectedItem.ToString();
                form_hang.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã hoá đơn");
            }
        }

        private void cbo_mahoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_chon.Enabled = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = bus_Hoa_Don_Ban.thong_tin_hoa_don();
            DataRow[] row = dt.Select("ma_hoa_don like '%" + txt_timkiem.Text + "%'");
            if (row.Length > 0)
            {
                DataTable dt1 = row.CopyToDataTable();
                dgv_hoa_don.DataSource = dt1;
            }
            else
            {

            }
        }
    }
}
