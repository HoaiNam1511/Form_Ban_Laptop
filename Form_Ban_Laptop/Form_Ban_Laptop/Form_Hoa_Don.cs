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
    public partial class Form_Hoa_Don : Form
    {
        BUS_Hoa_Don busHD = new BUS_Hoa_Don();
        BUS_Thong_Tin_Laptop busLaptop = new BUS_Thong_Tin_Laptop();
        BUS_NhanVien busNV = new BUS_NhanVien();
        public Form_Hoa_Don()
        {
            InitializeComponent();
        }

        private void Form_Hoa_Don_Load(object sender, EventArgs e)
        {
            Hienthi();
            DataTable dt = busHD.thong_tin_hoa_don();
            dgvdanhsach.DataSource = dt;
            DataTable dt1 = busLaptop.thong_tin_laptop();
            foreach (DataRow r in dt1.Rows)
            {
                cbomalaptop.Items.Add(r["ma_laptop"]);
            }
            DataTable dt2 = busNV.lay_thong_tin_nv();
            foreach(DataRow r1 in dt2.Rows){
                cbomanv.Items.Add(r1["ma_nv"]);
            }
        }
        public void Hienthi()
        {
            DataTable dt = busHD.thong_tin_hoa_don();
            dgvdanhsach.DataSource = dt;
            dgvdanhsach.Columns["ma_hoa_don"].HeaderText = "Mã hoá đơn";
            dgvdanhsach.Columns["dia_chi"].HeaderText = "Địa chỉ";
            dgvdanhsach.Columns["so_dt"].HeaderText = "Số điện thoại";
            dgvdanhsach.Columns["ten_nv"].HeaderText = "Tên nhân viên";
            dgvdanhsach.Columns["ngay_ban"].HeaderText = "Ngày bán";
            dgvdanhsach.Columns["bao_hanh"].HeaderText = "Bảo hành";
            dgvdanhsach.Columns["so_luong"].HeaderText = "Số lượng";
            dgvdanhsach.Columns["don_gia"].HeaderText = "Đơn giá";
            dgvdanhsach.Columns["tong_tien"].HeaderText = "Tổng tiền";
            dgvdanhsach.Columns["ma_laptop"].HeaderText = "Mã laptop";
            dgvdanhsach.Columns["ma_nv"].HeaderText = "Mã nhân viên";

            dgvdanhsach.Columns["ten_khach"].Visible = false;
            dgvdanhsach.Columns["ten_laptop"].Visible = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (kiem_tra_nhap(true))
            {
                string ngayban = dtpngayban.Value.ToString("MM-dd-yyyy");
                int soluong = Convert.ToInt32(nbl_soluong.Value);
                
                string ma_laptop = cbomalaptop.SelectedItem.ToString();
                string ma_nv = cbomanv.SelectedItem.ToString();
                int baohanh = 0;
                int sodt = Convert.ToInt32(txtsodt.Text);
                if (rdo_6.Checked)
                {
                    baohanh = 6;
                }
                else
                {
                    if (rdo_12.Checked)
                    {
                        baohanh = 12;
                    }
                    else
                    {
                        if (rdo_24.Checked) {
                            baohanh = 24;
                        }
                        else
                        {
                            if (rdo_36.Checked)
                            {
                                baohanh = 36;
                            }
                        }
                    }
                }
                int don_gia = Convert.ToInt32(txt_dongia.Text);
                int tong = Convert.ToInt32(txttongtien.Text);
                DTO_Hoa_Don hd = new DTO_Hoa_Don(txt_mahoadon.Text,txttenkhach.Text,txtdiachi.Text,sodt,ngayban,baohanh,soluong, don_gia, tong,ma_laptop,ma_nv);
                if (busHD.them_thong_tin(hd))
                {
                    lb_thongbao_1.Text = "Thêm thành công";
                    Hienthi();
                }
                else
                {
                    lb_thongbao_1.Text = "Thêm thất bại";
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (kiem_tra_nhap(true))
            {
                string ngayban = dtpngayban.Value.ToString("MM-dd-yyyy");
                int soluong = Convert.ToInt32(nbl_soluong.Value);
            
                string ma_laptop = cbomalaptop.SelectedItem.ToString();
                string ma_nv = cbomanv.SelectedItem.ToString();
                int baohanh = 0;
                int sodt = Convert.ToInt32(txtsodt.Text);
                if (rdo_6.Checked)
                {
                    baohanh = 6;
                }
                else
                {
                    if (rdo_12.Checked)
                    {
                        baohanh = 12;
                    }
                    else
                    {
                        if (rdo_24.Checked)
                        {
                            baohanh = 24;
                        }
                        else
                        {
                            if (rdo_36.Checked)
                            {
                                baohanh = 36;
                            }
                        }
                    }
                }
                DTO_Hoa_Don hd = new DTO_Hoa_Don(txt_mahoadon.Text, txttenkhach.Text, txtdiachi.Text, sodt, ngayban, baohanh, soluong, 0, 0, ma_laptop, ma_nv);
                if (busHD.sua_hoa_don(hd))
                {
                    lb_thongbao_1.Text = "Sửa thành công";
                    Hienthi();
                }
                else
                {
                    lb_thongbao_1.Text = "Sửa thất bại";
                }
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(txt_mahoadon.Text != "")
            {
                string ma = txt_mahoadon.Text;
                if (busHD.xoa_hoa_don(ma))
                {
                    lb_thongbao_1.Text = "Xoá thành công";
                    Hienthi();
                }
            }
            else
            {
                lb_thongbao_1.Text = "Vui lòng chọn hoá đơn cần xoá";
            }
        }

        private void btn_resert_Click(object sender, EventArgs e)
        {

        }

        private void btnxem_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool kiem_tra_nhap(bool check)
        {
            string thong_bao = "Vui lòng nhập: ";
            bool kiem_tra = false;

            if (txt_mahoadon.Text.Trim().Length == 0)
            {
                thong_bao += " - Mã ";
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
          
     
            if (((int)nbl_soluong.Value) == 0)
            {
                thong_bao += " - Số lượng ";
                kiem_tra = true;
            }
            if (txtsodt.Text.Trim().Length == 0)
            {
                thong_bao += " - Số điện thoại ";
                kiem_tra = true;
            }
            if (txt_tennv.Text.Trim().Length == 0)
            {
                thong_bao += " - Nhân viên ";
                kiem_tra = true;
            }
            if (txt_tenlaptop.Text.Trim().Length == 0)
            {
                thong_bao += " - Nhân viên ";
                kiem_tra = true;
            }
            if (rdo_6.Checked || rdo_12.Checked || rdo_24.Checked || rdo_36.Checked)
            {

            }
            else
            {
                thong_bao += " - Bảo hành ";
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

        private void cbomanv_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            string ma_nv = cbomanv.SelectedItem.ToString();
            DataTable dt = busNV.thong_tin_1_nv(ma_nv);
            foreach (DataRow r1 in dt.Rows)
            {
                txt_tennv.Text = r1["ten_nv"].ToString();
            }
        }

        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dgvdanhsach.CurrentCell.RowIndex;
            txt_mahoadon.Text = dgvdanhsach.Rows[vitri].Cells[0].Value.ToString();
            txttenkhach.Text = dgvdanhsach.Rows[vitri].Cells[1].Value.ToString();
            txtdiachi.Text = dgvdanhsach.Rows[vitri].Cells[2].Value.ToString();
            txtsodt.Text = dgvdanhsach.Rows[vitri].Cells[3].Value.ToString();
            dtpngayban.Value = Convert.ToDateTime(dgvdanhsach.Rows[vitri].Cells[4].Value.ToString());
            int ngay = Convert.ToInt32(dgvdanhsach.Rows[vitri].Cells[5].Value.ToString());
            if (ngay == 6)
            {
                rdo_6.Checked = true;
            }
            else
            {
                if (ngay == 12)
                {
                    rdo_12.Checked = true;
                }
                else
                {
                    if (ngay == 24)
                    {
                        rdo_24.Checked = true;
                    }
                    else
                    {
                        if (ngay == 36)
                        {
                            rdo_36.Checked = true;
                        }
                    }
                }
            }
            DateTime datevalue;
            if (DateTime.TryParse(dgvdanhsach.Rows[vitri].Cells[5].Value.ToString(), out datevalue))
            {
                dtpngayban.Value = datevalue;
            }
            //txtsodt.Text = dgvdanhsach.Rows[vitri].Cells[4].Value.ToString();
            
            nbl_soluong.Value = Convert.ToInt32(dgvdanhsach.Rows[vitri].Cells[6].Value.ToString());
          
            txttongtien.Text = dgvdanhsach.Rows[vitri].Cells[8].Value.ToString();
            //for (int i = 0; i < cbomalaptop.Items.Count; i++)
            //{
            //    if (cbomalaptop.Items[i].ToString() == dgvdanhsach.Rows[vitri].Cells[9].Value.ToString())
            //    {
            //        cbomalaptop.SelectedIndex = i;
            //    }
            //}
            cbomalaptop.SelectedItem = dgvdanhsach.Rows[vitri].Cells[9].Value.ToString();
            cbomanv.SelectedItem = dgvdanhsach.Rows[vitri].Cells[10].Value.ToString();
        }

        private void nbl_soluong_ValueChanged(object sender, EventArgs e)
        {

            if(txt_dongia.Text != "")
            {
                int tong;
                int soluong = Convert.ToInt32(nbl_soluong.Value);
                int dongia = Convert.ToInt32(txt_dongia.Text);
                tong = soluong * dongia;
                txttongtien.Text = tong.ToString();
            }

        }

        private void txt_dongia_TextChanged(object sender, EventArgs e)
        {
            if (txt_dongia.Text != "")
            {
                int tong;
                int soluong = Convert.ToInt32(nbl_soluong.Value);
                int dongia = Convert.ToInt32(txt_dongia.Text);
                tong = soluong * dongia;
                txttongtien.Text = tong.ToString();
            }
        }
    }
}
